using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Azsscript : MonoBehaviour {

	public GameObject AzsPnl;
	//public GameObject NotMoney;
	public GameObject pnlTruck;

	public float speed;
	public int clickBuyFuel;	
	public float fuel;
	public float fuelMax;	
	public float price;
	public float targetfuel;
	public int litri;
	public int dengi;

	public GameObject azsSound;

	public bool pokupaem = false;

	public Text litritext;
	public Text dengitext;

    public void SetNewParams () {
		switch (Main.CarNumber)
        {
			case 1:
				Main.FuelBison200 = fuel;
				break;
			case 2:
				Main.FuelBison500 = fuel;
				break;
			case 3:
				Main.FuelBison5432 = fuel;
				break;
			case 4:
				Main.FuelBison6422 = fuel;
				break;
			case 5:
				Main.FuelBison6430 = fuel;
				break;
			case 6:
				Main.FuelBison6440 = fuel;
				break;
			case 7:
				Main.FuelBison5440 = fuel;
				break;
			case 8:
				Main.FuelDUB157 = fuel;
				break;
			case 9:
				Main.FuelDUB131 = fuel;
				break;
			case 10:
				Main.FuelDUB130 = fuel;
				break;
			case 11:
				Main.FuelDUB133 = fuel;
				break;
			case 12:
				Main.FuelDUB4421 = fuel;
				break;
			case 13:
				Main.FuelDUB5423 = fuel;
				break;
			case 14:
				Main.FuelFIIV690 = fuel;
				break;
			case 15:
				Main.FuelFIIV619 = fuel;
				break;
			case 16:
				Main.FuelFIIVTS = fuel;
				break;
			case 17:
				Main.FuelFIIVES = fuel;
				break;
			case 18:
				Main.FuelFIIVST = fuel;
				break;
			case 19:
				Main.FuelFIIVSTR = fuel;
				break;
			case 20:
				Main.FuelFIIVHW = fuel;
				break;
			case 21:
				Main.FuelFIIVSW = fuel;
				break;
			case 22:
				Main.FuelHORSE5410 = fuel;
				break;
			case 23:
				Main.FuelHORSE6460 = fuel;
				break;
			case 24:
				Main.FuelHORSE5460 = fuel;
				break;
			case 25:
				Main.FuelHORSE1840 = fuel;
				break;
			case 26:
				Main.FuelHORSE1855 = fuel;
				break;
			case 27:
				Main.FuelRIDGE375 = fuel;
				break;
			case 28:
				Main.FuelRIDGE4420 = fuel;
				break;
			case 29:
				Main.FuelRIDGE6370 = fuel;
				break;
			case 30:
				Main.FuelRIDGENX = fuel;
				break;
			case 101:
				Main.FuelFORBCARGO = fuel;
				break;
			case 102:
				Main.FuelFORBFMAX = fuel;
				break;
		}		
	}


	public void BuyToplivo () {
		targetfuel = fuelMax - fuel;
		pokupaem = true;
	}
	public void CloseNotMoney() 
	{ 
		//NotMoney.SetActive(false); 
	}

	public void ChekCar()
    {
		switch (Main.CarNumber)
		{
			case 1:
				fuel = Main.FuelBison200;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 2:
				fuel = Main.FuelBison500;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 3:
				fuel = Main.FuelBison5432;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 4:
				fuel = Main.FuelBison6422;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 5:
				fuel = Main.FuelBison6430;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 6:
				fuel = Main.FuelBison6440;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 7:
				fuel = Main.FuelBison5440;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 8:
				fuel = Main.FuelDUB157;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 9:
				fuel = Main.FuelDUB131;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 10:
				fuel = Main.FuelDUB130;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 11:
				fuel = Main.FuelDUB133;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 12:
				fuel = Main.FuelDUB4421;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 13:
				fuel = Main.FuelDUB5423;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 14:
				fuel = Main.FuelFIIV690;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 15:
				fuel = Main.FuelFIIV619;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 16:
				fuel = Main.FuelFIIVTS;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 17:
				fuel = Main.FuelFIIVES;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 18:
				fuel = Main.FuelFIIVST;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 19:
				fuel = Main.FuelFIIVSTR;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 20:
				fuel = Main.FuelFIIVHW;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 21:
				fuel = Main.FuelFIIVSW;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 22:
				fuel = Main.FuelHORSE5410;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 23:
				fuel = Main.FuelHORSE6460;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 24:
				fuel = Main.FuelHORSE5460;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 25:
				fuel = Main.FuelHORSE1840;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 26:
				fuel = Main.FuelHORSE1855;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 27:
				fuel = Main.FuelRIDGE375;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 28:
				fuel = Main.FuelRIDGE4420;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 29:
				fuel = Main.FuelRIDGE6370;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 30:
				fuel = Main.FuelRIDGENX;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 101:
				fuel = Main.FuelFORBCARGO;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
			case 102:
				fuel = Main.FuelFORBFMAX;
				fuelMax = pnlTruck.GetComponent<PnlTruck>().fuelMax;
				break;
		}
	}

	void Update () 
	{
		clickBuyFuel = Main.BuyFuel;
		speed = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Movecar>().speed;

		ChekCar();

		if (clickBuyFuel == 1)
        {
			BuyToplivo();
        }
		
		if (clickBuyFuel == 1)
        {
			if (pokupaem)
			{
				if (targetfuel > 0)
				{
					targetfuel--;
					fuel++;
					litri++;
					dengi += (int)price;
					Main.Money -= (int)price;
					azsSound.SetActive(true);
					//if (Main.Money >= (int)price)
					//{
						
					//}
					//else
					//{
					//	pokupaem = false;
					//	azsSound.SetActive(false);
					//	NotMoney.SetActive(true);
					//}
				}
				else
				{
					pokupaem = false;
					azsSound.SetActive(false);
				}
			}
		}
        else
        {
			azsSound.SetActive(false);
		}

		SetNewParams();
		litritext.text = litri.ToString() + " L";
		dengitext.text = dengi.ToString() + " R";
	}
	public void CloseAZS()
	{
		pnlTruck.SetActive(false);
		litri = 0;
		dengi = 0;
		AzsPnl.SetActive(false);		
	}
	void OnTriggerStay2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			if (speed <= 1)
			{
				pnlTruck.SetActive(true);
				AzsPnl.SetActive(true);
			}
			else
			{
				CloseAZS();
			}
		}
	}
}


