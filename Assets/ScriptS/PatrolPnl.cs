using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolPnl : MonoBehaviour
{
    public GameObject pnlPatrol;
    public GameObject btnShtraf;
    public GameObject dokiOk;
    public GameObject dokiBadly;
    

    public void ExitPnlPatrol()
    {
        pnlPatrol.SetActive(false);
    }

    public void DokiShtraf()
    {
        Main.Money -= 2500;
        btnShtraf.SetActive(false);
    }

    private void Update()
    {
       if (Main.DokiOk > 0)
       {
           btnShtraf.SetActive(true);
           dokiBadly.SetActive(true);
           dokiOk.SetActive(false);
       } 
       else if (Main.DokiOk == 0)
       {
            btnShtraf.SetActive(false);
            dokiBadly.SetActive(false);
            dokiOk.SetActive(true);
       }
    }
}

