using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnTile", menuName = "Level Editor/SpawnTile")]

public class SpawnTile : ScriptableObject
{
    GameObject testPrefab;
    Transform mapGenerator;

    public void Initialize(GameObject testPrefab, Transform mapGenerator)
    {
        this.testPrefab = testPrefab;
        this.mapGenerator = mapGenerator;
    }

    public void SpawnSelectedTile(GameObject hitGO)
    {
        Vector3 position = hitGO.transform.position;
        string hitName = hitGO.name;
        Destroy(hitGO);
        if (GameObject.Find("Border" + hitGO.name))
        {
            Destroy(GameObject.Find("Border" + hitGO.name));
        }
        GameObject newTile = Instantiate(testPrefab, position, Quaternion.identity, mapGenerator);
        newTile.name = hitName;
    }

    public void SpawnBasicTile(GameObject hitGO)
    {
        hitGO.GetComponent<Renderer>().enabled = true;
        Destroy(GameObject.Find("Border" + hitGO.name));
    }
}

