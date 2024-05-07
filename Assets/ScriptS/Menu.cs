using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject mainCamera;
    [Header("Нижняя панель и кнопки")]
    public GameObject pnlDw;
    public GameObject pnlTruck;
    public GameObject pnlTrailer;
    public GameObject btnTrailer;
    public GameObject btnUpgrade;
    public GameObject pnlUpgrade;
    public GameObject MenuUpgrade;
    public GameObject btnAzs;
    public GameObject btnSpecCargo;
    public GameObject pnlUpravlenie;
    public GameObject pnlFinish;
    public GameObject ExitPanel;
    [Header("Деньги, Доллары, Опыт")]
    private int MoneyInt;
    public Text MoneyTx;
    private int DollarsInt;
    public Text DollarsTx;
    private int XpFreeInt;
    public Text XpFreeTx;
    public GameObject Load;
    [Header("XP панели текста")]
    public GameObject pnlIn_app_purchases;
    public GameObject translationMoney;
    public GameObject translationXp;
    public GameObject xpBison;
    public GameObject backPnlOn;
    public float XpBisonFt;
    public Text TxXpBison;
    public GameObject xpDUB;
    public float XpDUBFt;
    public Text TxXpDUB;
    public GameObject xpFIIV;
    public float XpFIIVFt;
    public Text TxXpFIIV;
    public GameObject xpHORSE;
    public float XpHORSEFt;
    public Text TxXpHORSE;
    public GameObject xpRIDGE;
    public float XpRIDGEFt;
    public Text TxXpRIDGE;
    public GameObject xpBoard;
    public float XpBoardFt;
    public Text TxXpBoard;
    public GameObject xpTent;
    public float XpTentFt;
    public Text TxXpTent;
    public GameObject xpRef;
    public float XpRefFt;
    public Text TxXpRef;
    public GameObject xpCon;
    public float XpConFt;
    public Text TxXpCon;
    public GameObject ConnectionPnl;
    public GameObject ConnectionOn;
    [Header("Prize")]
    public float prizeRuly;
    public int prizeDollars;
    public float prizeXpFree;
    public float prizeXpCar;
    public float prizeXpTrailer;
    [Header("CARGO OFF")]
    public GameObject pnlCargoOff;
    public GameObject btnCargoOff;


    private void Start()
    {        
        XpTruck();
        XpTrailer();
        Main.MuteAudio = 0;
        MoneyInt = Main.Money;
        DollarsInt = Main.Dollars;
        XpFreeInt = (int)Main.BankXpFree;        
    }  

    public void OpenCargoOff()
    {
        pnlCargoOff.SetActive(true);
    }
    public void CloseCargoOff()
    {
        pnlCargoOff.SetActive(false);
    }
    public void CargoOff()
    {
        Main.CargoCondition = 0;
        Main.DokiOk = 0;
        Main.FinishLoca = 0;
        CloseCargoOff();
    }    

    public void BackPnlOn()
    {
        backPnlOn.SetActive(true);
    }
    public void BackPnlOff()
    {
        backPnlOn.SetActive(false);
    }
    public void ConnectionPnlOpen()
    {
        ConnectionPnl.SetActive(true);
        ConnectionOn.SetActive(true);
    }
    public void ConnectionPnlClose()
    {
        ConnectionPnl.SetActive(false);
        ConnectionOn.SetActive(false);
    }
    public void CloseExitPnl()
    {
        ExitPanel.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void PnlIn_app_purchasesOpen()
    {
        pnlIn_app_purchases.SetActive(true);
    }
    public void PnlIn_app_purchasesClose()
    {
        pnlIn_app_purchases.SetActive(false);
    }
    public void TranslationMoneyOpen()
    {
        translationMoney.SetActive(true);
    }
    public void TranslationMoneyClose()
    {
        translationMoney.SetActive(false);
    }
    public void TranslationXpOpen()
    {
        translationXp.SetActive(true);
    }
    public void TranslationXpClose()
    {
        translationXp.SetActive(false);
    }
    public void XpBison()
    {
        xpBison.SetActive(true);
        xpDUB.SetActive(false);
        xpFIIV.SetActive(false);
        xpHORSE.SetActive(false);
        xpRIDGE.SetActive(false);
    }
    public void XpDUB()
    {
        xpBison.SetActive(false);
        xpDUB.SetActive(true);
        xpFIIV.SetActive(false);
        xpHORSE.SetActive(false);
        xpRIDGE.SetActive(false);
    }
    public void XpFIIV()
    {
        xpBison.SetActive(false);
        xpDUB.SetActive(false);
        xpFIIV.SetActive(true);
        xpHORSE.SetActive(false);
        xpRIDGE.SetActive(false);
    }
    public void XpHORSE()
    {
        xpBison.SetActive(false);
        xpDUB.SetActive(false);
        xpFIIV.SetActive(false);
        xpHORSE.SetActive(true);
        xpRIDGE.SetActive(false);
    }
    public void XpRIDGE()
    {
        xpBison.SetActive(false);
        xpDUB.SetActive(false);
        xpFIIV.SetActive(false);
        xpHORSE.SetActive(false);
        xpRIDGE.SetActive(true);
    }
    public void XpPREMIUM()
    {
        xpBison.SetActive(false);
        xpDUB.SetActive(false);
        xpFIIV.SetActive(false);
        xpHORSE.SetActive(false);
    }
    public void XpBoard()
    {
        xpBoard.SetActive(true);
        xpTent.SetActive(false);
        xpRef.SetActive(false);
        xpCon.SetActive(false);
    }
    public void XpTent()
    {
        xpBoard.SetActive(false);
        xpTent.SetActive(true);
        xpRef.SetActive(false);
        xpCon.SetActive(false);
    }
    public void XpRef()
    {
        xpBoard.SetActive(false);
        xpTent.SetActive(false);
        xpRef.SetActive(true);
        xpCon.SetActive(false);
    }
    public void XpCon()
    {
        xpBoard.SetActive(false);
        xpTent.SetActive(false);
        xpRef.SetActive(false);
        xpCon.SetActive(true);
    }
    public void XpTruck()
    {
        if (Main.CarNumber >= 1 && Main.CarNumber <= 7)
        {
            XpBison();
        }
        else if (Main.CarNumber >= 8 && Main.CarNumber <= 13)
        {
            XpDUB();
        }
        else if (Main.CarNumber >= 14 && Main.CarNumber <= 21)
        {
            XpFIIV();
        }
        else if (Main.CarNumber >= 22 && Main.CarNumber <= 26)
        {
            XpHORSE();
        }
        else if (Main.CarNumber >= 27 && Main.CarNumber <= 30)
        {
            XpRIDGE();
        }
        else if (Main.CarNumber >= 101 && Main.CarNumber <= 102)
        {
            XpPREMIUM();
        }
    }
    
    public void XpTrailer()
    {
        if(Main.PrcNumber >= 1 && Main.PrcNumber <= 7)
        {
            XpBoard();
        }
        else if (Main.PrcNumber >= 8 && Main.PrcNumber <= 14)
        {
            XpTent();
        }
        else if (Main.PrcNumber >= 15 && Main.PrcNumber <= 20)
        {
            XpRef();
        }
        else if (Main.PrcNumber >= 21 && Main.PrcNumber <= 25)
        {
            XpCon();
        }
    }
    public void openPnlTruck()
    {
        mainCamera.GetComponent<Movecar>().TruckCam();
        pnlTruck.SetActive(true);
        Main.Engine = 1;
        Main.Gearbox = 1;
        Main.Brake = 1;
        Main.FuelTank = 1;
        Main.RearBogie = 1;
        Main.ExternalTuning = 1;
    }
    public void openPnlTrailer()
    {
        mainCamera.GetComponent<Movecar>().TrailerCam();
        pnlTrailer.SetActive(true);        
    }
    public void openPnlUpgrade()
    {
        pnlTruck.SetActive(true);
        pnlUpgrade.SetActive(true);
        MenuUpgrade.SetActive(true);
    }
    public void closePnlUpgrade()
    {
        pnlTruck.SetActive(false);
        pnlUpgrade.SetActive(false);
        MenuUpgrade.SetActive(false);
    }    

    
    public void SmenaSceni()
    {
        Main.Money += (int)prizeRuly;    
        Main.BankXpFree += prizeXpFree;        
        
        if (Main.CarNumber >= 1 && Main.CarNumber <= 7)
            Main.BankXpBison += prizeXpCar;
        if (Main.CarNumber >= 8 && Main.CarNumber <= 13)
            Main.BankXpDUB += prizeXpCar;
        if (Main.CarNumber >= 14 && Main.CarNumber <= 21)
            Main.BankXpFIIV += prizeXpCar;
        if (Main.CarNumber >= 22 && Main.CarNumber <= 26)
            Main.BankXpHORSE += prizeXpCar;
        if (Main.CarNumber >= 27 && Main.CarNumber <= 30)
            Main.BankXpRIDGE += prizeXpCar;
        if (Main.PrcNumber >= 1 && Main.PrcNumber <= 7)
            Main.BankXpBoard += prizeXpTrailer;
        if (Main.PrcNumber >= 8 && Main.PrcNumber <= 14)
            Main.BankXpTent += prizeXpTrailer;
        if (Main.PrcNumber >= 15 && Main.PrcNumber <= 20)
            Main.BankXpRef += prizeXpTrailer;
        if (Main.PrcNumber >= 21 && Main.PrcNumber <= 25)
            Main.BankXpCon += prizeXpTrailer;
        if (Main.PrcNumber >= 100 && Main.PrcNumber <= 102)
            Main.Dollars += prizeDollars;

        //if (Main.Hitchhiker == 1)
        //{
        //    Main.Money += Main.PrizeHitchhikerR;
        //    Main.BankXpFree += Main.PrizeHitchhikerX;
        //    Main.Dollars += Main.PrizeHitchhikerD;
        //}
        //else
        //{
        //    Main.PrizeHitchhikerR = 0;
        //    Main.PrizeHitchhikerX = 0;
        //    Main.PrizeHitchhikerD = 0;
        //}
        
        Main.Hitchhiker = 0;
        Main.CargoCondition = 0;
        Main.CargoWeight = 0;
        Main.FinishLoca = 0;
        Main.DokiOk = 0;

        if (Main.SpecCargo == 1)
        {
            Main.SpecCargo = 0;
            Main.PrcNumber = 0;
        }  
        
        pnlFinish.SetActive(false);
    }
   
    private void Update()
    {
        if(Main.cargo_condition > 0 || Main.SpecCargo > 0)
        {
            btnCargoOff.SetActive(true);
        }
        else
        {
            btnCargoOff.SetActive(false);
        }

        XpBisonFt = Main.BankXpBison;
        TxXpBison.text = XpBisonFt.ToString("0" + " XP");

        XpDUBFt = Main.BankXpDUB;
        TxXpDUB.text = XpDUBFt.ToString("0" + " XP");

        XpFIIVFt = Main.BankXpFIIV;
        TxXpFIIV.text = XpFIIVFt.ToString("0" + " XP");

        XpHORSEFt = Main.BankXpHORSE;
        TxXpHORSE.text = XpHORSEFt.ToString("0" + " XP");

        XpRIDGEFt = Main.BankXpRIDGE;
        TxXpRIDGE.text = XpRIDGEFt.ToString("0" + " XP");

        XpBoardFt = Main.BankXpBoard;
        TxXpBoard.text = XpBoardFt.ToString("0" + " XP");

        XpTentFt = Main.BankXpTent;        
        TxXpTent.text = XpTentFt.ToString("0" + " XP");

        XpRefFt = Main.BankXpRef;
        TxXpRef.text = XpRefFt.ToString("0" + " XP");

        XpConFt = Main.BankXpCon;
        TxXpCon.text = XpConFt.ToString("0" + " XP");     

        XpFreeInt = (int)Main.BankXpFree;
        MoneyInt = Main.Money;
        MoneyTx.text = " R " + MoneyInt;
        XpFreeTx.text = "XP " + XpFreeInt;
        DollarsInt = Main.Dollars;
        DollarsTx.text = " $ " + DollarsInt;
        prizeRuly = Main.PrizeRuly;
        prizeDollars = Main.PrizeDollars;
        prizeXpFree = Main.PrizeXpFree;
        prizeXpCar = Main.PrizeXpCar;
        prizeXpTrailer = Main.PrizeXpTrailer;

        if (Input.GetKeyUp(KeyCode.Escape)) { ExitPanel.SetActive(true); }
    }
}
