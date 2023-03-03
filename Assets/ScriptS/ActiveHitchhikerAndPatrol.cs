using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveHitchhikerAndPatrol : MonoBehaviour
{
    public GameObject Road;
    public GameObject GPS;
    public GameObject pnlHitch;


    void OnTriggerStay2D(Collider2D other)
    {
        if (Main.activeHitchhikerAndPatrol == 0)
        {
            Road.GetComponent<HitchhikerRnd>().ActiveHitchhiker();
            Road.GetComponent<PatrolRnd>().ActivePatrol();
            GPS.GetComponent<GPS>().StartRealSpeed();
            pnlHitch.GetComponent<HitchhikerPnl>().ActiveRndHitchhiker();
            Main.ActiveRndEvent = 1;
            Main.activeHitchhikerAndPatrol = 1;
        }        
    }
}
