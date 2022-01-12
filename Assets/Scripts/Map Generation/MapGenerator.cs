using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] GameObject baseHex;
    [SerializeField] Transform cam;

    int mapWidth = 20;
    int mapHeight = 20;
    float hexHeight;
    int camHeight = 20;

    private void Awake()
    {
        hexHeight = baseHex.GetComponentInChildren<MeshFilter>().sharedMesh.bounds.size.z;
        cam = GameObject.Find("Main Camera").transform;
    }

    void Start()
    {
        CreateHexTileMap();
        CalculateCameraPosition();
    }

    void CreateHexTileMap()
    {
        for (int x = 0; x < mapWidth; x++)
        {
            for (int z = 0; z < mapHeight; z++)
            {
                Hex hex = new Hex(x, z, hexHeight);

                GameObject prefab = Instantiate(baseHex, hex.Position(), Quaternion.identity, this.transform);

                setTileInfo(prefab, x, z);
            }
        }
    }

    void setTileInfo(GameObject GO, int x, int z)
    {
        GO.name = x.ToString() + "," + z.ToString();
    }

    void CalculateCameraPosition()
    {
        Hex hex = new Hex(hexHeight);
        float width = hex.GetWidth();

        float camX = (width * mapWidth) / 2;
        float camZ = (hexHeight * mapHeight * .75f) / 2;

        cam.position = new Vector3(camX, camHeight, camZ);
    }
}
