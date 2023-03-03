using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitchhikerRnd : MonoBehaviour
{
    public GameObject hitchhiker1;
    public GameObject hitchhiker2;
    public GameObject hitchhiker3;
    public GameObject hitchhiker4;
    public GameObject hitchhiker5;
    public GameObject hitchhiker6;
    public GameObject hitchhiker7;
    public GameObject hitchhiker8;
    public GameObject hitchhiker9;
    public GameObject hitchhiker10;

    public int rndhitchhiker;    

    public void ActiveHitchhiker()
    {
        rndhitchhiker = Random.Range(1, 11);
        Main.Hitchhiker = 0;
        trueHitch();
    }

    public void CloseAllHitchhiker()
    {
        hitchhiker1.SetActive(false);
        hitchhiker2.SetActive(false);
        hitchhiker3.SetActive(false);
        hitchhiker4.SetActive(false);
        hitchhiker5.SetActive(false);
        hitchhiker6.SetActive(false);
        hitchhiker7.SetActive(false);
        hitchhiker8.SetActive(false);
        hitchhiker9.SetActive(false);
        hitchhiker10.SetActive(false);
    }

    public void trueHitch()
    {
        switch (rndhitchhiker)
        {
            case 1:
                CloseAllHitchhiker();
                hitchhiker1.SetActive(true);
                break;
            case 2:
                CloseAllHitchhiker();
                hitchhiker2.SetActive(true);
                break;
            case 3:
                CloseAllHitchhiker();
                hitchhiker3.SetActive(true);
                break;
            case 4:
                CloseAllHitchhiker();
                hitchhiker4.SetActive(true);
                break;
            case 5:
                CloseAllHitchhiker();
                hitchhiker5.SetActive(true);
                break;
            case 6:
                CloseAllHitchhiker();
                hitchhiker6.SetActive(true);
                break;
            case 7:
                CloseAllHitchhiker();
                hitchhiker7.SetActive(true);
                break;
            case 8:
                CloseAllHitchhiker();
                hitchhiker8.SetActive(true);
                break;
            case 9:
                CloseAllHitchhiker();
                hitchhiker9.SetActive(true);
                break;
            case 10:
                CloseAllHitchhiker();
                hitchhiker10.SetActive(true);
                break;
        }        
    }

    void Update()
    {
        if (Main.Hitchhiker == 1)
        {
            CloseAllHitchhiker();
        }
    }
}
