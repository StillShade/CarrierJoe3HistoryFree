using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationDefinition : MonoBehaviour
{
    public string mapLocation;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Main.MapLocation = mapLocation;
            Main.SaveMapLocation = mapLocation;
            Main.activeHitchhikerAndPatrol = 0;
        }
    }
}
