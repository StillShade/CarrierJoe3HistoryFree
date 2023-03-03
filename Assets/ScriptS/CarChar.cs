using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChar : MonoBehaviour
{
	[Header("Engines")]
	public int Engine;
	public int checkEngine;
	public int charMaxTrust;
	public GameObject Engine1;
	public GameObject Engine2;
	public GameObject Engine3;
	public int priceEngine;
	[Header("Gearbox")]
	public int Gearbox;
	public int checkGearbox;
	public int charGearboxSpeed;
	public GameObject Gearbox1;
	public GameObject Gearbox2;
	public GameObject Gearbox3;
	public int priceGearbox;
	[Header("Brake")]
	public int Brake;
	public int checkBrake;
	public int charBrake;
	public int checCharBrake;
	public GameObject Brake1;
	public GameObject Brake2;
	public GameObject Brake3;
	public int priceBrake;
	[Header("FuelTank")]
	public int FuelTank;
	public int checkFuelTank;
	public int charFuelTank;
	public GameObject FuelTank1;
	public GameObject FuelTank2;
	public GameObject FuelTank3;
	public int priceFuelTank;
	[Header("RearBogie")]
	public int RearBogie;
	public int checkRearBogie;
	public int charRearBogie;
	public GameObject RearBogie1;
	public GameObject RearBogie2;
	public GameObject RearBogie3;
	public int priceRearBogie;
	[Header("ExternalTuning")]
	public int ExternalTuning;
	public int checkExternalTuning;
	public int charExternalTuning;
	public GameObject ExternalTuning1;
	public GameObject ExternalTuning2;
	public GameObject ExternalTuning3;
	public int priceExternalTuning;
	[Header("Цена")]
	public int priceMoney;
	[Header("Опыт")]
	public int priceXp;
	[Header("Вес")]
	public float weightCar;
	[Header("Допустимый вес")]
	public float allowableWeight;
	public float effectLoadTruck;
	[Header("Максимальная скорость")]
	public float realSpeedCal;
	public float maxSpeed;
	public int AKPP;
	[Header("Максимальная мощность")]
	public float horse;
	public float maxAcceleration;
	[Header("Тяга в гору")]
    public float maxThrustCar;
	public float effectThrustCar;
	[Header("Задняя скорость")]
	public float backSpeed;
	[Header("Сопротивление")]
	public float deacceleration;
	[Header("Сила тормоза")]
	public float brakeForce;
	[Header("Топливный бак в литрах")]
	public float fuelMax;
	[Header("Расход топлива")]
	public float fuelConsumption;
	[Header("Свободный опыт")]
	public float coefPrizeXpFree;
	[Header("Седло")]
	public GameObject pnlTrailer;
	public int pricepNumber;
	public GameObject sedlo;
	


	private void Start()
    {
		checkEngine = Engine;
		checkGearbox = Gearbox;
		checkBrake = Brake;
		checkFuelTank = FuelTank;
		checkRearBogie = RearBogie;
		checkExternalTuning = ExternalTuning;
	}

    public void OnEngine()
	{
		switch (Engine)
		{
			case 1:
				Engine1.SetActive(true);
				Engine2.SetActive(false);
				Engine3.SetActive(false);
				break;
			case 2:
				Engine1.SetActive(false);
				Engine2.SetActive(true);
				Engine3.SetActive(false);
				break;
			case 3:
				Engine1.SetActive(false);
				Engine2.SetActive(false);
				Engine3.SetActive(true);
				break;
		}
	}

	public void OnGearbox()
    {
		switch (Gearbox)
		{
			case 1:
				Gearbox1.SetActive(true);
				Gearbox2.SetActive(false);
				Gearbox3.SetActive(false);
				break;
			case 2:
				Gearbox1.SetActive(false);
				Gearbox2.SetActive(true);
				Gearbox3.SetActive(false);
				break;
			case 3:
				Gearbox1.SetActive(false);
				Gearbox2.SetActive(false);
				Gearbox3.SetActive(true);
				break;
		}
	}

	public void OnBrake()
	{
		switch (Brake)
		{
			case 1:
				Brake1.SetActive(true);
				Brake2.SetActive(false);
				Brake3.SetActive(false);
				break;
			case 2:
				Brake1.SetActive(false);
				Brake2.SetActive(true);
				Brake3.SetActive(false);
				break;
			case 3:
				Brake1.SetActive(false);
				Brake2.SetActive(false);
				Brake3.SetActive(true);
				break;
		}
	}
	public void OnFuelTank()
	{
		switch (FuelTank)
		{
			case 1:
				FuelTank1.SetActive(true);
				FuelTank2.SetActive(false);
				FuelTank3.SetActive(false);
				break;
			case 2:
				FuelTank1.SetActive(false);
				FuelTank2.SetActive(true);
				FuelTank3.SetActive(false);
				break;
			case 3:
				FuelTank1.SetActive(false);
				FuelTank2.SetActive(false);
				FuelTank3.SetActive(true);
				break;
		}
	}
	public void OnRearBogie()
	{
		switch (RearBogie)
		{
			case 1:
				RearBogie1.SetActive(true);
				RearBogie2.SetActive(false);
				RearBogie3.SetActive(false);
				break;
			case 2:
				RearBogie1.SetActive(false);
				RearBogie2.SetActive(true);
				RearBogie3.SetActive(false);
				break;
			case 3:
				RearBogie1.SetActive(false);
				RearBogie2.SetActive(false);
				RearBogie3.SetActive(true);
				break;
		}
	}
	public void OnExternalTuning()
    {
        switch (ExternalTuning)
        {
			case 1:
				ExternalTuning1.SetActive(true);
				ExternalTuning2.SetActive(false);
				ExternalTuning3.SetActive(false);
				break;
			case 2:
				ExternalTuning1.SetActive(false);
				ExternalTuning2.SetActive(true);
				ExternalTuning3.SetActive(true);
				break;
		}
    }

	public void ChangeEngine()
    {
		switch (Engine)
		{
			case 1:
				OnEngine();
				horse = Engine1.GetComponent<Engine>().horse;
				maxAcceleration = Engine1.GetComponent<Engine>().maxAcceleration;
				maxThrustCar = Engine1.GetComponent<Engine>().maxThrustCar;
				fuelConsumption = Engine1.GetComponent<Engine>().fuelConsumption;
				priceEngine = Engine1.GetComponent<Engine>().priceMoneyEngine;
				CharMaxTrust();
				CharGearBoxSpeed();
				break;
			case 2:
				OnEngine();
				horse = Engine2.GetComponent<Engine>().horse;
				maxAcceleration = Engine2.GetComponent<Engine>().maxAcceleration;
				maxThrustCar = Engine2.GetComponent<Engine>().maxThrustCar;
				fuelConsumption = Engine2.GetComponent<Engine>().fuelConsumption;
				priceEngine = Engine2.GetComponent<Engine>().priceMoneyEngine;
				CharMaxTrust();
				CharGearBoxSpeed();
				break;
			case 3:
				OnEngine();
				horse = Engine3.GetComponent<Engine>().horse;
				maxAcceleration = Engine3.GetComponent<Engine>().maxAcceleration;
				maxThrustCar = Engine3.GetComponent<Engine>().maxThrustCar;
				fuelConsumption = Engine3.GetComponent<Engine>().fuelConsumption;
				priceEngine = Engine3.GetComponent<Engine>().priceMoneyEngine;
				CharMaxTrust();
				CharGearBoxSpeed();
				break;
		}
	}
	public void CharMaxTrust()
	{
		if (maxThrustCar <= 110 && maxThrustCar >= 85) charMaxTrust = 1;
		else if (maxThrustCar <= 84 && maxThrustCar >= 72) charMaxTrust = 2;
		else if (maxThrustCar <= 71 && maxThrustCar >= 59) charMaxTrust = 3;
		else if (maxThrustCar <= 58 && maxThrustCar >= 46) charMaxTrust = 4;
		else if (maxThrustCar <= 45 && maxThrustCar >= 30) charMaxTrust = 5;
	}
	public void ChangeGearbox()
	{
		switch (Gearbox)
		{
			case 1:
				OnGearbox();
				priceGearbox = Gearbox1.GetComponent<Gearbox>().priceMoneyGearbox;
				maxSpeed = Gearbox1.GetComponent<Gearbox>().maxSpeed;
				effectThrustCar = Gearbox1.GetComponent<Gearbox>().effectThrustCar;
				AKPP = Gearbox1.GetComponent<Gearbox>().AKPP;
				maxThrustCar = effectThrustCar * maxThrustCar;
				CharMaxTrust();
				CharGearBoxSpeed();
				checkGearbox = 1;
				break;
			case 2:
				OnGearbox();
				priceGearbox = Gearbox2.GetComponent<Gearbox>().priceMoneyGearbox;
				maxSpeed = Gearbox2.GetComponent<Gearbox>().maxSpeed;
				effectThrustCar = Gearbox2.GetComponent<Gearbox>().effectThrustCar;
				AKPP = Gearbox2.GetComponent<Gearbox>().AKPP;
				maxThrustCar = effectThrustCar * maxThrustCar;
				CharMaxTrust();
				CharGearBoxSpeed();
				checkGearbox = 2;
				break;
			case 3:
				OnGearbox();
				priceGearbox = Gearbox3.GetComponent<Gearbox>().priceMoneyGearbox;
				maxSpeed = Gearbox3.GetComponent<Gearbox>().maxSpeed;
				effectThrustCar = Gearbox3.GetComponent<Gearbox>().effectThrustCar;
				AKPP = Gearbox3.GetComponent<Gearbox>().AKPP;
				maxThrustCar = effectThrustCar * maxThrustCar;
				CharMaxTrust();
				CharGearBoxSpeed();
				checkGearbox = 3;
				break;
		}
	}
	public void CharGearBoxSpeed()
	{
		if (maxAcceleration >= 0 && maxAcceleration <= 349) charGearboxSpeed = 1;
		else if (maxAcceleration >= 350 && maxAcceleration <= 419) charGearboxSpeed = 2;
		else if (maxAcceleration >= 420 && maxAcceleration <= 499) charGearboxSpeed = 3;
		else if (maxAcceleration >= 500 && maxAcceleration <= 599) charGearboxSpeed = 4;
		else if (maxAcceleration >= 600 && maxAcceleration <= 750) charGearboxSpeed = 5;
	}
	public void ChangeBrake()
	{
		switch (Brake)
		{
			case 1:
				OnBrake();
				priceBrake = Brake1.GetComponent<Brake>().priceMoneyBrake;
				brakeForce = Brake1.GetComponent<Brake>().brakeForce;
				CharBrake();
				checkBrake = 1;
				break;
			case 2:
				OnBrake();
				priceBrake = Brake2.GetComponent<Brake>().priceMoneyBrake;
				brakeForce = Brake2.GetComponent<Brake>().brakeForce;
				CharBrake();
				checkBrake = 2;
				break;
			case 3:
				OnBrake();
				priceBrake = Brake3.GetComponent<Brake>().priceMoneyBrake;
				brakeForce = Brake3.GetComponent<Brake>().brakeForce;
				CharBrake();
				checkBrake = 3;
				break;
		}
	}
	public void CharBrake()
    {
		if (brakeForce >= 0 && brakeForce <= 399) charBrake = 1;
		else if (brakeForce >= 400 && brakeForce <= 469) charBrake = 2;
		else if (brakeForce >= 470 && brakeForce <= 549) charBrake = 3;
		else if (brakeForce >= 550 && brakeForce <= 649) charBrake = 4;
		else if (brakeForce >= 650 && brakeForce <= 750) charBrake = 5;
	}
	public void ChangeFuelTank()
	{
		switch (FuelTank)
		{
			case 1:
				OnFuelTank();
				priceFuelTank = FuelTank1.GetComponent<FuelTank>().priceMoneyFuelTank;
				fuelMax = FuelTank1.GetComponent<FuelTank>().fuelMax;
				checkFuelTank = 1;
				break;
			case 2:
				OnFuelTank();
				priceFuelTank = FuelTank2.GetComponent<FuelTank>().priceMoneyFuelTank;
				fuelMax = FuelTank2.GetComponent<FuelTank>().fuelMax;
				checkFuelTank = 2;
				break;
			case 3:
				OnFuelTank();
				priceFuelTank = FuelTank3.GetComponent<FuelTank>().priceMoneyFuelTank;
				fuelMax = FuelTank3.GetComponent<FuelTank>().fuelMax;
				checkFuelTank = 3;
				break;
		}
	}
	public void ChangeRearBogie()
	{
		switch (RearBogie)
		{
			case 1:
				OnRearBogie();
				priceRearBogie = RearBogie1.GetComponent<RearBogie>().priceMoneyRearBogie;
				allowableWeight = RearBogie1.GetComponent<RearBogie>().allowableWeight;
				effectLoadTruck = 1f;
				checkRearBogie = 1;
				break;
			case 2:
				OnRearBogie();
				priceRearBogie = RearBogie2.GetComponent<RearBogie>().priceMoneyRearBogie;
				allowableWeight = RearBogie2.GetComponent<RearBogie>().allowableWeight;
				effectLoadTruck = 0.75f;
				checkRearBogie = 2;
				break;
			case 3:
				OnRearBogie();
				priceRearBogie = RearBogie3.GetComponent<RearBogie>().priceMoneyRearBogie;
				allowableWeight = RearBogie3.GetComponent<RearBogie>().allowableWeight;
				effectLoadTruck = 0.5f;
				checkRearBogie = 3;
				break;
		}
	}
	public void ChangeExternalTuning()
    {
        switch (ExternalTuning)
        {
			case 1:
				OnExternalTuning();
				priceExternalTuning = ExternalTuning1.GetComponent<ExternalTuning>().priceExternalTuning;
				coefPrizeXpFree = ExternalTuning1.GetComponent<ExternalTuning>().coefPrizeXpFree;
				Main.CoefPrizeXpFree = coefPrizeXpFree;
				break;
			case 2:
				OnExternalTuning();
				priceExternalTuning = ExternalTuning3.GetComponent<ExternalTuning>().priceExternalTuning;
				coefPrizeXpFree = ExternalTuning3.GetComponent<ExternalTuning>().coefPrizeXpFree;
				Main.CoefPrizeXpFree = coefPrizeXpFree;
				break;
		}
    }

	private void Update()
	{
		pricepNumber = Main.PrcNumber;
		if (pricepNumber == 0) sedlo.SetActive(true);
		else sedlo.SetActive(false);

		Engine = Main.Engine;
		Gearbox = Main.Gearbox;
		Main.AKPP = AKPP;
		Brake = Main.Brake;
		FuelTank = Main.FuelTank;
		RearBogie = Main.RearBogie;
		ExternalTuning = Main.ExternalTuning;

		if (checkEngine != Engine)
        {
			ChangeEngine();
        }

		if (checkGearbox != Gearbox)
        {
			ChangeGearbox();
        }
		
		if (checkBrake != Brake)
        {
			ChangeBrake();
        }

		if (checkFuelTank != FuelTank)
        {
			ChangeFuelTank();
        }

		if (checkRearBogie != RearBogie)
		{
			ChangeRearBogie();
		}

		if (checkExternalTuning != ExternalTuning)
        {
			ChangeExternalTuning();
        }
	}
}
