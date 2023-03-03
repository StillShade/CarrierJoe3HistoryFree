using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailerCharTent : MonoBehaviour
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
    public float glassBottle;
    public float refrigerator;
    public float drywall;
    public float cannedFood;
    public float sandwichPanel;
    [Header("��� �����")]
    public int cargoType;    
    public GameObject GlassBottle;
    public GameObject Refrigerator;
    public GameObject Drywall;
    public GameObject CannedFood;
    public GameObject SandwichPanel;

    void Start()
    {
        //Main.CargoCondition = 0;
    }

    public void CloseCargo()
    {
        GlassBottle.SetActive(false);
        Refrigerator.SetActive(false);
        Drywall.SetActive(false);
        CannedFood.SetActive(false);
        SandwichPanel.SetActive(false);
    }

    private void Update()
    {

        switch (Main.CargoCondition)
        {
            case 0:
                CloseCargo();
                break;            
            case 7:
                GlassBottle.SetActive(true);
                break;
            case 8:
                Refrigerator.SetActive(true);
                break;
            case 9:
                Drywall.SetActive(true);
                break;
            case 10:
                CannedFood.SetActive(true);
                break;
            case 11:
                SandwichPanel.SetActive(true);
                break;
        }

    }
}


