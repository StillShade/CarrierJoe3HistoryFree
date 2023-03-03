using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpecCargo : MonoBehaviour
{
    public GameObject specCargoTimer;
    [Header("Бортовые прицепы")]
    public GameObject nullObjTrailer;
    public GameObject B1;
    public GameObject B2;
    public GameObject B3;
    public GameObject B4;
    public GameObject B5;
    public GameObject B6;
    public GameObject B7;

    [Header("Тентовые прицепы")]
    public GameObject T1;
    public GameObject T2;
    public GameObject T3;
    public GameObject T4;
    public GameObject T5;
    public GameObject T6;
    public GameObject T7;

    [Header("Рефрижираторы")]
    public GameObject R1;
    public GameObject R2;
    public GameObject R3;
    public GameObject R4;
    public GameObject R5;
    public GameObject R6;

    [Header("Контенеровозы")]
    public GameObject C1;
    public GameObject C2;
    public GameObject C3;
    public GameObject C4;
    public GameObject C5;

    [Header("Спецприцепы")]
    public GameObject ST1;
    public GameObject ST2;
    public GameObject ST3;

    [Header("Road")]
    public int rndFinLoca;
    public GameObject cityImg;
    public GameObject villageImg;
    public GameObject railwayImg;
    public GameObject airportImg;
    public GameObject portImg;
    public Text numbLoca;
    private int checkMyPos;
    public float distanceRoadTrue;
    public float distanceRoad;
    [Header("Финишь на карте")]
    public GameObject city1;
    public GameObject city2;
    public GameObject city3;
    public GameObject city4;
    public GameObject city5;
    public GameObject village1;
    public GameObject village4;
    public GameObject railway1;
    public GameObject airport1;
    public GameObject port1;
    [Header("Кнопка и панель спецгруза")]
    public GameObject pnlSpecCargo;
    public GameObject btnSpecCargo;    
    [Header("Рандомный спецгруз")]
    public float cargoWeight;
    public int numbrTrailer;
    public int rndSpecCargo;
    public GameObject imgST1;
    public GameObject imgST2;
    public GameObject imgST3;
    [Header("Награда")]
    public int rndRoad;
    public float rndPriceCargo;
    public float priceCargo;
    public float prizeRuly;
    public float rndXpFree;
    public float prizeXpFree;
    public int prizeDollars;
    [Header("TEXT")]
    public Text txDistanceRoad;
    public Text prizeRulyTx;
    public Text prizeXpFreeTx;
    public Text prizeDollarsTx;    
        

    public void ActiveRnd()
    {        
        rndSpecCargo = Random.Range(1, 4);
        rndFinLoca = Random.Range(1, 11);
        rndPriceCargo = Random.Range(50, 101);
        rndXpFree = Random.Range(20, 41);
    }

    public void CloseAllImgLoca()
    {
        cityImg.SetActive(false);
        villageImg.SetActive(false);
        railwayImg.SetActive(false);
        airportImg.SetActive(false);
        portImg.SetActive(false);
    }

    void Update()
    {      
        if (rndSpecCargo == 1)
        {
            imgST1.SetActive(true);
            imgST2.SetActive(false);
            imgST3.SetActive(false);
            cargoWeight = ST1.GetComponent<TrailerSpec>().Cargo;
            numbrTrailer = 100;
        }
        else if (rndSpecCargo == 2)
        {
            imgST1.SetActive(false);
            imgST2.SetActive(true);
            imgST3.SetActive(false);
            cargoWeight = ST2.GetComponent<TrailerSpec>().Cargo;
            numbrTrailer = 101;
        }
        else if (rndSpecCargo == 3)
        {
            imgST1.SetActive(false);
            imgST2.SetActive(false);
            imgST3.SetActive(true);
            cargoWeight = ST3.GetComponent<TrailerSpec>().Cargo;
            numbrTrailer = 102;
        }       

        switch (Main.MapLocation)
        {
            case "C1":
                checkMyPos = 1;
                break;
            case "C2":
                checkMyPos = 2;
                break;
            case "C3":
                checkMyPos = 3;
                break;
            case "C4":
                checkMyPos = 4;
                break;
            case "C5":
                checkMyPos = 5;
                break;
            case "V1":
                checkMyPos = 6;
                break;
            case "V4":
                checkMyPos = 7;
                break;
            case "R1":
                checkMyPos = 8;
                break;
            case "A1":
                checkMyPos = 9;
                break;
            case "P1":
                checkMyPos = 10;
                break;
        }

        switch (rndFinLoca)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                CloseAllImgLoca();
                cityImg.SetActive(true);
                numbLoca.text = rndFinLoca.ToString("0");
                break;
            case 6:
                CloseAllImgLoca();
                villageImg.SetActive(true);
                numbLoca.text = "1";
                break;
            case 7:
                CloseAllImgLoca();
                villageImg.SetActive(true);
                numbLoca.text = "4";
                break;
            case 8:
                CloseAllImgLoca();
                railwayImg.SetActive(true);
                numbLoca.text = "1";
                break;
            case 9:
                CloseAllImgLoca();
                airportImg.SetActive(true);
                numbLoca.text = "1";
                break;
            case 10:
                CloseAllImgLoca();
                portImg.SetActive(true);
                numbLoca.text = "1";
                break;
            case 11:
                CloseAllImgLoca();
                cityImg.SetActive(true);
                numbLoca.text = "1";
                break;
        }

        if (rndFinLoca == checkMyPos)
        {
            if (checkMyPos == 10)
            {
                rndFinLoca = 1;
                cityImg.SetActive(true);
            }
            else rndFinLoca++;
        }

        switch (checkMyPos)
        {
            case 1:
                switch (rndFinLoca)
                {
                    case 1:
                        distanceRoad = 0;
                        distanceRoadTrue = 0;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 2:
                        distanceRoad = 165;
                        distanceRoadTrue = 165;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 3:
                        distanceRoad = 420;
                        distanceRoadTrue = 420;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 4:
                        distanceRoad = 675;
                        distanceRoadTrue = 675;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 5:
                        distanceRoad = 935;
                        distanceRoadTrue = 935;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 6:
                        distanceRoad = 200;
                        distanceRoadTrue = 200;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 7:
                        distanceRoad = 865;
                        distanceRoadTrue = 865;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 8:
                        distanceRoad = 690;
                        distanceRoadTrue = 690;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 9:
                        distanceRoad = 110;
                        distanceRoadTrue = 110;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 10:
                        distanceRoad = 320;
                        distanceRoadTrue = 320;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                }
                break;
            case 2:
                switch (rndFinLoca)
                {
                    case 1:
                        distanceRoad = 165;
                        distanceRoadTrue = 165;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 2:
                        distanceRoad = 0;
                        distanceRoadTrue = 0;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 3:
                        distanceRoad = 255;
                        distanceRoadTrue = 255;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 4:
                        distanceRoad = 510;
                        distanceRoadTrue = 510;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 5:
                        distanceRoad = 770;
                        distanceRoadTrue = 770;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 6:
                        distanceRoad = 365;
                        distanceRoadTrue = 365;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 7:
                        distanceRoad = 700;
                        distanceRoadTrue = 700;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 8:
                        distanceRoad = 525;
                        distanceRoadTrue = 525;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 9:
                        distanceRoad = 275;
                        distanceRoadTrue = 275;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 10:
                        distanceRoad = 485;
                        distanceRoadTrue = 485;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                }
                break;
            case 3:
                switch (rndFinLoca)
                {
                    case 1:
                        distanceRoad = 420;
                        distanceRoadTrue = 420;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 2:
                        distanceRoad = 255;
                        distanceRoadTrue = 255;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 3:
                        distanceRoad = 0;
                        distanceRoadTrue = 0;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 4:
                        distanceRoad = 255;
                        distanceRoadTrue = 255;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 5:
                        distanceRoad = 515;
                        distanceRoadTrue = 515;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 6:
                        distanceRoad = 620;
                        distanceRoadTrue = 620;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 7:
                        distanceRoad = 445;
                        distanceRoadTrue = 445;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 8:
                        distanceRoad = 270;
                        distanceRoadTrue = 270;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 9:
                        distanceRoad = 530;
                        distanceRoadTrue = 530;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 10:
                        distanceRoad = 740;
                        distanceRoadTrue = 740;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                }
                break;
            case 4:
                switch (rndFinLoca)
                {
                    case 1:
                        distanceRoad = 675;
                        distanceRoadTrue = 675;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 2:
                        distanceRoad = 510;
                        distanceRoadTrue = 510;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 3:
                        distanceRoad = 255;
                        distanceRoadTrue = 255;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 4:
                        distanceRoad = 0;
                        distanceRoadTrue = 0;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 5:
                        distanceRoad = 500;
                        distanceRoadTrue = 500;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 6:
                        distanceRoad = 875;
                        distanceRoadTrue = 875;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 7:
                        distanceRoad = 190;
                        distanceRoadTrue = 190;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 8:
                        distanceRoad = 255;
                        distanceRoadTrue = 255;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 9:
                        distanceRoad = 785;
                        distanceRoadTrue = 785;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 10:
                        distanceRoad = 995;
                        distanceRoadTrue = 995;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                }
                break;
            case 5:
                switch (rndFinLoca)
                {
                    case 1:
                        distanceRoad = 935;
                        distanceRoadTrue = 935;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 2:
                        distanceRoad = 770;
                        distanceRoadTrue = 770;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 3:
                        distanceRoad = 515;
                        distanceRoadTrue = 515;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 4:
                        distanceRoad = 500;
                        distanceRoadTrue = 500;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 5:
                        distanceRoad = 0;
                        distanceRoadTrue = 0;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 6:
                        distanceRoad = 1135;
                        distanceRoadTrue = 1135;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 7:
                        distanceRoad = 690;
                        distanceRoadTrue = 690;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 8:
                        distanceRoad = 245;
                        distanceRoadTrue = 245;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 9:
                        distanceRoad = 1045;
                        distanceRoadTrue = 1045;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 10:
                        distanceRoad = 1255;
                        distanceRoadTrue = 1255;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                }
                break;
            case 6:
                switch (rndFinLoca)
                {
                    case 1:
                        distanceRoad = 200;
                        distanceRoadTrue = 200;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 2:
                        distanceRoad = 365;
                        distanceRoadTrue = 365;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 3:
                        distanceRoad = 620;
                        distanceRoadTrue = 620;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 4:
                        distanceRoad = 875;
                        distanceRoadTrue = 875;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 5:
                        distanceRoad = 1135;
                        distanceRoadTrue = 1135;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 6:
                        distanceRoad = 0;
                        distanceRoadTrue = 0;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 7:
                        distanceRoad = 1065;
                        distanceRoadTrue = 1065;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 8:
                        distanceRoad = 890;
                        distanceRoadTrue = 890;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 9:
                        distanceRoad = 310;
                        distanceRoadTrue = 310;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 10:
                        distanceRoad = 520;
                        distanceRoadTrue = 520;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                }
                break;
            case 7:
                switch (rndFinLoca)
                {
                    case 1:
                        distanceRoad = 865;
                        distanceRoadTrue = 865;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 2:
                        distanceRoad = 700;
                        distanceRoadTrue = 700;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 3:
                        distanceRoad = 445;
                        distanceRoadTrue = 445;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 4:
                        distanceRoad = 190;
                        distanceRoadTrue = 190;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 5:
                        distanceRoad = 690;
                        distanceRoadTrue = 690;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 6:
                        distanceRoad = 1065;
                        distanceRoadTrue = 1065;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 7:
                        distanceRoad = 0;
                        distanceRoadTrue = 0;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 8:
                        distanceRoad = 445;
                        distanceRoadTrue = 445;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 9:
                        distanceRoad = 975;
                        distanceRoadTrue = 975;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 10:
                        distanceRoad = 1185;
                        distanceRoadTrue = 1185;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                }
                break;
            case 8:
                switch (rndFinLoca)
                {
                    case 1:
                        distanceRoad = 690;
                        distanceRoadTrue = 690;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 2:
                        distanceRoad = 525;
                        distanceRoadTrue = 525;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 3:
                        distanceRoad = 270;
                        distanceRoadTrue = 270;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 4:
                        distanceRoad = 255;
                        distanceRoadTrue = 255;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 5:
                        distanceRoad = 245;
                        distanceRoadTrue = 245;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 6:
                        distanceRoad = 890;
                        distanceRoadTrue = 890;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 7:
                        distanceRoad = 445;
                        distanceRoadTrue = 445;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 8:
                        distanceRoad = 0;
                        distanceRoadTrue = 0;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 9:
                        distanceRoad = 800;
                        distanceRoadTrue = 800;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 10:
                        distanceRoad = 1010;
                        distanceRoadTrue = 1010;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                }
                break;
            case 9:
                switch (rndFinLoca)
                {
                    case 1:
                        distanceRoad = 110;
                        distanceRoadTrue = 110;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 2:
                        distanceRoad = 275;
                        distanceRoadTrue = 275;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 3:
                        distanceRoad = 530;
                        distanceRoadTrue = 530;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 4:
                        distanceRoad = 785;
                        distanceRoadTrue = 785;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 5:
                        distanceRoad = 1045;
                        distanceRoadTrue = 1045;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 6:
                        distanceRoad = 310;
                        distanceRoadTrue = 310;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 7:
                        distanceRoad = 975;
                        distanceRoadTrue = 975;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 8:
                        distanceRoad = 800;
                        distanceRoadTrue = 800;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 9:
                        distanceRoad = 0;
                        distanceRoadTrue = 0;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 10:
                        distanceRoad = 430;
                        distanceRoadTrue = 430;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                }
                break;
            case 10:
                switch (rndFinLoca)
                {
                    case 1:
                        distanceRoad = 320;
                        distanceRoadTrue = 320;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 2:
                        distanceRoad = 485;
                        distanceRoadTrue = 485;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 3:
                        distanceRoad = 740;
                        distanceRoadTrue = 740;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 4:
                        distanceRoad = 995;
                        distanceRoadTrue = 995;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 5:
                        distanceRoad = 1255;
                        distanceRoadTrue = 1255;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 6:
                        distanceRoad = 520;
                        distanceRoadTrue = 520;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 7:
                        distanceRoad = 1185;
                        distanceRoadTrue = 1185;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 8:
                        distanceRoad = 1010;
                        distanceRoadTrue = 1010;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 9:
                        distanceRoad = 430;
                        distanceRoadTrue = 430;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 10:
                        distanceRoad = 0;
                        distanceRoadTrue = 0;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                    case 11:
                        distanceRoad = 320;
                        distanceRoadTrue = 320;
                        txDistanceRoad.text = distanceRoad + " KM";
                        break;
                }
                break;
        }

        if (distanceRoad >= 250 && distanceRoad <= 500) distanceRoad = distanceRoad * 1.05f;
        else if (distanceRoad >= 501 && distanceRoad <= 750) distanceRoad = distanceRoad * 1.1f;
        else if (distanceRoad >= 751 && distanceRoad <= 1000) distanceRoad = distanceRoad * 1.15f;
        else if (distanceRoad >= 1001 && distanceRoad <= 1250) distanceRoad = distanceRoad * 1.2f;

        prizeRuly = rndPriceCargo * distanceRoad;
        priceCargo = prizeRuly / distanceRoadTrue;
        prizeXpFree = rndXpFree * distanceRoad / 20;

        prizeRulyTx.text = prizeRuly.ToString("0") + " R (" + priceCargo.ToString("0") + " R/KM)";
        prizeXpFreeTx.text = prizeXpFree.ToString("0") + " XP";

        if (distanceRoadTrue <= 100)
            prizeDollars = 2;
        else if (distanceRoadTrue >= 101 && distanceRoadTrue <= 200)
            prizeDollars = 4;
        else if (distanceRoadTrue >= 201 && distanceRoadTrue <= 300)
            prizeDollars = 6;
        else if (distanceRoadTrue >= 301 && distanceRoadTrue <= 400)
            prizeDollars = 8;
        else if (distanceRoadTrue >= 401 && distanceRoadTrue <= 500)
            prizeDollars = 10;
        else if (distanceRoadTrue >= 501 && distanceRoadTrue <= 600)
            prizeDollars = 12;
        else if (distanceRoadTrue >= 601 && distanceRoadTrue <= 700)
            prizeDollars = 14;
        else if (distanceRoadTrue >= 701 && distanceRoadTrue <= 800)
            prizeDollars = 16;
        else if (distanceRoadTrue >= 801 && distanceRoadTrue <= 900)
            prizeDollars = 18;
        else if (distanceRoadTrue >= 901 && distanceRoadTrue <= 1000)
            prizeDollars = 20;
        else if (distanceRoadTrue >= 1001 && distanceRoadTrue <= 1100)
            prizeDollars = 22;
        else if (distanceRoadTrue >= 1101 && distanceRoadTrue <= 1200)
            prizeDollars = 24;
        else if (distanceRoadTrue >= 1201 && distanceRoadTrue <= 1300)
            prizeDollars = 26;
        else if (distanceRoadTrue >= 1301 && distanceRoadTrue <= 1400)
            prizeDollars = 28;
        else if (distanceRoadTrue >= 1401 && distanceRoadTrue <= 1500)
            prizeDollars = 30;
        prizeDollarsTx.text = prizeDollars.ToString("0") + " $";
    }

    public void OpenFinishLoca()
    {
        CloseAllFinishLoca();
        switch (rndFinLoca)
        {
            case 1:
                city1.SetActive(true);
                break;
            case 2:
                city2.SetActive(true);
                break;
            case 3:
                city3.SetActive(true);
                break;
            case 4:
                city4.SetActive(true);
                break;
            case 5:
                city5.SetActive(true);
                break;
            case 6:
                village1.SetActive(true);
                break;
            case 7:
                village4.SetActive(true);
                break;
            case 8:
                railway1.SetActive(true);
                break;
            case 9:
                airport1.SetActive(true);
                break;
            case 10:
                port1.SetActive(true);
                break;
            case 11:
                city1.SetActive(true);
                break;
        }
    }

    public void OpenSpecCargo()
    {
        ActiveRnd();
        pnlSpecCargo.SetActive(true);
    }
    public void ExitSpecCargo()
    {
        specCargoTimer.GetComponent<SpecCargoTimer>().timer += 900;
        pnlSpecCargo.SetActive(false);        
    }
    public void SelectSpecCargo()
    {
        Main.PrcNumber = numbrTrailer;
        CloseAllTrailer();
        switch (numbrTrailer)
        {
            case 100:
                ST1.SetActive(true);
                break;
            case 101:
                ST2.SetActive(true);
                break;
            case 102:
                ST3.SetActive(true);
                break;
        }
        
        Main.FinishLoca = rndFinLoca;        
        Main.PrizeRuly = prizeRuly;
        Main.PrizeXpFree = prizeXpFree;
        Main.PrizeDollars = prizeDollars;        
        Main.CargoWeight = cargoWeight;
        Main.SpecCargo = 1;
        btnSpecCargo.SetActive(false);
        pnlSpecCargo.SetActive(false);
    }

    public void CloseAllFinishLoca()
    {
        city1.SetActive(false);
        city2.SetActive(false);
        city3.SetActive(false);
        city4.SetActive(false);
        city5.SetActive(false);
        village1.SetActive(false);
        village4.SetActive(false);
        railway1.SetActive(false);
        airport1.SetActive(false);
        port1.SetActive(false);
    }

    public void CloseAllTrailer()
    {
        switch (numbrTrailer)
        {
            case 0:
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                break;
            case 1:
                nullObjTrailer.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                break;
            case 2:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                break;
            case 3:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                break;
            case 4:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                break;
            case 5:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                break;
            case 6:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                break;
            case 7:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                break;
            case 8:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                break;
            case 9:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                break;
            case 10:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                break;
            case 11:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                break;
            case 12:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                break;
            case 13:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                break;
            case 14:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                break;
            case 15:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                break;
            case 16:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                break;
            case 17:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                break;
            case 18:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                break;
            case 19:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R6.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                break;
            case 20:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                break;
            case 21:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                break;
            case 22:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                C1.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                break;
            case 23:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                break;
            case 24:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C5.SetActive(false);
                break;
            case 25:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                break;
            case 100:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST2.SetActive(false);
                ST3.SetActive(false);
                break;
            case 101:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST1.SetActive(false);
                ST3.SetActive(false);
                break;
            case 102:
                nullObjTrailer.SetActive(false);
                B1.SetActive(false);
                B2.SetActive(false);
                B3.SetActive(false);
                B4.SetActive(false);
                B5.SetActive(false);
                B6.SetActive(false);
                B7.SetActive(false);
                T1.SetActive(false);
                T2.SetActive(false);
                T3.SetActive(false);
                T4.SetActive(false);
                T5.SetActive(false);
                T6.SetActive(false);
                T7.SetActive(false);
                R1.SetActive(false);
                R2.SetActive(false);
                R3.SetActive(false);
                R4.SetActive(false);
                R5.SetActive(false);
                R6.SetActive(false);
                C1.SetActive(false);
                C2.SetActive(false);
                C3.SetActive(false);
                C4.SetActive(false);
                C5.SetActive(false);
                ST1.SetActive(false);
                ST2.SetActive(false);
                break;
        }
    }
}
