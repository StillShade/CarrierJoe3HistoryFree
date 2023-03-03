using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectLocationDefinition : MonoBehaviour
{
    private string mapLocation;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            mapLocation = Main.MapLocation;
            Main.activeHitchhikerAndPatrol = 0;
        }
    }
}
