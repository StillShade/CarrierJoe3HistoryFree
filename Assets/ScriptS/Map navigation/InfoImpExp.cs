using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoImpExp : MonoBehaviour
{
    public GameObject InfoPnl;
    public GameObject entry;
    public bool infPnl;
    public string mapLocation;

    private void Start()
    {
        infPnl = false;
    }

    public void OpenCloseInfPnl()
    {
        if (infPnl == false) infPnl = true;
        else infPnl = false;
        if (infPnl == false) InfoPnl.SetActive(false);
        else InfoPnl.SetActive(true);
        if(Main.MapLocation == mapLocation) entry.SetActive(true);
        else entry.SetActive(false);
    }
}
