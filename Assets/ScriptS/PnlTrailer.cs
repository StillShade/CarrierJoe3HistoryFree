using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PnlTrailer : MonoBehaviour
{
    public GameObject mainCamera;
    [Header("Панели прицепов")]
    public GameObject pnlTrailer;
    public GameObject pnlBoard;
    public GameObject pnlTent;
    public GameObject pnlRef;
    public GameObject pnlCon;
    public Text nameTx;
    public GameObject infoPnl;
    public int pricepNumber;
    GameObject prefTrailerClone;

    [Header("Кнопки и тексты XP, Money, Select")]
    public GameObject pnlBtnXpMonSel;
    public GameObject btnXpActive;
    public int priceXp;
    public Text priceXpTx;
    public GameObject btnMoneyActive;
    public int priceMoney;
    public Text priceMoneyTx;
    public GameObject btnSelect;

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

    [Header("Панели предупреждений")]
    public GameObject somethingIsMissing;
    public Text SIMtx;
    [Header("Характеристики прицепа")]
    public GameObject Camera;
    public float allowableWeightTruck;
    public float cargoWeight;
    public float trailerWeight;
    public float allowableWeight;
    public Text cargoWeightTx;
    public Text trailerWeightTx;
    public Text allowableWeightTx;
       

    public void OpenPnlBoard()
    {
        infoPnl.SetActive(true);
        pnlBtnXpMonSel.SetActive(true);
        pnlBoard.SetActive(true);
        btnSelect.SetActive(true);
        pricepNumber = 1;
    }

    public void NextBoard()
    {
        if (pricepNumber < 7)
        pricepNumber++;
    }

    public void BackBoard()
    {
        if (pricepNumber > 1)
            pricepNumber--;
    }

    public void OpenPnlTent()
    {
        infoPnl.SetActive(true);
        pnlBtnXpMonSel.SetActive(true);
        pnlTent.SetActive(true);
        btnSelect.SetActive(true);
        pricepNumber = 8;
    }

    public void NextTent()
    {
        if (pricepNumber < 14)
            pricepNumber++;
    }

    public void BackTent()
    {
        if (pricepNumber > 8)
            pricepNumber--;
    }

    public void OpenPnlRef()
    {
        infoPnl.SetActive(true);
        pnlBtnXpMonSel.SetActive(true);
        pnlRef.SetActive(true);
        btnSelect.SetActive(true);
        pricepNumber = 15;
    }

    public void NextRef()
    {
        if (pricepNumber < 20)
            pricepNumber++;
    }

    public void BackRef()
    {
        if (pricepNumber > 15)
            pricepNumber--;
    }

    public void OpenPnlCon()
    {
        infoPnl.SetActive(true);
        pnlBtnXpMonSel.SetActive(true);
        pnlCon.SetActive(true);
        btnSelect.SetActive(true);
        pricepNumber = 21;
    }

    public void NextCon()
    {
        if (pricepNumber < 25)
            pricepNumber++;
    }

    public void BackCon()
    {
        if (pricepNumber > 21)
            pricepNumber--;
    }

    public void CloseAllPanel()
    {
        infoPnl.SetActive(false);
        pricepNumber = Main.PrcNumber;
        pnlBoard.SetActive(false);
        pnlTent.SetActive(false);
        pnlRef.SetActive(false);
        pnlCon.SetActive(false);
        btnSelect.SetActive(false);
        btnMoneyActive.SetActive(false);
        btnXpActive.SetActive(false);
        pnlBtnXpMonSel.SetActive(false);
        CloseAllTrailer();
    }

    //nullObjTrailer.SetActive(false);
    //B1.SetActive(false);
    //            B2.SetActive(false);
    //            B3.SetActive(false);
    //            B4.SetActive(false);
    //            B5.SetActive(false);
    //            B6.SetActive(false);
    //            B7.SetActive(false);
    //            T1.SetActive(false);
    //            T2.SetActive(false);
    //            T3.SetActive(false);
    //            T4.SetActive(false);
    //            T5.SetActive(false);
    //            T6.SetActive(false);
    //            T7.SetActive(false);
    //            R1.SetActive(false);
    //            R2.SetActive(false);
    //            R3.SetActive(false);
    //            R4.SetActive(false);
    //            R5.SetActive(false);
    //            R6.SetActive(false);
    //            ST1.SetActive(false);
    //            ST2.SetActive(false);
    //            ST3.SetActive(false);
    //    C1.SetActive(false);
    //            C2.SetActive(false);
    //            C3.SetActive(false);
    //            C4.SetActive(false);
    //            C5.SetActive(false);

    public void CloseAllTrailer()
    {
        switch (pricepNumber)
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

    public void ClosePnlTrailer() 
    {
        mainCamera.GetComponent<Movecar>().GarageCam();
        pricepNumber = Main.PrcNumber;
        pnlTrailer.SetActive(false);
        btnSelect.SetActive(false);
        pnlBtnXpMonSel.SetActive(false);
        CloseAllTrailer();
    }   

    public void CloseSIM()
    {
        somethingIsMissing.SetActive(false);
    }

    public void BuyXpTrailer()
    {
        if (pricepNumber >= 1 && pricepNumber <= 7 && Main.BankXpBoard >= priceXp)
        {      
            switch (pricepNumber)
            {
                case 1:
                    Main.BankXpBoard -= priceXp;
                    Main.XpActiveB1 = 1;
                    break;
                case 2:
                    if (Main.XpActiveB1 == 1)
                    {
                        Main.BankXpBoard -= priceXp;
                        Main.XpActiveB2 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore B1";
                    }
                    break;
                case 3:
                    if (Main.XpActiveB2 == 1)
                    {
                        Main.BankXpBoard -= priceXp;
                        Main.XpActiveB3 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore B2";
                    }
                    break;
                case 4:
                    if (Main.XpActiveB3 == 1)
                    {
                        Main.BankXpBoard -= priceXp;
                        Main.XpActiveB4 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore B3";
                    }
                    break;
                case 5:
                    if (Main.XpActiveB4 == 1)
                    {
                        Main.BankXpBoard -= priceXp;
                        Main.XpActiveB5 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore B4";
                    }
                    break;
                case 6:
                    if (Main.XpActiveB5 == 1)
                    {
                        Main.BankXpBoard -= priceXp;
                        Main.XpActiveB6 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore B5";
                    }
                    break;
                case 7:
                    if (Main.XpActiveB6 == 1)
                    {
                        Main.BankXpBoard -= priceXp;
                        Main.XpActiveB7 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore B6";
                    }
                    break;                  
            }            
        }
        else if (pricepNumber >= 1 && pricepNumber <= 7 && Main.BankXpBoard < priceXp)
        {
            somethingIsMissing.SetActive(true);
            SIMtx.text = "Not enough XP";
        }
        else if (pricepNumber >= 8 && pricepNumber <= 14 && Main.BankXpTent >= priceXp)
        {
            switch (pricepNumber)
            {
                case 8:
                    Main.BankXpTent -= priceXp;
                    Main.XpActiveT1 = 1;
                    break;
                case 9:
                    if (Main.XpActiveT1 == 1)
                    {
                        Main.BankXpTent -= priceXp;
                        Main.XpActiveT2 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore T1";
                    }
                    break;
                case 10:
                    if (Main.XpActiveT2 == 1)
                    {
                        Main.BankXpTent -= priceXp;
                        Main.XpActiveT3 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore T2";
                    }
                    break;
                case 11:
                    if (Main.XpActiveT3 == 1)
                    {
                        Main.BankXpTent -= priceXp;
                        Main.XpActiveT4 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore T3";
                    }
                    break;
                case 12:
                    if (Main.XpActiveT4 == 1)
                    {
                        Main.BankXpTent -= priceXp;
                        Main.XpActiveT5 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore T4";
                    }
                    break;
                case 13:
                    if (Main.XpActiveT5 == 1)
                    {
                        Main.BankXpTent -= priceXp;
                        Main.XpActiveT6 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore T5";
                    }
                    break;
                case 14:
                    if (Main.XpActiveT6 == 1)
                    {
                        Main.BankXpTent -= priceXp;
                        Main.XpActiveT7 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore T6";
                    }
                    break;
                case 15:
                    if (Main.XpActiveT7 == 1)
                    {
                        Main.BankXpTent -= priceXp;
                        Main.XpActiveT8 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore T7";
                    }
                    break;
            }
        }        
        else if (pricepNumber >= 8 && pricepNumber <= 14 && Main.BankXpTent < priceXp)
        {
            somethingIsMissing.SetActive(true);
            SIMtx.text = "Not enough XP";
        }
        else if (pricepNumber >= 15 && pricepNumber <= 20 && Main.BankXpRef >= priceXp)
        {
            switch (pricepNumber)
            {
                case 15:
                    Main.BankXpRef -= priceXp;
                    Main.XpActiveR1 = 1;
                    break;
                case 16:
                    if (Main.XpActiveR1 == 1)
                    {
                        Main.BankXpRef -= priceXp;
                        Main.XpActiveR2 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore R1";
                    }
                    break;
                case 17:
                    if (Main.XpActiveR2 == 1)
                    {
                        Main.BankXpRef -= priceXp;
                        Main.XpActiveR3 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore R2";
                    }
                    break;
                case 18:
                    if (Main.XpActiveR3 == 1)
                    {
                        Main.BankXpRef -= priceXp;
                        Main.XpActiveR4 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore R3";
                    }
                    break;
                case 19:
                    if (Main.XpActiveR4 == 1)
                    {
                        Main.BankXpRef -= priceXp;
                        Main.XpActiveR5 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore R4";
                    }
                    break;
                case 20:
                    if (Main.XpActiveR5 == 1)
                    {
                        Main.BankXpRef -= priceXp;
                        Main.XpActiveR6 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore R5";
                    }
                    break;                
            }
        }
        else if (pricepNumber >= 15 && pricepNumber <= 20 && Main.BankXpRef < priceXp)
        {
            somethingIsMissing.SetActive(true);
            SIMtx.text = "Not enough XP";
        }
        else if (pricepNumber >= 21 && pricepNumber <= 25 && Main.BankXpCon >= priceXp)
        {
            switch (pricepNumber)
            {
                case 21:
                    Main.BankXpCon -= priceXp;
                    Main.XpActiveC1 = 1;
                    break;
                case 22:
                    if (Main.XpActiveC1 == 1)
                    {
                        Main.BankXpCon -= priceXp;
                        Main.XpActiveC2 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore C1";
                    }
                    break;
                case 23:
                    if (Main.XpActiveC2 == 1)
                    {
                        Main.BankXpCon -= priceXp;
                        Main.XpActiveC3 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore C2";
                    }
                    break;
                case 24:
                    if (Main.XpActiveC3 == 1)
                    {
                        Main.BankXpCon -= priceXp;
                        Main.XpActiveC4 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore C3";
                    }
                    break;
                case 25:
                    if (Main.XpActiveC4 == 1)
                    {
                        Main.BankXpCon -= priceXp;
                        Main.XpActiveC5 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore C4";
                    }
                    break;
            }
        }
        else if (pricepNumber >= 21 && pricepNumber <= 25 && Main.BankXpCon < priceXp)
        {
            somethingIsMissing.SetActive(true);
            SIMtx.text = "Not enough XP";
        }
    }

    public void BuyMoneyTrailer()
    {
        if (Main.Money >= priceMoney)
        {
            switch (pricepNumber)
            {
                case 1:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveB1 = 1;
                    break;
                case 2:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveB2 = 1;
                    break;
                case 3:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveB3 = 1;
                    break;
                case 4:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveB4 = 1;
                    break;
                case 5:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveB5 = 1;
                    break;
                case 6:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveB6 = 1;
                    break;
                case 7:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveB7 = 1;
                    break;
                case 8:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveT1 = 1;
                    break;
                case 9:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveT2 = 1;
                    break;
                case 10:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveT3 = 1;
                    break;
                case 11:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveT4 = 1;
                    break;
                case 12:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveT5 = 1;
                    break;
                case 13:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveT6 = 1;
                    break;
                case 14:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveT7 = 1;
                    break;
                case 15:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveR1 = 1;
                    break;
                case 16:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveR2 = 1;
                    break;
                case 17:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveR3 = 1;
                    break;
                case 18:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveR4 = 1;
                    break;
                case 19:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveR5 = 1;
                    break;
                case 20:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveR6 = 1;
                    break;
                case 21:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveC1 = 1;
                    break;
                case 22:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveC2 = 1;
                    break;
                case 23:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveC3 = 1;
                    break;
                case 24:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveC4 = 1;
                    break;
                case 25:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveC5 = 1;
                    break;
            }
        }
        else if (Main.Money < priceMoney)
        {
            somethingIsMissing.SetActive(true);
            SIMtx.text = "Not enough R";
        }        
    }
   
    public void SelectTrailer()
    {
        switch (pricepNumber)
        {
            case 0:
                Main.PrcNumber = 0;
                break;
            case 1:
                Main.PrcNumber = 1;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 2:
                Main.PrcNumber = 2;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 3:
                Main.PrcNumber = 3;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 4:
                Main.PrcNumber = 4;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 5:
                Main.PrcNumber = 5;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 6:
                Main.PrcNumber = 6;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 7:
                Main.PrcNumber = 7;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 8:
                Main.PrcNumber = 8;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 9:
                Main.PrcNumber = 9;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 10:
                Main.PrcNumber = 10;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 11:
                Main.PrcNumber = 11;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 12:
                Main.PrcNumber = 12;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 13:
                Main.PrcNumber = 13;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 14:
                Main.PrcNumber = 14;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 15:
                Main.PrcNumber = 15;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 16:
                Main.PrcNumber = 16;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 17:
                Main.PrcNumber = 17;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 18:
                Main.PrcNumber = 18;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 19:
                Main.PrcNumber = 19;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 20:
                Main.PrcNumber = 20;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 21:
                Main.PrcNumber = 21;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 22:
                Main.PrcNumber = 22;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 23:
                Main.PrcNumber = 23;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 24:
                Main.PrcNumber = 24;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
            case 25:
                Main.PrcNumber = 25;
                CloseAllPanel();
                ClosePnlTrailer();
                break;
        }
    }
    
    void Update()
    {       
        switch (pricepNumber)
        {
            case 0:
                CloseAllTrailer();
                nullObjTrailer.SetActive(true);
                prefTrailerClone = nullObjTrailer;
                break;
            case 1:
                CloseAllTrailer();
                B1.SetActive(true);
                nameTx.text = "B1";
                prefTrailerClone = B1;
                cargoWeight = prefTrailerClone.GetComponent<TrailerChar>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerChar>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerChar>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveB1 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveB1 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;

            case 2:
                CloseAllTrailer();
                B2.SetActive(true);
                nameTx.text = "B2";
                prefTrailerClone = B2;
                cargoWeight = prefTrailerClone.GetComponent<TrailerChar>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerChar>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerChar>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveB2 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveB2 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 3:
                CloseAllTrailer();
                B3.SetActive(true);
                nameTx.text = "B3";
                prefTrailerClone = B3;
                cargoWeight = prefTrailerClone.GetComponent<TrailerChar>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerChar>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerChar>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveB3 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveB3 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 4:
                CloseAllTrailer();
                B4.SetActive(true);
                nameTx.text = "B4";
                prefTrailerClone = B4;
                cargoWeight = prefTrailerClone.GetComponent<TrailerChar>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerChar>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerChar>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveB4 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveB4 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 5:
                CloseAllTrailer();
                B5.SetActive(true);
                nameTx.text = "B5";
                prefTrailerClone = B5;
                cargoWeight = prefTrailerClone.GetComponent<TrailerChar>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerChar>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerChar>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveB5 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveB5 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 6:
                CloseAllTrailer();
                B6.SetActive(true);
                nameTx.text = "B6";
                prefTrailerClone = B6;
                cargoWeight = prefTrailerClone.GetComponent<TrailerChar>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerChar>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerChar>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveB6 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveB6 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 7:
                CloseAllTrailer();
                B7.SetActive(true);
                nameTx.text = "B7";
                prefTrailerClone = B7;
                cargoWeight = prefTrailerClone.GetComponent<TrailerChar>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerChar>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerChar>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveB7 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveB7 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 8:
                CloseAllTrailer();
                T1.SetActive(true);
                nameTx.text = "T1";
                prefTrailerClone = T1;
                cargoWeight = prefTrailerClone.GetComponent<TrailerCharTent>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerCharTent>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerCharTent>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveT1 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerCharTent>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveT1 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 9:
                CloseAllTrailer();
                T2.SetActive(true);
                nameTx.text = "T2";
                prefTrailerClone = T2;
                cargoWeight = prefTrailerClone.GetComponent<TrailerCharTent>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerCharTent>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerCharTent>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveT2 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerCharTent>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveT2 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 10:
                CloseAllTrailer();
                T3.SetActive(true);
                nameTx.text = "T3";
                prefTrailerClone = T3;
                cargoWeight = prefTrailerClone.GetComponent<TrailerCharTent>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerCharTent>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerCharTent>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveT3 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerCharTent>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveT3 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 11:
                CloseAllTrailer();
                T4.SetActive(true);
                nameTx.text = "T4";
                prefTrailerClone = T4;
                cargoWeight = prefTrailerClone.GetComponent<TrailerCharTent>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerCharTent>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerCharTent>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveT4 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerCharTent>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveT4 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 12:
                CloseAllTrailer();
                T5.SetActive(true);
                nameTx.text = "T5";
                prefTrailerClone = T5;
                cargoWeight = prefTrailerClone.GetComponent<TrailerCharTent>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerCharTent>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerCharTent>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveT5 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerCharTent>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveT5 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 13:
                CloseAllTrailer();
                T6.SetActive(true);
                nameTx.text = "T6";
                prefTrailerClone = T6;
                cargoWeight = prefTrailerClone.GetComponent<TrailerCharTent>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerCharTent>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerCharTent>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveT6 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerCharTent>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveT6 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 14:
                CloseAllTrailer();
                T7.SetActive(true);
                nameTx.text = "T7";
                prefTrailerClone = T7;
                cargoWeight = prefTrailerClone.GetComponent<TrailerCharTent>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerCharTent>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerCharTent>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveT7 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerCharTent>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveT7 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 15:
                CloseAllTrailer();
                R1.SetActive(true);
                nameTx.text = "R1";
                prefTrailerClone = R1;
                cargoWeight = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveR1 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveR1 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 16:
                CloseAllTrailer();
                R2.SetActive(true);
                nameTx.text = "R2";
                prefTrailerClone = R2;
                cargoWeight = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveR2 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveR2 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 17:
                CloseAllTrailer();
                R3.SetActive(true);
                nameTx.text = "R3";
                prefTrailerClone = R3;
                cargoWeight = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveR3 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveR3 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 18:
                CloseAllTrailer();
                R4.SetActive(true);
                nameTx.text = "R4";
                prefTrailerClone = R4;
                cargoWeight = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveR4 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveR4 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 19:
                CloseAllTrailer();
                R5.SetActive(true);
                nameTx.text = "R5";
                prefTrailerClone = R5;
                cargoWeight = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveR5 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveR5 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 20:
                CloseAllTrailer();
                R6.SetActive(true);
                nameTx.text = "R6";
                prefTrailerClone = R6;
                cargoWeight = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveR6 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerCharRefrigerator>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveR6 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 21:
                CloseAllTrailer();
                C1.SetActive(true);
                nameTx.text = "C1";
                prefTrailerClone = C1;
                cargoWeight = prefTrailerClone.GetComponent<TrailerCharCont>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerCharCont>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerCharCont>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveC1 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerCharCont>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveC1 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 22:
                CloseAllTrailer();
                C2.SetActive(true);
                nameTx.text = "C2";
                prefTrailerClone = C2;
                cargoWeight = prefTrailerClone.GetComponent<TrailerCharCont>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerCharCont>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerCharCont>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveC2 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerCharCont>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveC2 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 23:
                CloseAllTrailer();
                C3.SetActive(true);
                nameTx.text = "C3";
                prefTrailerClone = C3;
                cargoWeight = prefTrailerClone.GetComponent<TrailerCharCont>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerCharCont>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerCharCont>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveC3 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerCharCont>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveC3 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 24:
                CloseAllTrailer();
                C4.SetActive(true);
                nameTx.text = "C4";
                prefTrailerClone = C4;
                cargoWeight = prefTrailerClone.GetComponent<TrailerCharCont>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerCharCont>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerCharCont>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveC4 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerCharCont>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveC4 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 25:
                CloseAllTrailer();
                C5.SetActive(true);
                nameTx.text = "C5";
                prefTrailerClone = C5;
                cargoWeight = prefTrailerClone.GetComponent<TrailerCharCont>().cargoWeight;
                trailerWeight = prefTrailerClone.GetComponent<TrailerCharCont>().trailerWeight;
                priceXp = prefTrailerClone.GetComponent<TrailerCharCont>().priceXp;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveC5 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }

                priceMoney = prefTrailerClone.GetComponent<TrailerCharCont>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveC5 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
        }
        allowableWeightTruck = Camera.GetComponent<Movecar>().allowableWeight;
        cargoWeightTx.text = cargoWeight.ToString("") + " kg";
        trailerWeightTx.text = trailerWeight.ToString("") + " kg";
        allowableWeight = cargoWeight + trailerWeight;
        if(allowableWeight > allowableWeightTruck)
        {
            allowableWeightTx.color = Color.red;
            allowableWeightTx.text = allowableWeight.ToString("") + " kg";
        }
        else if(allowableWeight <= allowableWeightTruck)
        {
            allowableWeightTx.color = Color.green;
            allowableWeightTx.text = allowableWeight.ToString("") + " kg";
        }        
    }
}
