using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TranslationXP : MonoBehaviour
{
    [Header("Текста")]    
    public int DollarsInt;
    public Text DollarsTx;
    public float XpFreeFt;
    public Text XpFreeTx;

    public float XpBisonFt;
    public Text TxXpBison;

    public float XpDUBFt;
    public Text TxXpDUB;

    public float XpFIIVFt;
    public Text TxXpFIIV;

    public float XpHORSEFt;
    public Text TxXpHORSE;

    public float XpRIDGEFt;
    public Text TxXpRIDGE;

    public float XpBoardFt;
    public Text TxXpBoard;

    public float XpTentFt;
    public Text TxXpTent;

    public float XpRefFt;
    public Text TxXpRef;

    public float XpConFt;
    public Text TxXpCon;

    public Text XpFreePM;
    [Header("Кнопки")]    
    public GameObject DollarsBtn;
    public GameObject DollarsBtn2;
    public GameObject DollarsBtn3;

    public GameObject BisonP;
    public GameObject BisonM;
    public GameObject BisonP2;
    public GameObject BisonM2;
    public GameObject BisonP3;
    public GameObject BisonM3;

    public GameObject DubP;
    public GameObject DubM;
    public GameObject DubP2;
    public GameObject DubM2;
    public GameObject DubP3;
    public GameObject DubM3;

    public GameObject FIIVP;
    public GameObject FIIVM;
    public GameObject FIIVP2;
    public GameObject FIIVM2;
    public GameObject FIIVP3;
    public GameObject FIIVM3;

    public GameObject HORSEP;
    public GameObject HORSEM;
    public GameObject HORSEP2;
    public GameObject HORSEM2;
    public GameObject HORSEP3;
    public GameObject HORSEM3;

    public GameObject RIDGEP;
    public GameObject RIDGEM;
    public GameObject RIDGEP2;
    public GameObject RIDGEM2;
    public GameObject RIDGEP3;
    public GameObject RIDGEM3;

    public GameObject BoardP;
    public GameObject BoardM;
    public GameObject BoardP2;
    public GameObject BoardM2;
    public GameObject BoardP3;
    public GameObject BoardM3;

    public GameObject TentP;
    public GameObject TentM;
    public GameObject TentP2;
    public GameObject TentM2;
    public GameObject TentP3;
    public GameObject TentM3;

    public GameObject RefP;
    public GameObject RefM;
    public GameObject RefP2;
    public GameObject RefM2;
    public GameObject RefP3;
    public GameObject RefM3;

    public GameObject ConP;
    public GameObject ConM;
    public GameObject ConP2;
    public GameObject ConM2;
    public GameObject ConP3;
    public GameObject ConM3;

    public GameObject XpFreeP;
    public GameObject XpFreeM;

    public GameObject notEnough;
    public Text notEnoughTx;

    public int PandM;

    public void CloseNotEnough()
    {
        notEnough.SetActive(false);
    }

    public void TranslationBisonXp()
    {
        if (Main.BankXpFree >= 100)
        {
            Main.BankXpFree -= 100;
            Main.BankXpBison += 100;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationBisonXp200()
    {
        if (Main.BankXpFree >= 200)
        {
            Main.BankXpFree -= 200;
            Main.BankXpBison += 200;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationBisonXp500()
    {
        if (Main.BankXpFree >= 500)
        {
            Main.BankXpFree -= 500;
            Main.BankXpBison += 500;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationDUBXp()
    {
        if (Main.BankXpFree >= 100)
        {
            Main.BankXpFree -= 100;
            Main.BankXpDUB += 100;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationDUBXp200()
    {
        if (Main.BankXpFree >= 200)
        {
            Main.BankXpFree -= 200;
            Main.BankXpDUB += 200;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationDUBXp500()
    {
        if (Main.BankXpFree >= 500)
        {
            Main.BankXpFree -= 500;
            Main.BankXpDUB += 500;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationFIIVXp()
    {
        if (Main.BankXpFree >= 100)
        {
            Main.BankXpFree -= 100;
            Main.BankXpFIIV += 100;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationFIIVXp200()
    {
        if (Main.BankXpFree >= 200)
        {
            Main.BankXpFree -= 200;
            Main.BankXpFIIV += 200;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationFIIVXp500()
    {
        if (Main.BankXpFree >= 500)
        {
            Main.BankXpFree -= 500;
            Main.BankXpFIIV += 500;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationHORSEXp()
    {
        if (Main.BankXpFree >= 100)
        {
            Main.BankXpFree -= 100;
            Main.BankXpHORSE += 100;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationHORSEXp200()
    {
        if (Main.BankXpFree >= 200)
        {
            Main.BankXpFree -= 200;
            Main.BankXpHORSE += 200;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationHORSEXp500()
    {
        if (Main.BankXpFree >= 500)
        {
            Main.BankXpFree -= 500;
            Main.BankXpHORSE += 500;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationRIDGEXp()
    {
        if (Main.BankXpFree >= 100)
        {
            Main.BankXpFree -= 100;
            Main.BankXpRIDGE += 100;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationRIDGEXp200()
    {
        if (Main.BankXpFree >= 200)
        {
            Main.BankXpFree -= 200;
            Main.BankXpRIDGE += 200;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationRIDGEXp500()
    {
        if (Main.BankXpFree >= 500)
        {
            Main.BankXpFree -= 500;
            Main.BankXpRIDGE += 500;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationBoardXp()
    {
        if (Main.BankXpFree >= 100)
        {
            Main.BankXpFree -= 100;
            Main.BankXpBoard += 100;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationBoardXp200()
    {
        if (Main.BankXpFree >= 200)
        {
            Main.BankXpFree -= 200;
            Main.BankXpBoard += 200;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationBoardXp500()
    {
        if (Main.BankXpFree >= 500)
        {
            Main.BankXpFree -= 500;
            Main.BankXpBoard += 500;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationTentXp()
    {
        if (Main.BankXpFree >= 100)
        {
            Main.BankXpFree -= 100;
            Main.BankXpTent += 100;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationTentXp200()
    {
        if (Main.BankXpFree >= 200)
        {
            Main.BankXpFree -= 200;
            Main.BankXpTent += 200;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationTentXp500()
    {
        if (Main.BankXpFree >= 500)
        {
            Main.BankXpFree -= 500;
            Main.BankXpTent += 500;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationRefXp()
    {
        if (Main.BankXpFree >= 100)
        {
            Main.BankXpFree -= 100;
            Main.BankXpRef += 100;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationRefXp200()
    {
        if (Main.BankXpFree >= 200)
        {
            Main.BankXpFree -= 200;
            Main.BankXpRef += 200;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationRefXp500()
    {
        if (Main.BankXpFree >= 500)
        {
            Main.BankXpFree -= 500;
            Main.BankXpRef += 500;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationConXp()
    {
        if (Main.BankXpFree >= 100)
        {
            Main.BankXpFree -= 100;
            Main.BankXpCon += 100;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationConXp200()
    {
        if (Main.BankXpFree >= 200)
        {
            Main.BankXpFree -= 200;
            Main.BankXpCon += 200;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }
    public void TranslationConXp500()
    {
        if (Main.BankXpFree >= 500)
        {
            Main.BankXpFree -= 500;
            Main.BankXpCon += 500;
        }
        else
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
    }

    public void XpFreeBisonXp()
    {
        if (Main.BankXpBison >= 100 && Main.Dollars >= 1)
        {
            Main.BankXpBison -= 100;
            Main.Dollars -= 1;
            Main.BankXpFree += 100;
        }
        else if (Main.BankXpBison <= 100)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 1)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeBisonXp200()
    {
        if (Main.BankXpBison >= 200 && Main.Dollars >= 2)
        {
            Main.BankXpBison -= 200;
            Main.Dollars -= 2;
            Main.BankXpFree += 200;
        }
        else if (Main.BankXpBison <= 200)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 2)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeBisonXp500()
    {
        if (Main.BankXpBison >= 500 && Main.Dollars >= 5)
        {
            Main.BankXpBison -= 500;
            Main.Dollars -= 5;
            Main.BankXpFree += 500;
        }
        else if (Main.BankXpBison <= 500)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 5)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeDUBXp()
    {
        if (Main.BankXpDUB >= 100 && Main.Dollars >= 1)
        {
            Main.BankXpDUB -= 100;
            Main.Dollars -= 1;
            Main.BankXpFree += 100;
        }
        else if (Main.BankXpDUB <= 100)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 1)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeDUBXp200()
    {
        if (Main.BankXpDUB >= 200 && Main.Dollars >= 2)
        {
            Main.BankXpDUB -= 200;
            Main.Dollars -= 2;
            Main.BankXpFree += 200;
        }
        else if (Main.BankXpDUB <= 200)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 2)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeDUBXp500()
    {
        if (Main.BankXpDUB >= 500 && Main.Dollars >= 5)
        {
            Main.BankXpDUB -= 500;
            Main.Dollars -= 5;
            Main.BankXpFree += 500;
        }
        else if (Main.BankXpDUB <= 500)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 5)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeFIIVXp()
    {
        if (Main.BankXpFIIV >= 100 && Main.Dollars >= 1)
        {
            Main.BankXpFIIV -= 100;
            Main.Dollars -= 1;
            Main.BankXpFree += 100;
        }
        else if (Main.BankXpFIIV <= 100)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 1)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeFIIVXp200()
    {
        if (Main.BankXpFIIV >= 200 && Main.Dollars >= 2)
        {
            Main.BankXpFIIV -= 200;
            Main.Dollars -= 2;
            Main.BankXpFree += 200;
        }
        else if (Main.BankXpFIIV <= 200)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 2)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeFIIVXp500()
    {
        if (Main.BankXpFIIV >= 500 && Main.Dollars >= 5)
        {
            Main.BankXpFIIV -= 500;
            Main.Dollars -= 5;
            Main.BankXpFree += 500;
        }
        else if (Main.BankXpFIIV <= 500)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 5)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeHORSEXp()
    {
        if (Main.BankXpHORSE >= 100 && Main.Dollars >= 1)
        {
            Main.BankXpHORSE -= 100;
            Main.Dollars -= 1;
            Main.BankXpFree += 100;
        }
        else if (Main.BankXpHORSE <= 100)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 1)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeHORSEXp200()
    {
        if (Main.BankXpHORSE >= 200 && Main.Dollars >= 2)
        {
            Main.BankXpHORSE -= 200;
            Main.Dollars -= 2;
            Main.BankXpFree += 200;
        }
        else if (Main.BankXpHORSE <= 200)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 2)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeHORSEXp500()
    {
        if (Main.BankXpHORSE >= 500 && Main.Dollars >= 5)
        {
            Main.BankXpHORSE -= 500;
            Main.Dollars -= 5;
            Main.BankXpFree += 500;
        }
        else if (Main.BankXpHORSE <= 500)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 5)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeRIDGEXp()
    {
        if (Main.BankXpRIDGE >= 100 && Main.Dollars >= 1)
        {
            Main.BankXpRIDGE -= 100;
            Main.Dollars -= 1;
            Main.BankXpFree += 100;
        }
        else if (Main.BankXpRIDGE <= 100)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 1)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeRIDGEXp200()
    {
        if (Main.BankXpRIDGE >= 200 && Main.Dollars >= 2)
        {
            Main.BankXpRIDGE -= 200;
            Main.Dollars -= 2;
            Main.BankXpFree += 200;
        }
        else if (Main.BankXpRIDGE <= 200)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 2)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeRIDGEXp500()
    {
        if (Main.BankXpRIDGE >= 500 && Main.Dollars >= 5)
        {
            Main.BankXpRIDGE -= 500;
            Main.Dollars -= 5;
            Main.BankXpFree += 500;
        }
        else if (Main.BankXpRIDGE <= 500)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 5)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeBoardXp()
    {
        if (Main.BankXpBoard >= 100 && Main.Dollars >= 1)
        {
            Main.BankXpBoard -= 100;
            Main.Dollars -= 1;
            Main.BankXpFree += 100;
        }
        else if (Main.BankXpBoard <= 100)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 1)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeBoardXp200()
    {
        if (Main.BankXpBoard >= 200 && Main.Dollars >= 2)
        {
            Main.BankXpBoard -= 200;
            Main.Dollars -= 2;
            Main.BankXpFree += 200;
        }
        else if (Main.BankXpBoard <= 200)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 2)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeBoardXp500()
    {
        if (Main.BankXpBoard >= 500 && Main.Dollars >= 5)
        {
            Main.BankXpBoard -= 500;
            Main.Dollars -= 5;
            Main.BankXpFree += 500;
        }
        else if (Main.BankXpBoard <= 500)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 5)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeTentXp()
    {
        if (Main.BankXpTent >= 100 && Main.Dollars >= 1)
        {
            Main.BankXpTent -= 100;
            Main.Dollars -= 1;
            Main.BankXpFree += 100;
        }
        else if (Main.BankXpTent <= 100)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 1)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeTentXp200()
    {
        if (Main.BankXpTent >= 200 && Main.Dollars >= 2)
        {
            Main.BankXpTent -= 200;
            Main.Dollars -= 2;
            Main.BankXpFree += 200;
        }
        else if (Main.BankXpTent <= 200)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 2)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeTentXp500()
    {
        if (Main.BankXpTent >= 500 && Main.Dollars >= 5)
        {
            Main.BankXpTent -= 500;
            Main.Dollars -= 5;
            Main.BankXpFree += 500;
        }
        else if (Main.BankXpTent <= 500)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 5)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeRefXp()
    {
        if (Main.BankXpRef >= 100 && Main.Dollars >= 1)
        {
            Main.BankXpRef -= 100;
            Main.Dollars -= 1;
            Main.BankXpFree += 100;
        }
        else if (Main.BankXpRef <= 100)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 1)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeRefXp200()
    {
        if (Main.BankXpRef >= 200 && Main.Dollars >= 2)
        {
            Main.BankXpRef -= 200;
            Main.Dollars -= 2;
            Main.BankXpFree += 200;
        }
        else if (Main.BankXpRef <= 200)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 2)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeRefXp500()
    {
        if (Main.BankXpRef >= 500 && Main.Dollars >= 5)
        {
            Main.BankXpRef -= 500;
            Main.Dollars -= 5;
            Main.BankXpFree += 500;
        }
        else if (Main.BankXpRef <= 500)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 5)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeConXp()
    {
        if (Main.BankXpCon >= 100 && Main.Dollars >= 1)
        {
            Main.BankXpCon -= 100;
            Main.Dollars -= 1;
            Main.BankXpFree += 100;
        }
        else if (Main.BankXpCon <= 100)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 1)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeConXp200()
    {
        if (Main.BankXpCon >= 200 && Main.Dollars >= 2)
        {
            Main.BankXpCon -= 200;
            Main.Dollars -= 2;
            Main.BankXpFree += 200;
        }
        else if (Main.BankXpCon <= 200)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 2)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeConXp500()
    {
        if (Main.BankXpCon >= 500 && Main.Dollars >= 5)
        {
            Main.BankXpCon -= 500;
            Main.Dollars -= 5;
            Main.BankXpFree += 500;
        }
        else if (Main.BankXpCon <= 500)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough XP";
        }
        else if (Main.Dollars < 5)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeDollars()
    {
        if (Main.Dollars >= 2)
        {            
            Main.Dollars -= 2;
            Main.BankXpFree += 100;
        }        
        else if (Main.Dollars < 2)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeDollars200()
    {
        if (Main.Dollars >= 4)
        {
            Main.Dollars -= 4;
            Main.BankXpFree += 200;
        }
        else if (Main.Dollars < 4)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }
    public void XpFreeDollars500()
    {
        if (Main.Dollars >= 10)
        {
            Main.Dollars -= 10;
            Main.BankXpFree += 500;
        }
        else if (Main.Dollars < 10)
        {
            notEnough.SetActive(true);
            notEnoughTx.text = "Not enough $";
        }
    }

    public void xpFreeP()
    {
        PandM = 1;
        BisonP.SetActive(false);
        BisonM.SetActive(true);
        BisonP2.SetActive(false);
        BisonM2.SetActive(true);
        BisonP3.SetActive(false);
        BisonM3.SetActive(true);

        DubP.SetActive(false);
        DubM.SetActive(true);
        DubP2.SetActive(false);
        DubM2.SetActive(true);
        DubP3.SetActive(false);
        DubM3.SetActive(true);

        FIIVP.SetActive(false);
        FIIVM.SetActive(true);
        FIIVP2.SetActive(false);
        FIIVM2.SetActive(true);
        FIIVP3.SetActive(false);
        FIIVM3.SetActive(true);

        HORSEP.SetActive(false);
        HORSEM.SetActive(true);
        HORSEP2.SetActive(false);
        HORSEM2.SetActive(true);
        HORSEP3.SetActive(false);
        HORSEM3.SetActive(true);

        RIDGEP.SetActive(false);
        RIDGEM.SetActive(true);
        RIDGEP2.SetActive(false);
        RIDGEM2.SetActive(true);
        RIDGEP3.SetActive(false);
        RIDGEM3.SetActive(true);

        BoardP.SetActive(false);
        BoardM.SetActive(true);
        BoardP2.SetActive(false);
        BoardM2.SetActive(true);
        BoardP3.SetActive(false);
        BoardM3.SetActive(true);

        TentP.SetActive(false);
        TentM.SetActive(true);
        TentP2.SetActive(false);
        TentM2.SetActive(true);
        TentP3.SetActive(false);
        TentM3.SetActive(true);

        RefP.SetActive(false);
        RefM.SetActive(true);
        RefP2.SetActive(false);
        RefM2.SetActive(true);
        RefP3.SetActive(false);
        RefM3.SetActive(true);

        ConP.SetActive(false);
        ConM.SetActive(true);
        ConP2.SetActive(false);
        ConM2.SetActive(true);
        ConP3.SetActive(false);
        ConM3.SetActive(true);

        XpFreeP.SetActive(false);
        XpFreeM.SetActive(true);
        DollarsBtn.SetActive(true);
        DollarsBtn2.SetActive(true);
        DollarsBtn3.SetActive(true);
        XpFreePM.text = "+ XP";
    }
    public void xpFreeM()
    {
        PandM = 0;
        BisonP.SetActive(true);
        BisonM.SetActive(false);
        BisonP2.SetActive(true);
        BisonM2.SetActive(false);
        BisonP3.SetActive(true);
        BisonM3.SetActive(false);

        DubP.SetActive(true);
        DubM.SetActive(false);
        DubP2.SetActive(true);
        DubM2.SetActive(false);
        DubP3.SetActive(true);
        DubM3.SetActive(false);

        FIIVP.SetActive(true);
        FIIVM.SetActive(false);
        FIIVP2.SetActive(true);
        FIIVM2.SetActive(false);
        FIIVP3.SetActive(true);
        FIIVM3.SetActive(false);

        HORSEP.SetActive(true);
        HORSEM.SetActive(false);
        HORSEP2.SetActive(true);
        HORSEM2.SetActive(false);
        HORSEP3.SetActive(true);
        HORSEM3.SetActive(false);

        RIDGEP.SetActive(true);
        RIDGEM.SetActive(false);
        RIDGEP2.SetActive(true);
        RIDGEM2.SetActive(false);
        RIDGEP3.SetActive(true);
        RIDGEM3.SetActive(false);

        BoardP.SetActive(true);
        BoardM.SetActive(false);
        BoardP2.SetActive(true);
        BoardM2.SetActive(false);
        BoardP3.SetActive(true);
        BoardM3.SetActive(false);

        TentP.SetActive(true);
        TentM.SetActive(false);
        TentP2.SetActive(true);
        TentM2.SetActive(false);
        TentP3.SetActive(true);
        TentM3.SetActive(false);

        RefP.SetActive(true);
        RefM.SetActive(false);
        RefP2.SetActive(true);
        RefM2.SetActive(false);
        RefP3.SetActive(true);
        RefM3.SetActive(false);

        ConP.SetActive(true);
        ConM.SetActive(false);
        ConP2.SetActive(true);
        ConM2.SetActive(false);
        ConP3.SetActive(true);
        ConM3.SetActive(false);

        XpFreeP.SetActive(true);
        XpFreeM.SetActive(false);
        DollarsBtn.SetActive(false);
        DollarsBtn2.SetActive(false);
        DollarsBtn3.SetActive(false);
        XpFreePM.text = "- XP";
    }

    private void Start()
    {
        xpFreeM();
    }
    void Update()
    {
        DollarsInt = Main.Dollars;
        DollarsTx.text = DollarsInt.ToString("0" + " $");

        if (PandM == 0)
        {
            XpFreeFt = Main.BankXpFree;
            XpFreeTx.text = XpFreeFt.ToString("0" + " XP ->");
        }
        else if (PandM == 1)
        {
            XpFreeFt = Main.BankXpFree;
            XpFreeTx.text = XpFreeFt.ToString("0" + " XP <-");
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
    }
}
