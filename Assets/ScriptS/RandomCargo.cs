using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomCargo : MonoBehaviour
{
    [Header("Прицепы")]
    public GameObject prefTrailerClon;
    public GameObject B1;
    public GameObject B2;
    public GameObject B3;
    public GameObject B4;
    public GameObject B5;
    public GameObject B6;
    public GameObject B7;
    public GameObject T1;
    public GameObject T2;
    public GameObject T3;
    public GameObject T4;
    public GameObject T5;
    public GameObject T6;
    public GameObject T7;
    public GameObject R1;
    public GameObject R2;
    public GameObject R3;
    public GameObject R4;
    public GameObject R5;
    public GameObject R6;
    public GameObject C1;
    public GameObject C2;
    public GameObject C3;
    public GameObject C4;
    public GameObject C5;
    [Header("Панель выбора груза")]
    public GameObject pnlSelectCargo;
    [Header("Изображения груза")]
    public GameObject imgBrick;
    public GameObject imgCub;
    public GameObject imgBarel;
    public GameObject imgBigBag;
    public GameObject imgIronRoll;
    public GameObject imgFertilizer;
    public GameObject imgGlassBottle;
    public GameObject imgRefrigerator;
    public GameObject imgDrywall;
    public GameObject imgCannedFood;
    public GameObject imgSandwichPanel;
    public GameObject imgFish;
    public GameObject imgMeat;
    public GameObject imgFlowers;
    public GameObject imgFruits;
    public GameObject imgButter;
    public GameObject imgBlueCon;
    public GameObject imgGreenCon;
    public GameObject imgRedCon;
    public GameObject imgFreezeCon;
    public GameObject imgTankCon;
    [Header("Изображения авто")]
    public GameObject xpCarImg;
    public GameObject imgBison, imgDUB, imgFIIV, imgHORSE, imgRIDGE;
    [Header("Изображения прицепа")]
    public GameObject imgBoard, imgTent, imgRef, imgCon;
    [Header("Изображения веса и документов")]    
    public GameObject Camera;
    public float totalWeightTrailer;
    public float allowableWeight;
    public float weightTrailer;
    public int dokiOk;
    public GameObject imgWeightOk;
    public GameObject imgOVERLOAD;
    public GameObject imgDokiOk;
    public GameObject imgNoDocuments;
    [Header("Рандомные числа")]
    public int rndCargo;
    public int rndPriceCargo;
    public float priceCargo;
    public int rndFinLoca;
    public int rndDoki;
    [Header("Road")]
    public GameObject cityImg;
    public GameObject villageImg;
    public GameObject railwayImg;
    public GameObject airportImg;
    public GameObject portImg;
    public Text numbLoca;
    private int checkMyPos;
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

    public float distanceRoadTrue;
    public float distanceRoad;
    
    [Header("Разные числа")]
    public float cargoWeight;
    public float coefficientCargo;
    public int xpFree;
    public int xpCar;
    public int xpTrailer;
    public int cargoType;
    [Header("Текст")]
    public Text txCargoWeight;
    public Text txDistanceRoad;
    public Text txPriceCargo;
    public Text txXpFree;
    public Text txXpCar;
    public Text txXpTrailer;
    public Text txWeight;
    public Text txDoki;
    [Header("Prize")]
    public float prizeRuly;
    public float prizeXpFree;
    public float coefPrizeXpFree;
    public float prizeXpCar;
    public float prizeXpTrailer;
    [Header("StopBack")]
    public GameObject stopBack;
    public GameObject stopForward;

    public void ActiveRndCargo()
    {
        if (Main.PrcNumber >= 1 && Main.PrcNumber <= 7)
        {
            rndCargo = Random.Range(1, 7);
        }
        if (Main.PrcNumber >= 8 && Main.PrcNumber <= 14)
        {
            rndCargo = Random.Range(7, 12);
        }
        if (Main.PrcNumber >= 15 && Main.PrcNumber <= 20)
        {
            rndCargo = Random.Range(12, 17);
        }
        if (Main.PrcNumber >= 21 && Main.PrcNumber <= 25)
        {
            rndCargo = Random.Range(17, 22);
        }
        rndPriceCargo = Random.Range(8, 16);
        rndFinLoca = Random.Range(1, 11);
        rndDoki = Random.Range(1, 101);
        xpCar = Random.Range(10, 21);
        xpTrailer = Random.Range(10, 21);
        coefPrizeXpFree = Main.CoefPrizeXpFree;        
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

    public void CloseAllImgLoca()
    {
        cityImg.SetActive(false);
        villageImg.SetActive(false);
        railwayImg.SetActive(false);
        airportImg.SetActive(false);
        portImg.SetActive(false);
    }

    public void CloseAllImgCargo()
    {
        imgBrick.SetActive(false);
        imgCub.SetActive(false);
        imgBarel.SetActive(false);
        imgBigBag.SetActive(false);
        imgIronRoll.SetActive(false);
        imgFertilizer.SetActive(false);
        imgGlassBottle.SetActive(false);
        imgRefrigerator.SetActive(false);
        imgDrywall.SetActive(false);
        imgCannedFood.SetActive(false);
        imgSandwichPanel.SetActive(false);
        imgFish.SetActive(false);
        imgMeat.SetActive(false);
        imgFlowers.SetActive(false);
        imgFruits.SetActive(false);
        imgButter.SetActive(false);
        imgBlueCon.SetActive(false);
        imgGreenCon.SetActive(false);
        imgRedCon.SetActive(false);
        imgFreezeCon.SetActive(false);
        imgTankCon.SetActive(false);
    }

    public void CloseAllImgTruck()
    {
        imgBison.SetActive(false); imgDUB.SetActive(false); imgFIIV.SetActive(false); imgHORSE.SetActive(false); imgRIDGE.SetActive(false);
    }

    public void CloseAllImgTrailer()
    {
        imgBoard.SetActive(false); imgTent.SetActive(false); imgRef.SetActive(false); imgCon.SetActive(false);
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

    public void SelectOrder()
    {
        stopBack.SetActive(true);
        stopForward.SetActive(false);
        Main.DokiOk = dokiOk;
        Main.FinishLoca = rndFinLoca;
        pnlSelectCargo.SetActive(false);
        Main.PrizeRuly = prizeRuly;
        Main.PrizeXpFree = prizeXpFree;
        Main.PrizeXpCar = prizeXpCar;
        Main.PrizeXpTrailer = prizeXpTrailer;
        Main.CargoCondition = cargoType;
        Main.CargoWeight = cargoWeight;
    }

    void Update()
    {      
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

        if (rndFinLoca == checkMyPos)
        {
            if (checkMyPos == 10)
            {
                rndFinLoca = 1;
                cityImg.SetActive(true);
            }
            else rndFinLoca++;
        }

        switch (Main.PrcNumber)
        {
            case 1:
                prefTrailerClon = B1;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerChar>().coefficient;
                CloseAllImgTrailer();
                imgBoard.SetActive(true);
                break;
            case 2:
                prefTrailerClon = B2;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerChar>().coefficient;
                CloseAllImgTrailer();
                imgBoard.SetActive(true);
                break;
            case 3:
                prefTrailerClon = B3;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerChar>().coefficient;
                CloseAllImgTrailer();
                imgBoard.SetActive(true);
                break;
            case 4:
                prefTrailerClon = B4;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerChar>().coefficient;
                CloseAllImgTrailer();
                imgBoard.SetActive(true);
                break;
            case 5:
                prefTrailerClon = B5;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerChar>().coefficient;
                CloseAllImgTrailer();
                imgBoard.SetActive(true);
                break;
            case 6:
                prefTrailerClon = B6;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerChar>().coefficient;
                CloseAllImgTrailer();
                imgBoard.SetActive(true);
                break;
            case 7:
                prefTrailerClon = B7;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerChar>().coefficient;
                CloseAllImgTrailer();
                imgBoard.SetActive(true);
                break;
            case 8:
                prefTrailerClon = T1;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerCharTent>().coefficient;
                CloseAllImgTrailer();
                imgTent.SetActive(true);
                break;
            case 9:
                prefTrailerClon = T2;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerCharTent>().coefficient;
                CloseAllImgTrailer();
                imgTent.SetActive(true);
                break;
            case 10:
                prefTrailerClon = T3;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerCharTent>().coefficient;
                CloseAllImgTrailer();
                imgTent.SetActive(true);
                break;
            case 11:
                prefTrailerClon = T4;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerCharTent>().coefficient;
                CloseAllImgTrailer();
                imgTent.SetActive(true);
                break;
            case 12:
                prefTrailerClon = T5;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerCharTent>().coefficient;
                CloseAllImgTrailer();
                imgTent.SetActive(true);
                break;
            case 13:
                prefTrailerClon = T6;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerCharTent>().coefficient;
                CloseAllImgTrailer();
                imgTent.SetActive(true);
                break;
            case 14:
                prefTrailerClon = T7;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerCharTent>().coefficient;
                CloseAllImgTrailer();
                imgTent.SetActive(true);
                break;
            case 15:
                prefTrailerClon = R1;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerCharRefrigerator>().coefficient;
                CloseAllImgTrailer();
                imgRef.SetActive(true);
                break;
            case 16:
                prefTrailerClon = R2;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerCharRefrigerator>().coefficient;
                CloseAllImgTrailer();
                imgRef.SetActive(true);
                break;
            case 17:
                prefTrailerClon = R3;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerCharRefrigerator>().coefficient;
                CloseAllImgTrailer();
                imgRef.SetActive(true);
                break;
            case 18:
                prefTrailerClon = R4;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerCharRefrigerator>().coefficient;
                CloseAllImgTrailer();
                imgRef.SetActive(true);
                break;
            case 19:
                prefTrailerClon = R5;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerCharRefrigerator>().coefficient;
                CloseAllImgTrailer();
                imgRef.SetActive(true);
                break;
            case 20:
                prefTrailerClon = R6;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerCharRefrigerator>().coefficient;
                CloseAllImgTrailer();
                imgRef.SetActive(true);
                break;
            case 21:
                prefTrailerClon = C1;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerCharCont>().coefficient;
                CloseAllImgTrailer();
                imgCon.SetActive(true);
                break;
            case 22:
                prefTrailerClon = C2;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerCharCont>().coefficient;
                CloseAllImgTrailer();
                imgCon.SetActive(true);
                break;
            case 23:
                prefTrailerClon = C3;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerCharCont>().coefficient;
                CloseAllImgTrailer();
                imgCon.SetActive(true);
                break;
            case 24:
                prefTrailerClon = C4;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerCharCont>().coefficient;
                CloseAllImgTrailer();
                imgCon.SetActive(true);
                break;
            case 25:
                prefTrailerClon = C5;
                coefficientCargo = prefTrailerClon.GetComponent<TrailerCharCont>().coefficient;
                CloseAllImgTrailer();
                imgCon.SetActive(true);
                break;
        }
        switch (rndCargo)
        {
            case 1:
                CloseAllImgCargo();
                imgBrick.SetActive(true);
                cargoWeight = prefTrailerClon.GetComponent<TrailerChar>().brick;
                cargoType = 1;
                break;
            case 2:
                CloseAllImgCargo();
                imgCub.SetActive(true);
                cargoWeight = prefTrailerClon.GetComponent<TrailerChar>().cub;
                cargoType = 2;
                break;
            case 3:
                CloseAllImgCargo();
                imgBarel.SetActive(true);
                cargoWeight = prefTrailerClon.GetComponent<TrailerChar>().barel;
                cargoType = 3;
                break;
            case 4:
                CloseAllImgCargo();
                imgBigBag.SetActive(true);
                cargoWeight = prefTrailerClon.GetComponent<TrailerChar>().bigBag;
                cargoType = 4;
                break;
            case 5:
                CloseAllImgCargo();
                imgIronRoll.SetActive(true);
                cargoWeight = prefTrailerClon.GetComponent<TrailerChar>().ironRoll;
                cargoType = 5;
                break;
            case 6:
                CloseAllImgCargo();
                imgFertilizer.SetActive(true);
                cargoWeight = prefTrailerClon.GetComponent<TrailerChar>().fertilizer;
                cargoType = 6;
                break;
            case 7:
                CloseAllImgCargo();
                imgGlassBottle.SetActive(true);
                cargoWeight = prefTrailerClon.GetComponent<TrailerCharTent>().glassBottle;
                cargoType = 7;
                break;
            case 8:
                CloseAllImgCargo();
                imgRefrigerator.SetActive(true);
                cargoWeight = prefTrailerClon.GetComponent<TrailerCharTent>().refrigerator;
                cargoType = 8;
                break;
            case 9:
                CloseAllImgCargo();
                imgDrywall.SetActive(true);
                cargoWeight = prefTrailerClon.GetComponent<TrailerCharTent>().drywall;
                cargoType = 9;
                break;
            case 10:
                CloseAllImgCargo();
                imgCannedFood.SetActive(true);
                cargoWeight = prefTrailerClon.GetComponent<TrailerCharTent>().cannedFood;
                cargoType = 10;
                break;
            case 11:
                CloseAllImgCargo();
                imgSandwichPanel.SetActive(true);
                cargoWeight = prefTrailerClon.GetComponent<TrailerCharTent>().sandwichPanel;
                cargoType = 11;
                break;
            case 12:
                CloseAllImgCargo();
                imgFish.SetActive(true);
                cargoWeight = prefTrailerClon.GetComponent<TrailerCharRefrigerator>().fish;
                cargoType = 12;
                break;
            case 13:
                CloseAllImgCargo();
                imgMeat.SetActive(true);
                cargoWeight = prefTrailerClon.GetComponent<TrailerCharRefrigerator>().meat;
                cargoType = 13;
                break;
            case 14:
                CloseAllImgCargo();
                imgFlowers.SetActive(true);
                cargoWeight = prefTrailerClon.GetComponent<TrailerCharRefrigerator>().flowers;
                cargoType = 14;
                break;
            case 15:
                CloseAllImgCargo();
                imgFruits.SetActive(true);
                cargoWeight = prefTrailerClon.GetComponent<TrailerCharRefrigerator>().fruits;
                cargoType = 15;
                break;
            case 16:
                CloseAllImgCargo();
                imgButter.SetActive(true);
                cargoWeight = prefTrailerClon.GetComponent<TrailerCharRefrigerator>().butter;
                cargoType = 16;
                break;
            case 17:
                CloseAllImgCargo();
                imgBlueCon.SetActive(true);
                cargoWeight = prefTrailerClon.GetComponent<TrailerCharCont>().blue;
                cargoType = 17;
                break;
            case 18:
                CloseAllImgCargo();
                imgGreenCon.SetActive(true);
                cargoWeight = prefTrailerClon.GetComponent<TrailerCharCont>().green;
                cargoType = 18;
                break;
            case 19:
                CloseAllImgCargo();
                imgRedCon.SetActive(true);
                cargoWeight = prefTrailerClon.GetComponent<TrailerCharCont>().red;
                cargoType = 19;
                break;
            case 20:
                CloseAllImgCargo();
                imgFreezeCon.SetActive(true);
                cargoWeight = prefTrailerClon.GetComponent<TrailerCharCont>().freeze;
                cargoType = 20;
                break;
            case 21:
                CloseAllImgCargo();
                imgTankCon.SetActive(true);
                cargoWeight = prefTrailerClon.GetComponent<TrailerCharCont>().tank;
                cargoType = 21;
                break;
        }        
        switch (Main.CarNumber)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
                CloseAllImgTruck();
                imgBison.SetActive(true);
                break;
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
                CloseAllImgTruck();
                imgDUB.SetActive(true);
                break;
            case 14:
            case 15:
            case 16:
            case 17:
            case 18:
            case 19:
            case 20:
            case 21:
                CloseAllImgTruck();
                imgFIIV.SetActive(true);
                break;
            case 22:                
            case 23:
            case 24:
            case 25:
            case 26:
                CloseAllImgTruck();
                imgHORSE.SetActive(true);
                break;
            case 27:
            case 28:
            case 29:
            case 30:
                CloseAllImgTruck();
                imgRIDGE.SetActive(true);
                break;
            case 101:
            case 102:
                CloseAllImgTruck();
                xpCarImg.SetActive(false);
                break;
        }
        txCargoWeight.text = cargoWeight + " T";

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

        if (rndDoki <= 20)
        {
            prizeRuly = ((rndPriceCargo * coefficientCargo) * distanceRoad) * 1.5f;
        }
        else
        {
            prizeRuly = (rndPriceCargo * coefficientCargo) * distanceRoad;
        }
        
        priceCargo = prizeRuly / distanceRoadTrue;
        prizeXpCar = ((xpCar * coefficientCargo) / 100) * distanceRoad;
        prizeXpTrailer = ((xpTrailer * coefficientCargo) / 100) * distanceRoad;

        prizeXpFree = (prizeXpCar + prizeXpTrailer) * coefPrizeXpFree;
        txPriceCargo.text = prizeRuly.ToString("0") + " R (" + priceCargo.ToString("0") + " R/KM)";
        txXpFree.text = prizeXpFree.ToString("0") + " XP";
        txXpCar.text = prizeXpCar.ToString("0") + " XP";
        txXpTrailer.text = prizeXpTrailer.ToString("0") + " XP";

        weightTrailer = Camera.GetComponent<Movecar>().weightTrailer;
        allowableWeight = Camera.GetComponent<Movecar>().allowableWeight;
        totalWeightTrailer = weightTrailer + cargoWeight * 1000;
        if (totalWeightTrailer > allowableWeight)
        {
            imgOVERLOAD.SetActive(true);
            imgWeightOk.SetActive(false);
            txWeight.text = "OVERLOAD";
        }
        else
        {
            imgWeightOk.SetActive(true);
            imgOVERLOAD.SetActive(false);
            txWeight.text = "OK";
        }

        if (rndDoki <= 20)
        {
            dokiOk = 1;
            imgDokiOk.SetActive(false);
            imgNoDocuments.SetActive(true);
            txDoki.text = "NO DOCUMENTS";
            prizeRuly = prizeRuly * 1.5f;
        }
        else
        {
            dokiOk = 0;
            imgNoDocuments.SetActive(false);
            imgDokiOk.SetActive(true);
            txDoki.text = "OK";
        }
    }
}