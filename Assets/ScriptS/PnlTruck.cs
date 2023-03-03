using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PnlTruck : MonoBehaviour
{
    [Header("Панели гузовиков")]
    public GameObject pnlTruck;
    public GameObject pnlBison;
    public GameObject pnlDUB;
    public GameObject pnlFIIV;
    public GameObject pnlHORSE;
    public GameObject pnlRIDGE;
    [Header("Панель прицепов")]
    public GameObject Trailer;    
    [Header("Номер грузовика")]
    public int carNumber;
    GameObject prefTruckClone;
    public Text nameTx;
    public GameObject infoPnl;
    [Header("Кнопки и тексты XP, Money, Select")]
    public GameObject pnlBtnXpMonSel;
    public GameObject btnXpActive;
    public int priceXp;
    public Text priceXpTx;
    public GameObject btnMoneyActive;
    public int priceMoney;
    public int priceDollars;
    public Text priceMoneyTx;
    public GameObject btnSelect;
    [Header("Кнопки и тексты Dollars, Select PREMIUM TRUCK")]
    //public GameObject hiddenButton;
    //public int hiddenPoint = 0;
    public GameObject pnlPREMIUM;
    public GameObject btnSelectPremTruck;
    public GameObject btnDollarsActive;
    public Text priceDollarsTx;
    public GameObject btnDollarBuy;
    [Header("Bison")]
    public GameObject nullObj;
    public GameObject Bison200;
    public GameObject Bison500;
    public GameObject Bison5432;
    public GameObject Bison6422;
    public GameObject Bison6430;
    public GameObject Bison6440;
    public GameObject Bison5440;
    [Header("DUB")]
    public GameObject DUB157;
    public GameObject DUB131;
    public GameObject DUB130;
    public GameObject DUB133;
    public GameObject DUB4421;
    public GameObject DUB5423;
    [Header("FIIV")]
    public GameObject FIIV690;
    public GameObject FIIV619;
    public GameObject FIIVTS;
    public GameObject FIIVES;
    public GameObject FIIVST;
    public GameObject FIIVSTR;
    public GameObject FIIVHW;
    public GameObject FIIVSW;
    [Header("HORSE")]
    public GameObject HORSE5410;
    public GameObject HORSE6460;
    public GameObject HORSE5460;
    public GameObject HORSE1840;
    public GameObject HORSE1855;
    [Header("RIDGE")]
    public GameObject RIDGE375;
    public GameObject RIDGE4420;
    public GameObject RIDGE6370;
    public GameObject RIDGENX;
    [Header("PREMIUM")]
    [Header("FORB")]
    public GameObject FORBCARGO;
    public GameObject FORBFMAX;
    [Header("Панели предупреждений")]
    public GameObject somethingIsMissing;
    public Text SIMtx;
        
    public AudioSource[] carSound;
    [Header("Характеристики грузовика")]
    public float horse;
    public float maxSpeed;
    public float fuelConsumption;
    public float fuelMax;
    public float allowableWeight;
    public Text horseTx;
    public Text maxSpeedTx;
    public Text fuelConsumptionTx;
    public Text fuelMaxTx;
    public Text allowableWeightTx;
    [Header("Upgrade Engine")]
    public int priceEngine;
    public int saveEngine;
    [Header("Upgrade Gearbox")]    
    public GameObject trustLevel1;
    public GameObject trustLevel2;
    public GameObject trustLevel3;
    public GameObject trustLevel4;
    public GameObject trustLevel5;
    public GameObject speedLevel1;
    public GameObject speedLevel2;
    public GameObject speedLevel3;
    public GameObject speedLevel4;
    public GameObject speedLevel5;
    public int priceGearbox;
    public int saveGearbox;
    public int charGearBoxSpeed;
    public int charMaxTrust;
    [Header("Upgrade Brake")]
    public GameObject brakeLevel1;
    public GameObject brakeLevel2;
    public GameObject brakeLevel3;
    public GameObject brakeLevel4;
    public GameObject brakeLevel5;
    public int priceBrake;
    public int saveBrake;
    public int charBrake;
    [Header("FuelTank")]
    public int priceFuelTank;
    public int saveFuelTank;
    [Header("RearBogie")]
    public int priceRearBogie;
    public int saveRearBogie;
    [Header("ExternalTuning")]
    public int priceExternalTuning;
    public int saveExternalTuning;
    public float coefPrizeXpFree;
    public Text coefPrizeXpFreeTx;

    private void Start()
    {
        carNumber = Main.CarNumber;
    }
    //public void PointPlus()
    //{
    //    hiddenPoint++;
    //}

    public void TrailerOff()
    {
        Trailer.SetActive(false);
    }
    public void TrailerOn()
    {
        Trailer.SetActive(true);
    }
    public void OpenPnlBison()
    {
        Trailer.SetActive(false);
        pnlBtnXpMonSel.SetActive(true);
        pnlBison.SetActive(true);
        btnSelect.SetActive(true);
        infoPnl.SetActive(true);
        carNumber = 1;
    }
    public void NextBison()
    {
        if (carNumber < 7)
            carNumber++;
    }

    public void BackBison()
    {
        if (carNumber > 1)
            carNumber--;
    }
    public void OpenPnlDUB()
    {
        Trailer.SetActive(false);
        pnlBtnXpMonSel.SetActive(true);
        pnlDUB.SetActive(true);
        btnSelect.SetActive(true);
        infoPnl.SetActive(true);
        carNumber = 8;
    }
    public void NextDUB()
    {
        if (carNumber < 13)
            carNumber++;
    }

    public void BackDUB()
    {
        if (carNumber > 8)
            carNumber--;
    }

    public void OpenPnlFIIV()
    {
        Trailer.SetActive(false);
        pnlBtnXpMonSel.SetActive(true);
        pnlFIIV.SetActive(true);
        btnSelect.SetActive(true);
        infoPnl.SetActive(true);
        carNumber = 14;
    }
    public void NextFIIV()
    {
        if (carNumber < 21)
            carNumber++;
    }

    public void BackFIIV()
    {
        if (carNumber > 14)
            carNumber--;
    }
    public void OpenPnlHORSE()
    {
        Trailer.SetActive(false);
        pnlBtnXpMonSel.SetActive(true);
        pnlHORSE.SetActive(true);
        btnSelect.SetActive(true);
        infoPnl.SetActive(true);
        carNumber = 22;
    }
    public void NextHORSE()
    {
        if (carNumber < 26)
            carNumber++;
    }

    public void BackHORSE()
    {
        if (carNumber > 22)
            carNumber--;
    }
    public void OpenPnlRIDGE()
    {
        Trailer.SetActive(false);
        pnlBtnXpMonSel.SetActive(true);
        pnlRIDGE.SetActive(true);
        btnSelect.SetActive(true);
        infoPnl.SetActive(true);
        carNumber = 27;
    }
    public void NextRIDGE()
    {
        if (carNumber < 30)
            carNumber++;
    }

    public void BackRIDGE()
    {
        if (carNumber > 27)
            carNumber--;
    }
    public void OpenPnlPREMIUM()
    {
        Trailer.SetActive(false);
        btnDollarBuy.SetActive(true);
        pnlPREMIUM.SetActive(true);
        btnSelectPremTruck.SetActive(true);
        infoPnl.SetActive(true);
        carNumber = 101;
    }
    public void NextPREMIUM()
    {
        if (carNumber < 102)
            carNumber++;
    }

    public void BackPREMIUM()
    {
        if (carNumber > 101)
            carNumber--;
    }

    public void SelectGearBoxSpeedOk()
    {
        switch (charGearBoxSpeed)
        {
            case 1:
                speedLevel1.SetActive(true);
                speedLevel2.SetActive(false);
                speedLevel3.SetActive(false);
                speedLevel4.SetActive(false);
                speedLevel5.SetActive(false);
                break;
            case 2:
                speedLevel1.SetActive(false);
                speedLevel2.SetActive(true);
                speedLevel3.SetActive(false);
                speedLevel4.SetActive(false);
                speedLevel5.SetActive(false);
                break;
            case 3:
                speedLevel1.SetActive(false);
                speedLevel2.SetActive(false);
                speedLevel3.SetActive(true);
                speedLevel4.SetActive(false);
                speedLevel5.SetActive(false);
                break;
            case 4:
                speedLevel1.SetActive(false);
                speedLevel2.SetActive(false);
                speedLevel3.SetActive(false);
                speedLevel4.SetActive(true);
                speedLevel5.SetActive(false);
                break;
            case 5:
                speedLevel1.SetActive(false);
                speedLevel2.SetActive(false);
                speedLevel3.SetActive(false);
                speedLevel4.SetActive(false);
                speedLevel5.SetActive(true);
                break;
        }
    }
    public void SelectMaxTrust()
    {
        switch (charMaxTrust)
        {
            case 1:
                trustLevel1.SetActive(true);
                trustLevel2.SetActive(false);
                trustLevel3.SetActive(false);
                trustLevel4.SetActive(false);
                trustLevel5.SetActive(false);
                break;
            case 2:
                trustLevel1.SetActive(false);
                trustLevel2.SetActive(true);
                trustLevel3.SetActive(false);
                trustLevel4.SetActive(false);
                trustLevel5.SetActive(false);
                break;
            case 3:
                trustLevel1.SetActive(false);
                trustLevel2.SetActive(false);
                trustLevel3.SetActive(true);
                trustLevel4.SetActive(false);
                trustLevel5.SetActive(false);
                break;
            case 4:
                trustLevel1.SetActive(false);
                trustLevel2.SetActive(false);
                trustLevel3.SetActive(false);
                trustLevel4.SetActive(true);
                trustLevel5.SetActive(false);
                break;
            case 5:
                trustLevel1.SetActive(false);
                trustLevel2.SetActive(false);
                trustLevel3.SetActive(false);
                trustLevel4.SetActive(false);
                trustLevel5.SetActive(true);
                break;
        }
    }

    public void SelectBrakeOk()
    {
        switch (charBrake)
        {
            case 1:
                brakeLevel1.SetActive(true);
                brakeLevel2.SetActive(false);
                brakeLevel3.SetActive(false);
                brakeLevel4.SetActive(false);
                brakeLevel5.SetActive(false);
                break;
            case 2:
                brakeLevel1.SetActive(false);
                brakeLevel2.SetActive(true);
                brakeLevel3.SetActive(false);
                brakeLevel4.SetActive(false);
                brakeLevel5.SetActive(false);
                break;
            case 3:
                brakeLevel1.SetActive(false);
                brakeLevel2.SetActive(false);
                brakeLevel3.SetActive(true);
                brakeLevel4.SetActive(false);
                brakeLevel5.SetActive(false);
                break;
            case 4:
                brakeLevel1.SetActive(false);
                brakeLevel2.SetActive(false);
                brakeLevel3.SetActive(false);
                brakeLevel4.SetActive(true);
                brakeLevel5.SetActive(false);
                break;
            case 5:
                brakeLevel1.SetActive(false);
                brakeLevel2.SetActive(false);
                brakeLevel3.SetActive(false);
                brakeLevel4.SetActive(false);
                brakeLevel5.SetActive(true);
                break;
        }
    }
    public void CloseAllPanel()
    {        
        carNumber = Main.CarNumber;
        pnlBison.SetActive(false);
        pnlDUB.SetActive(false);
        pnlFIIV.SetActive(false);
        pnlHORSE.SetActive(false);
        pnlRIDGE.SetActive(false);
        pnlPREMIUM.SetActive(false);
        btnDollarBuy.SetActive(false);
        btnSelect.SetActive(false);
        btnMoneyActive.SetActive(false);
        btnXpActive.SetActive(false);
        pnlBtnXpMonSel.SetActive(false);
        Trailer.SetActive(false);
        infoPnl.SetActive(false);
    }
    //nullObj.SetActive(false);
    //Bison200.SetActive(false);
    //Bison500.SetActive(false);
    //Bison5432.SetActive(false);
    //Bison6422.SetActive(false);
    //Bison6430.SetActive(false);
    //Bison6440.SetActive(false);
    //Bison5440.SetActive(false);
    //DUB157.SetActive(false);
    //DUB131.SetActive(false);
    //DUB130.SetActive(false);
    //DUB133.SetActive(false);
    //DUB4421.SetActive(false);
    //DUB5423.SetActive(false);
    //FIIV690.SetActive(false);
    //FIIV619.SetActive(false);
    //FIIVTS.SetActive(false);
    //FIIVES.SetActive(false);
    //FIIVST.SetActive(false);
    //FIIVSTR.SetActive(false);
    //FIIVHW.SetActive(false);
    //FIIVSW.SetActive(false);
    //HORSE5410.SetActive(false);
    //HORSE6460.SetActive(false);
    //HORSE5460.SetActive(false);
    //HORSE1840.SetActive(false);
    //HORSE1855.SetActive(false);
    //RIDGE375.SetActive(false);
    //RIDGE4420.SetActive(false);
    //RIDGE6370.SetActive(false);
    //RIDGENX.SetActive(false);
    //FORBCARGO.SetActive(false);
    //FORBFMAX.SetActive(false);

    public void CloseAllTruck()
    {
        switch (carNumber)
        {
            case 0:
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 1:
                nullObj.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 2:
                nullObj.SetActive(false);
                Bison200.SetActive(false);                
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 3:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 4:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 5:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 6:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 7:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 8:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 9:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);                
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 10:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 11:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 12:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 13:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 14:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 15:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 16:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 17:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 18:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 19:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 20:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 21:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 22:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 23:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 24:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 25:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 26:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 27:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 28:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 29:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGENX.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 30:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                HORSE1855.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                FORBCARGO.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 101:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                HORSE1855.SetActive(false);
                FORBFMAX.SetActive(false);
                break;
            case 102:
                nullObj.SetActive(false);
                Bison200.SetActive(false);
                Bison500.SetActive(false);
                Bison5432.SetActive(false);
                Bison6422.SetActive(false);
                Bison6430.SetActive(false);
                Bison6440.SetActive(false);
                Bison5440.SetActive(false);
                DUB157.SetActive(false);
                DUB131.SetActive(false);
                DUB130.SetActive(false);
                DUB133.SetActive(false);
                DUB4421.SetActive(false);
                DUB5423.SetActive(false);
                FIIV690.SetActive(false);
                FIIV619.SetActive(false);
                FIIVTS.SetActive(false);
                FIIVES.SetActive(false);
                FIIVST.SetActive(false);
                FIIVSTR.SetActive(false);
                FIIVHW.SetActive(false);
                FIIVSW.SetActive(false);
                HORSE5410.SetActive(false);
                HORSE6460.SetActive(false);
                HORSE5460.SetActive(false);
                HORSE1840.SetActive(false);
                RIDGE375.SetActive(false);
                RIDGE4420.SetActive(false);
                RIDGE6370.SetActive(false);
                RIDGENX.SetActive(false);
                HORSE1855.SetActive(false);
                FORBCARGO.SetActive(false);
                break;
        }
    }

    public void ClosePnlTruck()
    {
        pnlTruck.SetActive(false);
        btnSelect.SetActive(false);
        pnlBtnXpMonSel.SetActive(false);
        btnDollarBuy.SetActive(false);
    }

    public void CloseSIM()
    {
        somethingIsMissing.SetActive(false);
    }

    public void BuyXpTruck()
    {
        if (carNumber >= 1 && carNumber <= 7 && Main.BankXpBison >= priceXp)
        {
            switch (carNumber)
            {
                case 1:
                    Main.BankXpBison -= priceXp;
                    Main.XpActiveBison200 = 1;
                    break;
                case 2:
                    if (Main.XpActiveBison200 == 1)
                    {
                        Main.BankXpBison -= priceXp;
                        Main.XpActiveBison500 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore Bison200";
                    }
                    break;
                case 3:
                    if (Main.XpActiveBison500 == 1)
                    {
                        Main.BankXpBison -= priceXp;
                        Main.XpActiveBison5432 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore Bison500";
                    }
                    break;
                case 4:
                    if (Main.XpActiveBison5432 == 1)
                    {
                        Main.BankXpBison -= priceXp;
                        Main.XpActiveBison6422 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore Bison5432";
                    }
                    break;
                case 5:
                    if (Main.XpActiveBison6422 == 1)
                    {
                        Main.BankXpBison -= priceXp;
                        Main.XpActiveBison6430 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore Bison6422";
                    }
                    break;
                case 6:
                    if (Main.XpActiveBison6430 == 1)
                    {
                        Main.BankXpBison -= priceXp;
                        Main.XpActiveBison6440 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore Bison6430";
                    }
                    break;
                case 7:
                    if (Main.XpActiveBison6440 == 1)
                    {
                        Main.BankXpBison -= priceXp;
                        Main.XpActiveBison5440 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore Bison6440";
                    }
                    break;                
            }            
        }
        if (carNumber >= 8 && carNumber <= 13 && Main.BankXpDUB >= priceXp)
        {
            switch (carNumber)
            {
                case 8:
                    Main.BankXpDUB -= priceXp;
                    Main.XpActiveDUB157 = 1;
                    break;
                case 9:
                    if (Main.XpActiveDUB157 == 1)
                    {
                        Main.BankXpDUB -= priceXp;
                        Main.XpActiveDUB131 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore DUB157";
                    }
                    break;
                case 10:
                    if (Main.XpActiveDUB131 == 1)
                    {
                        Main.BankXpDUB -= priceXp;
                        Main.XpActiveDUB130 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore DUB131";
                    }
                    break;
                case 11:
                    if (Main.XpActiveDUB130 == 1)
                    {
                        Main.BankXpDUB -= priceXp;
                        Main.XpActiveDUB133 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore DUB130";
                    }
                    break;
                case 12:
                    if (Main.XpActiveDUB133 == 1)
                    {
                        Main.BankXpDUB -= priceXp;
                        Main.XpActiveDUB4421 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore DUB133";
                    }
                    break;
                case 13:
                    if (Main.XpActiveDUB4421 == 1)
                    {
                        Main.BankXpDUB -= priceXp;
                        Main.XpActiveDUB5423 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore DUB4421";
                    }
                    break;
            }
        }
        if (carNumber >= 14 && carNumber <= 21 && Main.BankXpFIIV >= priceXp)
        {
            switch (carNumber)
            {
                case 14:
                    Main.BankXpFIIV -= priceXp;
                    Main.XpActiveFIIV690 = 1;
                    break;
                case 15:
                    if (Main.XpActiveFIIV690 == 1)
                    {
                        Main.BankXpFIIV -= priceXp;
                        Main.XpActiveFIIV619 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore FIIV690";
                    }
                    break;
                case 16:
                    if (Main.XpActiveFIIV619 == 1)
                    {
                        Main.BankXpFIIV -= priceXp;
                        Main.XpActiveFIIVTS = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore FIIV619";
                    }
                    break;
                case 17:
                    if (Main.XpActiveFIIVTS == 1)
                    {
                        Main.BankXpFIIV -= priceXp;
                        Main.XpActiveFIIVES = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore FIIVTS";
                    }
                    break;
                case 18:
                    if (Main.XpActiveFIIVES == 1)
                    {
                        Main.BankXpFIIV -= priceXp;
                        Main.XpActiveFIIVST = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore FIIVES";
                    }
                    break;
                case 19:
                    if (Main.XpActiveFIIVST == 1)
                    {
                        Main.BankXpFIIV -= priceXp;
                        Main.XpActiveFIIVSTR = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore FIIVST";
                    }
                    break;
                case 20:
                    if (Main.XpActiveFIIVSTR == 1)
                    {
                        Main.BankXpFIIV -= priceXp;
                        Main.XpActiveFIIVHW = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore FIIVSTR";
                    }
                    break;
                case 21:
                    if (Main.XpActiveFIIVHW == 1)
                    {
                        Main.BankXpFIIV -= priceXp;
                        Main.XpActiveFIIVSW = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore FIIVHW";
                    }
                    break;
            }
        }
        if (carNumber >= 22 && carNumber <= 26 && Main.BankXpHORSE >= priceXp)
        {
            switch (carNumber)
            {
                case 22:
                    Main.BankXpHORSE -= priceXp;
                    Main.XpActiveHORSE5410 = 1;
                    break;
                case 23:
                    if (Main.XpActiveHORSE5410 == 1)
                    {
                        Main.BankXpHORSE -= priceXp;
                        Main.XpActiveHORSE6460 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore HORSE5410";
                    }
                    break;
                case 24:
                    if (Main.XpActiveHORSE6460 == 1)
                    {
                        Main.BankXpHORSE -= priceXp;
                        Main.XpActiveHORSE5460 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore HORSE6460";
                    }
                    break;
                case 25:
                    if (Main.XpActiveHORSE5460 == 1)
                    {
                        Main.BankXpHORSE -= priceXp;
                        Main.XpActiveHORSE1840 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore HORSE5460";
                    }
                    break;
                case 26:
                    if (Main.XpActiveHORSE1840 == 1)
                    {
                        Main.BankXpHORSE -= priceXp;
                        Main.XpActiveHORSE1855 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore HORSE1840";
                    }
                    break;
            }
        }
        if (carNumber >= 27 && carNumber <= 30 && Main.BankXpRIDGE >= priceXp)
        {
            switch (carNumber)
            {
                case 27:
                    Main.BankXpRIDGE -= priceXp;
                    Main.XpActiveRIDGE375 = 1;
                    break;
                case 28:
                    if (Main.XpActiveRIDGE375 == 1)
                    {
                        Main.BankXpRIDGE -= priceXp;
                        Main.XpActiveRIDGE4420 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore RIDGE375";
                    }
                    break;
                case 29:
                    if (Main.XpActiveRIDGE4420 == 1)
                    {
                        Main.BankXpRIDGE -= priceXp;
                        Main.XpActiveRIDGE6370 = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore RIDGE4420";
                    }
                    break;
                case 30:
                    if (Main.XpActiveRIDGE6370 == 1)
                    {
                        Main.BankXpRIDGE -= priceXp;
                        Main.XpActiveRIDGENX = 1;
                    }
                    else
                    {
                        somethingIsMissing.SetActive(true);
                        SIMtx.text = "Explore RIDGE6370";
                    }
                    break;               
            }
        }
        else if (carNumber >= 1 && carNumber <= 7 && Main.BankXpBison < priceXp)
        {
            somethingIsMissing.SetActive(true);
            SIMtx.text = "Not enough XP";
        }
        else if (carNumber >= 8 && carNumber <= 13 && Main.BankXpDUB < priceXp)
        {
            somethingIsMissing.SetActive(true);
            SIMtx.text = "Not enough XP";
        }
        else if (carNumber >= 14 && carNumber <= 21 && Main.BankXpFIIV < priceXp)
        {
            somethingIsMissing.SetActive(true);
            SIMtx.text = "Not enough XP";
        }
        else if (carNumber >= 22 && carNumber <= 26 && Main.BankXpHORSE < priceXp)
        {
            somethingIsMissing.SetActive(true);
            SIMtx.text = "Not enough XP";
        }
        else if (carNumber >= 27 && carNumber <= 30 && Main.BankXpRIDGE < priceXp)
        {
            somethingIsMissing.SetActive(true);
            SIMtx.text = "Not enough XP";
        }
    }

    public void BuyMoneyTruck()
    {
        if (Main.Money >= priceMoney)
        {
            switch (carNumber)
            {
                case 1:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveBison200 = 1;
                    break;
                case 2:
                    Main.Money -= priceMoney;
                    Main.MoneyActive500 = 1;
                    break;
                case 3:
                    Main.Money -= priceMoney;
                    Main.MoneyActive5432 = 1;
                    break;
                case 4:
                    Main.Money -= priceMoney;
                    Main.MoneyActive6422 = 1;
                    break;
                case 5:
                    Main.Money -= priceMoney;
                    Main.MoneyActive6430 = 1;
                    break;
                case 6:
                    Main.Money -= priceMoney;
                    Main.MoneyActive6440 = 1;
                    break;
                case 7:
                    Main.Money -= priceMoney;
                    Main.MoneyActive5440 = 1;
                    break;
                case 8:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveDUB157 = 1;
                    break;
                case 9:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveDUB131 = 1;
                    break;
                case 10:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveDUB130 = 1;
                    break;
                case 11:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveDUB133 = 1;
                    break;
                case 12:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveDUB4421 = 1;
                    break;
                case 13:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveDUB5423 = 1;
                    break;
                case 14:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveFIIV690 = 1;
                    break;
                case 15:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveFIIV619 = 1;
                    break;
                case 16:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveFIIVTS = 1;
                    break;
                case 17:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveFIIVES = 1;
                    break;
                case 18:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveFIIVST = 1;
                    break;
                case 19:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveFIIVSTR = 1;
                    break;
                case 20:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveFIIVHW = 1;
                    break;
                case 21:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveFIIVSW = 1;
                    break;
                case 22:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveHORSE5410 = 1;
                    break;
                case 23:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveHORSE6460 = 1;
                    break;
                case 24:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveHORSE5460 = 1;
                    break;
                case 25:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveHORSE1840 = 1;
                    break;
                case 26:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveHORSE1855 = 1;
                    break;
                case 27:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveRIDGE375 = 1;
                    break;
                case 28:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveRIDGE4420 = 1;
                    break;
                case 29:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveRIDGE6370 = 1;
                    break;
                case 30:
                    Main.Money -= priceMoney;
                    Main.MoneyActiveRIDGENX = 1;
                    break;
                case 101:
                    Main.Dollars -= priceDollars;
                    Main.DollarActiveFORBCARGO = 1;
                    break;
                case 102:
                    Main.Dollars -= priceDollars;
                    Main.DollarActiveFORBFMAX = 1;
                    break;
            }
        }
        else if (Main.Money < priceMoney)
        {
            somethingIsMissing.SetActive(true);
            SIMtx.text = "Not enough R";
        }
        else if (Main.Dollars < priceDollars)
        {
            somethingIsMissing.SetActive(true);
            SIMtx.text = "Not enough $";
        }
    }
    public void BuyDollarsTruck()
    {
        if (Main.Dollars >= priceDollars)
        {
            switch (carNumber)
            {                
                case 101:
                    Main.Dollars -= priceDollars;
                    Main.DollarActiveFORBCARGO = 1;
                    break;
                case 102:
                    Main.Dollars -= priceDollars;
                    Main.DollarActiveFORBFMAX = 1;
                    break;
            }
        }        
        else if (Main.Dollars < priceDollars)
        {
            somethingIsMissing.SetActive(true);
            SIMtx.text = "Not enough $";
        }
    }
    public void SelectTruck()
    {
        switch (carNumber)
        {
            case 0:
                Main.CarNumber = 0;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 1:
                Main.CarNumber = 1;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 2:
                Main.CarNumber = 2;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 3:
                Main.CarNumber = 3;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 4:
                Main.CarNumber = 4;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 5:
                Main.CarNumber = 5;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 6:
                Main.CarNumber = 6;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 7:
                Main.CarNumber = 7;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 8:
                Main.CarNumber = 8;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 9:
                Main.CarNumber = 9;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 10:
                Main.CarNumber = 10;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 11:
                Main.CarNumber = 11;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 12:
                Main.CarNumber = 12;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 13:
                Main.CarNumber = 13;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 14:
                Main.CarNumber = 14;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 15:
                Main.CarNumber = 15;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 16:
                Main.CarNumber = 16;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 17:
                Main.CarNumber = 17;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 18:
                Main.CarNumber = 18;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 19:
                Main.CarNumber = 19;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 20:
                Main.CarNumber = 20;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 21:
                Main.CarNumber = 21;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 22:
                Main.CarNumber = 22;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 23:
                Main.CarNumber = 23;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 24:
                Main.CarNumber = 24;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 25:
                Main.CarNumber = 25;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 26:
                Main.CarNumber = 26;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 27:
                Main.CarNumber = 27;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 28:
                Main.CarNumber = 28;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 29:
                Main.CarNumber = 29;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 30:
                Main.CarNumber = 30;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 101:
                Main.CarNumber = 101;
                CloseAllPanel();
                ClosePnlTruck();
                break;
            case 102:
                Main.CarNumber = 102;
                CloseAllPanel();
                ClosePnlTruck();
                break;
        }
        Trailer.SetActive(true);
    }

    void FixedUpdate()
    {    
        //if (hiddenPoint >= 50)
        //{
        //    Main.DollarActiveFORBCARGO = 1;
        //}

        switch (carNumber)
        {
            case 0:
                CloseAllTruck();
                nullObj.SetActive(true);
                prefTruckClone = nullObj;                
                break;
            case 1:
                CloseAllTruck();
                Bison200.SetActive(true);
                nameTx.text = "Bison 200";
                prefTruckClone = Bison200;
                saveEngine = Main.EngineBison200;
                saveGearbox = Main.GearboxBison200;
                saveBrake = Main.BrakeBison200;
                saveFuelTank = Main.FuelTankBison200;
                saveRearBogie = Main.RearBogieBison200;
                saveExternalTuning = Main.ExternalTuningBison200;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveBison200 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveBison200 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;

            case 2:
                CloseAllTruck();
                Bison500.SetActive(true);
                nameTx.text = "Bison 500";
                prefTruckClone = Bison500;
                saveEngine = Main.EngineBison500;
                saveGearbox = Main.GearboxBison500;
                saveBrake = Main.BrakeBison500;
                saveFuelTank = Main.FuelTankBison500;
                saveRearBogie = Main.RearBogieBison500;
                saveExternalTuning = Main.ExternalTuningBison500;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveBison500 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActive500 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 3:
                CloseAllTruck();
                Bison5432.SetActive(true);
                nameTx.text = "Bison 5432";
                prefTruckClone = Bison5432;
                saveEngine = Main.EngineBison5432;
                saveGearbox = Main.GearboxBison5432;
                saveBrake = Main.BrakeBison5432;
                saveFuelTank = Main.FuelTankBison5432;
                saveRearBogie = Main.RearBogieBison5432;
                saveExternalTuning = Main.ExternalTuningBison5432;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveBison5432 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActive5432 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 4:
                CloseAllTruck();
                Bison6422.SetActive(true);
                nameTx.text = "Bison 6422";
                prefTruckClone = Bison6422;
                saveEngine = Main.EngineBison6422;
                saveGearbox = Main.GearboxBison6422;
                saveBrake = Main.BrakeBison6422;
                saveFuelTank = Main.FuelTankBison6422;
                saveRearBogie = Main.RearBogieBison6422;
                saveExternalTuning = Main.ExternalTuningBison6422;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveBison6422 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActive6422 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 5:
                CloseAllTruck();
                Bison6430.SetActive(true);
                nameTx.text = "Bison 6430";
                prefTruckClone = Bison6430;
                saveEngine = Main.EngineBison6430;
                saveGearbox = Main.GearboxBison6430;
                saveBrake = Main.BrakeBison6430;
                saveFuelTank = Main.FuelTankBison6430;
                saveRearBogie = Main.RearBogieBison6430;
                saveExternalTuning = Main.ExternalTuningBison6430;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveBison6430 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActive6430 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 6:
                CloseAllTruck();
                Bison6440.SetActive(true);
                nameTx.text = "Bison 6440";
                prefTruckClone = Bison6440;
                saveEngine = Main.EngineBison6440;
                saveGearbox = Main.GearboxBison6440;
                saveBrake = Main.BrakeBison6440;
                saveFuelTank = Main.FuelTankBison6440;
                saveRearBogie = Main.RearBogieBison6440;
                saveExternalTuning = Main.ExternalTuningBison6440;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveBison6440 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActive6440 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 7:
                CloseAllTruck();
                Bison5440.SetActive(true);
                nameTx.text = "Bison 5440";
                prefTruckClone = Bison5440;
                saveEngine = Main.EngineBison5440;
                saveGearbox = Main.GearboxBison5440;
                saveBrake = Main.BrakeBison5440;
                saveFuelTank = Main.FuelTankBison5440;
                saveRearBogie = Main.RearBogieBison5440;
                saveExternalTuning = Main.ExternalTuningBison5440;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveBison5440 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActive5440 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 8:
                CloseAllTruck();
                DUB157.SetActive(true);
                nameTx.text = "DUB 157";
                prefTruckClone = DUB157;
                saveEngine = Main.EngineDUB157;
                saveGearbox = Main.GearboxDUB157;
                saveBrake = Main.BrakeDUB157;
                saveFuelTank = Main.FuelTankDUB157;
                saveRearBogie = Main.RearBogieDUB157;
                saveExternalTuning = Main.ExternalTuningDUB157;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveDUB157 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveDUB157 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 9:
                CloseAllTruck();
                DUB131.SetActive(true);
                nameTx.text = "DUB 131";
                prefTruckClone = DUB131;
                saveEngine = Main.EngineDUB131;
                saveGearbox = Main.GearboxDUB131;
                saveBrake = Main.BrakeDUB131;
                saveFuelTank = Main.FuelTankDUB131;
                saveRearBogie = Main.RearBogieDUB131;
                saveExternalTuning = Main.ExternalTuningDUB131;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveDUB131 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveDUB131 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 10:
                CloseAllTruck();
                DUB130.SetActive(true);
                nameTx.text = "DUB 130";
                prefTruckClone = DUB130;
                saveEngine = Main.EngineDUB130;
                saveGearbox = Main.GearboxDUB130;
                saveBrake = Main.BrakeDUB130;
                saveFuelTank = Main.FuelTankDUB130;
                saveRearBogie = Main.RearBogieDUB130;
                saveExternalTuning = Main.ExternalTuningDUB130;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveDUB130 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveDUB130 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 11:
                CloseAllTruck();
                DUB133.SetActive(true);
                nameTx.text = "DUB 133";
                prefTruckClone = DUB133;
                saveEngine = Main.EngineDUB133;
                saveGearbox = Main.GearboxDUB133;
                saveBrake = Main.BrakeDUB133;
                saveFuelTank = Main.FuelTankDUB133;
                saveRearBogie = Main.RearBogieDUB133;
                saveExternalTuning = Main.ExternalTuningDUB133;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveDUB133 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveDUB133 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 12:
                CloseAllTruck();
                DUB4421.SetActive(true);
                nameTx.text = "DUB 4421";
                prefTruckClone = DUB4421;
                saveEngine = Main.EngineDUB4421;
                saveGearbox = Main.GearboxDUB4421;
                saveBrake = Main.BrakeDUB4421;
                saveFuelTank = Main.FuelTankDUB4421;
                saveRearBogie = Main.RearBogieDUB4421;
                saveExternalTuning = Main.ExternalTuningDUB4421;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveDUB4421 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveDUB4421 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 13:
                CloseAllTruck();
                DUB5423.SetActive(true);
                nameTx.text = "DUB 5423";
                prefTruckClone = DUB5423;
                saveEngine = Main.EngineDUB5423;
                saveGearbox = Main.GearboxDUB5423;
                saveBrake = Main.BrakeDUB5423;
                saveFuelTank = Main.FuelTankDUB5423;
                saveRearBogie = Main.RearBogieDUB5423;
                saveExternalTuning = Main.ExternalTuningDUB5423;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveDUB5423 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveDUB5423 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 14:
                CloseAllTruck();
                FIIV690.SetActive(true);
                nameTx.text = "FIIV 690";
                prefTruckClone = FIIV690;
                saveEngine = Main.EngineFIIV690;
                saveGearbox = Main.GearboxFIIV690;
                saveBrake = Main.BrakeFIIV690;
                saveFuelTank = Main.FuelTankFIIV690;
                saveRearBogie = Main.RearBogieFIIV690;
                saveExternalTuning = Main.ExternalTuningFIIV690;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveFIIV690 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveFIIV690 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 15:
                CloseAllTruck();
                FIIV619.SetActive(true);
                nameTx.text = "FIIV 619";
                prefTruckClone = FIIV619;
                saveEngine = Main.EngineFIIV619;
                saveGearbox = Main.GearboxFIIV619;
                saveBrake = Main.BrakeFIIV619;
                saveFuelTank = Main.FuelTankFIIV619;
                saveRearBogie = Main.RearBogieFIIV619;
                saveExternalTuning = Main.ExternalTuningFIIV619;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveFIIV619 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveFIIV619 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 16:
                CloseAllTruck();
                FIIVTS.SetActive(true);
                nameTx.text = "FIIV TS";
                prefTruckClone = FIIVTS;
                saveEngine = Main.EngineFIIVTS;
                saveGearbox = Main.GearboxFIIVTS;
                saveBrake = Main.BrakeFIIVTS;
                saveFuelTank = Main.FuelTankFIIVTS;
                saveRearBogie = Main.RearBogieFIIVTS;
                saveExternalTuning = Main.ExternalTuningFIIVTS;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveFIIVTS == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveFIIVTS == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 17:
                CloseAllTruck();
                FIIVES.SetActive(true);
                nameTx.text = "FIIV ES";
                prefTruckClone = FIIVES;
                saveEngine = Main.EngineFIIVES;
                saveGearbox = Main.GearboxFIIVES;
                saveBrake = Main.BrakeFIIVES;
                saveFuelTank = Main.FuelTankFIIVES;
                saveRearBogie = Main.RearBogieFIIVES;
                saveExternalTuning = Main.ExternalTuningFIIVES;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveFIIVES == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveFIIVES == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 18:
                CloseAllTruck();
                FIIVST.SetActive(true);
                nameTx.text = "FIIV ST";
                prefTruckClone = FIIVST;
                saveEngine = Main.EngineFIIVST;
                saveGearbox = Main.GearboxFIIVST;
                saveBrake = Main.BrakeFIIVST;
                saveFuelTank = Main.FuelTankFIIVST;
                saveRearBogie = Main.RearBogieFIIVST;
                saveExternalTuning = Main.ExternalTuningFIIVST;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveFIIVST == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveFIIVST == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 19:
                CloseAllTruck();
                FIIVSTR.SetActive(true);
                nameTx.text = "FIIV STR";
                prefTruckClone = FIIVSTR;
                saveEngine = Main.EngineFIIVSTR;
                saveGearbox = Main.GearboxFIIVSTR;
                saveBrake = Main.BrakeFIIVSTR;
                saveFuelTank = Main.FuelTankFIIVSTR;
                saveRearBogie = Main.RearBogieFIIVSTR;
                saveExternalTuning = Main.ExternalTuningFIIVSTR;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveFIIVSTR == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveFIIVSTR == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 20:
                CloseAllTruck();
                FIIVHW.SetActive(true);
                nameTx.text = "FIIV HW";
                prefTruckClone = FIIVHW;
                saveEngine = Main.EngineFIIVHW;
                saveGearbox = Main.GearboxFIIVHW;
                saveBrake = Main.BrakeFIIVHW;
                saveFuelTank = Main.FuelTankFIIVHW; 
                saveRearBogie = Main.RearBogieFIIVHW;
                saveExternalTuning = Main.ExternalTuningFIIVHW;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveFIIVHW == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveFIIVHW == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 21:
                CloseAllTruck();
                FIIVSW.SetActive(true);
                nameTx.text = "FIIV SW";
                prefTruckClone = FIIVSW;
                saveEngine = Main.EngineFIIVSW;
                saveGearbox = Main.GearboxFIIVSW;
                saveBrake = Main.BrakeFIIVSW;
                saveFuelTank = Main.FuelTankFIIVSW;
                saveRearBogie = Main.RearBogieFIIVSW;
                saveExternalTuning = Main.ExternalTuningFIIVSW;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveFIIVSW == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveFIIVSW == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 22:
                CloseAllTruck();
                HORSE5410.SetActive(true);
                nameTx.text = "HORSE 5410";
                prefTruckClone = HORSE5410;
                saveEngine = Main.EngineHORSE5410;
                saveGearbox = Main.GearboxHORSE5410;
                saveBrake = Main.BrakeHORSE5410;
                saveFuelTank = Main.FuelTankHORSE5410;
                saveRearBogie = Main.RearBogieHORSE5410;
                saveExternalTuning = Main.ExternalTuningHORSE5410;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveHORSE5410 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveHORSE5410 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 23:
                CloseAllTruck();
                HORSE6460.SetActive(true);
                nameTx.text = "HORSE 6460";
                prefTruckClone = HORSE6460;
                saveEngine = Main.EngineHORSE6460;
                saveGearbox = Main.GearboxHORSE6460;
                saveBrake = Main.BrakeHORSE6460;
                saveFuelTank = Main.FuelTankHORSE6460;
                saveRearBogie = Main.RearBogieHORSE6460;
                saveExternalTuning = Main.ExternalTuningHORSE6460;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveHORSE6460 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveHORSE6460 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 24:
                CloseAllTruck();
                HORSE5460.SetActive(true);
                nameTx.text = "HORSE 5460";
                prefTruckClone = HORSE5460;
                saveEngine = Main.EngineHORSE5460;
                saveGearbox = Main.GearboxHORSE5460;
                saveBrake = Main.BrakeHORSE5460;
                saveFuelTank = Main.FuelTankHORSE5460;
                saveRearBogie = Main.RearBogieHORSE5460;
                saveExternalTuning = Main.ExternalTuningHORSE5460;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveHORSE5460 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveHORSE5460 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 25:
                CloseAllTruck();
                HORSE1840.SetActive(true);
                nameTx.text = "HORSE 1840";
                prefTruckClone = HORSE1840;
                saveEngine = Main.EngineHORSE1840;
                saveGearbox = Main.GearboxHORSE1840;
                saveBrake = Main.BrakeHORSE1840;
                saveFuelTank = Main.FuelTankHORSE1840;
                saveRearBogie = Main.RearBogieHORSE1840;
                saveExternalTuning = Main.ExternalTuningHORSE1840;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveHORSE1840 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveHORSE1840 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 26:
                CloseAllTruck();
                HORSE1855.SetActive(true);
                nameTx.text = "HORSE 1855";
                prefTruckClone = HORSE1855;
                saveEngine = Main.EngineHORSE1855;
                saveGearbox = Main.GearboxHORSE1855;
                saveBrake = Main.BrakeHORSE1855;
                saveFuelTank = Main.FuelTankHORSE1855;
                saveRearBogie = Main.RearBogieHORSE1855;
                saveExternalTuning = Main.ExternalTuningHORSE1855;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveHORSE1855 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveHORSE1855 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 27:
                CloseAllTruck();
                RIDGE375.SetActive(true);
                nameTx.text = "RIDGE 375C";
                prefTruckClone = RIDGE375;
                saveEngine = Main.EngineRIDGE375;
                saveGearbox = Main.GearboxRIDGE375;
                saveBrake = Main.BrakeRIDGE375;
                saveFuelTank = Main.FuelTankRIDGE375;
                saveRearBogie = Main.RearBogieRIDGE375;
                saveExternalTuning = Main.ExternalTuningRIDGE375;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveRIDGE375 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveRIDGE375 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 28:
                CloseAllTruck();
                RIDGE4420.SetActive(true);
                nameTx.text = "RIDGE 4420";
                prefTruckClone = RIDGE4420;
                saveEngine = Main.EngineRIDGE4420;
                saveGearbox = Main.GearboxRIDGE4420;
                saveBrake = Main.BrakeRIDGE4420;
                saveFuelTank = Main.FuelTankRIDGE4420;
                saveRearBogie = Main.RearBogieRIDGE4420;
                saveExternalTuning = Main.ExternalTuningRIDGE4420;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveRIDGE4420 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveRIDGE4420 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 29:
                CloseAllTruck();
                RIDGE6370.SetActive(true);
                nameTx.text = "RIDGE 6370";
                prefTruckClone = RIDGE6370;
                saveEngine = Main.EngineRIDGE6370;
                saveGearbox = Main.GearboxRIDGE6370;
                saveBrake = Main.BrakeRIDGE6370;
                saveFuelTank = Main.FuelTankRIDGE6370;
                saveRearBogie = Main.RearBogieRIDGE6370;
                saveExternalTuning = Main.ExternalTuningRIDGE6370;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveRIDGE6370 == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveRIDGE6370 == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 30:
                CloseAllTruck();
                RIDGENX.SetActive(true);
                nameTx.text = "RIDGE NX";
                prefTruckClone = RIDGENX;
                saveEngine = Main.EngineRIDGENX;
                saveGearbox = Main.GearboxRIDGENX;
                saveBrake = Main.BrakeRIDGENX;
                saveFuelTank = Main.FuelTankRIDGENX;
                saveRearBogie = Main.RearBogieRIDGENX;
                saveExternalTuning = Main.ExternalTuningRIDGENX;
                priceXp = prefTruckClone.GetComponent<CarChar>().priceXp;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceXpTx.text = priceXp + " XP";
                if (Main.XpActiveRIDGENX == 0)
                {
                    btnXpActive.SetActive(true);
                }
                else
                {
                    btnXpActive.SetActive(false);
                }
                priceMoney = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceMoneyTx.text = priceMoney + " R";
                if (Main.MoneyActiveRIDGENX == 0)
                {
                    btnMoneyActive.SetActive(true);
                }
                else
                {
                    btnMoneyActive.SetActive(false);
                }
                break;
            case 101:
                CloseAllTruck();
                FORBCARGO.SetActive(true);
                nameTx.text = "FORB CARGO";
                prefTruckClone = FORBCARGO;
                saveEngine = Main.EngineFORBCARGO;
                saveGearbox = Main.GearboxFORBCARGO;
                saveBrake = Main.BrakeFORBCARGO;
                saveFuelTank = Main.FuelTankFORBCARGO;
                saveRearBogie = Main.RearBogieFORBCARGO;
                saveExternalTuning = Main.ExternalTuningFORBCARGO;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceDollars = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceDollarsTx.text = priceDollars + " $";
                if (Main.DollarActiveFORBCARGO == 0)
                {
                    btnDollarsActive.SetActive(true);
                }
                else
                {
                    btnDollarsActive.SetActive(false);
                }
                break;
            case 102:
                CloseAllTruck();
                FORBFMAX.SetActive(true);
                nameTx.text = "FORB F-MAX";
                prefTruckClone = FORBFMAX;
                saveEngine = Main.EngineFORBFMAX;
                saveGearbox = Main.GearboxFORBFMAX;
                saveBrake = Main.BrakeFORBFMAX;
                saveFuelTank = Main.FuelTankFORBFMAX;
                saveRearBogie = Main.RearBogieFORBFMAX;
                saveExternalTuning = Main.ExternalTuningFORBFMAX;
                carSound = prefTruckClone.GetComponents<AudioSource>();
                carSound[0].volume = 0;
                priceDollars = prefTruckClone.GetComponent<CarChar>().priceMoney;
                priceDollarsTx.text = priceDollars + " $";
                if (Main.DollarActiveFORBFMAX == 0)
                {
                    btnDollarsActive.SetActive(true);
                }
                else
                {
                    btnDollarsActive.SetActive(false);
                }
                break;
        }
        horse = prefTruckClone.GetComponent<CarChar>().horse;
        maxSpeed = prefTruckClone.GetComponent<CarChar>().maxSpeed / -20;
        fuelConsumption = prefTruckClone.GetComponent<CarChar>().fuelConsumption;
        fuelMax = prefTruckClone.GetComponent<CarChar>().fuelMax;
        allowableWeight = prefTruckClone.GetComponent<CarChar>().allowableWeight;
        priceEngine = prefTruckClone.GetComponent<CarChar>().priceEngine;
        priceGearbox = prefTruckClone.GetComponent<CarChar>().priceGearbox;
        charGearBoxSpeed = prefTruckClone.GetComponent<CarChar>().charGearboxSpeed;
        charMaxTrust = prefTruckClone.GetComponent<CarChar>().charMaxTrust;
        priceBrake = prefTruckClone.GetComponent<CarChar>().priceBrake;        
        charBrake = prefTruckClone.GetComponent<CarChar>().charBrake;
        priceFuelTank = prefTruckClone.GetComponent<CarChar>().priceFuelTank;
        priceRearBogie = prefTruckClone.GetComponent<CarChar>().priceRearBogie;
        priceExternalTuning = prefTruckClone.GetComponent<CarChar>().priceExternalTuning;
        coefPrizeXpFree = prefTruckClone.GetComponent<CarChar>().coefPrizeXpFree * 100;
        SelectGearBoxSpeedOk();
        SelectMaxTrust();
        SelectBrakeOk();

        horseTx.text = horse.ToString("") + " h/p";
        maxSpeedTx.text = maxSpeed.ToString("") + " Km/h";
        fuelConsumptionTx.text = fuelConsumption.ToString("") + " l/100km";
        fuelMaxTx.text = fuelMax.ToString("") + " l";
        allowableWeightTx.text = allowableWeight.ToString("") + " kg";
        coefPrizeXpFreeTx.text = "+ " + coefPrizeXpFree.ToString("") + " % XP";
    }
}
