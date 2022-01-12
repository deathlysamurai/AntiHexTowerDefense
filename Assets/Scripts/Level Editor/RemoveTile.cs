using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RemoveTile", menuName = "Level Editor/RemoveTile")]

public class RemoveTile : ScriptableObject
{
    Border border;
    GameObject basicTile;
    Transform mapGenerator;

    public void Initialize(Border border, GameObject basicTile, Transform mapGenerator)
    {
        this.border = border;
        this.basicTile = basicTile;
        this.mapGenerator = mapGenerator;
    }

    public void RemoveBasicTile(GameObject hitGO)
    {
        hitGO.GetComponent<Renderer>().enabled = false;
        border.DrawBorder(hitGO);
    }

    public void RemoveSelectedTile(GameObject hitGO)
    {
        string name = hitGO.name;
        Destroy(hitGO);
        GameObject prefab = Instantiate(basicTile, hitGO.transform.position, Quaternion.identity, mapGenerator);
        prefab.name = name;
    }
}
