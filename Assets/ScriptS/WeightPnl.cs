using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeightPnl : MonoBehaviour
{
    public GameObject pnlWeight;
    public GameObject Camera;
    public GameObject btnShtraf;
    public int payTheFine;
    public float weightCar;
    public float allowableWeight;
    public float weightTrailer;
    public float weightCargo;
    public float totalWeight;
    public float totalWeightTrailer;
    public Text weightCarTx;
    public Text weightCargoTx;
    public Text totalWeightTx;
    public Text totalWeightTrailerTx;

    public void exitPnlWeight()
    {
        pnlWeight.SetActive(false);
    }

    public void PayTheFine()
    {
        Main.Money -= 2500;
        btnShtraf.SetActive(false);
        payTheFine++;
    }

    private void Start()
    {
        payTheFine = 0;
    }

    void Update()
    {
        weightCar = Camera.GetComponent<Movecar>().weightCar;
        allowableWeight = Camera.GetComponent<Movecar>().allowableWeight;
        weightTrailer = Camera.GetComponent<Movecar>().weightTrailer;
        weightCargo = Camera.GetComponent<Movecar>().loadTruck * 1000;

        totalWeightTrailer = weightTrailer + weightCargo;
        totalWeight = weightCar + weightTrailer + weightCargo;

        weightCarTx.text = weightCar.ToString("") + " kg";
        weightCargoTx.text = weightCargo.ToString("") + " kg";
        totalWeightTx.text = totalWeight.ToString("") + " kg";
        totalWeightTrailerTx.text = totalWeightTrailer.ToString("") + " kg";

        if(totalWeightTrailer > allowableWeight && payTheFine == 0)
        {
            totalWeightTrailerTx.color = new Color(255, 0, 0);
            btnShtraf.SetActive(true);
        }
        else
        {
            btnShtraf.SetActive(false);
        }
    }
}
