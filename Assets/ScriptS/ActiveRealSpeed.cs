using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveRealSpeed : MonoBehaviour
{
    public GameObject GPS;
    public int activeHit;

    private void Update()
    {
        activeHit = Main.activeHitchhikerAndPatrol;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (Main.activeHitchhikerAndPatrol == 0)
            {
                GPS.GetComponent<GPS>().StartRealSpeed();
                Main.activeHitchhikerAndPatrol = 1;
            }
        }
    }
}
