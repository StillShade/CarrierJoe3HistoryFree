using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitchhikerPnl : MonoBehaviour
{    
    public GameObject hitchhikerPnl;    
    public Text text;
    public Text textFinish;

    public int rndPrize;
    public int rndRuly;
    public int rndXp;
    public int rndDollars;

    public void ActiveRndHitchhiker()
    {
        Main.PrizeHitchhikerD = 0;
        Main.PrizeHitchhikerX = 0;
        Main.PrizeHitchhikerR = 0;
        rndPrize = Random.Range(1, 101);
        if (rndPrize >= 1 && rndPrize <= 6)
            rndDollars = Random.Range(1, 6);
        if (rndPrize >= 7 && rndPrize <= 35)
            rndXp = Random.Range(25, 101);
        if (rndPrize >= 36 && rndPrize <= 100)
            rndRuly = Random.Range(500, 5001);

        ActiveHitchhiker();
    }
    
    public void ActiveHitchhiker()
    {
        if (rndPrize >= 1 && rndPrize <= 6)
        {
            text.color = Color.green;
            text.text = rndDollars + " $";
        }
        if (rndPrize >= 7 && rndPrize <= 35)
        {
            text.text = rndXp + " XP";
        }
        if (rndPrize >= 36 && rndPrize <= 100)
        {
            text.color = Color.yellow;
            text.text = rndRuly + " R";
        }
        textFinish.color = text.color;
        textFinish.text = text.text;
    }

    public void HitchhikerOk()
    {
        Main.Hitchhiker = 1;

        if (rndPrize >= 1 && rndPrize <= 6)
            Main.Dollars += rndDollars;
        if (rndPrize >= 7 && rndPrize <= 35)
            Main.BankXpFree += rndXp;
        if (rndPrize >= 36 && rndPrize <= 100)
            Main.Money += rndRuly;


        hitchhikerPnl.SetActive(false);
    }    
}
