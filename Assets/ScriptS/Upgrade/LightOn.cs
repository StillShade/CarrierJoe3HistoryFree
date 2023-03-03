using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOn : MonoBehaviour
{
    public GameObject lightOn;

    void Update()
    {
        if (Main.LightOn == 1) lightOn.SetActive(true);
        else lightOn.SetActive(false);
    }
}
