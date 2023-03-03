using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    public GameObject pnlTruck;
    [Header("Engine")]
    public GameObject btnBuyEngine;
    public GameObject okEngine1;
    public GameObject okEngine2;
    public GameObject okEngine3;
    public int priceEngine;
    public Text priceEngineTx;
    [Header("Кнопки")]
    public GameObject EnginePnl;
    public int saveEngine;
    [Header("Gearbox")]
    public GameObject btnBuyGearbox;
    public GameObject okGearbox1;
    public GameObject okGearbox2;
    public GameObject okGearbox3;
    public Text AKPP;
    public int priceGearbox;
    public Text priceGearboxTx;
    [Header("Кнопки")]
    public GameObject GearboxPnl;
    public int saveGearbox;
    [Header("Brake")]
    public GameObject btnBuyBrake;
    public GameObject okBrake1;
    public GameObject okBrake2;
    public GameObject okBrake3;
    public int priceBrake;
    public Text priceBrakeTx;
    [Header("Кнопки")]
    public GameObject BrakePnl;
    public int saveBrake;
    [Header("FuelTank")]
    public GameObject btnBuyFuelTank;
    public GameObject okFuelTank1;
    public GameObject okFuelTank2;
    public GameObject okFuelTank3;
    public int priceFuelTank;
    public Text priceFuelTankTx;
    [Header("Кнопки")]
    public GameObject FuelTankPnl;
    public int saveFuelTank;
    [Header("RearBogie")]
    public GameObject btnBuyRearBogie;
    public GameObject okRearBogie1;
    public GameObject okRearBogie2;
    public GameObject okRearBogie3;
    public int priceRearBogie;
    public Text priceRearBogieTx;
    [Header("Кнопки")]
    public GameObject RearBogiePnl;
    public int saveRearBogie;
    [Header("ExternalTuning")]
    public GameObject btnBuyExternalTuning;
    public GameObject okExternalTuning1;
    public GameObject okExternalTuning2;
    public int priceExternalTuning;
    public Text priceExternalTuningTx;
    [Header("Кнопки")]
    public GameObject ExternalTuningPnl;
    public int saveExternalTuning;

    public GameObject notMoney;


    public void SelectEngineOk()
    {
        switch (saveEngine)
        {
            case 1:
                okEngine1.SetActive(true);
                okEngine2.SetActive(false);
                okEngine3.SetActive(false);
                break;
            case 2:
                okEngine1.SetActive(false);
                okEngine2.SetActive(true);
                okEngine3.SetActive(false);
                break;
            case 3:
                okEngine1.SetActive(false);
                okEngine2.SetActive(false);
                okEngine3.SetActive(true);
                break;
        }
    }
    public void SelectGearboxOk()
    {
        switch (saveGearbox)
        {
            case 1:
                okGearbox1.SetActive(true);
                okGearbox2.SetActive(false);
                okGearbox3.SetActive(false);
                break;
            case 2:
                okGearbox1.SetActive(false);
                okGearbox2.SetActive(true);
                okGearbox3.SetActive(false);
                break;
            case 3:
                okGearbox1.SetActive(false);
                okGearbox2.SetActive(false);
                okGearbox3.SetActive(true);
                break;
        }
    }
    public void SelectBrakeOk()
    {
        switch (saveBrake)
        {
            case 1:
                okBrake1.SetActive(true);
                okBrake2.SetActive(false);
                okBrake3.SetActive(false);
                break;
            case 2:
                okBrake1.SetActive(false);
                okBrake2.SetActive(true);
                okBrake3.SetActive(false);
                break;
            case 3:
                okBrake1.SetActive(false);
                okBrake2.SetActive(false);
                okBrake3.SetActive(true);
                break;
        }
    }
    public void SelectFuelTankOk()
    {
        switch (saveFuelTank)
        {
            case 1:
                okFuelTank1.SetActive(true);
                okFuelTank2.SetActive(false);
                okFuelTank3.SetActive(false);
                break;
            case 2:
                okFuelTank1.SetActive(false);
                okFuelTank2.SetActive(true);
                okFuelTank3.SetActive(false);
                break;
            case 3:
                okFuelTank1.SetActive(false);
                okFuelTank2.SetActive(false);
                okFuelTank3.SetActive(true);
                break;
        }
    }
    public void SelectRearBogieOk()
    {
        switch (saveRearBogie)
        {
            case 1:
                okRearBogie1.SetActive(true);
                okRearBogie2.SetActive(false);
                okRearBogie3.SetActive(false);
                break;
            case 2:
                okRearBogie1.SetActive(false);
                okRearBogie2.SetActive(true);
                okRearBogie3.SetActive(false);
                break;
            case 3:
                okRearBogie1.SetActive(false);
                okRearBogie2.SetActive(false);
                okRearBogie3.SetActive(true);
                break;
        }
    }
    public void SelectExternalTuningOk()
    {
        switch (saveExternalTuning)
        {
            case 1:
                okExternalTuning1.SetActive(true);
                okExternalTuning2.SetActive(false);
                break;
            case 2:
                okExternalTuning1.SetActive(false);
                okExternalTuning2.SetActive(true);
                break;
        }
    }


    public void OnEngine1()
    {
        Main.Engine = 1;
        SelectEngineOk();
        if (saveEngine == Main.Engine)
            btnBuyEngine.SetActive(false);
        else
            btnBuyEngine.SetActive(true);
    }
    public void OnEngine2()
    {
        Main.Engine = 2;
        SelectEngineOk();
        if (saveEngine == Main.Engine)
            btnBuyEngine.SetActive(false);
        else
            btnBuyEngine.SetActive(true);
    }
    public void OnEngine3()
    {
        Main.Engine = 3;
        SelectEngineOk();
        if (saveEngine == Main.Engine)
            btnBuyEngine.SetActive(false);
        else
            btnBuyEngine.SetActive(true);
    }
    public void OnGearbox1()
    {
        Main.Gearbox = 1;
        SelectGearboxOk();
        if (saveGearbox == Main.Gearbox)
            btnBuyGearbox.SetActive(false);
        else
            btnBuyGearbox.SetActive(true);
    }
    public void OnGearbox2()
    {
        Main.Gearbox = 2;
        SelectGearboxOk();
        if (saveGearbox == Main.Gearbox)
            btnBuyGearbox.SetActive(false);
        else
            btnBuyGearbox.SetActive(true);
    }
    public void OnGearbox3()
    {
        Main.Gearbox = 3;
        SelectGearboxOk();
        if (saveGearbox == Main.Gearbox)
            btnBuyGearbox.SetActive(false);
        else
            btnBuyGearbox.SetActive(true);
    }
    public void OnBrake1()
    {
        Main.Brake = 1;
        SelectBrakeOk();
        if (saveBrake == Main.Brake)
            btnBuyBrake.SetActive(false);
        else
            btnBuyBrake.SetActive(true);
    }
    public void OnBrake2()
    {
        Main.Brake = 2;
        SelectBrakeOk();
        if (saveBrake == Main.Brake)
            btnBuyBrake.SetActive(false);
        else
            btnBuyBrake.SetActive(true);
    }
    public void OnBrake3()
    {
        Main.Brake = 3;
        SelectBrakeOk();
        if (saveBrake == Main.Brake)
            btnBuyBrake.SetActive(false);
        else
            btnBuyBrake.SetActive(true);
    }
    public void OnFuelTank1()
    {
        Main.FuelTank = 1;
        SelectFuelTankOk();
        if (saveFuelTank == Main.FuelTank)
            btnBuyFuelTank.SetActive(false);
        else
            btnBuyFuelTank.SetActive(true);
    }
    public void OnFuelTank2()
    {
        Main.FuelTank = 2;
        SelectFuelTankOk();
        if (saveFuelTank == Main.FuelTank)
            btnBuyFuelTank.SetActive(false);
        else
            btnBuyFuelTank.SetActive(true);
    }
    public void OnFuelTank3()
    {
        Main.FuelTank = 3;
        SelectFuelTankOk();
        if (saveFuelTank == Main.FuelTank)
            btnBuyFuelTank.SetActive(false);
        else
            btnBuyFuelTank.SetActive(true);
    }
    public void OnRearBogie1()
    {
        Main.RearBogie = 1;
        SelectRearBogieOk();
        if (saveRearBogie == Main.RearBogie)
            btnBuyRearBogie.SetActive(false);
        else
            btnBuyRearBogie.SetActive(true);
    }
    public void OnRearBogie2()
    {
        Main.RearBogie = 2;
        SelectRearBogieOk();
        if (saveRearBogie == Main.RearBogie)
            btnBuyRearBogie.SetActive(false);
        else
            btnBuyRearBogie.SetActive(true);
    }
    public void OnRearBogie3()
    {
        Main.RearBogie = 3;
        SelectRearBogieOk();
        if (saveRearBogie == Main.RearBogie)
            btnBuyRearBogie.SetActive(false);
        else
            btnBuyRearBogie.SetActive(true);
    }
    public void OnExternalTuning1()
    {
        Main.ExternalTuning = 1;
        SelectExternalTuningOk();
        if (saveExternalTuning == Main.ExternalTuning)
            btnBuyExternalTuning.SetActive(false);
        else
            btnBuyExternalTuning.SetActive(true);
    }
    public void OnExternalTuning2()
    {
        Main.ExternalTuning = 2;
        SelectExternalTuningOk();
        if (saveExternalTuning == Main.ExternalTuning)
            btnBuyExternalTuning.SetActive(false);
        else
            btnBuyExternalTuning.SetActive(true);
    }

    public void OpenEnginePnl()
    {
        EnginePnl.SetActive(true);
        saveEngine = pnlTruck.GetComponent<PnlTruck>().saveEngine;
        switch (saveEngine)
        {
            case 1:
                OnEngine1();
                break;
            case 2:
                OnEngine2();
                break;
            case 3:
                OnEngine3();
                break;
        }
    }
    public void OpenGearboxPnl()
    {
        GearboxPnl.SetActive(true);
        saveGearbox = pnlTruck.GetComponent<PnlTruck>().saveGearbox;
        switch (saveGearbox)
        {
            case 1:
                OnGearbox1();
                break;
            case 2:
                OnGearbox2();
                break;
            case 3:
                OnGearbox3();
                break;
        }
    }
    public void OpenBrakePnl()
    {
        BrakePnl.SetActive(true);
        saveBrake = pnlTruck.GetComponent<PnlTruck>().saveBrake;
        switch (saveBrake)
        {
            case 1:
                OnBrake1();
                break;
            case 2:
                OnBrake2();
                break;
            case 3:
                OnBrake3();
                break;
        }
    }
    public void OpenFuelTankPnl()
    {
        FuelTankPnl.SetActive(true);
        saveFuelTank = pnlTruck.GetComponent<PnlTruck>().saveFuelTank;
        switch (saveFuelTank)
        {
            case 1:
                OnFuelTank1();
                break;
            case 2:
                OnFuelTank2();
                break;
            case 3:
                OnFuelTank3();
                break;
        }
    }
    public void OpenRearBogiePnl()
    {
        RearBogiePnl.SetActive(true);
        saveRearBogie = pnlTruck.GetComponent<PnlTruck>().saveRearBogie;
        switch (saveRearBogie)
        {
            case 1:
                OnRearBogie1();
                break;
            case 2:
                OnRearBogie2();
                break;
            case 3:
                OnRearBogie3();
                break;
        }
    }
    public void OpenExternalTuningPnl()
    {
        ExternalTuningPnl.SetActive(true);
        saveExternalTuning = pnlTruck.GetComponent<PnlTruck>().saveExternalTuning;
        switch (saveExternalTuning)
        {
            case 1:
                OnExternalTuning1();
                break;
            case 2:
                OnExternalTuning2();
                break;
        }
    }
    public void OpenUpgrade()
    {
        saveEngine = pnlTruck.GetComponent<PnlTruck>().saveEngine;
        switch (saveEngine)
        {
            case 1:
                OnEngine1();
                break;
            case 2:
                OnEngine2();
                break;
            case 3:
                OnEngine3();
                break;
        }
        saveGearbox = pnlTruck.GetComponent<PnlTruck>().saveGearbox;
        switch (saveGearbox)
        {
            case 1:
                OnGearbox1();
                break;
            case 2:
                OnGearbox2();
                break;
            case 3:
                OnGearbox3();
                break;
        }
        saveBrake = pnlTruck.GetComponent<PnlTruck>().saveBrake;
        switch (saveBrake)
        {
            case 1:
                OnBrake1();
                break;
            case 2:
                OnBrake2();
                break;
            case 3:
                OnBrake3();
                break;
        }
        saveFuelTank = pnlTruck.GetComponent<PnlTruck>().saveFuelTank;
        switch (saveFuelTank)
        {
            case 1:
                OnFuelTank1();
                break;
            case 2:
                OnFuelTank2();
                break;
            case 3:
                OnFuelTank3();
                break;
        }
        saveRearBogie = pnlTruck.GetComponent<PnlTruck>().saveRearBogie;
        switch (saveRearBogie)
        {
            case 1:
                OnRearBogie1();
                break;
            case 2:
                OnRearBogie2();
                break;
            case 3:
                OnRearBogie3();
                break;
        }
        saveExternalTuning = pnlTruck.GetComponent<PnlTruck>().saveExternalTuning;
        switch (saveExternalTuning)
        {
            case 1:
                OnExternalTuning1();
                break;
            case 2:
                OnExternalTuning2();
                break;
        }
    }


    public void CloseEnginePnl()
    {
        EnginePnl.SetActive(false);
        Main.Engine = saveEngine;
    }
    public void CloseGearboxPnl()
    {
        GearboxPnl.SetActive(false);
        Main.Gearbox = saveGearbox;
    }
    public void CloseBrakePnl()
    {
        BrakePnl.SetActive(false);
        Main.Brake = saveBrake;
    }
    public void CloseFuelTankPnl()
    {
        FuelTankPnl.SetActive(false);
        Main.FuelTank = saveFuelTank;
    }
    public void CloseRearBogie()
    {
        RearBogiePnl.SetActive(false);
        Main.RearBogie = saveRearBogie;
    }
    public void CloseExternalTuning()
    {
        ExternalTuningPnl.SetActive(false);
        Main.ExternalTuning = saveExternalTuning;
    }


    public void BuyEngine()
    {
        if (Main.Money >= priceEngine)
        {
            switch (Main.CarNumber)
            {
                case 1:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineBison200 = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineBison200 = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineBison200 = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 2:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineBison500 = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineBison500 = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineBison500 = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 3:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineBison5432 = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineBison5432 = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineBison5432 = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 4:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineBison6422 = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineBison6422 = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineBison6422 = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 5:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineBison6430 = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineBison6430 = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineBison6430 = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 6:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineBison6440 = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineBison6440 = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineBison6440 = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 7:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineBison5440 = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineBison5440 = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineBison5440 = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 8:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineDUB157 = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineDUB157 = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineDUB157 = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 9:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineDUB131 = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineDUB131 = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineDUB131 = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 10:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineDUB130 = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineDUB130 = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineDUB130 = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 11:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineDUB133 = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineDUB133 = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineDUB133 = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 12:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineDUB4421 = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineDUB4421 = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineDUB4421 = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 13:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineDUB5423 = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineDUB5423 = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineDUB5423 = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 14:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineFIIV690 = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineFIIV690 = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineFIIV690 = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 15:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineFIIV619 = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineFIIV619 = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineFIIV619 = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 16:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineFIIVTS = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineFIIVTS = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineFIIVTS = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 17:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineFIIVES = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineFIIVES = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineFIIVES = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 18:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineFIIVST = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineFIIVST = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineFIIVST = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 19:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineFIIVSTR = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineFIIVSTR = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineFIIVSTR = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 20:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineFIIVHW = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineFIIVHW = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineFIIVHW = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 21:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineFIIVSW = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineFIIVSW = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineFIIVSW = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 22:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineHORSE5410 = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineHORSE5410 = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineHORSE5410 = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 23:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineHORSE6460 = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineHORSE6460 = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineHORSE6460 = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 24:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineHORSE5460 = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineHORSE5460 = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineHORSE5460 = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 25:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineHORSE1840 = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineHORSE1840 = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineHORSE1840 = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 26:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineHORSE1855 = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineHORSE1855 = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineHORSE1855 = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 27:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineRIDGE375 = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineRIDGE375 = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineRIDGE375 = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 28:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineRIDGE4420 = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineRIDGE4420 = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineRIDGE4420 = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 29:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineRIDGE6370 = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineRIDGE6370 = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineRIDGE6370 = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
                case 30:
                    switch (Main.Engine)
                    {
                        case 1:
                            Main.Money -= priceEngine;
                            Main.EngineRIDGENX = 1;
                            saveEngine = 1;
                            OnEngine1();
                            break;
                        case 2:
                            Main.Money -= priceEngine;
                            Main.EngineRIDGENX = 2;
                            saveEngine = 2;
                            OnEngine2();
                            break;
                        case 3:
                            Main.Money -= priceEngine;
                            Main.EngineRIDGENX = 3;
                            saveEngine = 3;
                            OnEngine3();
                            break;
                    }
                    break;
            }
        }
        else
        {
            notMoney.SetActive(true);
        }
    }
    public void BuyGearbox()
    {
        if (Main.Money >= priceGearbox)
        {
            switch (Main.CarNumber)
            {
                case 1:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxBison200 = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxBison200 = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxBison200 = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 2:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxBison500 = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxBison500 = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxBison500 = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 3:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxBison5432 = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxBison5432 = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxBison5432 = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 4:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxBison6422 = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxBison6422 = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxBison6422 = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 5:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxBison6430 = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxBison6430 = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxBison6430 = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 6:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxBison6440 = 1;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxBison6440 = 2;
                            Main.AKPP = 0;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxBison6440 = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 7:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxBison5440 = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxBison5440 = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxBison5440 = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 8:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxDUB157 = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxDUB157 = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxDUB157 = 3;
                            Main.AKPP = 0;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 9:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxDUB131 = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxDUB131 = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxDUB131 = 3;
                            Main.AKPP = 0;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 10:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxDUB130 = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxDUB130 = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxDUB130 = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 11:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxDUB133 = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxDUB133 = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxDUB133 = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 12:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxDUB4421 = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxDUB4421 = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxDUB4421 = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 13:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxDUB5423 = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxDUB5423 = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxDUB5423 = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 14:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIV690 = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIV690 = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIV690 = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 15:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIV619 = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIV619 = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIV619 = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 16:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIVTS = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIVTS = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIVTS = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 17:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIVES = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIVES = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIVES = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 18:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIVST = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIVST = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIVST = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 19:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIVSTR = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIVSTR = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIVSTR = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 20:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIVHW = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIVHW = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIVHW = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 21:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIVSW = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIVSW = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxFIIVSW = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 22:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxHORSE5410 = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxHORSE5410 = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxHORSE5410 = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 23:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxHORSE6460 = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxHORSE6460 = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxHORSE6460 = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 24:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxHORSE5460 = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxHORSE5460 = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxHORSE5460 = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 25:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxHORSE1840 = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxHORSE1840 = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxHORSE1840 = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 26:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxHORSE1855 = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxHORSE1855 = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxHORSE1855 = 3;
                            Main.AKPP = 1;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 27:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxRIDGE375 = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxRIDGE375 = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxRIDGE375 = 3;
                            Main.AKPP = 0;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 28:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxRIDGE4420 = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxRIDGE4420 = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxRIDGE4420 = 3;
                            Main.AKPP = 0;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 29:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxRIDGE6370 = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxRIDGE6370 = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxRIDGE6370 = 3;
                            Main.AKPP = 0;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
                case 30:
                    switch (Main.Gearbox)
                    {
                        case 1:
                            Main.Money -= priceGearbox;
                            Main.GearboxRIDGENX = 1;
                            Main.AKPP = 0;
                            saveGearbox = 1;
                            OnGearbox1();
                            break;
                        case 2:
                            Main.Money -= priceGearbox;
                            Main.GearboxRIDGENX = 2;
                            Main.AKPP = 0;
                            saveGearbox = 2;
                            OnGearbox2();
                            break;
                        case 3:
                            Main.Money -= priceGearbox;
                            Main.GearboxRIDGENX = 3;
                            Main.AKPP = 0;
                            saveGearbox = 3;
                            OnGearbox3();
                            break;
                    }
                    break;
            }
        }
        else
        {
            notMoney.SetActive(true);
        }
    }
    public void BuyBrake()
    {
        if (Main.Money >= priceBrake)
        {
            switch (Main.CarNumber)
            {
                case 1:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeBison200 = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeBison200 = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeBison200 = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 2:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeBison500 = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeBison500 = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeBison500 = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 3:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeBison5432 = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeBison5432 = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeBison5432 = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 4:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeBison6422 = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeBison6422 = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeBison6422 = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 5:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeBison6430 = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeBison6430 = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeBison6430 = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 6:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeBison6440 = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeBison6440 = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeBison6440 = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 7:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeBison5440 = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeBison5440 = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeBison5440 = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 8:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeDUB157 = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeDUB157 = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeDUB157 = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 9:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeDUB131 = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeDUB131 = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeDUB131 = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 10:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeDUB130 = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeDUB130 = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeDUB130 = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 11:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeDUB133 = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeDUB133 = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeDUB133 = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 12:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeDUB4421 = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeDUB4421 = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeDUB4421 = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 13:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeDUB5423 = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeDUB5423 = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeDUB5423 = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 14:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIV690 = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIV690 = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIV690 = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 15:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIV619 = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIV619 = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIV619 = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 16:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIVTS = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIVTS = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIVTS = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 17:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIVES = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIVES = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIVES = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 18:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIVST = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIVST = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIVST = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 19:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIVSTR = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIVSTR = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIVSTR = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 20:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIVHW = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIVHW = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIVHW = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 21:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIVSW = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIVSW = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeFIIVSW = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 22:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeHORSE5410 = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeHORSE5410 = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeHORSE5410 = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 23:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeHORSE6460 = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeHORSE6460 = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeHORSE6460 = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 24:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeHORSE5460 = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeHORSE5460 = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeHORSE5460 = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 25:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeHORSE1840 = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeHORSE1840 = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeHORSE1840 = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 26:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeHORSE1855 = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeHORSE1855 = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeHORSE1855 = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 27:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeRIDGE375 = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeRIDGE375 = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeRIDGE375 = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 28:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeRIDGE4420 = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeRIDGE4420 = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeRIDGE4420 = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 29:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeRIDGE6370 = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeRIDGE6370 = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeRIDGE6370 = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
                case 30:
                    switch (Main.Brake)
                    {
                        case 1:
                            Main.Money -= priceBrake;
                            Main.BrakeRIDGENX = 1;
                            saveBrake = 1;
                            OnBrake1();
                            break;
                        case 2:
                            Main.Money -= priceBrake;
                            Main.BrakeRIDGENX = 2;
                            saveBrake = 2;
                            OnBrake2();
                            break;
                        case 3:
                            Main.Money -= priceBrake;
                            Main.BrakeRIDGENX = 3;
                            saveBrake = 3;
                            OnBrake3();
                            break;
                    }
                    break;
            }
        }
        else
        {
            notMoney.SetActive(true);
        }
    }
    public void BuyFuelTank()
    {
        if (Main.Money >= priceFuelTank)
        {
            switch (Main.CarNumber)
            {
                case 1:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankBison200 = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankBison200 = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankBison200 = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 2:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankBison500 = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankBison500 = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankBison500 = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 3:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankBison5432 = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankBison5432 = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankBison5432 = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 4:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankBison6422 = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankBison6422 = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankBison6422 = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 5:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankBison6430 = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankBison6430 = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankBison6430 = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 6:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankBison6440 = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankBison6440 = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankBison6440 = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 7:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankBison5440 = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankBison5440 = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankBison5440 = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 8:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankDUB157 = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankDUB157 = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankDUB157 = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 9:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankDUB131 = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankDUB131 = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankDUB131 = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 10:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankDUB130 = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankDUB130 = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankDUB130 = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 11:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankDUB133 = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankDUB133 = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankDUB133 = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 12:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankDUB4421 = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankDUB4421 = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankDUB4421 = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 13:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankDUB5423 = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankDUB5423 = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankDUB5423 = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 14:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIV690 = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIV690 = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIV690 = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 15:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIV619 = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIV619 = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIV619 = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 16:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIVTS = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIVTS = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIVTS = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 17:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIVES = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIVES = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIVES = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 18:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIVST = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIVST = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIVST = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 19:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIVSTR = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIVSTR = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIVSTR = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 20:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIVHW = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIVHW = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIVHW = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 21:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIVSW = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIVSW = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankFIIVSW = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 22:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankHORSE5410 = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankHORSE5410 = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankHORSE5410 = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 23:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankHORSE6460 = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankHORSE6460 = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankHORSE6460 = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 24:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankHORSE5460 = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankHORSE5460 = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankHORSE5460 = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 25:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankHORSE1840 = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankHORSE1840 = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankHORSE1840 = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 26:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankHORSE1855 = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankHORSE1855 = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankHORSE1855 = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 27:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankRIDGE375 = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankRIDGE375 = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankRIDGE375 = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 28:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankRIDGE4420 = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankRIDGE4420 = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankRIDGE4420 = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 29:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankRIDGE6370 = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankRIDGE6370 = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankRIDGE6370 = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
                case 30:
                    switch (Main.FuelTank)
                    {
                        case 1:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankRIDGENX = 1;
                            saveFuelTank = 1;
                            OnFuelTank1();
                            break;
                        case 2:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankRIDGENX = 2;
                            saveFuelTank = 2;
                            OnFuelTank2();
                            break;
                        case 3:
                            Main.Money -= priceFuelTank;
                            Main.FuelTankRIDGENX = 3;
                            saveFuelTank = 3;
                            OnFuelTank3();
                            break;
                    }
                    break;
            }
        }
        else
        {
            notMoney.SetActive(true);
        }
    }
    public void BuyRearBogie()
    {
        if (Main.Money >= priceRearBogie)
        {
            switch (Main.CarNumber)
            {
                case 1:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieBison200 = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieBison200 = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieBison200 = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 2:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieBison500 = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieBison500 = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieBison500 = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 3:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieBison5432 = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieBison5432 = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieBison5432 = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 4:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieBison6422 = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieBison6422 = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieBison6422 = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 5:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieBison6430 = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieBison6430 = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieBison6430 = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 6:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieBison6440 = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieBison6440 = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieBison6440 = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 7:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieBison5440 = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieBison5440 = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieBison5440 = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 8:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieDUB157 = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieDUB157 = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieDUB157 = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 9:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieDUB131 = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieDUB131 = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieDUB131 = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 10:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieDUB130 = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieDUB130 = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieDUB130 = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 11:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieDUB133 = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieDUB133 = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieDUB133 = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 12:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieDUB4421 = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieDUB4421 = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieDUB4421 = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 13:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieDUB5423 = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieDUB5423 = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieDUB5423 = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 14:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIV690 = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIV690 = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIV690 = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 15:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIV619 = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIV619 = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIV619 = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 16:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIVTS = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIVTS = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIVTS = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 17:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIVES = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIVES = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIVES = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 18:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIVST = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIVST = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIVST = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 19:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIVSTR = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIVSTR = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIVSTR = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 20:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIVHW = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIVHW = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIVHW = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 21:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIVSW = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIVSW = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieFIIVSW = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 22:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieHORSE5410 = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieHORSE5410 = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieHORSE5410 = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 23:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieHORSE6460 = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieHORSE6460 = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieHORSE6460 = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 24:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieHORSE5460 = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieHORSE5460 = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieHORSE5460 = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 25:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieHORSE1840 = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieHORSE1840 = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieHORSE1840 = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 26:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieHORSE1855 = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieHORSE1855 = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieHORSE1855 = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 27:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieRIDGE375 = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieRIDGE375 = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieRIDGE375 = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 28:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieRIDGE4420 = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieRIDGE4420 = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieRIDGE4420 = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 29:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieRIDGE6370 = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieRIDGE6370 = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieRIDGE6370 = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
                case 30:
                    switch (Main.RearBogie)
                    {
                        case 1:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieRIDGENX = 1;
                            saveRearBogie = 1;
                            OnRearBogie1();
                            break;
                        case 2:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieRIDGENX = 2;
                            saveRearBogie = 2;
                            OnRearBogie2();
                            break;
                        case 3:
                            Main.Money -= priceRearBogie;
                            Main.RearBogieRIDGENX = 3;
                            saveRearBogie = 3;
                            OnRearBogie3();
                            break;
                    }
                    break;
            }
        }
    }
    public void BuyExternalTuning()
    {
        if (Main.Money >= priceExternalTuning)
        {
            switch (Main.CarNumber)
            {
                case 1:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningBison200 = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningBison200 = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 2:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningBison500 = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningBison500 = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 3:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningBison5432 = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningBison5432 = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 4:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningBison6422 = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningBison6422 = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 5:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningBison6430 = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningBison6430 = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 6:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningBison6440 = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningBison6440 = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 7:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningBison5440 = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningBison5440 = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 8:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningDUB157 = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningDUB157 = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 9:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningDUB131 = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningDUB131 = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 10:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningDUB130 = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningDUB130 = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 11:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningDUB133 = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningDUB133 = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 12:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningDUB4421 = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningDUB4421 = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 13:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningDUB5423 = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningDUB5423 = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 14:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningFIIV690 = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningFIIV690 = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 15:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningFIIV619 = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningFIIV619 = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 16:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningFIIVTS = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningFIIVTS = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 17:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningFIIVES = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningFIIVES = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 18:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningFIIVST = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningFIIVST = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 19:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningFIIVSTR = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningFIIVSTR = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 20:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningFIIVHW = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningFIIVHW = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 21:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningFIIVSW = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningFIIVSW = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 22:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningHORSE5410 = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningHORSE5410 = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 23:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningHORSE6460 = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningHORSE6460 = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 24:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningHORSE5460 = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningHORSE5460 = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 25:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningHORSE1840 = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningHORSE1840 = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 26:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningHORSE1855 = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningHORSE1855 = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 27:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningRIDGE375 = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningRIDGE375 = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 28:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningRIDGE4420 = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningRIDGE4420 = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 29:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningRIDGE6370 = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningRIDGE6370 = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
                case 30:
                    switch (Main.ExternalTuning)
                    {
                        case 1:
                            Main.Money += priceExternalTuning;
                            Main.ExternalTuningRIDGENX = 1;
                            saveExternalTuning = 1;
                            OnExternalTuning1();
                            break;
                        case 2:
                            Main.Money -= priceExternalTuning;
                            Main.ExternalTuningRIDGENX = 2;
                            saveExternalTuning = 2;
                            OnExternalTuning2();
                            break;
                    }
                    break;
            }
        }
    }


    public void CloseNotMoney()
    {
        notMoney.SetActive(false);
    }    

    
    private void Update()
    {
        if (Main.AKPP == 1)
            AKPP.text = "AT";
        else
            AKPP.text = "MT";

        priceEngine = pnlTruck.GetComponent<PnlTruck>().priceEngine;
        priceEngineTx.text = priceEngine.ToString("") + " R";
        priceGearbox = pnlTruck.GetComponent<PnlTruck>().priceGearbox;
        priceGearboxTx.text = priceGearbox.ToString("") + " R";
        priceBrake = pnlTruck.GetComponent<PnlTruck>().priceBrake;
        priceBrakeTx.text = priceBrake.ToString("") + " R";
        priceFuelTank = pnlTruck.GetComponent<PnlTruck>().priceFuelTank;
        priceFuelTankTx.text = priceFuelTank.ToString("") + " R";
        priceRearBogie = pnlTruck.GetComponent<PnlTruck>().priceRearBogie;
        priceRearBogieTx.text = priceRearBogie.ToString("") + " R";
        priceExternalTuning = pnlTruck.GetComponent<PnlTruck>().priceExternalTuning;
        priceExternalTuningTx.text = priceExternalTuning.ToString("") + " R";
    }
}
