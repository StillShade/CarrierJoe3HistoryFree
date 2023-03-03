using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dashboard : MonoBehaviour
{
    public GameObject ControlCamera;
    public GameObject BtnCamOn;
    public GameObject BtnCamOff;

    public GameObject toTheGarage;
    public GameObject toTheGarageCheckSpeed;
    public GameObject EmergencyOff;

    public GameObject lightOn;

    public GameObject AzsPnl;
    public GameObject NotMoneyAzs;
    public GameObject NotMoneyAzsPnl;

    public AudioSource sos;
    public GameObject noSpeed;


    public void NoSpeed()
    {
        noSpeed.SetActive(true);
        StartCoroutine(delay());
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(3f);
        noSpeed.SetActive(false);
    }

    public void LightOn()
    {
        Main.LightOn = 1;
        lightOn.SetActive(true);
    }
    public void LightOff()
    {
        Main.LightOn = 0;
        lightOn.SetActive(false);
    }

    public void BuyFuel()
    {
        Main.BuyFuel = 1;
    }
    public void NoBuyFuel()
    {
        Main.BuyFuel = 0;
    }
    public void CloseNotMoneyAzs()
    {
        NotMoneyAzs.SetActive(false);
        NotMoneyAzsPnl.SetActive(false);
    }
    public void ConCamOn()
    {
        ControlCamera.SetActive(true);
        BtnCamOff.SetActive(true);
        BtnCamOn.SetActive(false);
    }
    public void ConCamOff()
    {
        ControlCamera.SetActive(false);
        BtnCamOn.SetActive(true);
        BtnCamOff.SetActive(false);
    }    
    public void ToTheGarageActive()
    {
        sos.Play();
        toTheGarage.SetActive(true);
        EmergencyOff.SetActive(true);
        AzsPnl.SetActive(false);
    }
    public void ToTheGarageActiveDeactive()
    {
        sos.Stop();
        toTheGarage.SetActive(false);
        EmergencyOff.SetActive(false);        
    }

    private void Update()
    {
        if (Main.RealSpeed > 5) toTheGarageCheckSpeed.SetActive(true);
        else toTheGarageCheckSpeed.SetActive(false);
    }
}
