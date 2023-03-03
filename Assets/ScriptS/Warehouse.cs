using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warehouse : MonoBehaviour
{
    public GameObject selectCargo;
    public float speed;
    public int i;

    [Header("Îðäåðà")]
    public int numberOfOrders;    
    public GameObject order1;
    public GameObject order2;
    public GameObject order3;
    public GameObject order4;
    public GameObject order5;
    [Header("Ãðóç")]
    public GameObject Brick;
    public GameObject Cub;
    public GameObject Barel;
    public GameObject BigBag;
    public GameObject Iron;
    public GameObject Fertilizer;
    public GameObject GlassBottle;
    public GameObject Refrigerator;
    public GameObject Drywall;
    public GameObject CannedFood;
    public GameObject SandwichPanel;
    public GameObject Fish;
    public GameObject Meat;
    public GameObject Flowers;
    public GameObject Fruits;
    public GameObject Butter;
    public GameObject Blue;
    public GameObject Green;
    public GameObject Red;
    public GameObject Freeze;
    public GameObject Tank;

    public void CloseAllOrder()
    {
        order1.SetActive(false);
        order2.SetActive(false);
        order3.SetActive(false);
        order4.SetActive(false);
        order5.SetActive(false);
    }
    public void TypeÑargo()
    {
        switch (Main.PrcNumber)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
                Brick.SetActive(true);
                Cub.SetActive(true);
                Barel.SetActive(true);
                BigBag.SetActive(true);
                Iron.SetActive(true);
                Fertilizer.SetActive(true);
                break;
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
                GlassBottle.SetActive(true);
                Refrigerator.SetActive(true);
                Drywall.SetActive(true);
                CannedFood.SetActive(true);
                SandwichPanel.SetActive(true);
                break;
            case 15:
            case 16:
            case 17:
            case 18:
            case 19:
            case 20:
                Fish.SetActive(true);
                Meat.SetActive(true);
                Flowers.SetActive(true);
                Fruits.SetActive(true);
                Butter.SetActive(true);
                break;
            case 21:
            case 22:
            case 23:
            case 24:
            case 25:
                Blue.SetActive(true);
                Green.SetActive(true);
                Red.SetActive(true);
                Freeze.SetActive(true);
                Tank.SetActive(true);
                break;
        }
    }
    void Start()
    {
        i = 0;
        numberOfOrders = Random.Range(1, 6);
        OpenOrder();
    }

    public void RandomCargo()
    {
        order1.GetComponent<RandomCargo>().ActiveRndCargo();
        order2.GetComponent<RandomCargo>().ActiveRndCargo();
        order3.GetComponent<RandomCargo>().ActiveRndCargo();
        order4.GetComponent<RandomCargo>().ActiveRndCargo();
        order5.GetComponent<RandomCargo>().ActiveRndCargo();
    }

    public void OpenOrder()
    {
        RandomCargo();

        switch (numberOfOrders)
        {
            case 1:
                order1.SetActive(true);
                break;
            case 2:
                order1.SetActive(true);
                order2.SetActive(true);
                break;
            case 3:
                order1.SetActive(true);
                order2.SetActive(true);
                order3.SetActive(true);
                break;
            case 4:
                order1.SetActive(true);
                order2.SetActive(true);
                order3.SetActive(true);
                order4.SetActive(true);
                break;
            case 5:
                order1.SetActive(true);
                order2.SetActive(true);
                order3.SetActive(true);
                order4.SetActive(true);
                order5.SetActive(true);
                break;
        }        
    }

    public void ClosepnlCargo()
    {
        selectCargo.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (i == 0)
        {
            numberOfOrders = Random.Range(1, 6);
            OpenOrder();
            i++;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        i = 0;
    }
}
