using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailerCharCont : MonoBehaviour
{
    [Header("Грузоподъемность")]
    public float cargoWeight;
    [Header("Цена")]
    public int priceMoney;
    [Header("Опыт")]
    public int priceXp;
    [Header("Коэффициент")]
    public float coefficient;
    [Header("Вес")]
    public float trailerWeight;
    [Header("Вес груза")]
    public float blue;
    public float green;
    public float red;
    public float freeze;
    public float tank;
    [Header("Тип груза")]
    public int cargoType;
    public GameObject Blue;
    public GameObject Green;
    public GameObject Red;
    public GameObject Freeze;
    public GameObject Tank;

    void Start()
    {
        //Main.CargoCondition = 0;
    }

    public void CloseCargo()
    {
        Blue.SetActive(false);
        Green.SetActive(false);
        Red.SetActive(false);
        Freeze.SetActive(false);
        Tank.SetActive(false);
    }

    private void Update()
    {

        switch (Main.CargoCondition)
        {
            case 0:
                CloseCargo();
                break;
            case 17:
                Blue.SetActive(true);
                break;
            case 18:
                Green.SetActive(true);
                break;
            case 19:
                Red.SetActive(true);
                break;
            case 20:
                Freeze.SetActive(true);
                break;
            case 21:
                Tank.SetActive(true);
                break;
        }
    }
}
