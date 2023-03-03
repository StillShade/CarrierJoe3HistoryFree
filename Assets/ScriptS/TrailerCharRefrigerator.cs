using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailerCharRefrigerator : MonoBehaviour
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
    public float fish;
    public float meat;
    public float flowers;
    public float fruits;
    public float butter;
    [Header("Тип груза")]
    public int cargoType;
    public GameObject Fish;
    public GameObject Meat;
    public GameObject Flowers;
    public GameObject Fruits;
    public GameObject Butter;
    [Header("Установка")]
    public GameObject refOn;
    public AudioSource refOnAudio;

    int i = 0;

    
    void Start()
    {
        i = 0;
        //Main.CargoCondition = 0;
    }

    public void CloseCargo()
    {
        Fish.SetActive(false);
        Meat.SetActive(false);
        Flowers.SetActive(false);
        Fruits.SetActive(false);
        Butter.SetActive(false);
    }

    public void RefOn1()
    {
        refOn.SetActive(true);
        RefOn2();
    }
    public void RefOn2()
    {
        StartCoroutine(delay());
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(8f);
        refOnAudio.Play();
    }
    public void RefOff()
    {
        refOn.SetActive(false);
        refOnAudio.Stop();
    }
    private void Update()
    {

        switch (Main.CargoCondition)
        {
            case 0:
                CloseCargo();
                RefOff();
                break;
            case 12:
                Fish.SetActive(true);
                if (i == 0)
                {
                    RefOn1();
                    i++;
                }
                break;
            case 13:
                Meat.SetActive(true);
                if (i == 0)
                {
                    RefOn1();
                    i++;
                }
                break;
            case 14:
                Flowers.SetActive(true);
                if (i == 0)
                {
                    RefOn1();
                    i++;
                }
                break;
            case 15:
                Fruits.SetActive(true);
                if (i == 0)
                {
                    RefOn1();
                    i++;
                }
                break;
            case 16:
                Butter.SetActive(true);
                if (i == 0)
                {
                    RefOn1();
                    i++;
                }
                break;                  
        }        
    }
}
