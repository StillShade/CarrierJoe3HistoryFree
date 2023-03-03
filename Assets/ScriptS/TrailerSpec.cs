using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailerSpec : MonoBehaviour
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
    public float Cargo;    
    [Header("Тип груза")]
    public int cargoType;
    public GameObject cargo;    

    void Start()
    {
        //Main.CargoCondition = 0;
    }      

    private void Update()
    {

        switch (Main.CargoCondition)
        {
            case 100:
                cargo.SetActive(true);
                break;
        }
    }
}
