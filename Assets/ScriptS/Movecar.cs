using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.UI;

public class Movecar : MonoBehaviour {

	public GameObject mainCamera;
	public float dampTime = 0.1f;
	private Vector3 velocity = Vector3.zero;
	public Transform target;	
	public float CamX = 0f;
	public float CamY = 0f;
	public float CamZ = 0f;
	public bool camLeft = false;
	public bool camRight = false;
	public bool camZoomPlus = false;
	public bool camZoomMinus = false;
	
	WheelJoint2D[] wheelJoints;
	JointMotor2D frontWheel;
	JointMotor2D backWheel;
	JointMotor2D backWheel2;

	WheelJoint2D[] wheelJointsTrailer;
	JointMotor2D wheel1;
	JointMotor2D wheel2;
	JointMotor2D wheel3;
	JointMotor2D wheel4;

	public int carNumber;
	public int prcNumber;
	GameObject prefCarClon;
	GameObject prefPrcClon;

	public GameObject pnlUpravlenie;
	public GameObject gazTurn;
	public int changeTrailer;
	[Header("Грузовики")]
	public GameObject nullObj;
	public GameObject Bison200;
	public GameObject Bison500;
	public GameObject Bison5432;
	public GameObject Bison6422;
	public GameObject Bison6430;
	public GameObject Bison6440;
	public GameObject Bison5440;

	public GameObject DUB157;
	public GameObject DUB131;
	public GameObject DUB130;
	public GameObject DUB133;
	public GameObject DUB4421;
	public GameObject DUB5423;

	public GameObject FIIV690;
	public GameObject FIIV619;
	public GameObject FIIVTS;
	public GameObject FIIVES;
	public GameObject FIIVST;
	public GameObject FIIVSTR;
	public GameObject FIIVHW;
	public GameObject FIIVSW;

	public GameObject HORSE5410;
	public GameObject HORSE6460;
	public GameObject HORSE5460;
	public GameObject HORSE1840;
	public GameObject HORSE1855;

	public GameObject RIDGE375;
	public GameObject RIDGE4420;
	public GameObject RIDGE6370;
	public GameObject RIDGENX;

	public GameObject FORBCARGO;
	public GameObject FORBFMAX;
	[Header("Прицепы")]
	public GameObject nullObjTrailer;
	public GameObject B1;
	public GameObject B2;
	public GameObject B3;
	public GameObject B4;
	public GameObject B5;
	public GameObject B6;
	public GameObject B7;
	public GameObject T1;
	public GameObject T2;
	public GameObject T3;
	public GameObject T4;
	public GameObject T5;
	public GameObject T6;
	public GameObject T7;
	public GameObject R1;
	public GameObject R2;
	public GameObject R3;
	public GameObject R4;
	public GameObject R5;
	public GameObject R6;
	public GameObject C1;
	public GameObject C2;
	public GameObject C3;
	public GameObject C4;
	public GameObject C5;
	public GameObject ST1;
	public GameObject ST2;
	public GameObject ST3;
	[Header("Зажигание")]
	public int indicator;
	public GameObject IgnitionOn;
	public GameObject IgnitionOff;
	public GameObject BlockGaz;
	public GameObject OnZag;	
	[Header("Вес")]
	public float weightCar;
	public float weightTrailer;
	public float allowableWeight;
	[Header("Разное")]
	public float kilometers;
	public GameObject smallFuel;
	public float fuelMax;
    public float fuel;
	[Header("Fuel Bison")]
	private float fuelBison200;
	private float fuelBison500;
	private float fuelBison5432;
	private float fuelBison6422;
	private float fuelBison6430;
	private float fuelBison6440;
	private float fuelBison5440;
	[Header("Fuel DUB")]
	private float fuelDUB157;
	private float fuelDUB131;
	private float fuelDUB130;
	private float fuelDUB133;
	private float fuelDUB4421;
	private float fuelDUB5423;
	[Header("Fuel FIIV")]
	private float fuelFIIV690;
	private float fuelFIIV619;
	private float fuelFIIVTS;
	private float fuelFIIVES;
	private float fuelFIIVST;
	private float fuelFIIVSTR;
	private float fuelFIIVHW;
	private float fuelFIIVSW;
	[Header("Fuel HORSE")]
	private float fuelHORSE5410;
	private float fuelHORSE6460;
	private float fuelHORSE5460;
	private float fuelHORSE1840;
	private float fuelHORSE1855;
	[Header("Fuel RIDGE")]
	private float fuelRIDGE375;
	private float fuelRIDGE4420;
	private float fuelRIDGE6370;
	private float fuelRIDGENX;
	[Header("Fuel PREMIUM")]
	private float fuelFORBCARGO;
	private float fuelFORBFMAX;
	[Header("Разное")]
	public float fuelConsumption;
	public float carAcceleration;
	public float carSpeed;
	private float minSpeed = 1;
	private float realSpeedCal;
	private float maxSpeed;	
	private float maxAcceleration;	
	private float maxThrustCar;
	public float thrustCar;
	public float loadTruck;
	public float effectLoadTruck;

	private float backSpeed;
	private float deacceleration;
	public float brakeForce;
	private float gravity = 9.8f;
	private float angleCar = 0f;


	private Vector3 startpos = new Vector3(0f, 1.7f, 0f);
	private Vector3 curpos;

	public AudioSource breakSound1;
	public AudioSource breakSound2;
	public AudioSource KPP;	
	public AudioSource[] carSound;	

	public bool turnUp;
	
	public float turnovers;
	public int AKPP;
	public GameObject AKPP_pnl;
	public GameObject gearR_BLOK_AKPP;
	public GameObject gear1_AKPP;
	public GameObject gearN_AKPP;
	public GameObject gearR_AKPP;
	public GameObject gearN;
	public GameObject gear1;
	public GameObject gear2;
	public GameObject gear3;
	public GameObject gear4;
	public GameObject gearR;
	public GameObject gearR_BLOK;
	public GameObject gear1_BLOK;
	public GameObject gear2_BLOK;
	public GameObject gear3_BLOK;
	public GameObject gear4_BLOK;
	public Text gearOn;

	private int Gear = 0;

	public int kiloint;

	public Text kmtext;

	public float speed;
	public float realSpeed;
	public float speedTrailer;

	public GameObject strelka;
	public GameObject strelkaTurn;
	public GameObject strelkaTurnOff;
	public GameObject fuelstrelka;

	public bool accelclickedIs = false;
	public bool brakeclickedIs = false;
		
	[Header("Loading")]
	public GameObject Load;

	public float pos;

	void Awake()
	{
		//if (Main.SpecCargo == 1 || Main.PrcNumber >= 100)
		//{
		//	ST1.SetActive(false);
		//	ST2.SetActive(false);
		//	ST3.SetActive(false);
		//	Main.SpecCargo = 0;
		//	Main.CargoCondition = 0;
		//	Main.PrcNumber = 0;
		//}

		carNumber = Main.CarNumber;
		prcNumber = Main.PrcNumber;
		Main.MuteAudio = 1;		
	}

	void Start()
	{
		CamX = Main.camX;
        CamY = Main.camY;
        CamZ = Main.camZ;

		Main.LightOn = 0;

		if (Main.SpecCargo == 1 || Main.PrcNumber >= 100)
		{
			ST1.SetActive(false);
			ST2.SetActive(false);
			ST3.SetActive(false);
			Main.SpecCargo = 0;
			Main.CargoCondition = 0;
			Main.PrcNumber = 0;
		}

		carNumber = Main.CarNumber;
		switch (carNumber)
		{
			case 0:
				nullObj.SetActive(true);
				break;
			case 1:
				Bison200.SetActive(true);				
				break;
			case 2:
				Bison500.SetActive(true);
				break;
			case 3:
				Bison5432.SetActive(true);
				break;
			case 4:
				Bison6422.SetActive(true);
				break;
			case 5:
				Bison6430.SetActive(true);
				break;
			case 6:
				Bison6440.SetActive(true);
				break;
			case 7:
				Bison5440.SetActive(true);
				break;
			case 8:
				DUB157.SetActive(true);
				break;
			case 9:
				DUB131.SetActive(true);
				break;
			case 10:
				DUB130.SetActive(true);
				break;
			case 11:
				DUB133.SetActive(true);
				break;
			case 12:
				DUB4421.SetActive(true);
				break;
			case 13:
				DUB5423.SetActive(true);
				break;
			case 14:
				FIIV690.SetActive(true);
				break;
			case 15:
				FIIV619.SetActive(true);
				break;
			case 16:
				FIIVTS.SetActive(true);
				break;
			case 17:
				FIIVES.SetActive(true);
				break;
			case 18:
				FIIVST.SetActive(true);
				break;
			case 19:
				FIIVSTR.SetActive(true);
				break;
			case 20:
				FIIVHW.SetActive(true);
				break;
			case 21:
				FIIVSW.SetActive(true);
				break;
			case 22:
				HORSE5410.SetActive(true);
				break;
			case 23:
				HORSE6460.SetActive(true);
				break;
			case 24:
				HORSE5460.SetActive(true);
				break;
			case 25:
				HORSE1840.SetActive(true);
				break;
			case 26:
				HORSE1855.SetActive(true);
				break;
			case 27:
				RIDGE375.SetActive(true);
				break;
			case 28:
				RIDGE4420.SetActive(true);
				break;
			case 29:
				RIDGE6370.SetActive(true);
				break;
			case 30:
				RIDGENX.SetActive(true);
				break;
			case 101:
				FORBCARGO.SetActive(true);
				break;
			case 102:
				FORBFMAX.SetActive(true);
				break;
		}
		fuelDUB157 = Main.FuelDUB157;
		fuelDUB131 = Main.FuelDUB131;
		fuelDUB130 = Main.FuelDUB130;
		fuelDUB133 = Main.FuelDUB133;
		fuelDUB4421 = Main.FuelDUB4421;
		fuelDUB5423 = Main.FuelDUB5423;
		fuelBison200 = Main.FuelBison200;
		fuelBison500 = Main.FuelBison500;
		fuelBison5432 = Main.FuelBison5432;
		fuelBison6422 = Main.FuelBison6422;
		fuelBison6430 = Main.FuelBison6430;
		fuelBison6440 = Main.FuelBison6440;
		fuelBison5440 = Main.FuelBison5440;
		fuelFIIV690 = Main.FuelFIIV690;
		fuelFIIV619 = Main.FuelFIIV619;
		fuelFIIVTS = Main.FuelFIIVTS;
		fuelFIIVES = Main.FuelFIIVES;
		fuelFIIVST = Main.FuelFIIVST;
		fuelFIIVSTR = Main.FuelFIIVSTR;
		fuelFIIVHW = Main.FuelFIIVHW;
		fuelFIIVSW = Main.FuelFIIVSW;
		fuelHORSE5410 = Main.FuelHORSE5410;
		fuelHORSE6460 = Main.FuelHORSE6460;
		fuelHORSE5460 = Main.FuelHORSE5460;
		fuelHORSE1840 = Main.FuelHORSE1840;
		fuelHORSE1855 = Main.FuelHORSE1855;
		fuelRIDGE375 = Main.FuelRIDGE375;
		fuelRIDGE4420 = Main.FuelRIDGE4420;
		fuelRIDGE6370 = Main.FuelRIDGE6370;
		fuelRIDGENX = Main.FuelRIDGENX;
		fuelFORBCARGO = Main.FuelFORBCARGO;
		fuelFORBFMAX = Main.FuelFORBFMAX;

		prcNumber = Main.PrcNumber;		

		switch (prcNumber)
		{
			case 0:
				nullObjTrailer.SetActive(true);
				break;
			case 1:
				B1.SetActive(true);
				break;
			case 2:
				B2.SetActive(true);
				break;
			case 3:
				B3.SetActive(true);
				break;
			case 4:
				B4.SetActive(true);
				break;
			case 5:
				B5.SetActive(true);
				break;
			case 6:
				B6.SetActive(true);
				break;
			case 7:
				B7.SetActive(true);
				break;
			case 8:
				T1.SetActive(true);
				break;
			case 9:
				T2.SetActive(true);
				break;
			case 10:
				T3.SetActive(true);
				break;
			case 11:
				T4.SetActive(true);
				break;
			case 12:
				T5.SetActive(true);
				break;
			case 13:
				T6.SetActive(true);
				break;
			case 14:
				T7.SetActive(true);
				break;
			case 15:
				R1.SetActive(true);
				break;
			case 16:
				R2.SetActive(true);
				break;
			case 17:
				R3.SetActive(true);
				break;
			case 18:
				R4.SetActive(true);
				break;
			case 19:
				R5.SetActive(true);
				break;
			case 20:
				R6.SetActive(true);
				break;
			case 21:
				C1.SetActive(true);
				break;
			case 22:
				C2.SetActive(true);
				break;
			case 23:
				C3.SetActive(true);
				break;
			case 24:
				C4.SetActive(true);
				break;
			case 25:
				C5.SetActive(true);
				break;
			case 100:
				ST1.SetActive(true);
				break;
			case 101:
				ST2.SetActive(true);
				break;
			case 102:
				ST3.SetActive(true);
				break;
		}
		curpos = startpos;
		Gear = 0;
		indicator = 1;
	}

	public void Acceler() {
		accelclickedIs = true;
		DeBraker();
		Main.TruckSmoke = 1;
	}

	public void Deacceler() {
		accelclickedIs = false;
		Main.TruckSmoke = 0;
	}


	public void Braker() {
		brakeclickedIs = true;
		breakSound1.Play();
		Main.LightOnStop = 1;
	}

	public void DeBraker() {
		brakeclickedIs = false;
		breakSound2.Play();
		Main.LightOnStop = 0;
	}

	public void SetNewParams() {
		carNumber = Main.CarNumber;
        switch (carNumber)
        {
            case 1:
                Main.FuelBison200 = fuelBison200;
                break;
            case 2:
                Main.FuelBison500 = fuelBison500;
                break;
            case 3:
                Main.FuelBison5432 = fuelBison5432;
                break;
            case 4:
                Main.FuelBison6422 = fuelBison6422;
                break;
            case 5:
                Main.FuelBison6430 = fuelBison6430;
                break;
            case 6:
                Main.FuelBison6440 = fuelBison6440;
                break;
            case 7:
                Main.FuelBison5440 = fuelBison5440;
                break;
			case 8:
				Main.FuelDUB157 = fuelDUB157;
				break;
			case 9:
				Main.FuelDUB131 = fuelDUB131;
				break;
			case 10:
				Main.FuelDUB130 = fuelDUB130;
				break;
			case 11:
				Main.FuelDUB133 = fuelDUB133;
				break;
			case 12:
				Main.FuelDUB4421 = fuelDUB4421;
				break;
			case 13:
				Main.FuelDUB5423 = fuelDUB5423;
				break;
			case 14:
				Main.FuelFIIV690 = fuelFIIV690;
				break;
			case 15:
				Main.FuelFIIV619 = fuelFIIV619;
				break;
			case 16:
				Main.FuelFIIVTS = fuelFIIVTS;
				break;
			case 17:
				Main.FuelFIIVES = fuelFIIVES;
				break;
			case 18:
				Main.FuelFIIVST = fuelFIIVST;
				break;
			case 19:
				Main.FuelFIIVSTR = fuelFIIVSTR;
				break;
			case 20:
				Main.FuelFIIVHW = fuelFIIVHW;
				break;
			case 21:
				Main.FuelFIIVSW = fuelFIIVSW;
				break;
			case 22:
				Main.FuelHORSE5410 = fuelHORSE5410;
				break;
			case 23:
				Main.FuelHORSE6460 = fuelHORSE6460;
				break;
			case 24:
				Main.FuelHORSE5460 = fuelHORSE5460;
				break;
			case 25:
				Main.FuelHORSE1840 = fuelHORSE1840;
				break;
			case 26:
				Main.FuelHORSE1855 = fuelHORSE1855;
				break;
			case 27:
				Main.FuelRIDGE375 = fuelRIDGE375;
				break;
			case 28:
				Main.FuelRIDGE4420 = fuelRIDGE4420;
				break;
			case 29:
				Main.FuelRIDGE6370 = fuelRIDGE6370;
				break;
			case 30:
				Main.FuelRIDGENX = fuelRIDGENX;
				break;
			case 101:
				Main.FuelFORBCARGO = fuelFORBCARGO;
				break;
			case 102:
				Main.FuelFORBFMAX = fuelFORBFMAX;
				break;
		}
        Main.Kilometers = kilometers;
		prefCarClon.GetComponent<CarChar>().fuelConsumption = fuelConsumption;
		prcNumber = Main.PrcNumber;		
	}

    public void UpdateFuel()
    {
        carNumber = Main.CarNumber;
		if (fuel > fuelMax)
        {
			fuel = fuelMax;
			switch (carNumber)
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
    }
    ///////////////////   G E A R   ///////////////////////////////////////////////////////////////////////////////////////////////	

    public void GearN()
	{
		KPP.Play();
		gazTurn.SetActive(true);
		Main.Gear = 0;
		Gear = 0;
		carSpeed = -2800;		
		carAcceleration = 0;
		thrustCar = maxThrustCar * 0.01f;
		gearN_AKPP.SetActive(true);
		gear1_AKPP.SetActive(false);
		gearR_AKPP.SetActive(false);
		gearN.SetActive(true);
		gear1.SetActive(false);
		gear2.SetActive(false);
		gear3.SetActive(false);
		gear4.SetActive(false);
		gearR.SetActive(false);
		gearOn.text = "N";
	}
	public void Gear1()
	{
		KPP.Play();
		gazTurn.SetActive(false);
		Main.Gear = 1;
		Gear = 1;
		carSpeed = maxSpeed * 0.25f;		
		carAcceleration = maxAcceleration * 1 - loadTruck * effectLoadTruck;
		thrustCar = maxThrustCar * 0.25f + loadTruck * effectLoadTruck;
		gearN_AKPP.SetActive(false);
		gear1_AKPP.SetActive(true);
		gearR_AKPP.SetActive(false);
		gearN.SetActive(false);
		gear1.SetActive(true);
		gear2.SetActive(false);
		gear3.SetActive(false);
		gear4.SetActive(false);
		gearR.SetActive(false);
		gearOn.text = "1";
	}
	public void Gear2()
	{
		KPP.Play();
		gazTurn.SetActive(false);
		Main.Gear = 2;
		Gear = 2;
		carSpeed = maxSpeed * 0.5f;		
		carAcceleration = maxAcceleration * 0.75f - loadTruck * (2 * effectLoadTruck);
		thrustCar = maxThrustCar * 0.5f + loadTruck * (2 * effectLoadTruck);
		gearN.SetActive(false);
		gear1.SetActive(false);
		gear2.SetActive(true);
		gear3.SetActive(false);
		gear4.SetActive(false);
		gearR.SetActive(false);
		gearOn.text = "2";
	}
	public void Gear3()
	{
		KPP.Play();
		gazTurn.SetActive(false);
		Main.Gear = 3;
		Gear = 3;
		carSpeed = maxSpeed * 0.75f;		
		carAcceleration = maxAcceleration * 0.5f - loadTruck * (3 * effectLoadTruck);
		if (carAcceleration < 3)
		{
			carAcceleration = 3;
		}
		thrustCar = maxThrustCar * 0.75f + loadTruck * (3 * effectLoadTruck);
		gearN.SetActive(false);
		gear1.SetActive(false);
		gear2.SetActive(false);
		gear3.SetActive(true);
		gear4.SetActive(false);
		gearR.SetActive(false);
		gearOn.text = "3";
	}
	public void Gear4()
	{
		KPP.Play();
		gazTurn.SetActive(false);
		Main.Gear = 4;
		Gear = 4;
		carSpeed = maxSpeed * 1f;		
		carAcceleration = maxAcceleration * 0.25f - loadTruck * (4 * effectLoadTruck);
		if (carAcceleration < 1)
        {
			carAcceleration = 1;
        }
		thrustCar = maxThrustCar * 1f + loadTruck * (4 * effectLoadTruck);
		gearN.SetActive(false);
		gear1.SetActive(false);
		gear2.SetActive(false);
		gear3.SetActive(false);
		gear4.SetActive(true);
		gearR.SetActive(false);
		gearOn.text = "4";
	}
    public void GearR()
    {
		KPP.Play();
		gazTurn.SetActive(false);
		Main.Gear = 5;
		Gear = 5;
        carSpeed = 300f;
		carAcceleration = 10;
        thrustCar = (maxThrustCar) * 0.01f;
		gearN_AKPP.SetActive(false);
		gear1_AKPP.SetActive(false);
		gearR_AKPP.SetActive(true);
		gearN.SetActive(false);
		gear1.SetActive(false);
		gear2.SetActive(false);
		gear3.SetActive(false);
		gear4.SetActive(false);
		gearR.SetActive(true);
		gearOn.text = "R";
	}
	
	public void Restart()
    {
		Load.SetActive(true);
	}

	public void vGarage()
    {
		Main.activeHitchhikerAndPatrol = 0;
		prefCarClon.transform.rotation = Quaternion.identity;
		prefCarClon.transform.position = startpos;
		prefPrcClon.transform.rotation = Quaternion.identity;
		prefPrcClon.transform.position = startpos;
		pnlUpravlenie.GetComponent<Dashboard>().ToTheGarageActiveDeactive();		
	}	

	public void EngineSpeedUp()
    {
		turnUp = true;
		if (indicator == 1) Main.TruckSmoke = 1;
		else Main.TruckSmoke = 0;
	}
	public void EngineSpeedDw()
	{
		turnUp = false;
		Main.TruckSmoke = 0;
	}
	public void CamLeft()
    {
		camLeft = true;
    }
	public void DeCamLeft()
	{
		camLeft = false;
	}
	public void CamRight()
	{
		camRight = true;
	}
	public void DeCamRight()
	{
		camRight = false;
	}
	public void CamZoomPlus()
	{
		camZoomPlus = true;
	}
	public void DeCamZoomPlus()
	{
		camZoomPlus = false;
	}
	public void CamZoomMinus()
	{
		camZoomMinus = true;
	}
	public void DeCamZoomMinus()
	{
		camZoomMinus = false;
	}
	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	void FixedUpdate() 
	{
		realSpeed = Main.RealSpeed;
		loadTruck = Main.CargoWeight;
		AKPP = Main.AKPP;
		if(AKPP == 1)
        {
			AKPP_pnl.SetActive(true);
        }
        else
        {
			AKPP_pnl.SetActive(false);
		}

		switch (carNumber)
        {
			case 0:
				prefCarClon = nullObj;
				target = prefCarClon.transform;				
				break;
			case 1:
				prefCarClon = Bison200;
				target = prefCarClon.transform;
				fuelBison200 = Main.FuelBison200;
                fuel = fuelBison200;
                break;
			case 2:
				prefCarClon = Bison500;
                target = prefCarClon.transform;
				fuelBison500 = Main.FuelBison500;
                fuel = fuelBison500;
                break;
			case 3:
				prefCarClon = Bison5432;
				target = prefCarClon.transform;
				fuelBison5432 = Main.FuelBison5432;
                fuel = fuelBison5432;
                break;
			case 4:
				prefCarClon = Bison6422;
				target = prefCarClon.transform;
				fuelBison6422 = Main.FuelBison6422;
                fuel = fuelBison6422;
                break;
			case 5:
				prefCarClon = Bison6430;
				target = prefCarClon.transform;
				fuelBison6430 = Main.FuelBison6430;
                fuel = fuelBison6430;
                break;
			case 6:
				prefCarClon = Bison6440;
				target = prefCarClon.transform;
				fuelBison6440 = Main.FuelBison6440;
                fuel = fuelBison6440;
                break;
			case 7:
				prefCarClon = Bison5440;
				target = prefCarClon.transform;
				fuelBison5440 = Main.FuelBison5440;
                fuel = fuelBison5440;
                break;
			case 8:
				prefCarClon = DUB157;
				target = prefCarClon.transform;
				fuelDUB157 = Main.FuelDUB157;
				fuel = fuelDUB157;
				break;
			case 9:
				prefCarClon = DUB131;
				target = prefCarClon.transform;
				fuelDUB131 = Main.FuelDUB131;
				fuel = fuelDUB131;
				break;
			case 10:
				prefCarClon = DUB130;
				target = prefCarClon.transform;
				fuelDUB130 = Main.FuelDUB130;
				fuel = fuelDUB130;
				break;
			case 11:
				prefCarClon = DUB133;
				target = prefCarClon.transform;
				fuelDUB133 = Main.FuelDUB133;
				fuel = fuelDUB133;
				break;
			case 12:
				prefCarClon = DUB4421;
				target = prefCarClon.transform;
				fuelDUB4421 = Main.FuelDUB4421;
				fuel = fuelDUB4421;
				break;
			case 13:
				prefCarClon = DUB5423;
				target = prefCarClon.transform;
				fuelDUB5423 = Main.FuelDUB5423;
				fuel = fuelDUB5423;
				break;
			case 14:
				prefCarClon = FIIV690;
				target = prefCarClon.transform;
				fuelFIIV690 = Main.FuelFIIV690;
				fuel = fuelFIIV690;
				break;
			case 15:
				prefCarClon = FIIV619;
				target = prefCarClon.transform;
				fuelFIIV619 = Main.FuelFIIV619;
				fuel = fuelFIIV619;
				break;
			case 16:
				prefCarClon = FIIVTS;
				target = prefCarClon.transform;
				fuelFIIVTS = Main.FuelFIIVTS;
				fuel = fuelFIIVTS;
				break;
			case 17:
				prefCarClon = FIIVES;
				target = prefCarClon.transform;
				fuelFIIVES = Main.FuelFIIVES;
				fuel = fuelFIIVES;
				break;
			case 18:
				prefCarClon = FIIVST;
				target = prefCarClon.transform;
				fuelFIIVST = Main.FuelFIIVST;
				fuel = fuelFIIVST;
				break;
			case 19:
				prefCarClon = FIIVSTR;
				target = prefCarClon.transform;
				fuelFIIVSTR = Main.FuelFIIVSTR;
				fuel = fuelFIIVSTR;
				break;
			case 20:
				prefCarClon = FIIVHW;
				target = prefCarClon.transform;
				fuelFIIVHW = Main.FuelFIIVHW;
				fuel = fuelFIIVHW;
				break;
			case 21:
				prefCarClon = FIIVSW;
				target = prefCarClon.transform;
				fuelFIIVSW = Main.FuelFIIVSW;
				fuel = fuelFIIVSW;
				break;
			case 22:
				prefCarClon = HORSE5410;
				target = prefCarClon.transform;
				fuelHORSE5410 = Main.FuelHORSE5410;
				fuel = fuelHORSE5410;
				break;
			case 23:
				prefCarClon = HORSE6460;
				target = prefCarClon.transform;
				fuelHORSE6460 = Main.FuelHORSE6460;
				fuel = fuelHORSE6460;
				break;
			case 24:
				prefCarClon = HORSE5460;
				target = prefCarClon.transform;
				fuelHORSE5460 = Main.FuelHORSE5460;
				fuel = fuelHORSE5460;
				break;
			case 25:
				prefCarClon = HORSE1840;
				target = prefCarClon.transform;
				fuelHORSE1840 = Main.FuelHORSE1840;
				fuel = fuelHORSE1840;
				break;
			case 26:
				prefCarClon = HORSE1855;
				target = prefCarClon.transform;
				fuelHORSE1855 = Main.FuelHORSE1855;
				fuel = fuelHORSE1855;
				break;
			case 27:
				prefCarClon = RIDGE375;
				target = prefCarClon.transform;
				fuelRIDGE375 = Main.FuelRIDGE375;
				fuel = fuelRIDGE375;
				break;
			case 28:
				prefCarClon = RIDGE4420;
				target = prefCarClon.transform;
				fuelRIDGE4420 = Main.FuelRIDGE4420;
				fuel = fuelRIDGE4420;
				break;
			case 29:
				prefCarClon = RIDGE6370;
				target = prefCarClon.transform;
				fuelRIDGE6370 = Main.FuelRIDGE6370;
				fuel = fuelRIDGE6370;
				break;
			case 30:
				prefCarClon = RIDGENX;
				target = prefCarClon.transform;
				fuelRIDGENX = Main.FuelRIDGENX;
				fuel = fuelRIDGENX;
				break;
			case 101:
				prefCarClon = FORBCARGO;
				target = prefCarClon.transform;
				fuelFORBCARGO = Main.FuelFORBCARGO;
				fuel = fuelFORBCARGO;
				break;
			case 102:
				prefCarClon = FORBFMAX;
				target = prefCarClon.transform;
				fuelFORBFMAX = Main.FuelFORBFMAX;
				fuel = fuelFORBFMAX;
				break;
		}

		kilometers = Main.Kilometers;
		weightCar = prefCarClon.GetComponent<CarChar>().weightCar;
		allowableWeight = prefCarClon.GetComponent<CarChar>().allowableWeight;
		carSound = prefCarClon.GetComponents<AudioSource>();
		realSpeedCal = prefCarClon.GetComponent<CarChar>().realSpeedCal;
		maxSpeed = prefCarClon.GetComponent<CarChar>().maxSpeed;
		maxAcceleration = prefCarClon.GetComponent<CarChar>().maxAcceleration;
		maxThrustCar = prefCarClon.GetComponent<CarChar>().maxThrustCar;
		effectLoadTruck = prefCarClon.GetComponent<CarChar>().effectLoadTruck;
		backSpeed = prefCarClon.GetComponent<CarChar>().backSpeed;
		deacceleration = prefCarClon.GetComponent<CarChar>().deacceleration;
		brakeForce = prefCarClon.GetComponent<CarChar>().brakeForce;
		fuelMax = prefCarClon.GetComponent<CarChar>().fuelMax;
		fuelConsumption = prefCarClon.GetComponent<CarChar>().fuelConsumption;

		switch (prcNumber)
        {
			case 0:
				prefPrcClon = nullObjTrailer;
				break;
			case 1:
				prefPrcClon = B1;
				prefPrcClon.name = "B1";
				weightTrailer = prefPrcClon.GetComponent<TrailerChar>().trailerWeight;
				break;
			case 2:
				prefPrcClon = B2;
				prefPrcClon.name = "B2";
				weightTrailer = prefPrcClon.GetComponent<TrailerChar>().trailerWeight;
				break;
			case 3:
				prefPrcClon = B3;
				prefPrcClon.name = "B3";
				weightTrailer = prefPrcClon.GetComponent<TrailerChar>().trailerWeight;
				break;
			case 4:
				prefPrcClon = B4;
				prefPrcClon.name = "B4";
				weightTrailer = prefPrcClon.GetComponent<TrailerChar>().trailerWeight;
				break;
			case 5:
				prefPrcClon = B5;
				prefPrcClon.name = "B5";
				weightTrailer = prefPrcClon.GetComponent<TrailerChar>().trailerWeight;
				break;
			case 6:
				prefPrcClon = B6;
				prefPrcClon.name = "B6";
				weightTrailer = prefPrcClon.GetComponent<TrailerChar>().trailerWeight;
				break;
			case 7:
				prefPrcClon = B7;
				prefPrcClon.name = "B7";
				weightTrailer = prefPrcClon.GetComponent<TrailerChar>().trailerWeight;
				break;
			case 8:
				prefPrcClon = T1;
				prefPrcClon.name = "T1";
				weightTrailer = prefPrcClon.GetComponent<TrailerCharTent>().trailerWeight;
				break;
			case 9:
				prefPrcClon = T2;
				prefPrcClon.name = "T2";
				weightTrailer = prefPrcClon.GetComponent<TrailerCharTent>().trailerWeight;
				break;
			case 10:
				prefPrcClon = T3;
				prefPrcClon.name = "T3";
				weightTrailer = prefPrcClon.GetComponent<TrailerCharTent>().trailerWeight;
				break;
			case 11:
				prefPrcClon = T4;
				prefPrcClon.name = "T4";
				weightTrailer = prefPrcClon.GetComponent<TrailerCharTent>().trailerWeight;
				break;
			case 12:
				prefPrcClon = T5;
				prefPrcClon.name = "T5";
				weightTrailer = prefPrcClon.GetComponent<TrailerCharTent>().trailerWeight;
				break;
			case 13:
				prefPrcClon = T6;
				prefPrcClon.name = "T6";
				weightTrailer = prefPrcClon.GetComponent<TrailerCharTent>().trailerWeight;
				break;
			case 14:
				prefPrcClon = T7;
				prefPrcClon.name = "T7";
				weightTrailer = prefPrcClon.GetComponent<TrailerCharTent>().trailerWeight;
				break;
			case 15:
				prefPrcClon = R1;
				prefPrcClon.name = "R1";
				weightTrailer = prefPrcClon.GetComponent<TrailerCharRefrigerator>().trailerWeight;
				break;
			case 16:
				prefPrcClon = R2;
				prefPrcClon.name = "R2";
				weightTrailer = prefPrcClon.GetComponent<TrailerCharRefrigerator>().trailerWeight;
				break;
			case 17:
				prefPrcClon = R3;
				prefPrcClon.name = "R3";
				weightTrailer = prefPrcClon.GetComponent<TrailerCharRefrigerator>().trailerWeight;
				break;
			case 18:
				prefPrcClon = R4;
				prefPrcClon.name = "R4";
				weightTrailer = prefPrcClon.GetComponent<TrailerCharRefrigerator>().trailerWeight;
				break;
			case 19:
				prefPrcClon = R5;
				prefPrcClon.name = "R5";
				weightTrailer = prefPrcClon.GetComponent<TrailerCharRefrigerator>().trailerWeight;
				break;
			case 20:
				prefPrcClon = R6;
				prefPrcClon.name = "R6";
				weightTrailer = prefPrcClon.GetComponent<TrailerCharRefrigerator>().trailerWeight;
				break;
			case 21:
				prefPrcClon = C1;
				prefPrcClon.name = "C1";
				weightTrailer = prefPrcClon.GetComponent<TrailerCharCont>().trailerWeight;
				break;
			case 22:
				prefPrcClon = C2;
				prefPrcClon.name = "C2";
				weightTrailer = prefPrcClon.GetComponent<TrailerCharCont>().trailerWeight;
				break;
			case 23:
				prefPrcClon = C3;
				prefPrcClon.name = "C3";
				weightTrailer = prefPrcClon.GetComponent<TrailerCharCont>().trailerWeight;
				break;
			case 24:
				prefPrcClon = C4;
				prefPrcClon.name = "C4";
				weightTrailer = prefPrcClon.GetComponent<TrailerCharCont>().trailerWeight;
				break;
			case 25:
				prefPrcClon = C5;
				prefPrcClon.name = "C5";
				weightTrailer = prefPrcClon.GetComponent<TrailerCharCont>().trailerWeight;
				break;
			case 100:
				prefPrcClon = ST1;
				prefPrcClon.name = "ST1";
				weightTrailer = prefPrcClon.GetComponent<TrailerSpec>().trailerWeight;
				break;
			case 101:
				prefPrcClon = ST2;
				prefPrcClon.name = "ST2";
				weightTrailer = prefPrcClon.GetComponent<TrailerSpec>().trailerWeight;
				break;
			case 102:
				prefPrcClon = ST3;
				prefPrcClon.name = "ST3";
				weightTrailer = prefPrcClon.GetComponent<TrailerSpec>().trailerWeight;
				break;
		}		

		wheelJoints = prefCarClon.GetComponents<WheelJoint2D>();
		backWheel2 = wheelJoints[2].motor;
		backWheel = wheelJoints[1].motor;
        frontWheel = wheelJoints[0].motor;

		wheelJointsTrailer = prefPrcClon.GetComponents<WheelJoint2D>();
		wheel1 = wheelJointsTrailer[0].motor;
		wheel2 = wheelJointsTrailer[1].motor;
		wheel3 = wheelJointsTrailer[2].motor;
		wheel4 = wheelJointsTrailer[3].motor;

		if (speed >= 1 && Gear <= 4)
        {
			gearR_BLOK.SetActive(true);
			gearR_BLOK_AKPP.SetActive(true);
		}
        else
        {
			gearR_BLOK.SetActive(false);
			gearR_BLOK_AKPP.SetActive(false);
		}
			

		if (Gear == 2)
        {
			if (speed > carSpeed * -0.025)
				gear1_BLOK.SetActive(true);
			else
				gear1_BLOK.SetActive(false);			
		}
		if (Gear == 3)
		{
			if (speed > carSpeed * -0.01666f)
            {
				gear1_BLOK.SetActive(true);				
			}
			else
			{
				gear1_BLOK.SetActive(false);
			}
			if (speed > carSpeed * -0.0333f)
			{
				gear2_BLOK.SetActive(true);
			}
            else
            {
				gear2_BLOK.SetActive(false);
            }
		}
		if (Gear == 4)
		{
			if (speed > carSpeed * -0.0125f)
			{
				gear1_BLOK.SetActive(true);				
			}
			else
			{
				gear1_BLOK.SetActive(false);				
			}
			if (speed > carSpeed * -0.025f)
			{
				gear2_BLOK.SetActive(true);
			}
			else
			{
				gear2_BLOK.SetActive(false);
			}
			if (speed > carSpeed * -0.0375f)
			{
				gear3_BLOK.SetActive(true);
			}
			else
			{
				gear3_BLOK.SetActive(false);
			}
		}

		if (carNumber == 8 || carNumber == 9 || carNumber == 27 || carNumber == 28 || carNumber == 29 || carNumber == 30)
		{
			frontWheel.motorSpeed = backWheel.motorSpeed;
		}

		backWheel2.motorSpeed = backWheel.motorSpeed;
		angleCar = prefCarClon.transform.localEulerAngles.z;		

		if (Gear == 0)
		{
			if (turnUp == true)
			{
				if (turnovers <= 2500f)
				{
					turnovers += 1000 * Time.deltaTime;
				}
			}
			else if (turnovers >= 500f)
			{
				turnovers -= 1000 * Time.deltaTime;
			}
		}
		if (Gear >= 1 && Gear <= 4)
		{			
			turnovers = ((speed - (-minSpeed / 20)) * 2500 + 500 * ((-carSpeed / 20) - speed)) / ((-carSpeed / 20) - (-minSpeed / 20));			
		}
        if (Gear == 5)
        {
            turnovers = ((speed - (minSpeed / 20)) * 2500 + 500 * ((carSpeed / 20) - speed)) / ((carSpeed / 20) - (minSpeed / 20));
        }
		if (Gear >= 0 && Gear <= 4)
        {
			if (speed > realSpeed + 20) Main.Smoke = 1;
			else Main.Smoke = 0;
		}

			//if (speed > realSpeed + 10) Main.Smoke = 1;
			//else if (speed + 10 < realSpeed) Main.Smoke = 2;
			//else Main.Smoke = 0;

		if (AKPP == 1)
        {
            switch (Gear)
            {
				case 1:
					if (turnovers >= 2300) Gear2();
					break;
				case 2:
					if (turnovers >= 2300) Gear3();
					else if (turnovers <= 1400) Gear1();
					break;
				case 3:
					if (turnovers >= 2300) Gear4();
					else if (turnovers <= 1400) Gear2();
					break;
				case 4:
					if (turnovers <= 1400) Gear3();
					break;
			}
        }

		if (angleCar >= 180) {
			angleCar = angleCar - 360;
		}

	///////////////////   С Ч Ё Т Ч И К   К М   //////////////////////////////////////////////////////////////////////////////////
		if (curpos.x < prefCarClon.transform.position.x)
		{
			kilometers += (prefCarClon.transform.position.x - curpos.x) / 10f;				
			pos += prefCarClon.transform.position.x - curpos.x;

            switch (carNumber)
            {
                case 1:
                    if (fuelBison200 > 0 && indicator == 1)
                    {
                        fuelBison200 -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
                    }
                    else if (fuelBison200 > 0 && indicator == 0)
                    {

                    }
                    else
                    {
                        fuelBison200 = 0;
                    }
                    break;
                case 2:
					if (fuelBison500 > 0 && indicator == 1)
					{
						fuelBison500 -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelBison500 > 0 && indicator == 0)
					{

					}
					else
					{
						fuelBison500 = 0;
					}
					break;
                case 3:
					if (fuelBison5432 > 0 && indicator == 1)
					{
						fuelBison5432 -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelBison5432 > 0 && indicator == 0)
					{

					}
					else
					{
						fuelBison5432 = 0;
					}
					break;
                case 4:
					if (fuelBison6422 > 0 && indicator == 1)
					{
						fuelBison6422 -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelBison6422 > 0 && indicator == 0)
					{

					}
					else
					{
						fuelBison6422 = 0;
					}
					break;
                case 5:
					if (fuelBison6430 > 0 && indicator == 1)
					{
						fuelBison6430 -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelBison6430 > 0 && indicator == 0)
					{

					}
					else
					{
						fuelBison6430 = 0;
					}
					break;
                case 6:
					if (fuelBison6440 > 0 && indicator == 1)
					{
						fuelBison6440 -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelBison6440 > 0 && indicator == 0)
					{

					}
					else
					{
						fuelBison6440 = 0;
					}
					break;
                case 7:
					if (fuelBison5440 > 0 && indicator == 1)
					{
						fuelBison5440 -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelBison5440 > 0 && indicator == 0)
					{

					}
					else
					{
						fuelBison5440 = 0;
					}
					break;
				case 8:
					if (fuelDUB157 > 0 && indicator == 1)
					{
						fuelDUB157 -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelDUB157 > 0 && indicator == 0)
					{

					}
					else
					{
						fuelDUB157 = 0;
					}
					break;
				case 9:
					if (fuelDUB131 > 0 && indicator == 1)
					{
						fuelDUB131 -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelDUB131 > 0 && indicator == 0)
					{

					}
					else
					{
						fuelDUB131 = 0;
					}
					break;
				case 10:
					if (fuelDUB130 > 0 && indicator == 1)
					{
						fuelDUB130 -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelDUB130 > 0 && indicator == 0)
					{

					}
					else
					{
						fuelDUB130 = 0;
					}
					break;
				case 11:
					if (fuelDUB133 > 0 && indicator == 1)
					{
						fuelDUB133 -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelDUB133 > 0 && indicator == 0)
					{

					}
					else
					{
						fuelDUB133 = 0;
					}
					break;
				case 12:
					if (fuelDUB4421 > 0 && indicator == 1)
					{
						fuelDUB4421 -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelDUB4421 > 0 && indicator == 0)
					{

					}
					else
					{
						fuelDUB4421 = 0;
					}
					break;
				case 13:
					if (fuelDUB5423 > 0 && indicator == 1)
					{
						fuelDUB5423 -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelDUB5423 > 0 && indicator == 0)
					{

					}
					else
					{
						fuelDUB5423 = 0;
					}
					break;
				case 14:
					if (fuelFIIV690 > 0 && indicator == 1)
					{
						fuelFIIV690 -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelFIIV690 > 0 && indicator == 0)
					{

					}
					else
					{
						fuelFIIV690 = 0;
					}
					break;
				case 15:
					if (fuelFIIV619 > 0 && indicator == 1)
					{
						fuelFIIV619 -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelFIIV619 > 0 && indicator == 0)
					{

					}
					else
					{
						fuelFIIV619 = 0;
					}
					break;
				case 16:
					if (fuelFIIVTS > 0 && indicator == 1)
					{
						fuelFIIVTS -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelFIIVTS > 0 && indicator == 0)
					{

					}
					else
					{
						fuelFIIVTS = 0;
					}
					break;
				case 17:
					if (fuelFIIVES > 0 && indicator == 1)
					{
						fuelFIIVES -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelFIIVES > 0 && indicator == 0)
					{

					}
					else
					{
						fuelFIIVES = 0;
					}
					break;
				case 18:
					if (fuelFIIVST > 0 && indicator == 1)
					{
						fuelFIIVST -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelFIIVST > 0 && indicator == 0)
					{

					}
					else
					{
						fuelFIIVST = 0;
					}
					break;
				case 19:
					if (fuelFIIVSTR > 0 && indicator == 1)
					{
						fuelFIIVSTR -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelFIIVSTR > 0 && indicator == 0)
					{

					}
					else
					{
						fuelFIIVSTR = 0;
					}
					break;
				case 20:
					if (fuelFIIVHW > 0 && indicator == 1)
					{
						fuelFIIVHW -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelFIIVHW > 0 && indicator == 0)
					{

					}
					else
					{
						fuelFIIVHW = 0;
					}
					break;
				case 21:
					if (fuelFIIVSW > 0 && indicator == 1)
					{
						fuelFIIVSW -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelFIIVSW > 0 && indicator == 0)
					{

					}
					else
					{
						fuelFIIVSW = 0;
					}
					break;
				case 22:
					if (fuelHORSE5410 > 0 && indicator == 1)
					{
						fuelHORSE5410 -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelHORSE5410 > 0 && indicator == 0)
					{

					}
					else
					{
						fuelHORSE5410 = 0;
					}
					break;
				case 23:
					if (fuelHORSE6460 > 0 && indicator == 1)
					{
						fuelHORSE6460 -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelHORSE6460 > 0 && indicator == 0)
					{

					}
					else
					{
						fuelHORSE6460 = 0;
					}
					break;
				case 24:
					if (fuelHORSE5460 > 0 && indicator == 1)
					{
						fuelHORSE5460 -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelHORSE5460 > 0 && indicator == 0)
					{

					}
					else
					{
						fuelHORSE5460 = 0;
					}
					break;
				case 25:
					if (fuelHORSE1840 > 0 && indicator == 1)
					{
						fuelHORSE1840 -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelHORSE1840 > 0 && indicator == 0)
					{

					}
					else
					{
						fuelHORSE1840 = 0;
					}
					break;
				case 26:
					if (fuelHORSE1855 > 0 && indicator == 1)
					{
						fuelHORSE1855 -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelHORSE1855 > 0 && indicator == 0)
					{

					}
					else
					{
						fuelHORSE1855 = 0;
					}
					break;
				case 27:
					if (fuelRIDGE375 > 0 && indicator == 1)
					{
						fuelRIDGE375 -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelRIDGE375 > 0 && indicator == 0)
					{

					}
					else
					{
						fuelRIDGE375 = 0;
					}
					break;
				case 28:
					if (fuelRIDGE4420 > 0 && indicator == 1)
					{
						fuelRIDGE4420 -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelRIDGE4420 > 0 && indicator == 0)
					{

					}
					else
					{
						fuelRIDGE4420 = 0;
					}
					break;
				case 29:
					if (fuelRIDGE6370 > 0 && indicator == 1)
					{
						fuelRIDGE6370 -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelRIDGE6370 > 0 && indicator == 0)
					{

					}
					else
					{
						fuelRIDGE6370 = 0;
					}
					break;
				case 30:
					if (fuelRIDGENX > 0 && indicator == 1)
					{
						fuelRIDGENX -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelRIDGENX > 0 && indicator == 0)
					{

					}
					else
					{
						fuelRIDGENX = 0;
					}
					break;
				case 101:
					if (fuelFORBCARGO > 0 && indicator == 1)
					{
						fuelFORBCARGO -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelFORBCARGO > 0 && indicator == 0)
					{

					}
					else
					{
						fuelFORBCARGO = 0;
					}
					break;
				case 102:
					if (fuelFORBFMAX > 0 && indicator == 1)
					{
						fuelFORBFMAX -= (prefCarClon.transform.position.x - curpos.x) / 10f / 100f * fuelConsumption;
					}
					else if (fuelFORBFMAX > 0 && indicator == 0)
					{

					}
					else
					{
						fuelFORBFMAX = 0;
					}
					break;
			}
			curpos.x = prefCarClon.transform.position.x;
		}
		else
		{
			kilometers += -(prefCarClon.transform.position.x - curpos.x) / 10f;
			curpos.x = prefCarClon.transform.position.x;
        }
        kiloint = (int)kilometers;
		kmtext.text = kiloint.ToString();
		if (maxSpeed >= 0)
		{
			maxSpeed = 0;
		}
		if (backWheel.motorSpeed < 0)
		{
			speed = -backWheel.motorSpeed / realSpeedCal;
			speedTrailer = -wheel2.motorSpeed / 20f;
		}
		else
		{
			speed = backWheel.motorSpeed / realSpeedCal;
			speedTrailer = wheel2.motorSpeed / 20f;
		}		

		strelka.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, (speed / -0.44f)), 5);
		strelkaTurn.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, (turnovers / -0.21f * Time.deltaTime)), 5);

		if (carNumber >= 1) 
		{
			fuelstrelka.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, (fuel / fuelMax * (-110))), 7);
		}	

		if (fuel / fuelMax < 0.2f)
		{
			smallFuel.SetActive(true);
		}
		else
		{
			smallFuel.SetActive(false);
		}		
		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		//движение камеры
		if (camLeft == true)
        {
			if(CamX <= 0.8f)
            {
				CamX += 0.4f * Time.deltaTime;
			}			
        }
		if (camRight == true)
		{
			if (CamX >= 0.05f)
			{
				CamX -= 0.4f * Time.deltaTime;
			}
		}
		if (camZoomPlus == true)
		{
			if (CamZ >= 30f)
			{
				CamZ -= 20f * Time.deltaTime;
			}
		}
		if (camZoomMinus == true)
		{
			if (CamZ <= 70f)
			{
				CamZ += 20f * Time.deltaTime;
			}
		}

		Main.camX = CamX;
		Main.camY = CamY;
		Main.camZ = CamZ;

		if (turnovers > 2500)
            turnovers = 2500;
        if (turnovers < 500)
            turnovers = 500;

        if (target) 
		{
            Vector3 delta = new Vector3(target.position.x, target.position.y, target.position.z) - GetComponent<Camera>().ViewportToWorldPoint(new Vector3(CamX, CamY, CamZ));
            Vector3 destination = transform.position + delta;
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }

		//движение автомобиля		
        if (brakeclickedIs == false) 
		{
            if (fuel > 0) {
				if (carNumber == 8 || carNumber == 9 || carNumber == 27 || carNumber == 28 || carNumber == 29 || carNumber == 30)
                {
					frontWheel.maxMotorTorque = 1000000;
				} 
				else frontWheel.maxMotorTorque = 0;

				backWheel2.maxMotorTorque = backWheel.maxMotorTorque;				
				wheel1.maxMotorTorque = 0;
				wheel2.maxMotorTorque = 0;
				wheel3.maxMotorTorque = 0;
				wheel4.maxMotorTorque = 0;
				if (accelclickedIs == true) {
                    backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (carAcceleration - gravity * Mathf.PI * (angleCar / 180) * thrustCar) * Time.deltaTime, carSpeed + gravity * Mathf.PI * (angleCar / 180) * thrustCar * 2, backSpeed);					
				} else if (backWheel.motorSpeed < 0) {
					backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (deacceleration - 2.5f * gravity * Mathf.PI * (angleCar / 180) * thrustCar) * Time.deltaTime, carSpeed + gravity * Mathf.PI * (angleCar / 180) * thrustCar * 2, 0);
                } else if (backWheel.motorSpeed > 0 && accelclickedIs == true) {
					backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (-deacceleration - 2.5f * gravity * Mathf.PI * (angleCar / 180) * thrustCar) * Time.deltaTime, 0, backSpeed);
                } else if (angleCar < 0 && accelclickedIs == true) {
					backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (deacceleration - 2.5f * gravity * Mathf.PI * (angleCar / 180) * thrustCar) * Time.deltaTime, carSpeed + gravity * Mathf.PI * (angleCar / 180) * thrustCar * 2, 0);
                } else {
					backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (-deacceleration - 2.5f * gravity * Mathf.PI * (angleCar / 180) * thrustCar) * Time.deltaTime, 0, backSpeed);
                }
			}
			else if (backWheel.motorSpeed < 0)
			{
				backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (deacceleration - 2.5f * gravity * Mathf.PI * (angleCar / 180) * thrustCar) * Time.deltaTime, carSpeed + gravity * Mathf.PI * (angleCar / 180) * thrustCar * 2, 0);
			}
			else if (backWheel.motorSpeed > 0)
			{
				backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (-deacceleration - 2.5f * gravity * Mathf.PI * (angleCar / 180) * thrustCar) * Time.deltaTime, 0, backSpeed);
			}
			else if (angleCar < 0)
			{
				backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (deacceleration - 2.5f * gravity * Mathf.PI * (angleCar / 180) * thrustCar) * Time.deltaTime, carSpeed + gravity * Mathf.PI * (angleCar / 180) * thrustCar * 2, 0);
			}
			else
			{
				backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (-deacceleration - 2.5f * gravity * Mathf.PI * (angleCar / 180) * thrustCar) * Time.deltaTime, 0, backSpeed);
			}
        } 
		else
		{
			if (speed + 10 < realSpeed) Main.Smoke = 2;

			backWheel2.maxMotorTorque = backWheel.maxMotorTorque;
			frontWheel.maxMotorTorque = 100000;
			wheel1.maxMotorTorque = 100000;
			wheel2.maxMotorTorque = 100000;
			wheel3.maxMotorTorque = 100000;
			wheel4.maxMotorTorque = 100000;

			if (backWheel.motorSpeed > 0)
			{
				backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - brakeForce * Time.deltaTime, 0, backSpeed);
				frontWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - brakeForce * Time.deltaTime, 0, backSpeed);
				wheel1.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - brakeForce * Time.deltaTime, 0, backSpeed);
				wheel2.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - brakeForce * Time.deltaTime, 0, backSpeed);
				wheel3.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - brakeForce * Time.deltaTime, 0, backSpeed);
				wheel4.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - brakeForce * Time.deltaTime, 0, backSpeed);
			}
			else if (backWheel.motorSpeed < 0)
			{
				backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed + brakeForce * Time.deltaTime, carSpeed, 0);
				frontWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - brakeForce * Time.deltaTime, 0, backSpeed);
				wheel1.motorSpeed = Mathf.Clamp(backWheel.motorSpeed + brakeForce * Time.deltaTime, 0, backSpeed);
				wheel2.motorSpeed = Mathf.Clamp(backWheel.motorSpeed + brakeForce * Time.deltaTime, 0, backSpeed);
				wheel3.motorSpeed = Mathf.Clamp(backWheel.motorSpeed + brakeForce * Time.deltaTime, 0, backSpeed);
				wheel4.motorSpeed = Mathf.Clamp(backWheel.motorSpeed + brakeForce * Time.deltaTime, 0, backSpeed);
			}
		}
		wheelJoints[2].motor = backWheel2;
        wheelJoints[1].motor = backWheel;
        wheelJoints[0].motor = frontWheel;
		wheelJointsTrailer[0].motor = wheel1;
		wheelJointsTrailer[1].motor = wheel2;
		wheelJointsTrailer[2].motor = wheel3;
		wheelJointsTrailer[3].motor = wheel4;

		if (Main.MuteAudio == 0)
        {
			carSound[0].volume = 0;
		}
		if (Main.MuteAudio == 1)
        {
			carSound[0].pitch = Mathf.Clamp((turnovers / 1250), 0.7f, 2f);
			carSound[0].volume = Mathf.Clamp((turnovers / 2500), 0.2f, 1f);
			carSound[1].pitch = Mathf.Clamp((speed / 45), 0.1f, 2f);
			carSound[1].volume = Mathf.Clamp((speed / 90), 0f, 1f);
		}

        if (fuel == 0 && indicator == 1)
        {
            OffZazhiganie();
            indicator = 0;
        }
        SetNewParams ();		
	}

	public void OnZazhiganie()
	{
		indicator = 1;
		strelkaTurn.SetActive(true);
		strelkaTurnOff.SetActive(false);
		IgnitionOn.SetActive(true);
		IgnitionOff.SetActive(false);
		carSound[0].Play();		
		BlockGaz.SetActive(false);
		OnZag.SetActive(true);
	}
	public void OffZazhiganie()
	{
		indicator = 0;
		strelkaTurn.SetActive(false);
		strelkaTurnOff.SetActive(true);
		IgnitionOn.SetActive(false);
		IgnitionOff.SetActive(true);		
		carSound[0].Pause();		
		BlockGaz.SetActive(true);
		OnZag.SetActive(false);
		Deacceler();
	}
}
