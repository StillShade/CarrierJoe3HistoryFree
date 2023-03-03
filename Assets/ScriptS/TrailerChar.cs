using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailerChar : MonoBehaviour
{
    [Header("����������������")]
    public float cargoWeight;
    [Header("����")]
    public int priceMoney;
    [Header("����")]
    public int priceXp;
    [Header("�����������")]
    public float coefficient;
    [Header("���")]
    public float trailerWeight;
    [Header("��� �����")]
    public float brick;
    public float cub;
    public float barel;
    public float bigBag;
    public float ironRoll;
    public float fertilizer;
    [Header("��� �����")]
    public int cargoType;
    public GameObject Brick;
    public GameObject Cub;
    public GameObject Barel;
    public GameObject BigBag;
    public GameObject IronRoll;
    public GameObject Fertilizer;

    void Start()
    {
        //Main.CargoCondition = 0;
    }

    public void CloseCargo()
    {
        Brick.SetActive(false);
        Cub.SetActive(false);
        Barel.SetActive(false);
        BigBag.SetActive(false);
        IronRoll.SetActive(false);
        Fertilizer.SetActive(false);
    }

    private void Update()
    {

        switch (Main.CargoCondition)
        {
            case 0:
                CloseCargo();
                break;
            case 1:                
                Brick.SetActive(true);
                break;
            case 2:                
                Cub.SetActive(true);
                break;
            case 3:                
                Barel.SetActive(true);
                break;
            case 4:                
                BigBag.SetActive(true);
                break;
            case 5:                
                IronRoll.SetActive(true);
                break;
            case 6:                
                Fertilizer.SetActive(true);
                break;            
        }  
    }
}
