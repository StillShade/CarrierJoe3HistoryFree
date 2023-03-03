using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailerSpec : MonoBehaviour
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
    public float Cargo;    
    [Header("��� �����")]
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
