using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTransition : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject map;
    public GameObject mapGlobal;
    public GameObject ExitMap;
    public string mapLocation;
    public int finishLoca;
    public GameObject Finish;

    void Update()
    {
        if (finishLoca == Main.FinishLoca) 
        {
            Finish.SetActive(true);
        }        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            mainCamera.GetComponent<Movecar>().Deacceler();
            mainCamera.GetComponent<Movecar>().Braker();
            mainCamera.GetComponent<Movecar>().BlockGaz.SetActive(true);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (Main.RealSpeed <= 5)
        {
            mapGlobal.SetActive(true);
            map.GetComponent<Map>().LocationDefinition();
            map.GetComponent<Map>().PathChoice();
            mainCamera.GetComponent<Movecar>().BlockGaz.SetActive(false);
            ExitMap.SetActive(false);
            Main.activeHitchhikerAndPatrol = 0;
        }
    }
}
