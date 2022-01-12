using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Border", menuName = "Level Editor/Border")]

public class Border : ScriptableObject
{
    [SerializeField] Material defaultLineMat;

    public void DrawBorder(GameObject hitGO)
    {
        List<Vector3> pos = new List<Vector3>();
        Vector3[] vertices = hitGO.GetComponent<MeshFilter>().mesh.vertices;

        Vector3Int hexGridCoordinates = Utilities.GetXZFromName(hitGO.name);
        Hex hex = new Hex(hexGridCoordinates.x, hexGridCoordinates.z, hitGO.GetComponent<MeshFilter>().sharedMesh.bounds.size.z);
        Vector3 hexPosition = hex.Position();

        float zAverage = 0;
        for (int i = 0; i < vertices.Length; i++)
        {
            if (vertices[i].y != 0 && !pos.Contains(new Vector3(vertices[i].x + hexPosition.x, 0, vertices[i].z + hexPosition.z)))
            {
                pos.Add(new Vector3(vertices[i].x + hexPosition.x, 0, vertices[i].z + hexPosition.z));
                zAverage += vertices[i].z + hexPosition.z;
            }
        }
        zAverage = zAverage / pos.Count;

        pos.Sort(delegate (Vector3 first, Vector3 second)
        {
            if (first.z < zAverage && second.z < zAverage)
                return first.x.CompareTo(second.x);
            else if (first.z > zAverage && second.z > zAverage)
                return second.x.CompareTo(first.x);
            else
                return first.z.CompareTo(second.z);
        }); ;

        GameObject lineGO = new GameObject("Border" + hitGO.name, typeof(LineRenderer), typeof(Target));
        lineGO.transform.parent = GameObject.Find("MapGenerator").transform;
        LineRenderer line = lineGO.GetComponent<LineRenderer>();

        line.loop = true;
        line.startWidth = .05f;
        line.endWidth = .05f;
        line.positionCount = pos.Count;
        line.material = defaultLineMat;
        line.startColor = Color.white;
        line.endColor = Color.white;

        for (int i = 0; i < pos.Count; i++)
        {
            line.SetPosition(i, pos[i]);
        }
    }
}
