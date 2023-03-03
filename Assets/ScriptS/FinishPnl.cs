using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishPnl : MonoBehaviour
{
    [Header("Спец прицепы")]
    public GameObject ST1;
    public GameObject ST2;
    public GameObject ST3;
    [Header("Иконки")]
    public GameObject xpCar;
    public GameObject prizeDollars;
    public GameObject prizeHitchhiker;
    [Header("Текст")]
    public Text prizeRuly;
    public Text prizeXpFree;
    public Text prizeXpCar;
    public Text prizeXpTrailer;
    public Text prizeDollarsTx;

    [Header("Текст ADS")]
    public float prizeRulyFt;
    public Text prizeRulyX2;

    public float prizeXpFreeFt;
    public Text prizeXpFreeX2;

    public float prizeXpCarFt;
    public Text prizeXpCarX2;

    public float prizeXpTrailerFt;
    public Text prizeXpTrailerX2;

    [Header("Иконки")]
    public GameObject imgBison;
    public GameObject imgDUB;
    public GameObject imgFIIV;
    public GameObject imgHORSE;
    public GameObject imgRIDGE;
    public GameObject imgBoard;
    public GameObject imgTent;
    public GameObject imgRef;
    public GameObject imgCon;

    public void CloseAllImgTruck()
    {
        imgBison.SetActive(false);
        imgDUB.SetActive(false);
        imgFIIV.SetActive(false);
        imgHORSE.SetActive(false);
        imgRIDGE.SetActive(false);
    }

    public void CloseAllImgTrailer()
    {
        imgBoard.SetActive(false);
        imgTent.SetActive(false);
        imgRef.SetActive(false);
        imgCon.SetActive(false);
    }

    void Update()
    {
        if(Main.Hitchhiker == 0)
        {
            prizeHitchhiker.SetActive(false);
        }
        else
        {
            prizeHitchhiker.SetActive(true);
        }
        prizeRuly.text = Main.PrizeRuly.ToString("0") + " R";
        prizeRulyFt = Main.PrizeRuly * 2;
        prizeRulyX2.text = prizeRulyFt.ToString("0") + " R";
        prizeXpFree.text = Main.PrizeXpFree.ToString("0") + " XP";
        prizeXpFreeFt = Main.PrizeXpFree * 2;
        prizeXpFreeX2.text = prizeXpFreeFt.ToString("0") + " XP";
        prizeDollarsTx.text = Main.PrizeDollars.ToString("0") + " $";
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
                xpCar.SetActive(false);
                break;
        }
        prizeXpCar.text = Main.PrizeXpCar.ToString("0") + " XP";
        prizeXpCarFt = Main.PrizeXpCar * 2;
        prizeXpCarX2.text = prizeXpCarFt.ToString("0") + " XP";
        switch (Main.PrcNumber)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
                CloseAllImgTrailer();
                imgBoard.SetActive(true);
                xpCar.SetActive(true);
                prizeDollars.SetActive(false);
                break;
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
                CloseAllImgTrailer();
                imgBoard.SetActive(true);
                xpCar.SetActive(true);
                prizeDollars.SetActive(false);
                imgTent.SetActive(true);
                break;
            case 15:
            case 16:
            case 17:
            case 18:
            case 19:
            case 20:
                CloseAllImgTrailer();
                imgBoard.SetActive(true);
                xpCar.SetActive(true);
                prizeDollars.SetActive(false);
                imgRef.SetActive(true);
                break;
            case 21:
            case 22:
            case 23:
            case 24:
            case 25:
                CloseAllImgTrailer();
                imgBoard.SetActive(true);
                xpCar.SetActive(true);
                prizeDollars.SetActive(false);
                imgCon.SetActive(true);
                break;
            case 100:
            case 101:
            case 102:
                CloseAllImgTrailer();
                xpCar.SetActive(false);
                prizeDollars.SetActive(true);
                break;
        }
        prizeXpTrailer.text = Main.PrizeXpTrailer.ToString("0") + " XP";
        prizeXpTrailerFt = Main.PrizeXpTrailer * 2;
        prizeXpTrailerX2.text = prizeXpTrailerFt.ToString("0") + " XP";

        if (Main.SpecCargo == 1)
        {            
            ST1.SetActive(false);
            ST2.SetActive(false);
            ST3.SetActive(false);
        }
    }    
}
