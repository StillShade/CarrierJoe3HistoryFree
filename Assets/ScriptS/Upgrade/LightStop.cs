using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightStop : MonoBehaviour
{
    public GameObject lightStop;

    void Update()
    {
        if (Main.LightOnStop == 1) lightStop.SetActive(true);
        else lightStop.SetActive(false);
    }
}
