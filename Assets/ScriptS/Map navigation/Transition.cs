using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject map;
    public GameObject mapGlobal;
    public GameObject mapLocations;
    public GameObject ExitMap;
    public string mapLocation;


    void Update()
    {
        mapLocation = Main.MapLocation;
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
        if (other.CompareTag("Player"))
        {
            if (Main.RealSpeed <= 5)
            {
                mainCamera.GetComponent<Movecar>().BlockGaz.SetActive(false);
                Main.MapLocation = mapLocation;
                Main.SaveMapLocation = mapLocation;
                mapGlobal.SetActive(true);
                map.GetComponent<Map>().LocationDefinition();
                map.GetComponent<Map>().PathChoice();
                mapLocations.GetComponent<MapLocation>().CloseAllMap();
                Main.activeHitchhikerAndPatrol = 0;
                ExitMap.SetActive(false);
                Time.timeScale = 0;
            }
        }
    }
}
