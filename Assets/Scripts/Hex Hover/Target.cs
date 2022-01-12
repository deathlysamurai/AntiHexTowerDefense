using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Target : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] GameObject TestGO;
    
    LevelEditor levelEditor;
    Renderer rend;
    GameObject tempGO;

    bool tileSpawned;
    bool tileRemoved;

    private void Awake()
    {
        levelEditor = GameObject.Find("LevelEditor").GetComponent<LevelEditor>();
    }

    void OnEnable()
    {
        rend = GetComponent<Renderer>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (rend.enabled == false)
        {
            rend.material.color = Color.green;
            rend.enabled = true;
        }
        else
        {
            tempGO = Instantiate(TestGO, this.gameObject.transform.position, Quaternion.identity, this.gameObject.transform);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (!tileSpawned && !tileRemoved)
        {
            if (rend.material.color == Color.green)
            {
                rend.enabled = false;
            }
            else
            {
                Destroy(tempGO);
            }
        }

        tileSpawned = false;
        tileRemoved = false;
    }

    public void OnTileSpawned()
    {
        tileSpawned = true;
    }

    public void OnTileRemoved()
    {
        tileRemoved = true;

        Destroy(tempGO);
    }
} 
