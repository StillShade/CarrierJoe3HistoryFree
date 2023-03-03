using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightRandom : MonoBehaviour
{
    [Header("Красный сигнал")]
    public GameObject redSignal;
    public GameObject ironScales;
    public GameObject weightPointBack;
    public GameObject dashBoardWeightRed;
    [Header("Зеленый сигнал")]
    public GameObject greenSignal;
    public GameObject weightPointFor;
    public GameObject dashBoardWeightGreen;
    [Header("Разное")]
    public GameObject dashBoardWeightShtraf;
    public int rndSignal;
    public GameObject weightPoint;
    public int fulfilledCondition;
    public AudioSource click;
    public int i;    

    public void ActiveWeight()
    {
        i = 0;
        rndSignal = Random.Range(1, 101);        
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(5f);
        dashBoardWeightShtraf.SetActive(false);
    }

    private void Update()
    {
        fulfilledCondition = weightPoint.GetComponent<WeightPoint>().fulfilledCondition;
        if(Main.ActiveRndEvent == 1)
        {
            weightPoint.GetComponent<WeightPoint>().FulFilCon();
            ActiveWeight();            
            Main.ActiveRndEvent = 0;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (rndSignal <= 40 && fulfilledCondition == 0)
            {
                redSignal.SetActive(true);
                greenSignal.SetActive(false);
                ironScales.SetActive(true);
                weightPointBack.SetActive(true);
                weightPointFor.SetActive(false);
                dashBoardWeightRed.SetActive(true);
            }
            else if (rndSignal <= 40 && fulfilledCondition == 1)
            {
                redSignal.SetActive(false);
                dashBoardWeightRed.SetActive(false);
                greenSignal.SetActive(true);                
            }            
            else
            {
                redSignal.SetActive(false);
                greenSignal.SetActive(true);
                weightPointBack.SetActive(false);
                weightPointFor.SetActive(true);
                weightPointFor.SetActive(true);
                ironScales.SetActive(false);
                dashBoardWeightGreen.SetActive(true);
            }            
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (rndSignal <= 40 && fulfilledCondition == 0)
            {
                if (i < 1)
                {                    
                    click.Play();
                    dashBoardWeightShtraf.SetActive(true);
                    Main.Money -= 5000;
                    redSignal.SetActive(false);
                    greenSignal.SetActive(true);
                    ironScales.SetActive(false);
                    weightPointBack.SetActive(false);
                    dashBoardWeightRed.SetActive(false);
                    StartCoroutine(delay());
                    i++;
                }
            }
        }
    }
}
