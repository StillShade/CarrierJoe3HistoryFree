using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveAzsGarage : MonoBehaviour
{
    public GameObject gazPompa;
    public GameObject gazPompaActive;
    public GameObject azsPnl;
    public GameObject pnlTruck;

    public void ActiveAzs()
    {
        gazPompaActive.SetActive(true);
    }
    public void OffActiveAzs()
    {
        pnlTruck.SetActive(false);
        gazPompaActive.SetActive(false);
        gazPompa.SetActive(false);
        azsPnl.SetActive(false);
    }
}
