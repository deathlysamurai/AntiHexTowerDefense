using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class LevelEditor : MonoBehaviour
{
    Camera cam;
    [SerializeField] GameObject testPrefab;
    [SerializeField] GameObject basicTile;
    [SerializeField] InputController inputController;
    [SerializeField] Border border;
    [SerializeField] SpawnTile spawnTile;
    [SerializeField] RemoveTile removeTile;

    //public event UnityAction tileRemoved;
    //public event UnityAction tileSpawned;

    Transform mapGenerator;
    bool isBasicTile;

    private void OnEnable()
    {
        inputController.ChangeTileEvent += ChangeTile;
    }

    private void OnDisable()
    {
        inputController.ChangeTileEvent -= ChangeTile;
    }

    private void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        mapGenerator = GameObject.Find("MapGenerator").transform;

        spawnTile.Initialize(testPrefab, mapGenerator);
        removeTile.Initialize(border, basicTile, mapGenerator);
    }

    void ChangeTile(string changeType)
    {
        GameObject hitGO = CastRay();

        if (hitGO == null)
            return;

        DetermineTileType(hitGO);

        if (changeType == "Spawn")
        {
            SpawnTile(hitGO);
            hitGO.GetComponent<Target>().OnTileSpawned();
        } else
        {
            RemoveTile(hitGO);
            hitGO.GetComponent<Target>().OnTileRemoved();
        }
    }

    void SpawnTile(GameObject hitGO)
    {
        if (!GameObject.Find("Border" + hitGO.name))
        {
            spawnTile.SpawnSelectedTile(hitGO);
        }
        else
        {
            spawnTile.SpawnBasicTile(hitGO);
        }
    }

    void RemoveTile(GameObject hitGO)
    {
        if (hitGO.tag != "BasicTile")
        {
            removeTile.RemoveSelectedTile(hitGO);
        }
        else
        {
            removeTile.RemoveBasicTile(hitGO);
        }
    }

    GameObject CastRay()
    {
        Ray ray = cam.ScreenPointToRay(Mouse.current.position.ReadValue());

        if (Physics.Raycast(ray, out RaycastHit hitInfo))
        {
            return hitInfo.collider.gameObject;
        }

        return null;
    }

    void DetermineTileType(GameObject hitGO)
    {
        if (hitGO.tag == "BasicTile")
        {
            isBasicTile = true;
        } else
        {
            isBasicTile = false;
        }

    }
}
