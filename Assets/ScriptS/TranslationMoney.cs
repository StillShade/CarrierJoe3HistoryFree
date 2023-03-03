using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TranslationMoney : MonoBehaviour
{
    [Header("Текста")]
    public int MoneyInt;
    public Text MoneyTx;
    public int DollarsInt;
    public Text DollarsTx;    

    public GameObject notEnough;
    public Text notEnoughTx;

    public void CloseNotEnough()
    {
        notEnough.SetActive(false);
    }

    public void MoneyPlus()
    {        
        if (Main.Dollars >= 1)
        {
            Main.Money += 1000;
            Main.Dollars -= 1;
        }
        else if (Main.Dollars < 1)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void MoneyPlus5000()
    {
        if (Main.Dollars >= 5)
        {
            Main.Money += 5000;
            Main.Dollars -= 5;
        }
        else if (Main.Dollars < 5)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void MoneyPlus10000()
    {
        if (Main.Dollars >= 10)
        {
            Main.Money += 10000;
            Main.Dollars -= 10;
        }
        else if (Main.Dollars < 10)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }

    public void DollarsPlus()
    {
        if (Main.Money >= 10000)
        {
            Main.Money -= 10000;
            Main.Dollars += 1;
        }
        else if (Main.Money < 10000)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough R";
        }
    }
    
    void Update()
    {        
        DollarsInt = Main.Dollars;
        DollarsTx.text = DollarsInt.ToString("0" + " $");
        MoneyInt = Main.Money;
        MoneyTx.text = MoneyInt.ToString("0" + " R");
    }
}
