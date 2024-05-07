using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	private static int money = 50000;
	private static int dollars = 0;
	private static float kilometers;
	private static float bankXpFree = 0;
	private static float bankXpBison = 0;
	private static float bankXpDUB = 0;
	private static float bankXpFIIV = 0;
	private static float bankXpHORSE = 0;
	private static float bankXpRIDGE = 0;
	private static float bankXpBoard = 0;
	private static float bankXpTent = 0;
	private static float bankXpRef = 0;
	private static float bankXpCon = 0;
	private static string language = "rus";
	private static int masterVolume = 1;
	private static int carNumber = 0;
	private static int prcNumber = 0;
	private static int finishLoca = 0;
	private static string mapLocation = "C1";
	private static string saveMapLocation = "C1";
	private static string road;

	private static int smoke = 0;
	private static int lightOn = 0;
	private static int lightOnStop = 0;
	private static int truckSmoke = 0;
	private static int hitchhiker = 0;
	private static int dokiOk = 0;
	private static float cargoWeight;
	private static float timer = 3600;
	private static float realSpeed;
	public static int cargo_condition;
	private static int specCargo = 0;
	private static int muteAudio = 1;
	private static int ads = 0;
	private static int gear;
	private static int buyFuel = 0;
	private static int mins;
	private static int hours = 8;
	private static int days = 1;
	///////////////////   Н А Г Р А Д А   //////////////////////////////////////////////////////////////////////////////////////////////
	private static float prizeRuly;
	private static int prizeDollars;
	private static float prizeXpFree;
	private static float prizeXpCar;
	private static float prizeXpTrailer;
	private static float coefPrizeXpFree;

	private static int ActiveHitchhikerAndPatrol;
	private static int activeRndEvent;

	private static int hitchhikerR;
	private static int hitchhikerX;
	private static int hitchhikerD;
	///////////////////   К А М Е Р А   //////////////////////////////////////////////////////////////////////////////////////////////
	private static float CamX = 0.5f;
	private static float CamY = 0.48f;
	private static float CamZ = 55f;
	private static float CamXGarage = 0.6f;
	private static float CamYGarage = 0.45f;
	private static float CamZGarage = 40f;
	private static float CamXTruck = 0.4f;
	private static float CamYTruck = 0.45f;
	private static float CamZTruck = 25f;
	private static float CamXTrailer = 0.7f;
	private static float CamYTrailer = 0.45f;
	private static float CamZTrailer = 40f;
	///////////////////   G L O B A L   M A P   ////////////////////////////////////////////////////////////////////////////////////////
	private static float ContPosX = 0f;
	private static float ContPosY = 0f;
	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	//////////////////////   U P G R A D E   ///////////////////////////////////////////////////////////////////////////////////////////
	private static int engine;
	private static int gearbox;
	public static int akpp;
	private static int brake;
	private static int fuelTank;
	private static int rearBogie;
	private static int externalTuning;
	///////////////////   B I S O N   S E R I A   //////////////////////////////////////////////////////////////////////////////////////
	///////////////////   B I S O N    2 0 0   /////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveBison200 = 0;
	private static int moneyActiveBison200 = 0;
	private static int engineBison200 = 1;
	private static int gearboxBison200 = 1;
	private static int brakeBison200 = 1;
	private static int fuelTankBison200 = 1;
	private static int rearBogieBison200 = 1;
	private static float fuelBison200 = 200f;
	private static int externalTuningBison200 = 1;
	///////////////////   B I S O N   5 0 0   //////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveBison500 = 0;
	private static int moneyActive500 = 0;
	private static int engineBison500 = 1;
	private static int gearboxBison500 = 1;
	private static int brakeBison500 = 1;
	private static int fuelTankBison500 = 1;
	private static int rearBogieBison500 = 1;
	private static float fuelBison500 = 300f;
	private static int externalTuningBison500 = 1;
	///////////////////   B I S O N   5 4 3 2   ////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveBison5432 = 0;
	private static int moneyActive5432 = 0;
	private static int engineBison5432 = 1;
	private static int gearboxBison5432 = 1;
	private static int brakeBison5432 = 1;
	private static int fuelTankBison5432 = 1;
	private static int rearBogieBison5432 = 1;
	private static float fuelBison5432 = 400f;
	private static int externalTuningBison5432 = 1;
	///////////////////   B I S O N   6 4 2 2   ////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveBison6422 = 0;
	private static int moneyActive6422 = 0;
	private static int engineBison6422 = 1;
	private static int gearboxBison6422 = 1;
	private static int brakeBison6422 = 1;
	private static int fuelTankBison6422 = 1;
	private static int rearBogieBison6422 = 1;
	private static float fuelBison6422 = 500f;
	private static int externalTuningBison6422 = 1;
	///////////////////   B I S O N   6 4 3 0   ////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveBison6430 = 0;
	private static int moneyActive6430 = 0;
	private static int engineBison6430 = 1;
	private static int gearboxBison6430 = 1;
	private static int brakeBison6430 = 1;
	private static int fuelTankBison6430 = 1;
	private static int rearBogieBison6430 = 1;
	private static float fuelBison6430 = 600f;
	private static int externalTuningBison6430 = 1;
	///////////////////   B I S O N   6 4 4 0   ////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveBison6440 = 0;
	private static int moneyActive6440 = 0;
	private static int engineBison6440 = 1;
	private static int gearboxBison6440 = 1;
	private static int brakeBison6440 = 1;
	private static int fuelTankBison6440 = 1;
	private static int rearBogieBison6440 = 1;
	private static float fuelBison6440 = 700f;
	private static int externalTuningBison6440 = 1;
	///////////////////   B I S O N   5 4 4 0   ////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveBison5440 = 0;
	private static int moneyActive5440 = 0;
	private static int engineBison5440 = 1;
	private static int gearboxBison5440 = 1;
	private static int brakeBison5440 = 1;
	private static int fuelTankBison5440 = 1;
	private static int rearBogieBison5440 = 1;
	private static float fuelBison5440 = 700f;
	private static int externalTuningBison5440 = 1;
	///////////////////   D U B   S E R I A   ///////////////////////////////////////////////////////////////////////////////////////////
	///////////////////   D U B   1 5 7   ///////////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveDUB157 = 0;
	private static int moneyActiveDUB157 = 0;
	private static int engineDUB157 = 1;
	private static int gearboxDUB157 = 1;
	private static int brakeDUB157 = 1;
	private static int fuelTankDUB157 = 1;
	private static int rearBogieDUB157 = 1;
	private static float fuelDUB157 = 200f;
	private static int externalTuningDUB157 = 1;
	///////////////////   D U B   1 3 1   ///////////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveDUB131 = 0;
	private static int moneyActiveDUB131 = 0;
	private static int engineDUB131 = 1;
	private static int gearboxDUB131 = 1;
	private static int brakeDUB131 = 1;
	private static int fuelTankDUB131 = 1;
	private static int rearBogieDUB131 = 1;
	private static float fuelDUB131 = 200f;
	private static int externalTuningDUB131 = 1;
	///////////////////   D U B   1 3 0   ///////////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveDUB130 = 0;
	private static int moneyActiveDUB130 = 0;
	private static int engineDUB130 = 1;
	private static int gearboxDUB130 = 1;
	private static int brakeDUB130 = 1;
	private static int fuelTankDUB130 = 1;
	private static int rearBogieDUB130 = 1;
	private static float fuelDUB130 = 200f;
	private static int externalTuningDUB130 = 1;
	///////////////////   D U B   1 3 3   ///////////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveDUB133 = 0;
	private static int moneyActiveDUB133 = 0;
	private static int engineDUB133 = 1;
	private static int gearboxDUB133 = 1;
	private static int brakeDUB133 = 1;
	private static int fuelTankDUB133 = 1;
	private static int rearBogieDUB133 = 1;
	private static float fuelDUB133 = 400f;
	private static int externalTuningDUB133 = 1;
	///////////////////   D U B   4 4 2 1  ///////////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveDUB4421 = 0;
	private static int moneyActiveDUB4421 = 0;
	private static int engineDUB4421 = 1;
	private static int gearboxDUB4421 = 1;
	private static int brakeDUB4421 = 1;
	private static int fuelTankDUB4421 = 1;
	private static int rearBogieDUB4421 = 1;
	private static float fuelDUB4421 = 400f;
	private static int externalTuningDUB4421 = 1;
	///////////////////   D U B   5 4 2 3  ///////////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveDUB5423 = 0;
	private static int moneyActiveDUB5423 = 0;
	private static int engineDUB5423 = 1;
	private static int gearboxDUB5423 = 1;
	private static int brakeDUB5423 = 1;
	private static int fuelTankDUB5423 = 1;
	private static int rearBogieDUB5423 = 1;
	private static float fuelDUB5423 = 500f;
	private static int externalTuningDUB5423 = 1;
	///////////////////   F I I V   S E R I A   /////////////////////////////////////////////////////////////////////////////////////////
	///////////////////   F I I V   6 9 0   ///////////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveFIIV690 = 0;
	private static int moneyActiveFIIV690 = 0;
	private static int engineFIIV690 = 1;
	private static int gearboxFIIV690 = 1;
	private static int brakeFIIV690 = 1;
	private static int fuelTankFIIV690 = 1;
	private static int rearBogieFIIV690 = 1;
	private static float fuelFIIV690 = 300f;
	private static int externalTuningFIIV690 = 1;
	///////////////////   F I I V   6 1 9   ///////////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveFIIV619 = 0;
	private static int moneyActiveFIIV619 = 0;
	private static int engineFIIV619 = 1;
	private static int gearboxFIIV619 = 1;
	private static int brakeFIIV619 = 1;
	private static int fuelTankFIIV619 = 1;
	private static int rearBogieFIIV619 = 1;
	private static float fuelFIIV619 = 200f;
	private static int externalTuningFIIV619 = 1;
	///////////////////   F I I V   T S   ///////////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveFIIVTS = 0;
	private static int moneyActiveFIIVTS = 0;
	private static int engineFIIVTS = 1;
	private static int gearboxFIIVTS = 1;
	private static int brakeFIIVTS = 1;
	private static int fuelTankFIIVTS = 1;
	private static int rearBogieFIIVTS = 1;
	private static float fuelFIIVTS = 400f;
	private static int externalTuningFIIVTS = 1;
	///////////////////   F I I V   E S   ///////////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveFIIVES = 0;
	private static int moneyActiveFIIVES = 0;
	private static int engineFIIVES = 1;
	private static int gearboxFIIVES = 1;
	private static int brakeFIIVES = 1;
	private static int fuelTankFIIVES = 1;
	private static int rearBogieFIIVES = 1;
	private static float fuelFIIVES = 500f;
	private static int externalTuningFIIVES = 1;
	///////////////////   F I I V   S T   ///////////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveFIIVST = 0;
	private static int moneyActiveFIIVST = 0;
	private static int engineFIIVST = 1;
	private static int gearboxFIIVST = 1;
	private static int brakeFIIVST = 1;
	private static int fuelTankFIIVST = 1;
	private static int rearBogieFIIVST = 1;
	private static float fuelFIIVST = 700f;
	private static int externalTuningFIIVST = 1;
	///////////////////   F I I V   S T R  ///////////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveFIIVSTR = 0;
	private static int moneyActiveFIIVSTR = 0;
	private static int engineFIIVSTR = 1;
	private static int gearboxFIIVSTR = 1;
	private static int brakeFIIVSTR = 1;
	private static int fuelTankFIIVSTR = 1;
	private static int rearBogieFIIVSTR = 1;
	private static float fuelFIIVSTR = 800f;
	private static int externalTuningFIIVSTR = 1;
	///////////////////   F I I V   H W  ///////////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveFIIVHW = 0;
	private static int moneyActiveFIIVHW = 0;
	private static int engineFIIVHW = 1;
	private static int gearboxFIIVHW = 1;
	private static int brakeFIIVHW = 1;
	private static int fuelTankFIIVHW = 1;
	private static int rearBogieFIIVHW = 1;
	private static float fuelFIIVHW = 700f;
	private static int externalTuningFIIVHW = 1;
	///////////////////   F I I V   S W  ///////////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveFIIVSW = 0;
	private static int moneyActiveFIIVSW = 0;
	private static int engineFIIVSW = 1;
	private static int gearboxFIIVSW = 1;
	private static int brakeFIIVSW = 1;
	private static int fuelTankFIIVSW = 1;
	private static int rearBogieFIIVSW = 1;
	private static float fuelFIIVSW = 700f;
	private static int externalTuningFIIVSW = 1;
	///////////////////   H O R S E   S E R I A   /////////////////////////////////////////////////////////////////////////////////////////
	///////////////////   H O R S E   5 4 1 0   ///////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveHORSE5410 = 0;
	private static int moneyActiveHORSE5410 = 0;
	private static int engineHORSE5410 = 1;
	private static int gearboxHORSE5410 = 1;
	private static int brakeHORSE5410 = 1;
	private static int fuelTankHORSE5410 = 1;
	private static int rearBogieHORSE5410 = 1;
	private static float fuelHORSE5410 = 400f;
	private static int externalTuningHORSE5410 = 1;
	///////////////////   H O R S E   6 4 6 0   ///////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveHORSE6460 = 0;
	private static int moneyActiveHORSE6460 = 0;
	private static int engineHORSE6460 = 1;
	private static int gearboxHORSE6460 = 1;
	private static int brakeHORSE6460 = 1;
	private static int fuelTankHORSE6460 = 1;
	private static int rearBogieHORSE6460 = 1;
	private static float fuelHORSE6460 = 500f;
	private static int externalTuningHORSE6460 = 1;
	///////////////////   H O R S E   5 4 6 0   ///////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveHORSE5460 = 0;
	private static int moneyActiveHORSE5460 = 0;
	private static int engineHORSE5460 = 1;
	private static int gearboxHORSE5460 = 1;
	private static int brakeHORSE5460 = 1;
	private static int fuelTankHORSE5460 = 1;
	private static int rearBogieHORSE5460 = 1;
	private static float fuelHORSE5460 = 700f;
	private static int externalTuningHORSE5460 = 1;
	///////////////////   H O R S E   1 8 4 0   ///////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveHORSE1840 = 0;
	private static int moneyActiveHORSE1840 = 0;
	private static int engineHORSE1840 = 1;
	private static int gearboxHORSE1840 = 1;
	private static int brakeHORSE1840 = 1;
	private static int fuelTankHORSE1840 = 1;
	private static int rearBogieHORSE1840 = 1;
	private static float fuelHORSE1840 = 700f;
	private static int externalTuningHORSE1840 = 1;
	///////////////////   H O R S E   1 8 5 5   ///////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveHORSE1855 = 0;
	private static int moneyActiveHORSE1855 = 0;
	private static int engineHORSE1855 = 1;
	private static int gearboxHORSE1855 = 1;
	private static int brakeHORSE1855 = 1;
	private static int fuelTankHORSE1855 = 1;
	private static int rearBogieHORSE1855 = 1;
	private static float fuelHORSE1855 = 700f;
	private static int externalTuningHORSE1855 = 1;
	///////////////////   R I D G E   S E R I A   //////////////////////////////////////////////////////////////////////////////////////
	///////////////////   R I D G E    3 7 5 C   ///////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveRIDGE375 = 0;
	private static int moneyActiveRIDGE375 = 0;
	private static int engineRIDGE375 = 1;
	private static int gearboxRIDGE375 = 1;
	private static int brakeRIDGE375 = 1;
	private static int fuelTankRIDGE375 = 1;
	private static int rearBogieRIDGE375 = 1;
	private static float fuelRIDGE375 = 300f;
	private static int externalTuningRIDGE375 = 1;
	///////////////////   R I D G E    4 4 2 0   ///////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveRIDGE4420 = 0;
	private static int moneyActiveRIDGE4420 = 0;
	private static int engineRIDGE4420 = 1;
	private static int gearboxRIDGE4420 = 1;
	private static int brakeRIDGE4420 = 1;
	private static int fuelTankRIDGE4420 = 1;
	private static int rearBogieRIDGE4420 = 1;
	private static float fuelRIDGE4420 = 400f;
	private static int externalTuningRIDGE4420 = 1;
	///////////////////   R I D G E    6 3 7 0   ///////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveRIDGE6370 = 0;
	private static int moneyActiveRIDGE6370 = 0;
	private static int engineRIDGE6370 = 1;
	private static int gearboxRIDGE6370 = 1;
	private static int brakeRIDGE6370 = 1;
	private static int fuelTankRIDGE6370 = 1;
	private static int rearBogieRIDGE6370 = 1;
	private static float fuelRIDGE6370 = 500f;
	private static int externalTuningRIDGE6370 = 1;
	///////////////////   R I D G E    N X    /////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveRIDGENX = 0;
	private static int moneyActiveRIDGENX = 0;
	private static int engineRIDGENX = 1;
	private static int gearboxRIDGENX = 1;
	private static int brakeRIDGENX = 1;
	private static int fuelTankRIDGENX = 1;
	private static int rearBogieRIDGENX = 1;
	private static float fuelRIDGENX = 600f;
	private static int externalTuningRIDGENX = 1;
	///////////////////   P R E M I U M   S E R I A   //////////////////////////////////////////////////////////////////////////////////
	///////////////////   F O R B   C A R G O   ////////////////////////////////////////////////////////////////////////////////////////
	private static int dollarActiveFORBCARGO = 0;
	private static int engineFORBCARGO = 3;
	private static int gearboxFORBCARGO = 3;
	private static int brakeFORBCARGO = 3;
	private static int fuelTankFORBCARGO = 3;
	private static int rearBogieFORBCARGO = 3;
	private static float fuelFORBCARGO = 800f;
	private static int externalTuningFORBCARGO = 2;
	///////////////////   F O R B   F M A X   ////////////////////////////////////////////////////////////////////////////////////////////
	private static int dollarActiveFORBFMAX = 0;
	private static int engineFORBFMAX = 3;
	private static int gearboxFORBFMAX = 3;
	private static int brakeFORBFMAX = 3;
	private static int fuelTankFORBFMAX = 3;
	private static int rearBogieFORBFMAX = 3;
	private static float fuelFORBFMAX = 1100f;
	private static int externalTuningFORBFMAX = 2;
	///////////////////   T R A I L E R  ///////////////////////////////////////////////////////////////////////////////////////////////
	//////////////////////   B O A R D  ////////////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveB1 = 0;
	private static int moneyActiveB1 = 0;

	private static int xpActiveB2 = 0;
	private static int moneyActiveB2 = 0;

	private static int xpActiveB3 = 0;
	private static int moneyActiveB3 = 0;

	private static int xpActiveB4 = 0;
	private static int moneyActiveB4 = 0;

	private static int xpActiveB5 = 0;
	private static int moneyActiveB5 = 0;

	private static int xpActiveB6 = 0;
	private static int moneyActiveB6 = 0;

	private static int xpActiveB7 = 0;
	private static int moneyActiveB7 = 0;
	//////////////////////   T E N T   ////////////////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveT1 = 0;
	private static int moneyActiveT1 = 0;

	private static int xpActiveT2 = 0;
	private static int moneyActiveT2 = 0;

	private static int xpActiveT3 = 0;
	private static int moneyActiveT3 = 0;

	private static int xpActiveT4 = 0;
	private static int moneyActiveT4 = 0;

	private static int xpActiveT5 = 0;
	private static int moneyActiveT5 = 0;

	private static int xpActiveT6 = 0;
	private static int moneyActiveT6 = 0;

	private static int xpActiveT7 = 0;
	private static int moneyActiveT7 = 0;

	private static int xpActiveT8 = 0;
	private static int moneyActiveT8 = 0;
	//////////////////////   R E F   ////////////////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveR1 = 0;
	private static int moneyActiveR1 = 0;

	private static int xpActiveR2 = 0;
	private static int moneyActiveR2 = 0;

	private static int xpActiveR3 = 0;
	private static int moneyActiveR3 = 0;

	private static int xpActiveR4 = 0;
	private static int moneyActiveR4 = 0;

	private static int xpActiveR5 = 0;
	private static int moneyActiveR5 = 0;

	private static int xpActiveR6 = 0;
	private static int moneyActiveR6 = 0;
	//////////////////////   C O N   ////////////////////////////////////////////////////////////////////////////////////////////////////
	private static int xpActiveC1 = 0;
	private static int moneyActiveC1 = 0;

	private static int xpActiveC2 = 0;
	private static int moneyActiveC2 = 0;

	private static int xpActiveC3 = 0;
	private static int moneyActiveC3 = 0;

	private static int xpActiveC4 = 0;
	private static int moneyActiveC4 = 0;

	private static int xpActiveC5 = 0;
	private static int moneyActiveC5 = 0;
	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////	
	void Awake()
	{
		//////////////////////   U P G R A D E   /////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("engine"))
		{
			engine = PlayerPrefs.GetInt("engine");
		}
		if (PlayerPrefs.HasKey("gearbox"))
		{
			gearbox = PlayerPrefs.GetInt("gearbox");
		}
		if (PlayerPrefs.HasKey("akpp"))
		{
			akpp = PlayerPrefs.GetInt("akpp");
		}
		if (PlayerPrefs.HasKey("brake"))
		{
			brake = PlayerPrefs.GetInt("brake");
		}
		if (PlayerPrefs.HasKey("fuelTank"))
		{
			fuelTank = PlayerPrefs.GetInt("fuelTank");
		}
		if (PlayerPrefs.HasKey("rearBogie"))
		{
			rearBogie = PlayerPrefs.GetInt("rearBogie");
		}
		if (PlayerPrefs.HasKey("externalTuning"))
		{
			externalTuning = PlayerPrefs.GetInt("externalTuning");
		}
		///////////////////   M O S   S E R I A   ///////////////////////////////////////////////////////////////////////////////////        
		///////////////////   M O S   2 0 0   //////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveBison200"))
		{
			xpActiveBison200 = PlayerPrefs.GetInt("xpActiveBison200");
		}
		if (PlayerPrefs.HasKey("moneyActiveBison200"))
		{
			moneyActiveBison200 = PlayerPrefs.GetInt("moneyActiveBison200");
		}
		if (PlayerPrefs.HasKey("engineBison200"))
		{
			engineBison200 = PlayerPrefs.GetInt("engineBison200");
		}
		if (PlayerPrefs.HasKey("gearboxBison200"))
		{
			gearboxBison200 = PlayerPrefs.GetInt("gearboxBison200");
		}
		if (PlayerPrefs.HasKey("brakeBison200"))
		{
			brakeBison200 = PlayerPrefs.GetInt("brakeBison200");
		}
		if (PlayerPrefs.HasKey("fuelTankBison200"))
		{
			fuelTankBison200 = PlayerPrefs.GetInt("fuelTankBison200");
		}
		if (PlayerPrefs.HasKey("fuelBison200"))
        {
			fuelBison200 = PlayerPrefs.GetFloat("fuelBison200");
        }
		if (PlayerPrefs.HasKey("rearBogieBison200"))
		{
			rearBogieBison200 = PlayerPrefs.GetInt("rearBogieBison200");
		}
		if (PlayerPrefs.HasKey("externalTuningBison200"))
		{
			externalTuningBison200 = PlayerPrefs.GetInt("externalTuningBison200");
		}
		///////////////////   M O S   5 0 0   //////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveBison500"))
        {
			xpActiveBison500 = PlayerPrefs.GetInt("xpActiveBison500");
        }
        if (PlayerPrefs.HasKey("moneyActive500"))
        {
			moneyActive500 = PlayerPrefs.GetInt("moneyActive500");
        }
		if (PlayerPrefs.HasKey("engineBison500"))
		{
			engineBison500 = PlayerPrefs.GetInt("engineBison500");
		}
		if (PlayerPrefs.HasKey("gearboxBison500"))
		{
			gearboxBison500 = PlayerPrefs.GetInt("gearboxBison500");
		}
		if (PlayerPrefs.HasKey("brakeBison500"))
		{
			brakeBison500 = PlayerPrefs.GetInt("brakeBison500");
		}
		if (PlayerPrefs.HasKey("fuelTankBison500"))
		{
			fuelTankBison500 = PlayerPrefs.GetInt("fuelTankBison500");
		}
		if (PlayerPrefs.HasKey("fuelBison500"))
		{
			fuelBison500 = PlayerPrefs.GetFloat("fuelBison500");
		}
		if (PlayerPrefs.HasKey("rearBogieBison500"))
		{
			rearBogieBison500 = PlayerPrefs.GetInt("rearBogieBison500");
		}
		if (PlayerPrefs.HasKey("externalTuningBison500"))
		{
			externalTuningBison500 = PlayerPrefs.GetInt("externalTuningBison500");
		}
		///////////////////   M O S   5 4 3 2  //////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveBison5432"))
		{
			xpActiveBison5432 = PlayerPrefs.GetInt("xpActiveBison5432");
		}
		if (PlayerPrefs.HasKey("moneyActive5432"))
		{
			moneyActive5432 = PlayerPrefs.GetInt("moneyActive5432");
		}
		if (PlayerPrefs.HasKey("engineBison5432"))
		{
			engineBison5432 = PlayerPrefs.GetInt("engineBison5432");
		}
		if (PlayerPrefs.HasKey("gearboxBison5432"))
		{
			gearboxBison5432 = PlayerPrefs.GetInt("gearboxBison5432");
		}
		if (PlayerPrefs.HasKey("brakeBison5432"))
		{
			brakeBison5432 = PlayerPrefs.GetInt("brakeBison5432");
		}
		if (PlayerPrefs.HasKey("fuelTankBison5432"))
		{
			fuelTankBison5432 = PlayerPrefs.GetInt("fuelTankBison5432");
		}
		if (PlayerPrefs.HasKey("fuelBison5432"))
		{
			fuelBison5432 = PlayerPrefs.GetFloat("fuelBison5432");
		}
		if (PlayerPrefs.HasKey("rearBogieBison5432"))
		{
			rearBogieBison5432 = PlayerPrefs.GetInt("rearBogieBison5432");
		}
		if (PlayerPrefs.HasKey("externalTuningBison5432"))
		{
			externalTuningBison5432 = PlayerPrefs.GetInt("externalTuningBison5432");
		}
		///////////////////   B I S O N   6 4 2 2   /////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveBison6422"))
		{
			xpActiveBison6422 = PlayerPrefs.GetInt("xpActiveBison6422");
		}
		if (PlayerPrefs.HasKey("moneyActive6422"))
		{
			moneyActive6422 = PlayerPrefs.GetInt("moneyActive6422");
		}
		if (PlayerPrefs.HasKey("engineBison6422"))
		{
			engineBison6422 = PlayerPrefs.GetInt("engineBison6422");
		}
		if (PlayerPrefs.HasKey("gearboxBison6422"))
		{
			gearboxBison6422 = PlayerPrefs.GetInt("gearboxBison6422");
		}
		if (PlayerPrefs.HasKey("brakeBison6422"))
		{
			brakeBison6422 = PlayerPrefs.GetInt("brakeBison6422");
		}
		if (PlayerPrefs.HasKey("fuelTankBison6422"))
		{
			fuelTankBison6422 = PlayerPrefs.GetInt("fuelTankBison6422");
		}
		if (PlayerPrefs.HasKey("fuelBison6422"))
		{
			fuelBison6422 = PlayerPrefs.GetFloat("fuelBison6422");
		}
		if (PlayerPrefs.HasKey("rearBogieBison6422"))
		{
			rearBogieBison6422 = PlayerPrefs.GetInt("rearBogieBison6422");
		}
		if (PlayerPrefs.HasKey("externalTuningBison6422"))
		{
			externalTuningBison6422 = PlayerPrefs.GetInt("externalTuningBison6422");
		}
		///////////////////   B I S O N   6 4 3 0   ////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveBison6430"))
		{
			xpActiveBison6430 = PlayerPrefs.GetInt("xpActiveBison6430");
		}
		if (PlayerPrefs.HasKey("moneyActive6430"))
		{
			moneyActive6430 = PlayerPrefs.GetInt("moneyActive6430");
		}
		if (PlayerPrefs.HasKey("engineBison6430"))
		{
			engineBison6430 = PlayerPrefs.GetInt("engineBison6430");
		}
		if (PlayerPrefs.HasKey("gearboxBison6430"))
		{
			gearboxBison6430 = PlayerPrefs.GetInt("gearboxBison6430");
		}
		if (PlayerPrefs.HasKey("brakeBison6430"))
		{
			brakeBison6430 = PlayerPrefs.GetInt("brakeBison6430");
		}
		if (PlayerPrefs.HasKey("fuelTankBison6430"))
		{
			fuelTankBison6430 = PlayerPrefs.GetInt("fuelTankBison6430");
		}
		if (PlayerPrefs.HasKey("fuelBison6430"))
		{
			fuelBison6430 = PlayerPrefs.GetFloat("fuelBison6430");
		}
		if (PlayerPrefs.HasKey("rearBogieBison6430"))
		{
			rearBogieBison6430 = PlayerPrefs.GetInt("rearBogieBison6430");
		}
		if (PlayerPrefs.HasKey("externalTuningBison6430"))
		{
			externalTuningBison6430 = PlayerPrefs.GetInt("externalTuningBison6430");
		}
		///////////////////   B I S O N   6 4 4 0   ////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveBison6440"))
		{
			xpActiveBison6440 = PlayerPrefs.GetInt("xpActiveBison6440");
		}
		if (PlayerPrefs.HasKey("moneyActive6440"))
		{
			moneyActive6440 = PlayerPrefs.GetInt("moneyActive6440");
		}
		if (PlayerPrefs.HasKey("engineBison6440"))
		{
			engineBison6440 = PlayerPrefs.GetInt("engineBison6440");
		}
		if (PlayerPrefs.HasKey("gearboxBison6440"))
		{
			gearboxBison6440 = PlayerPrefs.GetInt("gearboxBison6440");
		}
		if (PlayerPrefs.HasKey("brakeBison6440"))
		{
			brakeBison6440 = PlayerPrefs.GetInt("brakeBison6440");
		}
		if (PlayerPrefs.HasKey("fuelTankBison6440"))
		{
			fuelTankBison6440 = PlayerPrefs.GetInt("fuelTankBison6440");
		}
		if (PlayerPrefs.HasKey("fuelBison6440"))
		{
			fuelBison6440 = PlayerPrefs.GetFloat("fuelBison6440");
		}
		if (PlayerPrefs.HasKey("rearBogieBison6440"))
		{
			rearBogieBison6440 = PlayerPrefs.GetInt("rearBogieBison6440");
		}
		if (PlayerPrefs.HasKey("externalTuningBison6440"))
		{
			externalTuningBison6440 = PlayerPrefs.GetInt("externalTuningBison6440");
		}
		///////////////////   B I S O N   5 4 4 0   ////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveBison5440"))
		{
			xpActiveBison5440 = PlayerPrefs.GetInt("xpActiveBison5440");
		}
		if (PlayerPrefs.HasKey("moneyActive5440"))
		{
			moneyActive5440 = PlayerPrefs.GetInt("moneyActive5440");
		}
		if (PlayerPrefs.HasKey("engineBison5440"))
		{
			engineBison5440 = PlayerPrefs.GetInt("engineBison5440");
		}
		if (PlayerPrefs.HasKey("gearboxBison5440"))
		{
			gearboxBison5440 = PlayerPrefs.GetInt("gearboxBison5440");
		}
		if (PlayerPrefs.HasKey("brakeBison5440"))
		{
			brakeBison5440 = PlayerPrefs.GetInt("brakeBison5440");
		}
		if (PlayerPrefs.HasKey("fuelTankBison5440"))
		{
			fuelTankBison5440 = PlayerPrefs.GetInt("fuelTankBison5440");
		}
		if (PlayerPrefs.HasKey("fuelBison5440"))
		{
			fuelBison5440 = PlayerPrefs.GetFloat("fuelBison5440");
		}
		if (PlayerPrefs.HasKey("rearBogieBison5440"))
		{
			rearBogieBison5440 = PlayerPrefs.GetInt("rearBogieBison5440");
		}
		if (PlayerPrefs.HasKey("externalTuningBison5440"))
		{
			externalTuningBison5440 = PlayerPrefs.GetInt("externalTuningBison5440");
		}
		///////////////////   D U B   1 5 7   ////////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveDUB157"))
		{
			xpActiveDUB157 = PlayerPrefs.GetInt("xpActiveDUB157");
		}
		if (PlayerPrefs.HasKey("moneyActiveDUB157"))
		{
			moneyActiveDUB157 = PlayerPrefs.GetInt("moneyActiveDUB157");
		}		
		if (PlayerPrefs.HasKey("engineDUB157"))
		{
			engineDUB157 = PlayerPrefs.GetInt("engineDUB157");
		}
		if (PlayerPrefs.HasKey("gearboxDUB157"))
		{
			gearboxDUB157 = PlayerPrefs.GetInt("gearboxDUB157");
		}
		if (PlayerPrefs.HasKey("brakeDUB157"))
		{
			brakeDUB157 = PlayerPrefs.GetInt("brakeDUB157");
		}
		if (PlayerPrefs.HasKey("fuelTankDUB157"))
		{
			fuelTankDUB157 = PlayerPrefs.GetInt("fuelTankDUB157");
		}
		if (PlayerPrefs.HasKey("fuelDUB157"))
		{
			fuelDUB157 = PlayerPrefs.GetFloat("fuelDUB157");
		}
		if (PlayerPrefs.HasKey("rearBogieDUB157"))
		{
			rearBogieDUB157 = PlayerPrefs.GetInt("rearBogieDUB157");
		}
		if (PlayerPrefs.HasKey("externalTuningDUB157"))
		{
			externalTuningDUB157 = PlayerPrefs.GetInt("externalTuningDUB157");
		}
		///////////////////   D U B   1 3 1   ////////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveDUB131"))
		{
			xpActiveDUB131 = PlayerPrefs.GetInt("xpActiveDUB131");
		}
		if (PlayerPrefs.HasKey("moneyActiveDUB131"))
		{
			moneyActiveDUB131 = PlayerPrefs.GetInt("moneyActiveDUB131");
		}
		if (PlayerPrefs.HasKey("engineDUB131"))
		{
			engineDUB131 = PlayerPrefs.GetInt("engineDUB131");
		}
		if (PlayerPrefs.HasKey("gearboxDUB131"))
		{
			gearboxDUB131 = PlayerPrefs.GetInt("gearboxDUB131");
		}
		if (PlayerPrefs.HasKey("brakeDUB131"))
		{
			brakeDUB131 = PlayerPrefs.GetInt("brakeDUB131");
		}
		if (PlayerPrefs.HasKey("fuelTankDUB131"))
		{
			fuelTankDUB131 = PlayerPrefs.GetInt("fuelTankDUB131");
		}
		if (PlayerPrefs.HasKey("fuelDUB131"))
		{
			fuelDUB131 = PlayerPrefs.GetFloat("fuelDUB131");
		}
		if (PlayerPrefs.HasKey("rearBogieDUB131"))
		{
			rearBogieDUB131 = PlayerPrefs.GetInt("rearBogieDUB131");
		}
		if (PlayerPrefs.HasKey("externalTuningDUB131"))
		{
			externalTuningDUB131 = PlayerPrefs.GetInt("externalTuningDUB131");
		}
		///////////////////   D U B   1 3 0   ////////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveDUB130"))
		{
			xpActiveDUB130 = PlayerPrefs.GetInt("xpActiveDUB130");
		}
		if (PlayerPrefs.HasKey("moneyActiveDUB130"))
		{
			moneyActiveDUB130 = PlayerPrefs.GetInt("moneyActiveDUB130");
		}
		if (PlayerPrefs.HasKey("engineDUB130"))
		{
			engineDUB130 = PlayerPrefs.GetInt("engineDUB130");
		}
		if (PlayerPrefs.HasKey("gearboxDUB130"))
		{
			gearboxDUB130 = PlayerPrefs.GetInt("gearboxDUB130");
		}
		if (PlayerPrefs.HasKey("brakeDUB130"))
		{
			brakeDUB130 = PlayerPrefs.GetInt("brakeDUB130");
		}
		if (PlayerPrefs.HasKey("fuelTankDUB130"))
		{
			fuelTankDUB130 = PlayerPrefs.GetInt("fuelTankDUB130");
		}
		if (PlayerPrefs.HasKey("fuelDUB130"))
		{
			fuelDUB130 = PlayerPrefs.GetFloat("fuelDUB130");
		}
		if (PlayerPrefs.HasKey("rearBogieDUB130"))
		{
			rearBogieDUB130 = PlayerPrefs.GetInt("rearBogieDUB130");
		}
		if (PlayerPrefs.HasKey("externalTuningDUB130"))
		{
			externalTuningDUB130 = PlayerPrefs.GetInt("externalTuningDUB130");
		}
		///////////////////   D U B   1 3 3   ////////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveDUB133"))
		{
			xpActiveDUB133 = PlayerPrefs.GetInt("xpActiveDUB133");
		}
		if (PlayerPrefs.HasKey("moneyActiveDUB133"))
		{
			moneyActiveDUB133 = PlayerPrefs.GetInt("moneyActiveDUB133");
		}
		if (PlayerPrefs.HasKey("engineDUB133"))
		{
			engineDUB133 = PlayerPrefs.GetInt("engineDUB133");
		}
		if (PlayerPrefs.HasKey("gearboxDUB133"))
		{
			gearboxDUB133 = PlayerPrefs.GetInt("gearboxDUB133");
		}
		if (PlayerPrefs.HasKey("brakeDUB133"))
		{
			brakeDUB133 = PlayerPrefs.GetInt("brakeDUB133");
		}
		if (PlayerPrefs.HasKey("fuelTankDUB133"))
		{
			fuelTankDUB133 = PlayerPrefs.GetInt("fuelTankDUB133");
		}
		if (PlayerPrefs.HasKey("fuelDUB133"))
		{
			fuelDUB133 = PlayerPrefs.GetFloat("fuelDUB133");
		}
		if (PlayerPrefs.HasKey("rearBogieDUB133"))
		{
			rearBogieDUB133 = PlayerPrefs.GetInt("rearBogieDUB133");
		}
		if (PlayerPrefs.HasKey("externalTuningDUB133"))
		{
			externalTuningDUB133 = PlayerPrefs.GetInt("externalTuningDUB133");
		}
		///////////////////   D U B   4 4 2 1  ///////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveDUB4421"))
		{
			xpActiveDUB4421 = PlayerPrefs.GetInt("xpActiveDUB4421");
		}
		if (PlayerPrefs.HasKey("moneyActiveDUB4421"))
		{
			moneyActiveDUB4421 = PlayerPrefs.GetInt("moneyActiveDUB4421");
		}
		if (PlayerPrefs.HasKey("engineDUB4421"))
		{
			engineDUB4421 = PlayerPrefs.GetInt("engineDUB4421");
		}
		if (PlayerPrefs.HasKey("gearboxDUB4421"))
		{
			gearboxDUB4421 = PlayerPrefs.GetInt("gearboxDUB4421");
		}
		if (PlayerPrefs.HasKey("brakeDUB4421"))
		{
			brakeDUB4421 = PlayerPrefs.GetInt("brakeDUB4421");
		}
		if (PlayerPrefs.HasKey("fuelTankDUB4421"))
		{
			fuelTankDUB4421 = PlayerPrefs.GetInt("fuelTankDUB4421");
		}
		if (PlayerPrefs.HasKey("fuelDUB4421"))
		{
			fuelDUB4421 = PlayerPrefs.GetFloat("fuelDUB4421");
		}
		if (PlayerPrefs.HasKey("rearBogieDUB4421"))
		{
			rearBogieDUB4421 = PlayerPrefs.GetInt("rearBogieDUB4421");
		}
		if (PlayerPrefs.HasKey("externalTuningDUB4421"))
		{
			externalTuningDUB4421 = PlayerPrefs.GetInt("externalTuningDUB4421");
		}
		///////////////////   D U B   5 4 2 3  ///////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveDUB5423"))
		{
			xpActiveDUB5423 = PlayerPrefs.GetInt("xpActiveDUB5423");
		}
		if (PlayerPrefs.HasKey("moneyActiveDUB5423"))
		{
			moneyActiveDUB5423 = PlayerPrefs.GetInt("moneyActiveDUB5423");
		}
		if (PlayerPrefs.HasKey("engineDUB5423"))
		{
			engineDUB5423 = PlayerPrefs.GetInt("engineDUB5423");
		}
		if (PlayerPrefs.HasKey("gearboxDUB5423"))
		{
			gearboxDUB5423 = PlayerPrefs.GetInt("gearboxDUB5423");
		}
		if (PlayerPrefs.HasKey("brakeDUB5423"))
		{
			brakeDUB5423 = PlayerPrefs.GetInt("brakeDUB5423");
		}
		if (PlayerPrefs.HasKey("fuelTankDUB5423"))
		{
			fuelTankDUB5423 = PlayerPrefs.GetInt("fuelTankDUB5423");
		}
		if (PlayerPrefs.HasKey("fuelDUB5423"))
		{
			fuelDUB5423 = PlayerPrefs.GetFloat("fuelDUB5423");
		}
		if (PlayerPrefs.HasKey("rearBogieDUB5423"))
		{
			rearBogieDUB5423 = PlayerPrefs.GetInt("rearBogieDUB5423");
		}
		if (PlayerPrefs.HasKey("externalTuningDUB5423"))
		{
			externalTuningDUB5423 = PlayerPrefs.GetInt("externalTuningDUB5423");
		}
		///////////////////   F I I V   S E R I A   /////////////////////////////////////////////////////////////////////////////////////////
		///////////////////   F I I V   6 9 0   ///////////////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveFIIV690"))
		{
			xpActiveFIIV690 = PlayerPrefs.GetInt("xpActiveFIIV690");
		}
		if (PlayerPrefs.HasKey("moneyActiveFIIV690"))
		{
			moneyActiveFIIV690 = PlayerPrefs.GetInt("moneyActiveFIIV690");
		}
		if (PlayerPrefs.HasKey("engineFIIV690"))
		{
			engineFIIV690 = PlayerPrefs.GetInt("engineFIIV690");
		}
		if (PlayerPrefs.HasKey("gearboxFIIV690"))
		{
			gearboxFIIV690 = PlayerPrefs.GetInt("gearboxFIIV690");
		}
		if (PlayerPrefs.HasKey("brakeFIIV690"))
		{
			brakeFIIV690 = PlayerPrefs.GetInt("brakeFIIV690");
		}
		if (PlayerPrefs.HasKey("fuelTankFIIV690"))
		{
			fuelTankFIIV690 = PlayerPrefs.GetInt("fuelTankFIIV690");
		}
		if (PlayerPrefs.HasKey("fuelFIIV690"))
		{
			fuelFIIV690 = PlayerPrefs.GetFloat("fuelFIIV690");
		}
		if (PlayerPrefs.HasKey("rearBogieFIIV690"))
		{
			rearBogieFIIV690 = PlayerPrefs.GetInt("rearBogieFIIV690");
		}
		if (PlayerPrefs.HasKey("externalTuningFIIV690"))
		{
			externalTuningFIIV690 = PlayerPrefs.GetInt("externalTuningFIIV690");
		}
		///////////////////   F I I V   6 1 9   ///////////////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveFIIV619"))
		{
			xpActiveFIIV619 = PlayerPrefs.GetInt("xpActiveFIIV619");
		}
		if (PlayerPrefs.HasKey("moneyActiveFIIV619"))
		{
			moneyActiveFIIV619 = PlayerPrefs.GetInt("moneyActiveFIIV619");
		}
		if (PlayerPrefs.HasKey("engineFIIV619"))
		{
			engineFIIV619 = PlayerPrefs.GetInt("engineFIIV619");
		}
		if (PlayerPrefs.HasKey("gearboxFIIV619"))
		{
			gearboxFIIV619 = PlayerPrefs.GetInt("gearboxFIIV619");
		}
		if (PlayerPrefs.HasKey("brakeFIIV619"))
		{
			brakeFIIV619 = PlayerPrefs.GetInt("brakeFIIV619");
		}
		if (PlayerPrefs.HasKey("fuelTankFIIV619"))
		{
			fuelTankFIIV619 = PlayerPrefs.GetInt("fuelTankFIIV619");
		}
		if (PlayerPrefs.HasKey("fuelFIIV619"))
		{
			fuelFIIV619 = PlayerPrefs.GetFloat("fuelFIIV619");
		}
		if (PlayerPrefs.HasKey("rearBogieFIIV619"))
		{
			rearBogieFIIV619 = PlayerPrefs.GetInt("rearBogieFIIV619");
		}
		if (PlayerPrefs.HasKey("externalTuningFIIV619"))
		{
			externalTuningFIIV619 = PlayerPrefs.GetInt("externalTuningFIIV619");
		}
		///////////////////   F I I V   T S  ///////////////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveFIIVTS"))
		{
			xpActiveFIIVTS = PlayerPrefs.GetInt("xpActiveFIIVTS");
		}
		if (PlayerPrefs.HasKey("moneyActiveFIIVTS"))
		{
			moneyActiveFIIVTS = PlayerPrefs.GetInt("moneyActiveFIIVTS");
		}
		if (PlayerPrefs.HasKey("engineFIIVTS"))
		{
			engineFIIVTS = PlayerPrefs.GetInt("engineFIIVTS");
		}
		if (PlayerPrefs.HasKey("gearboxFIIVTS"))
		{
			gearboxFIIVTS = PlayerPrefs.GetInt("gearboxFIIVTS");
		}
		if (PlayerPrefs.HasKey("brakeFIIVTS"))
		{
			brakeFIIVTS = PlayerPrefs.GetInt("brakeFIIVTS");
		}
		if (PlayerPrefs.HasKey("fuelTankFIIVTS"))
		{
			fuelTankFIIVTS = PlayerPrefs.GetInt("fuelTankFIIVTS");
		}
		if (PlayerPrefs.HasKey("fuelFIIVTS"))
		{
			fuelFIIVTS = PlayerPrefs.GetFloat("fuelFIIVTS");
		}
		if (PlayerPrefs.HasKey("rearBogieFIIVTS"))
		{
			rearBogieFIIVTS = PlayerPrefs.GetInt("rearBogieFIIVTS");
		}
		if (PlayerPrefs.HasKey("externalTuningFIIVTS"))
		{
			externalTuningFIIVTS = PlayerPrefs.GetInt("externalTuningFIIVTS");
		}
		///////////////////   F I I V   E S  ///////////////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveFIIVES"))
		{
			xpActiveFIIVES = PlayerPrefs.GetInt("xpActiveFIIVES");
		}
		if (PlayerPrefs.HasKey("moneyActiveFIIVES"))
		{
			moneyActiveFIIVES = PlayerPrefs.GetInt("moneyActiveFIIVES");
		}
		if (PlayerPrefs.HasKey("engineFIIVES"))
		{
			engineFIIVES = PlayerPrefs.GetInt("engineFIIVES");
		}
		if (PlayerPrefs.HasKey("gearboxFIIVES"))
		{
			gearboxFIIVES = PlayerPrefs.GetInt("gearboxFIIVES");
		}
		if (PlayerPrefs.HasKey("brakeFIIVES"))
		{
			brakeFIIVES = PlayerPrefs.GetInt("brakeFIIVES");
		}
		if (PlayerPrefs.HasKey("fuelTankFIIVES"))
		{
			fuelTankFIIVES = PlayerPrefs.GetInt("fuelTankFIIVES");
		}
		if (PlayerPrefs.HasKey("fuelFIIVES"))
		{
			fuelFIIVES = PlayerPrefs.GetFloat("fuelFIIVES");
		}
		if (PlayerPrefs.HasKey("rearBogieFIIVES"))
		{
			rearBogieFIIVES = PlayerPrefs.GetInt("rearBogieFIIVES");
		}
		if (PlayerPrefs.HasKey("externalTuningFIIVES"))
		{
			externalTuningFIIVES = PlayerPrefs.GetInt("externalTuningFIIVES");
		}
		///////////////////   F I I V   S T  ///////////////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveFIIVST"))
		{
			xpActiveFIIVST = PlayerPrefs.GetInt("xpActiveFIIVST");
		}
		if (PlayerPrefs.HasKey("moneyActiveFIIVST"))
		{
			moneyActiveFIIVST = PlayerPrefs.GetInt("moneyActiveFIIVST");
		}
		if (PlayerPrefs.HasKey("engineFIIVST"))
		{
			engineFIIVST = PlayerPrefs.GetInt("engineFIIVST");
		}
		if (PlayerPrefs.HasKey("gearboxFIIVST"))
		{
			gearboxFIIVST = PlayerPrefs.GetInt("gearboxFIIVST");
		}
		if (PlayerPrefs.HasKey("brakeFIIVST"))
		{
			brakeFIIVST = PlayerPrefs.GetInt("brakeFIIVST");
		}
		if (PlayerPrefs.HasKey("fuelTankFIIVST"))
		{
			fuelTankFIIVST = PlayerPrefs.GetInt("fuelTankFIIVST");
		}
		if (PlayerPrefs.HasKey("fuelFIIVST"))
		{
			fuelFIIVST = PlayerPrefs.GetFloat("fuelFIIVST");
		}
		if (PlayerPrefs.HasKey("rearBogieFIIVST"))
		{
			rearBogieFIIVST = PlayerPrefs.GetInt("rearBogieFIIVST");
		}
		if (PlayerPrefs.HasKey("externalTuningFIIVST"))
		{
			externalTuningFIIVST = PlayerPrefs.GetInt("externalTuningFIIVST");
		}
		///////////////////   F I I V   S T R  ///////////////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveFIIVSTR"))
		{
			xpActiveFIIVSTR = PlayerPrefs.GetInt("xpActiveFIIVSTR");
		}
		if (PlayerPrefs.HasKey("moneyActiveFIIVSTR"))
		{
			moneyActiveFIIVSTR = PlayerPrefs.GetInt("moneyActiveFIIVSTR");
		}
		if (PlayerPrefs.HasKey("engineFIIVSTR"))
		{
			engineFIIVSTR = PlayerPrefs.GetInt("engineFIIVSTR");
		}
		if (PlayerPrefs.HasKey("gearboxFIIVSTR"))
		{
			gearboxFIIVSTR = PlayerPrefs.GetInt("gearboxFIIVSTR");
		}
		if (PlayerPrefs.HasKey("brakeFIIVSTR"))
		{
			brakeFIIVSTR = PlayerPrefs.GetInt("brakeFIIVSTR");
		}
		if (PlayerPrefs.HasKey("fuelTankFIIVSTR"))
		{
			fuelTankFIIVSTR = PlayerPrefs.GetInt("fuelTankFIIVSTR");
		}
		if (PlayerPrefs.HasKey("fuelFIIVSTR"))
		{
			fuelFIIVSTR = PlayerPrefs.GetFloat("fuelFIIVSTR");
		}
		if (PlayerPrefs.HasKey("rearBogieFIIVSTR"))
		{
			rearBogieFIIVSTR = PlayerPrefs.GetInt("rearBogieFIIVSTR");
		}
		if (PlayerPrefs.HasKey("externalTuningFIIVSTR"))
		{
			externalTuningFIIVSTR = PlayerPrefs.GetInt("externalTuningFIIVSTR");
		}
		///////////////////   F I I V   H W  ///////////////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveFIIVHW"))
		{
			xpActiveFIIVHW = PlayerPrefs.GetInt("xpActiveFIIVHW");
		}
		if (PlayerPrefs.HasKey("moneyActiveFIIVHW"))
		{
			moneyActiveFIIVHW = PlayerPrefs.GetInt("moneyActiveFIIVHW");
		}
		if (PlayerPrefs.HasKey("engineFIIVHW"))
		{
			engineFIIVHW = PlayerPrefs.GetInt("engineFIIVHW");
		}
		if (PlayerPrefs.HasKey("gearboxFIIVHW"))
		{
			gearboxFIIVHW = PlayerPrefs.GetInt("gearboxFIIVHW");
		}
		if (PlayerPrefs.HasKey("brakeFIIVHW"))
		{
			brakeFIIVHW = PlayerPrefs.GetInt("brakeFIIVHW");
		}
		if (PlayerPrefs.HasKey("fuelTankFIIVHW"))
		{
			fuelTankFIIVHW = PlayerPrefs.GetInt("fuelTankFIIVHW");
		}
		if (PlayerPrefs.HasKey("fuelFIIVHW"))
		{
			fuelFIIVHW = PlayerPrefs.GetFloat("fuelFIIVHW");
		}
		if (PlayerPrefs.HasKey("rearBogieFIIVHW"))
		{
			rearBogieFIIVHW = PlayerPrefs.GetInt("rearBogieFIIVHW");
		}
		if (PlayerPrefs.HasKey("externalTuningFIIVHW"))
		{
			externalTuningFIIVHW = PlayerPrefs.GetInt("externalTuningFIIVHW");
		}
		///////////////////   F I I V   S W  ///////////////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveFIIVSW"))
		{
			xpActiveFIIVSW = PlayerPrefs.GetInt("xpActiveFIIVSW");
		}
		if (PlayerPrefs.HasKey("moneyActiveFIIVSW"))
		{
			moneyActiveFIIVSW = PlayerPrefs.GetInt("moneyActiveFIIVSW");
		}
		if (PlayerPrefs.HasKey("engineFIIVSW"))
		{
			engineFIIVSW = PlayerPrefs.GetInt("engineFIIVSW");
		}
		if (PlayerPrefs.HasKey("gearboxFIIVSW"))
		{
			gearboxFIIVSW = PlayerPrefs.GetInt("gearboxFIIVSW");
		}
		if (PlayerPrefs.HasKey("brakeFIIVSW"))
		{
			brakeFIIVSW = PlayerPrefs.GetInt("brakeFIIVSW");
		}
		if (PlayerPrefs.HasKey("fuelTankFIIVSW"))
		{
			fuelTankFIIVSW = PlayerPrefs.GetInt("fuelTankFIIVSW");
		}
		if (PlayerPrefs.HasKey("fuelFIIVSW"))
		{
			fuelFIIVSW = PlayerPrefs.GetFloat("fuelFIIVSW");
		}
		if (PlayerPrefs.HasKey("rearBogieFIIVSW"))
		{
			rearBogieFIIVSW = PlayerPrefs.GetInt("rearBogieFIIVSW");
		}
		if (PlayerPrefs.HasKey("externalTuningFIIVSW"))
		{
			externalTuningFIIVSW = PlayerPrefs.GetInt("externalTuningFIIVSW");
		}
		///////////////////   H O R S E   S E R I A   /////////////////////////////////////////////////////////////////////////////////////////
		///////////////////   H O R S E   5 4 1 0   ///////////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveHORSE5410"))
		{
			xpActiveHORSE5410 = PlayerPrefs.GetInt("xpActiveHORSE5410");
		}
		if (PlayerPrefs.HasKey("moneyActiveHORSE5410"))
		{
			moneyActiveHORSE5410 = PlayerPrefs.GetInt("moneyActiveHORSE5410");
		}
		if (PlayerPrefs.HasKey("engineHORSE5410"))
		{
			engineHORSE5410 = PlayerPrefs.GetInt("engineHORSE5410");
		}
		if (PlayerPrefs.HasKey("gearboxHORSE5410"))
		{
			gearboxHORSE5410 = PlayerPrefs.GetInt("gearboxHORSE5410");
		}
		if (PlayerPrefs.HasKey("brakeHORSE5410"))
		{
			brakeHORSE5410 = PlayerPrefs.GetInt("brakeHORSE5410");
		}
		if (PlayerPrefs.HasKey("fuelTankHORSE5410"))
		{
			fuelTankHORSE5410 = PlayerPrefs.GetInt("fuelTankHORSE5410");
		}
		if (PlayerPrefs.HasKey("fuelHORSE5410"))
		{
			fuelHORSE5410 = PlayerPrefs.GetFloat("fuelHORSE5410");
		}
		if (PlayerPrefs.HasKey("rearBogieHORSE5410"))
		{
			rearBogieHORSE5410 = PlayerPrefs.GetInt("rearBogieHORSE5410");
		}
		if (PlayerPrefs.HasKey("externalTuningHORSE5410"))
		{
			externalTuningHORSE5410 = PlayerPrefs.GetInt("externalTuningHORSE5410");
		}
		///////////////////   H O R S E   6 4 6 0   ///////////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveHORSE6460"))
		{
			xpActiveHORSE6460 = PlayerPrefs.GetInt("xpActiveHORSE6460");
		}
		if (PlayerPrefs.HasKey("moneyActiveHORSE6460"))
		{
			moneyActiveHORSE6460 = PlayerPrefs.GetInt("moneyActiveHORSE6460");
		}
		if (PlayerPrefs.HasKey("engineHORSE6460"))
		{
			engineHORSE6460 = PlayerPrefs.GetInt("engineHORSE6460");
		}
		if (PlayerPrefs.HasKey("gearboxHORSE6460"))
		{
			gearboxHORSE6460 = PlayerPrefs.GetInt("gearboxHORSE6460");
		}
		if (PlayerPrefs.HasKey("brakeHORSE6460"))
		{
			brakeHORSE6460 = PlayerPrefs.GetInt("brakeHORSE6460");
		}
		if (PlayerPrefs.HasKey("fuelTankHORSE6460"))
		{
			fuelTankHORSE6460 = PlayerPrefs.GetInt("fuelTankHORSE6460");
		}
		if (PlayerPrefs.HasKey("fuelHORSE6460"))
		{
			fuelHORSE6460 = PlayerPrefs.GetFloat("fuelHORSE6460");
		}
		if (PlayerPrefs.HasKey("rearBogieHORSE6460"))
		{
			rearBogieHORSE6460 = PlayerPrefs.GetInt("rearBogieHORSE6460");
		}
		if (PlayerPrefs.HasKey("externalTuningHORSE6460"))
		{
			externalTuningHORSE6460 = PlayerPrefs.GetInt("externalTuningHORSE6460");
		}
		///////////////////   H O R S E   5 4 6 0   ///////////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveHORSE5460"))
		{
			xpActiveHORSE5460 = PlayerPrefs.GetInt("xpActiveHORSE5460");
		}
		if (PlayerPrefs.HasKey("moneyActiveHORSE5460"))
		{
			moneyActiveHORSE5460 = PlayerPrefs.GetInt("moneyActiveHORSE5460");
		}
		if (PlayerPrefs.HasKey("engineHORSE5460"))
		{
			engineHORSE5460 = PlayerPrefs.GetInt("engineHORSE5460");
		}
		if (PlayerPrefs.HasKey("gearboxHORSE5460"))
		{
			gearboxHORSE5460 = PlayerPrefs.GetInt("gearboxHORSE5460");
		}
		if (PlayerPrefs.HasKey("brakeHORSE5460"))
		{
			brakeHORSE5460 = PlayerPrefs.GetInt("brakeHORSE5460");
		}
		if (PlayerPrefs.HasKey("fuelTankHORSE5460"))
		{
			fuelTankHORSE5460 = PlayerPrefs.GetInt("fuelTankHORSE5460");
		}
		if (PlayerPrefs.HasKey("fuelHORSE5460"))
		{
			fuelHORSE5460 = PlayerPrefs.GetFloat("fuelHORSE5460");
		}
		if (PlayerPrefs.HasKey("rearBogieHORSE5460"))
		{
			rearBogieHORSE5460 = PlayerPrefs.GetInt("rearBogieHORSE5460");
		}
		if (PlayerPrefs.HasKey("externalTuningHORSE5460"))
		{
			externalTuningHORSE5460 = PlayerPrefs.GetInt("externalTuningHORSE5460");
		}
		///////////////////   H O R S E   1 8 4 0   ///////////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveHORSE1840"))
		{
			xpActiveHORSE1840 = PlayerPrefs.GetInt("xpActiveHORSE1840");
		}
		if (PlayerPrefs.HasKey("moneyActiveHORSE1840"))
		{
			moneyActiveHORSE1840 = PlayerPrefs.GetInt("moneyActiveHORSE1840");
		}
		if (PlayerPrefs.HasKey("engineHORSE1840"))
		{
			engineHORSE1840 = PlayerPrefs.GetInt("engineHORSE1840");
		}
		if (PlayerPrefs.HasKey("gearboxHORSE1840"))
		{
			gearboxHORSE1840 = PlayerPrefs.GetInt("gearboxHORSE1840");
		}
		if (PlayerPrefs.HasKey("brakeHORSE1840"))
		{
			brakeHORSE1840 = PlayerPrefs.GetInt("brakeHORSE1840");
		}
		if (PlayerPrefs.HasKey("fuelTankHORSE1840"))
		{
			fuelTankHORSE1840 = PlayerPrefs.GetInt("fuelTankHORSE1840");
		}
		if (PlayerPrefs.HasKey("fuelHORSE1840"))
		{
			fuelHORSE1840 = PlayerPrefs.GetFloat("fuelHORSE1840");
		}
		if (PlayerPrefs.HasKey("rearBogieHORSE1840"))
		{
			rearBogieHORSE1840 = PlayerPrefs.GetInt("rearBogieHORSE1840");
		}
		if (PlayerPrefs.HasKey("externalTuningHORSE1840"))
		{
			externalTuningHORSE1840 = PlayerPrefs.GetInt("externalTuningHORSE1840");
		}
		///////////////////   H O R S E   1 8 5 5   ///////////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveHORSE1855"))
		{
			xpActiveHORSE1855 = PlayerPrefs.GetInt("xpActiveHORSE1855");
		}
		if (PlayerPrefs.HasKey("moneyActiveHORSE1855"))
		{
			moneyActiveHORSE1855 = PlayerPrefs.GetInt("moneyActiveHORSE1855");
		}
		if (PlayerPrefs.HasKey("engineHORSE1855"))
		{
			engineHORSE1855 = PlayerPrefs.GetInt("engineHORSE1855");
		}
		if (PlayerPrefs.HasKey("gearboxHORSE1855"))
		{
			gearboxHORSE1855 = PlayerPrefs.GetInt("gearboxHORSE1855");
		}
		if (PlayerPrefs.HasKey("brakeHORSE1855"))
		{
			brakeHORSE1855 = PlayerPrefs.GetInt("brakeHORSE1855");
		}
		if (PlayerPrefs.HasKey("fuelTankHORSE1855"))
		{
			fuelTankHORSE1855 = PlayerPrefs.GetInt("fuelTankHORSE1855");
		}
		if (PlayerPrefs.HasKey("fuelHORSE1855"))
		{
			fuelHORSE1855 = PlayerPrefs.GetFloat("fuelHORSE1855");
		}
		if (PlayerPrefs.HasKey("rearBogieHORSE1855"))
		{
			rearBogieHORSE1855 = PlayerPrefs.GetInt("rearBogieHORSE1855");
		}
		if (PlayerPrefs.HasKey("externalTuningHORSE1855"))
		{
			externalTuningHORSE1855 = PlayerPrefs.GetInt("externalTuningHORSE1855");
		}
		///////////////////   R I D G E   S E R I A   /////////////////////////////////////////////////////////////////////////////////
		///////////////////   R I D G E    3 7 5 C   //////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveRIDGE375"))
		{
			xpActiveRIDGE375 = PlayerPrefs.GetInt("xpActiveRIDGE375");
		}
		if (PlayerPrefs.HasKey("moneyActiveRIDGE375"))
		{
			moneyActiveRIDGE375 = PlayerPrefs.GetInt("moneyActiveRIDGE375");
		}
		if (PlayerPrefs.HasKey("engineRIDGE375"))
		{
			engineRIDGE375 = PlayerPrefs.GetInt("engineRIDGE375");
		}
		if (PlayerPrefs.HasKey("gearboxRIDGE375"))
		{
			gearboxRIDGE375 = PlayerPrefs.GetInt("gearboxRIDGE375");
		}
		if (PlayerPrefs.HasKey("brakeRIDGE375"))
		{
			brakeRIDGE375 = PlayerPrefs.GetInt("brakeRIDGE375");
		}
		if (PlayerPrefs.HasKey("fuelTankRIDGE375"))
		{
			fuelTankRIDGE375 = PlayerPrefs.GetInt("fuelTankRIDGE375");
		}
		if (PlayerPrefs.HasKey("fuelRIDGE375"))
		{
			fuelRIDGE375 = PlayerPrefs.GetFloat("fuelRIDGE375");
		}
		if (PlayerPrefs.HasKey("rearBogieRIDGE375"))
		{
			rearBogieRIDGE375 = PlayerPrefs.GetInt("rearBogieRIDGE375");
		}
		if (PlayerPrefs.HasKey("externalTuningRIDGE375"))
		{
			externalTuningRIDGE375 = PlayerPrefs.GetInt("externalTuningRIDGE375");
		}
		///////////////////   R I D G E    4 4 2 0   //////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveRIDGE4420"))
		{
			xpActiveRIDGE4420 = PlayerPrefs.GetInt("xpActiveRIDGE4420");
		}
		if (PlayerPrefs.HasKey("moneyActiveRIDGE4420"))
		{
			moneyActiveRIDGE4420 = PlayerPrefs.GetInt("moneyActiveRIDGE4420");
		}
		if (PlayerPrefs.HasKey("engineRIDGE4420"))
		{
			engineRIDGE4420 = PlayerPrefs.GetInt("engineRIDGE4420");
		}
		if (PlayerPrefs.HasKey("gearboxRIDGE4420"))
		{
			gearboxRIDGE4420 = PlayerPrefs.GetInt("gearboxRIDGE4420");
		}
		if (PlayerPrefs.HasKey("brakeRIDGE4420"))
		{
			brakeRIDGE4420 = PlayerPrefs.GetInt("brakeRIDGE4420");
		}
		if (PlayerPrefs.HasKey("fuelTankRIDGE4420"))
		{
			fuelTankRIDGE4420 = PlayerPrefs.GetInt("fuelTankRIDGE4420");
		}
		if (PlayerPrefs.HasKey("fuelRIDGE4420"))
		{
			fuelRIDGE4420 = PlayerPrefs.GetFloat("fuelRIDGE4420");
		}
		if (PlayerPrefs.HasKey("rearBogieRIDGE4420"))
		{
			rearBogieRIDGE4420 = PlayerPrefs.GetInt("rearBogieRIDGE4420");
		}
		if (PlayerPrefs.HasKey("externalTuningRIDGE4420"))
		{
			externalTuningRIDGE4420 = PlayerPrefs.GetInt("externalTuningRIDGE4420");
		}
		///////////////////   R I D G E    6 3 7 0   //////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveRIDGE6370"))
		{
			xpActiveRIDGE6370 = PlayerPrefs.GetInt("xpActiveRIDGE6370");
		}
		if (PlayerPrefs.HasKey("moneyActiveRIDGE6370"))
		{
			moneyActiveRIDGE6370 = PlayerPrefs.GetInt("moneyActiveRIDGE6370");
		}
		if (PlayerPrefs.HasKey("engineRIDGE6370"))
		{
			engineRIDGE6370 = PlayerPrefs.GetInt("engineRIDGE6370");
		}
		if (PlayerPrefs.HasKey("gearboxRIDGE6370"))
		{
			gearboxRIDGE6370 = PlayerPrefs.GetInt("gearboxRIDGE6370");
		}
		if (PlayerPrefs.HasKey("brakeRIDGE6370"))
		{
			brakeRIDGE6370 = PlayerPrefs.GetInt("brakeRIDGE6370");
		}
		if (PlayerPrefs.HasKey("fuelTankRIDGE6370"))
		{
			fuelTankRIDGE6370 = PlayerPrefs.GetInt("fuelTankRIDGE6370");
		}
		if (PlayerPrefs.HasKey("fuelRIDGE6370"))
		{
			fuelRIDGE6370 = PlayerPrefs.GetFloat("fuelRIDGE6370");
		}
		if (PlayerPrefs.HasKey("rearBogieRIDGE6370"))
		{
			rearBogieRIDGE6370 = PlayerPrefs.GetInt("rearBogieRIDGE6370");
		}
		if (PlayerPrefs.HasKey("externalTuningRIDGE6370"))
		{
			externalTuningRIDGE6370 = PlayerPrefs.GetInt("externalTuningRIDGE6370");
		}
		///////////////////   R I D G E    N X   //////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveRIDGENX"))
		{
			xpActiveRIDGENX = PlayerPrefs.GetInt("xpActiveRIDGENX");
		}
		if (PlayerPrefs.HasKey("moneyActiveRIDGENX"))
		{
			moneyActiveRIDGENX = PlayerPrefs.GetInt("moneyActiveRIDGENX");
		}
		if (PlayerPrefs.HasKey("engineRIDGENX"))
		{
			engineRIDGENX = PlayerPrefs.GetInt("engineRIDGENX");
		}
		if (PlayerPrefs.HasKey("gearboxRIDGENX"))
		{
			gearboxRIDGENX = PlayerPrefs.GetInt("gearboxRIDGENX");
		}
		if (PlayerPrefs.HasKey("brakeRIDGENX"))
		{
			brakeRIDGENX = PlayerPrefs.GetInt("brakeRIDGENX");
		}
		if (PlayerPrefs.HasKey("fuelTankRIDGENX"))
		{
			fuelTankRIDGENX = PlayerPrefs.GetInt("fuelTankRIDGENX");
		}
		if (PlayerPrefs.HasKey("fuelRIDGENX"))
		{
			fuelRIDGENX = PlayerPrefs.GetFloat("fuelRIDGENX");
		}
		if (PlayerPrefs.HasKey("rearBogieRIDGENX"))
		{
			rearBogieRIDGENX = PlayerPrefs.GetInt("rearBogieRIDGENX");
		}
		if (PlayerPrefs.HasKey("externalTuningRIDGENX"))
		{
			externalTuningRIDGENX = PlayerPrefs.GetInt("externalTuningRIDGENX");
		}
		///////////////////   P R E M I U M   S E R I A   /////////////////////////////////////////////////////////////////////////////
		///////////////////   F O R B   C A R G O   ///////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("dollarActiveFORBCARGO"))
		{
			dollarActiveFORBCARGO = PlayerPrefs.GetInt("dollarActiveFORBCARGO");
		}
		if (PlayerPrefs.HasKey("engineFORBCARGO"))
		{
			engineFORBCARGO = PlayerPrefs.GetInt("engineFORBCARGO");
		}
		if (PlayerPrefs.HasKey("gearboxFORBCARGO"))
		{
			gearboxFORBCARGO = PlayerPrefs.GetInt("gearboxFORBCARGO");
		}
		if (PlayerPrefs.HasKey("brakeFORBCARGO"))
		{
			brakeFORBCARGO = PlayerPrefs.GetInt("brakeFORBCARGO");
		}
		if (PlayerPrefs.HasKey("fuelTankFORBCARGO"))
		{
			fuelTankFORBCARGO = PlayerPrefs.GetInt("fuelTankFORBCARGO");
		}
		if (PlayerPrefs.HasKey("fuelFORBCARGO"))
		{
			fuelFORBCARGO = PlayerPrefs.GetFloat("fuelFORBCARGO");
		}
		if (PlayerPrefs.HasKey("rearBogieFORBCARGO"))
		{
			rearBogieFORBCARGO = PlayerPrefs.GetInt("rearBogieFORBCARGO");
		}
		if (PlayerPrefs.HasKey("externalTuningFORBCARGO"))
		{
			externalTuningFORBCARGO = PlayerPrefs.GetInt("externalTuningFORBCARGO");
		}
		///////////////////   F O R B   F M A X   ////////////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("dollarActiveFORBFMAX"))
		{
			dollarActiveFORBFMAX = PlayerPrefs.GetInt("dollarActiveFORBFMAX");
		}
		if (PlayerPrefs.HasKey("engineFORBFMAX"))
		{
			engineFORBFMAX = PlayerPrefs.GetInt("engineFORBFMAX");
		}
		if (PlayerPrefs.HasKey("gearboxFORBFMAX"))
		{
			gearboxFORBFMAX = PlayerPrefs.GetInt("gearboxFORBFMAX");
		}
		if (PlayerPrefs.HasKey("brakeFORBFMAX"))
		{
			brakeFORBFMAX = PlayerPrefs.GetInt("brakeFORBFMAX");
		}
		if (PlayerPrefs.HasKey("fuelTankFORBFMAX"))
		{
			fuelTankFORBFMAX = PlayerPrefs.GetInt("fuelTankFORBFMAX");
		}
		if (PlayerPrefs.HasKey("fuelFORBFMAX"))
		{
			fuelFORBFMAX = PlayerPrefs.GetFloat("fuelFORBFMAX");
		}
		if (PlayerPrefs.HasKey("rearBogieFORBFMAX"))
		{
			rearBogieFORBFMAX = PlayerPrefs.GetInt("rearBogieFORBFMAX");
		}
		if (PlayerPrefs.HasKey("externalTuningFORBFMAX"))
		{
			externalTuningFORBFMAX = PlayerPrefs.GetInt("externalTuningFORBFMAX");
		}
		//////////////////////// B O A R D ///////////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("xpActiveB1"))
		{
			xpActiveB1 = PlayerPrefs.GetInt("xpActiveB1");
		}
		if (PlayerPrefs.HasKey("moneyActiveB1"))
		{
			moneyActiveB1 = PlayerPrefs.GetInt("moneyActiveB1");
		}
		///
		if (PlayerPrefs.HasKey("xpActiveB2"))
		{
			xpActiveB2 = PlayerPrefs.GetInt("xpActiveB2");
		}		
		if (PlayerPrefs.HasKey("moneyActiveB2"))
		{
			moneyActiveB2 = PlayerPrefs.GetInt("moneyActiveB2");
		}
		///
		if (PlayerPrefs.HasKey("xpActiveB3"))
		{
			xpActiveB3 = PlayerPrefs.GetInt("xpActiveB3");
		}
		if (PlayerPrefs.HasKey("moneyActiveB3"))
		{
			moneyActiveB3 = PlayerPrefs.GetInt("moneyActiveB3");
		}
		///
		if (PlayerPrefs.HasKey("xpActiveB4"))
		{
			xpActiveB4 = PlayerPrefs.GetInt("xpActiveB4");
		}
		if (PlayerPrefs.HasKey("moneyActiveB4"))
		{
			moneyActiveB4 = PlayerPrefs.GetInt("moneyActiveB4");
		}
		///
		if (PlayerPrefs.HasKey("xpActiveB5"))
		{
			xpActiveB5 = PlayerPrefs.GetInt("xpActiveB5");
		}
		if (PlayerPrefs.HasKey("moneyActiveB5"))
		{
			moneyActiveB5 = PlayerPrefs.GetInt("moneyActiveB5");
		}
		///
		if (PlayerPrefs.HasKey("xpActiveB6"))
		{
			xpActiveB6 = PlayerPrefs.GetInt("xpActiveB6");
		}
		if (PlayerPrefs.HasKey("moneyActiveB6"))
		{
			moneyActiveB6 = PlayerPrefs.GetInt("moneyActiveB6");
		}
		///
		if (PlayerPrefs.HasKey("xpActiveB7"))
		{
			xpActiveB7 = PlayerPrefs.GetInt("xpActiveB7");
		}
		if (PlayerPrefs.HasKey("moneyActiveB7"))
		{
			moneyActiveB7 = PlayerPrefs.GetInt("moneyActiveB7");
		}
		//////////////////////// T E N T ///////////////////////////////////////////////////////////////////////////////////////////////////
		///
		if (PlayerPrefs.HasKey("xpActiveT1"))
		{
			xpActiveT1 = PlayerPrefs.GetInt("xpActiveT1");
		}
		if (PlayerPrefs.HasKey("moneyActiveT1"))
		{
			moneyActiveT1 = PlayerPrefs.GetInt("moneyActiveT1");
		}
		///
		if (PlayerPrefs.HasKey("xpActiveT2"))
		{
			xpActiveT2 = PlayerPrefs.GetInt("xpActiveT2");
		}
		if (PlayerPrefs.HasKey("moneyActiveT2"))
		{
			moneyActiveT2 = PlayerPrefs.GetInt("moneyActiveT2");
		}
		///
		if (PlayerPrefs.HasKey("xpActiveT3"))
		{
			xpActiveT3 = PlayerPrefs.GetInt("xpActiveT3");
		}
		if (PlayerPrefs.HasKey("moneyActiveT3"))
		{
			moneyActiveT3 = PlayerPrefs.GetInt("moneyActiveT3");
		}
		///
		if (PlayerPrefs.HasKey("xpActiveT4"))
		{
			xpActiveT4 = PlayerPrefs.GetInt("xpActiveT4");
		}
		if (PlayerPrefs.HasKey("moneyActiveT4"))
		{
			moneyActiveT4 = PlayerPrefs.GetInt("moneyActiveT4");
		}
		///
		if (PlayerPrefs.HasKey("xpActiveT5"))
		{
			xpActiveT5 = PlayerPrefs.GetInt("xpActiveT5");
		}
		if (PlayerPrefs.HasKey("moneyActiveT5"))
		{
			moneyActiveT5 = PlayerPrefs.GetInt("moneyActiveT5");
		}
		///
		if (PlayerPrefs.HasKey("xpActiveT6"))
		{
			xpActiveT6 = PlayerPrefs.GetInt("xpActiveT6");
		}
		if (PlayerPrefs.HasKey("moneyActiveT6"))
		{
			moneyActiveT6 = PlayerPrefs.GetInt("moneyActiveT6");
		}
		///
		if (PlayerPrefs.HasKey("xpActiveT7"))
		{
			xpActiveT7 = PlayerPrefs.GetInt("xpActiveT7");
		}
		if (PlayerPrefs.HasKey("moneyActiveT7"))
		{
			moneyActiveT7 = PlayerPrefs.GetInt("moneyActiveT7");
		}
		///
		if (PlayerPrefs.HasKey("xpActiveT8"))
		{
			xpActiveT8 = PlayerPrefs.GetInt("xpActiveT8");
		}
		if (PlayerPrefs.HasKey("moneyActiveT8"))
		{
			moneyActiveT8 = PlayerPrefs.GetInt("moneyActiveT8");
		}
		//////////////////////// R E F ///////////////////////////////////////////////////////////////////////////////////////////////////
		///
		if (PlayerPrefs.HasKey("xpActiveR1"))
		{
			xpActiveR1 = PlayerPrefs.GetInt("xpActiveR1");
		}
		if (PlayerPrefs.HasKey("moneyActiveR1"))
		{
			moneyActiveR1 = PlayerPrefs.GetInt("moneyActiveR1");
		}
		///
		if (PlayerPrefs.HasKey("xpActiveR2"))
		{
			xpActiveR2 = PlayerPrefs.GetInt("xpActiveR2");
		}
		if (PlayerPrefs.HasKey("moneyActiveR2"))
		{
			moneyActiveR2 = PlayerPrefs.GetInt("moneyActiveR2");
		}
		///
		if (PlayerPrefs.HasKey("xpActiveR3"))
		{
			xpActiveR3 = PlayerPrefs.GetInt("xpActiveR3");
		}
		if (PlayerPrefs.HasKey("moneyActiveR3"))
		{
			moneyActiveR3 = PlayerPrefs.GetInt("moneyActiveR3");
		}
		///
		if (PlayerPrefs.HasKey("xpActiveR4"))
		{
			xpActiveR4 = PlayerPrefs.GetInt("xpActiveR4");
		}
		if (PlayerPrefs.HasKey("moneyActiveR4"))
		{
			moneyActiveR4 = PlayerPrefs.GetInt("moneyActiveR4");
		}
		///
		if (PlayerPrefs.HasKey("xpActiveR5"))
		{
			xpActiveR5 = PlayerPrefs.GetInt("xpActiveR5");
		}
		if (PlayerPrefs.HasKey("moneyActiveR5"))
		{
			moneyActiveR5 = PlayerPrefs.GetInt("moneyActiveR5");
		}
		///
		if (PlayerPrefs.HasKey("xpActiveR6"))
		{
			xpActiveR6 = PlayerPrefs.GetInt("xpActiveR6");
		}
		if (PlayerPrefs.HasKey("moneyActiveR6"))
		{
			moneyActiveR6 = PlayerPrefs.GetInt("moneyActiveR6");
		}
		//////////////////////// C O N ///////////////////////////////////////////////////////////////////////////////////////////////////
		///
		if (PlayerPrefs.HasKey("xpActiveC1"))
		{
			xpActiveC1 = PlayerPrefs.GetInt("xpActiveC1");
		}
		if (PlayerPrefs.HasKey("moneyActiveC1"))
		{
			moneyActiveC1 = PlayerPrefs.GetInt("moneyActiveC1");
		}
		///
		if (PlayerPrefs.HasKey("xpActiveC2"))
		{
			xpActiveC2 = PlayerPrefs.GetInt("xpActiveC2");
		}
		if (PlayerPrefs.HasKey("moneyActiveC2"))
		{
			moneyActiveC2 = PlayerPrefs.GetInt("moneyActiveC2");
		}
		///
		if (PlayerPrefs.HasKey("xpActiveC3"))
		{
			xpActiveC3 = PlayerPrefs.GetInt("xpActiveC3");
		}
		if (PlayerPrefs.HasKey("moneyActiveC3"))
		{
			moneyActiveC3 = PlayerPrefs.GetInt("moneyActiveC3");
		}
		///
		if (PlayerPrefs.HasKey("xpActiveC4"))
		{
			xpActiveC4 = PlayerPrefs.GetInt("xpActiveC4");
		}
		if (PlayerPrefs.HasKey("moneyActiveC4"))
		{
			moneyActiveC4 = PlayerPrefs.GetInt("moneyActiveC4");
		}
		///
		if (PlayerPrefs.HasKey("xpActiveC5"))
		{
			xpActiveC5 = PlayerPrefs.GetInt("xpActiveC5");
		}
		if (PlayerPrefs.HasKey("moneyActiveC5"))
		{
			moneyActiveC5 = PlayerPrefs.GetInt("moneyActiveC5");
		}		
		////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		///
		if (PlayerPrefs.HasKey("language"))
		{
			language = PlayerPrefs.GetString("language");
		}
		///
		if (PlayerPrefs.HasKey("dokiOk"))
		{
			dokiOk = PlayerPrefs.GetInt("dokiOk");
		}
		///
		if (PlayerPrefs.HasKey("hitchhiker"))
		{
			hitchhiker = PlayerPrefs.GetInt("hitchhiker");
		}
		///
		if (PlayerPrefs.HasKey("smoke"))
		{
			smoke = PlayerPrefs.GetInt("smoke");
		}
		///
		if (PlayerPrefs.HasKey("lightOn"))
		{
			lightOn = PlayerPrefs.GetInt("lightOn");
		}
		///
		if (PlayerPrefs.HasKey("lightOnStop"))
		{
			lightOnStop = PlayerPrefs.GetInt("lightOnStop");
		}
		///
		if (PlayerPrefs.HasKey("truckSmoke"))
		{
			truckSmoke = PlayerPrefs.GetInt("truckSmoke");
		}
		///
		if (PlayerPrefs.HasKey("cargo_condition"))
		{
			cargo_condition = PlayerPrefs.GetInt("cargo_condition");
		}

		if (PlayerPrefs.HasKey("specCargo"))
		{
			specCargo = PlayerPrefs.GetInt("specCargo");
		}
		///
		if (PlayerPrefs.HasKey("muteAudio"))
		{
			muteAudio = PlayerPrefs.GetInt("muteAudio");
		}
		///
		if (PlayerPrefs.HasKey("ads"))
		{
			ads = PlayerPrefs.GetInt("ads");
		}
		///
		if (PlayerPrefs.HasKey("gear"))
		{
			gear = PlayerPrefs.GetInt("gear");
		}
		///
		if (PlayerPrefs.HasKey("buyFuel"))
		{
			buyFuel = PlayerPrefs.GetInt("buyFuel");
		}
		///
		if (PlayerPrefs.HasKey("mins"))
		{
			mins = PlayerPrefs.GetInt("mins");
		}
		///
		if (PlayerPrefs.HasKey("hours"))
		{
			hours = PlayerPrefs.GetInt("hours");
		}
		///
		if (PlayerPrefs.HasKey("days"))
		{
			days = PlayerPrefs.GetInt("days");
		}
		///
		if (PlayerPrefs.HasKey("activeRndEvent"))
		{
			activeRndEvent = PlayerPrefs.GetInt("activeRndEvent");
		}
		///				
		if (PlayerPrefs.HasKey("masterVolume"))
		{
			masterVolume = PlayerPrefs.GetInt("masterVolume");
		}
		///			
		if (PlayerPrefs.HasKey("carNumber"))
		{
			carNumber = PlayerPrefs.GetInt("carNumber");
		}
		///
		if (PlayerPrefs.HasKey("prcNumber"))
		{
			prcNumber = PlayerPrefs.GetInt("prcNumber");
		}
		///
		if (PlayerPrefs.HasKey("finishLoca"))
		{
			finishLoca = PlayerPrefs.GetInt("finishLoca");
		}
		///
		if (PlayerPrefs.HasKey("mapLocation"))
		{
			mapLocation = PlayerPrefs.GetString("mapLocation");
		}
		///
		if (PlayerPrefs.HasKey("saveMapLocation"))
		{
			saveMapLocation = PlayerPrefs.GetString("saveMapLocation");
		}
		///
		if (PlayerPrefs.HasKey("road"))
		{
			road = PlayerPrefs.GetString("road");
		}
		///
		if (PlayerPrefs.HasKey("money"))
		{
			money = PlayerPrefs.GetInt("money");
		}
		///
		if (PlayerPrefs.HasKey("dollars"))
		{
			dollars = PlayerPrefs.GetInt("dollars");
		}
		///
		if (PlayerPrefs.HasKey("kilometers"))
        {
            kilometers = PlayerPrefs.GetFloat("kilometers");
        }
		if (PlayerPrefs.HasKey("bankXpFree"))
		{
			bankXpFree = PlayerPrefs.GetFloat("bankXpFree");
		}
		if (PlayerPrefs.HasKey("bankXpBison"))
		{
			bankXpBison = PlayerPrefs.GetFloat("bankXpBison");
		}
		if (PlayerPrefs.HasKey("bankXpDUB"))
		{
			bankXpDUB = PlayerPrefs.GetFloat("bankXpDUB");
		}
		if (PlayerPrefs.HasKey("bankXpFIIV"))
		{
			bankXpFIIV = PlayerPrefs.GetFloat("bankXpFIIV");
		}
		if (PlayerPrefs.HasKey("bankXpHORSE"))
		{
			bankXpHORSE = PlayerPrefs.GetFloat("bankXpHORSE");
		}
		if (PlayerPrefs.HasKey("bankXpRIDGE"))
		{
			bankXpRIDGE = PlayerPrefs.GetFloat("bankXpRIDGE");
		}
		if (PlayerPrefs.HasKey("bankXpBoard"))
		{
			bankXpBoard = PlayerPrefs.GetFloat("bankXpBoard");
		}
		if (PlayerPrefs.HasKey("bankXpTent"))
		{
			bankXpTent = PlayerPrefs.GetFloat("bankXpTent");
		}
		if (PlayerPrefs.HasKey("bankXpRef"))
		{
			bankXpRef = PlayerPrefs.GetFloat("bankXpRef");
		}
		if (PlayerPrefs.HasKey("bankXpCon"))
		{
			bankXpCon = PlayerPrefs.GetFloat("bankXpCon");
		}

		if (PlayerPrefs.HasKey("cargoWeight"))
		{
			cargoWeight = PlayerPrefs.GetFloat("cargoWeight");
		}

		if (PlayerPrefs.HasKey("timer"))
		{
			timer = PlayerPrefs.GetFloat("timer");
		}

		if (PlayerPrefs.HasKey("realSpeed"))
		{
			realSpeed = PlayerPrefs.GetFloat("realSpeed");
		}
		///////////////////   Н А Г Р А Д А   //////////////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("prizeRuly"))
		{
			prizeRuly = PlayerPrefs.GetFloat("prizeRuly");
		}

		if (PlayerPrefs.HasKey("prizeDollars"))
		{
			prizeDollars = PlayerPrefs.GetInt("prizeDollars");
		}

		if (PlayerPrefs.HasKey("prizeXpFree"))
		{
			prizeXpFree = PlayerPrefs.GetFloat("prizeXpFree");
		}

		if (PlayerPrefs.HasKey("prizeXpCar"))
		{
			prizeXpCar = PlayerPrefs.GetFloat("prizeXpCar");
		}

		if (PlayerPrefs.HasKey("prizeXpTrailer"))
		{
			prizeXpTrailer = PlayerPrefs.GetFloat("prizeXpTrailer");
		}

		if (PlayerPrefs.HasKey("coefPrizeXpFree"))
		{
			coefPrizeXpFree = PlayerPrefs.GetFloat("coefPrizeXpFree");
		}
		if (PlayerPrefs.HasKey("ActiveHitchhikerAndPatrol"))
		{
			ActiveHitchhikerAndPatrol = PlayerPrefs.GetInt("ActiveHitchhikerAndPatrol");
		}
		if (PlayerPrefs.HasKey("hitchhikerR"))
		{
			hitchhikerR = PlayerPrefs.GetInt("hitchhikerR");
		}
		if (PlayerPrefs.HasKey("hitchhikerX"))
		{
			hitchhikerX = PlayerPrefs.GetInt("hitchhikerX");
		}
		if (PlayerPrefs.HasKey("hitchhikerD"))
		{
			hitchhikerD = PlayerPrefs.GetInt("hitchhikerD");
		}
		/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("CamX"))
		{
			CamX = PlayerPrefs.GetFloat("CamX");
		}
		if (PlayerPrefs.HasKey("CamY"))
		{
			CamY = PlayerPrefs.GetFloat("CamY");
		}
		if (PlayerPrefs.HasKey("CamZ"))
		{
			CamZ = PlayerPrefs.GetFloat("CamZ");
		}
		if (PlayerPrefs.HasKey("CamXGarage"))
		{
			CamXGarage = PlayerPrefs.GetFloat("CamXGarage");
		}
		if (PlayerPrefs.HasKey("CamYGarage"))
		{
			CamYGarage = PlayerPrefs.GetFloat("CamYGarage");
		}
		if (PlayerPrefs.HasKey("CamZGarage"))
		{
			CamZGarage = PlayerPrefs.GetFloat("CamZGarage");
		}
		if (PlayerPrefs.HasKey("CamXTruck"))
		{
			CamXTruck = PlayerPrefs.GetFloat("CamXTruck");
		}
		if (PlayerPrefs.HasKey("CamYTruck"))
		{
			CamYTruck = PlayerPrefs.GetFloat("CamYTruck");
		}
		if (PlayerPrefs.HasKey("CamZTruck"))
		{
			CamZTruck = PlayerPrefs.GetFloat("CamZTruck");
		}
		if (PlayerPrefs.HasKey("CamXTrailer"))
		{
			CamXTrailer = PlayerPrefs.GetFloat("CamXTrailer");
		}
		if (PlayerPrefs.HasKey("CamYTrailer"))
		{
			CamYTrailer = PlayerPrefs.GetFloat("CamYTrailer");
		}
		if (PlayerPrefs.HasKey("CamZTrailer"))
		{
			CamZTrailer = PlayerPrefs.GetFloat("CamZTrailer");
		}
		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		if (PlayerPrefs.HasKey("ContPosX"))
		{
			ContPosX = PlayerPrefs.GetFloat("ContPosX");
		}
		if (PlayerPrefs.HasKey("ContPosY"))
		{
			ContPosY = PlayerPrefs.GetFloat("ContPosY");
		}		
	}
	//////////////////////   U P G R A D E   /////////////////////////////////////////////////////////////////////////////////////
	public static int Engine
	{
		get
		{
			return engine;
		}
		set
		{
			engine = value;
			PlayerPrefs.SetInt("engine", engine);
		}
	}

	public static int Gearbox
	{
		get
		{
			return gearbox;
		}
		set
		{
			gearbox = value;
			PlayerPrefs.SetInt("gearbox", gearbox);
		}
	}
	public static int AKPP
	{
		get
		{
			return akpp;
		}
		set
		{
			akpp = value;
			PlayerPrefs.SetInt("akpp", akpp);
		}
	}
	public static int Brake
	{
		get
		{
			return brake;
		}
		set
		{
			brake = value;
			PlayerPrefs.SetInt("brake", brake);
		}
	}
	public static int FuelTank
	{
		get
		{
			return fuelTank;
		}
		set
		{
			fuelTank = value;
			PlayerPrefs.SetInt("fuelTank", fuelTank);
		}
	}
	public static int RearBogie
	{
		get
		{
			return rearBogie;
		}
		set
		{
			rearBogie = value;
			PlayerPrefs.SetInt("rearBogie", rearBogie);
		}
	}
	public static int ExternalTuning
	{
		get
		{
			return externalTuning;
		}
		set
		{
			externalTuning = value;
			PlayerPrefs.SetInt("externalTuning", externalTuning);
		}
	}
	///////////////////   M O S   S E R I A   ///////////////////////////////////////////////////////////////////////////////////
	///////////////////   M O S   2 0 0   //////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveBison200
	{
		get
		{
			return xpActiveBison200;
		}
		set
		{
			xpActiveBison200 = value;
			PlayerPrefs.SetInt("xpActiveBison200", xpActiveBison200);
		}
	}
	public static int MoneyActiveBison200
	{
		get
		{
			return moneyActiveBison200;
		}
		set
		{
			moneyActiveBison200 = value;
			PlayerPrefs.SetInt("moneyActiveBison200", moneyActiveBison200);
		}
	}
	public static int EngineBison200
	{
		get
		{
			return engineBison200;
		}
		set
		{
			engineBison200 = value;
			PlayerPrefs.SetInt("engineBison200", engineBison200);
		}
	}
	public static int GearboxBison200
	{
		get
		{
			return gearboxBison200;
		}
		set
		{
			gearboxBison200 = value;
			PlayerPrefs.SetInt("gearboxBison200", gearboxBison200);
		}
	}
	public static int BrakeBison200
	{
		get
		{
			return brakeBison200;
		}
		set
		{
			brakeBison200 = value;
			PlayerPrefs.SetInt("brakeBison200", brakeBison200);
		}
	}
	public static int FuelTankBison200
	{
		get
		{
			return fuelTankBison200;
		}
		set
		{
			fuelTankBison200 = value;
			PlayerPrefs.SetInt("fuelTankBison200", fuelTankBison200);
		}
	}
	public static float FuelBison200
    {
        get
        {
			return fuelBison200;
		}
        set
        {
			fuelBison200 = value;
			PlayerPrefs.SetFloat("fuelBison200", fuelBison200);
		}
    }
	public static int RearBogieBison200
	{
		get
		{
			return rearBogieBison200;
		}
		set
		{
			rearBogieBison200 = value;
			PlayerPrefs.SetInt("rearBogieBison200", rearBogieBison200);
		}
	}
	public static int ExternalTuningBison200
	{
		get
		{
			return externalTuningBison200;
		}
		set
		{
			externalTuningBison200 = value;
			PlayerPrefs.SetInt("externalTuningBison200", externalTuningBison200);
		}
	}
	///////////////////   M O S   5 0 0  //////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveBison500
	{
        get
        {
            return xpActiveBison500;
        }
        set
        {
			xpActiveBison500 = value;
            PlayerPrefs.SetInt("xpActiveBison500", xpActiveBison500);
        }
    }
    public static int MoneyActive500
	{
        get
        {
            return moneyActive500;
        }
        set
        {
			moneyActive500 = value;
            PlayerPrefs.SetInt("moneyActive500", moneyActive500);
        }
    }
	public static int EngineBison500
	{
		get
		{
			return engineBison500;
		}
		set
		{
			engineBison500 = value;
			PlayerPrefs.SetInt("engineBison500", engineBison500);
		}
	}
	public static int GearboxBison500
	{
		get
		{
			return gearboxBison500;
		}
		set
		{
			gearboxBison500 = value;
			PlayerPrefs.SetInt("gearboxBison500", gearboxBison500);
		}
	}
	public static int BrakeBison500
	{
		get
		{
			return brakeBison500;
		}
		set
		{
			brakeBison500 = value;
			PlayerPrefs.SetInt("brakeBison500", brakeBison500);
		}
	}
	public static int FuelTankBison500
	{
		get
		{
			return fuelTankBison500;
		}
		set
		{
			fuelTankBison500 = value;
			PlayerPrefs.SetInt("fuelTankBison500", fuelTankBison500);
		}
	}
	public static float FuelBison500
	{
		get
		{
			return fuelBison500;
		}
		set
		{
			fuelBison500 = value;
			PlayerPrefs.SetFloat("fuelBison500", fuelBison500);
		}
	}
	public static int RearBogieBison500
	{
		get
		{
			return rearBogieBison500;
		}
		set
		{
			rearBogieBison500 = value;
			PlayerPrefs.SetInt("rearBogieBison500", rearBogieBison500);
		}
	}
	public static int ExternalTuningBison500
	{
		get
		{
			return externalTuningBison500;
		}
		set
		{
			externalTuningBison500 = value;
			PlayerPrefs.SetInt("externalTuningBison500", externalTuningBison500);
		}
	}
	///////////////////   M O S   5 4 3 2  //////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveBison5432
	{
		get
		{
			return xpActiveBison5432;
		}
		set
		{
			xpActiveBison5432 = value;
			PlayerPrefs.SetInt("xpActiveBison5432", xpActiveBison5432);
		}
	}
	public static int MoneyActive5432
	{
		get
		{
			return moneyActive5432;
		}
		set
		{
			moneyActive5432 = value;
			PlayerPrefs.SetInt("moneyActive5432", moneyActive5432);
		}
	}
	public static int EngineBison5432
	{
		get
		{
			return engineBison5432;
		}
		set
		{
			engineBison5432 = value;
			PlayerPrefs.SetInt("engineBison5432", engineBison5432);
		}
	}
	public static int GearboxBison5432
	{
		get
		{
			return gearboxBison5432;
		}
		set
		{
			gearboxBison5432 = value;
			PlayerPrefs.SetInt("gearboxBison5432", gearboxBison5432);
		}
	}
	public static int BrakeBison5432
	{
		get
		{
			return brakeBison5432;
		}
		set
		{
			brakeBison5432 = value;
			PlayerPrefs.SetInt("brakeBison5432", brakeBison5432);
		}
	}
	public static int FuelTankBison5432
	{
		get
		{
			return fuelTankBison5432;
		}
		set
		{
			fuelTankBison5432 = value;
			PlayerPrefs.SetInt("fuelTankBison5432", fuelTankBison5432);
		}
	}
	public static float FuelBison5432
	{
		get
		{
			return fuelBison5432;
		}
		set
		{
			fuelBison5432 = value;
			PlayerPrefs.SetFloat("fuelBison5432", fuelBison5432);
		}
	}
	public static int RearBogieBison5432
	{
		get
		{
			return rearBogieBison5432;
		}
		set
		{
			rearBogieBison5432 = value;
			PlayerPrefs.SetInt("rearBogieBison5432", rearBogieBison5432);
		}
	}
	public static int ExternalTuningBison5432
	{
		get
		{
			return externalTuningBison5432;
		}
		set
		{
			externalTuningBison5432 = value;
			PlayerPrefs.SetInt("externalTuningBison5432", externalTuningBison5432);
		}
	}
	///////////////////   M O S   6 4 2 2  //////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveBison6422
	{
		get
		{
			return xpActiveBison6422;
		}
		set
		{
			xpActiveBison6422 = value;
			PlayerPrefs.SetInt("xpActiveBison6422", xpActiveBison6422);
		}
	}
	public static int MoneyActive6422
	{
		get
		{
			return moneyActive6422;
		}
		set
		{
			moneyActive6422 = value;
			PlayerPrefs.SetInt("moneyActive6422", moneyActive6422);
		}
	}
	public static int EngineBison6422
	{
		get
		{
			return engineBison6422;
		}
		set
		{
			engineBison6422 = value;
			PlayerPrefs.SetInt("engineBison6422", engineBison6422);
		}
	}
	public static int GearboxBison6422
	{
		get
		{
			return gearboxBison6422;
		}
		set
		{
			gearboxBison6422 = value;
			PlayerPrefs.SetInt("gearboxBison6422", gearboxBison6422);
		}
	}
	public static int BrakeBison6422
	{
		get
		{
			return brakeBison6422;
		}
		set
		{
			brakeBison6422 = value;
			PlayerPrefs.SetInt("brakeBison6422", brakeBison6422);
		}
	}
	public static int FuelTankBison6422
	{
		get
		{
			return fuelTankBison6422;
		}
		set
		{
			fuelTankBison6422 = value;
			PlayerPrefs.SetInt("fuelTankBison6422", fuelTankBison6422);
		}
	}
	public static float FuelBison6422
	{
		get
		{
			return fuelBison6422;
		}
		set
		{
			fuelBison6422 = value;
			PlayerPrefs.SetFloat("fuelBison6422", fuelBison6422);
		}
	}
	public static int RearBogieBison6422
	{
		get
		{
			return rearBogieBison6422;
		}
		set
		{
			rearBogieBison6422 = value;
			PlayerPrefs.SetInt("rearBogieBison6422", rearBogieBison6422);
		}
	}
	public static int ExternalTuningBison6422
	{
		get
		{
			return externalTuningBison6422;
		}
		set
		{
			externalTuningBison6422 = value;
			PlayerPrefs.SetInt("externalTuningBison6422", externalTuningBison6422);
		}
	}
	///////////////////   M O S   6 4 3 0  //////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveBison6430
	{
		get
		{
			return xpActiveBison6430;
		}
		set
		{
			xpActiveBison6430 = value;
			PlayerPrefs.SetInt("xpActiveBison6430", xpActiveBison6430);
		}
	}
	public static int MoneyActive6430
	{
		get
		{
			return moneyActive6430;
		}
		set
		{
			moneyActive6430 = value;
			PlayerPrefs.SetInt("moneyActive6430", moneyActive6430);
		}
	}
	public static int EngineBison6430
	{
		get
		{
			return engineBison6430;
		}
		set
		{
			engineBison6430 = value;
			PlayerPrefs.SetInt("engineBison6430", engineBison6430);
		}
	}
	public static int GearboxBison6430
	{
		get
		{
			return gearboxBison6430;
		}
		set
		{
			gearboxBison6430 = value;
			PlayerPrefs.SetInt("gearboxBison6430", gearboxBison6430);
		}
	}
	public static int BrakeBison6430
	{
		get
		{
			return brakeBison6430;
		}
		set
		{
			brakeBison6430 = value;
			PlayerPrefs.SetInt("brakeBison6430", brakeBison6430);
		}
	}
	public static int FuelTankBison6430
	{
		get
		{
			return fuelTankBison6430;
		}
		set
		{
			fuelTankBison6430 = value;
			PlayerPrefs.SetInt("fuelTankBison6430", fuelTankBison6430);
		}
	}
	public static float FuelBison6430
	{
		get
		{
			return fuelBison6430;
		}
		set
		{
			fuelBison6430 = value;
			PlayerPrefs.SetFloat("fuelBison6430", fuelBison6430);
		}
	}
	public static int RearBogieBison6430
	{
		get
		{
			return rearBogieBison6430;
		}
		set
		{
			rearBogieBison6430 = value;
			PlayerPrefs.SetInt("rearBogieBison6430", rearBogieBison6430);
		}
	}
	public static int ExternalTuningBison6430
	{
		get
		{
			return externalTuningBison6430;
		}
		set
		{
			externalTuningBison6430 = value;
			PlayerPrefs.SetInt("externalTuningBison6430", externalTuningBison6430);
		}
	}
	///////////////////   M O S   6 4 4 0  //////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveBison6440
	{
		get
		{
			return xpActiveBison6440;
		}
		set
		{
			xpActiveBison6440 = value;
			PlayerPrefs.SetInt("xpActiveBison6440", xpActiveBison6440);
		}
	}
	public static int MoneyActive6440
	{
		get
		{
			return moneyActive6440;
		}
		set
		{
			moneyActive6440 = value;
			PlayerPrefs.SetInt("moneyActive6440", moneyActive6440);
		}
	}
	public static int EngineBison6440
	{
		get
		{
			return engineBison6440;
		}
		set
		{
			engineBison6440 = value;
			PlayerPrefs.SetInt("engineBison6440", engineBison6440);
		}
	}
	public static int GearboxBison6440
	{
		get
		{
			return gearboxBison6440;
		}
		set
		{
			gearboxBison6440 = value;
			PlayerPrefs.SetInt("gearboxBison6440", gearboxBison6440);
		}
	}
	public static int BrakeBison6440
	{
		get
		{
			return brakeBison6440;
		}
		set
		{
			brakeBison6440 = value;
			PlayerPrefs.SetInt("brakeBison6440", brakeBison6440);
		}
	}
	public static int FuelTankBison6440
	{
		get
		{
			return fuelTankBison6440;
		}
		set
		{
			fuelTankBison6440 = value;
			PlayerPrefs.SetInt("fuelTankBison6440", fuelTankBison6440);
		}
	}
	public static float FuelBison6440
	{
		get
		{
			return fuelBison6440;
		}
		set
		{
			fuelBison6440 = value;
			PlayerPrefs.SetFloat("fuelBison6440", fuelBison6440);
		}
	}
	public static int RearBogieBison6440
	{
		get
		{
			return rearBogieBison6440;
		}
		set
		{
			rearBogieBison6440 = value;
			PlayerPrefs.SetInt("rearBogieBison6440", rearBogieBison6440);
		}
	}
	public static int ExternalTuningBison6440
	{
		get
		{
			return externalTuningBison6440;
		}
		set
		{
			externalTuningBison6440 = value;
			PlayerPrefs.SetInt("externalTuningBison6440", externalTuningBison6440);
		}
	}
	///////////////////   M O S   5 4 4 0  //////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveBison5440
	{
		get
		{
			return xpActiveBison5440;
		}
		set
		{
			xpActiveBison5440 = value;
			PlayerPrefs.SetInt("xpActiveBison5440", xpActiveBison5440);
		}
	}
	public static int MoneyActive5440
	{
		get
		{
			return moneyActive5440;
		}
		set
		{
			moneyActive5440 = value;
			PlayerPrefs.SetInt("moneyActive5440", moneyActive5440);
		}
	}
	public static int EngineBison5440
	{
		get
		{
			return engineBison5440;
		}
		set
		{
			engineBison5440 = value;
			PlayerPrefs.SetInt("engineBison5440", engineBison5440);
		}
	}
	public static int GearboxBison5440
	{
		get
		{
			return gearboxBison5440;
		}
		set
		{
			gearboxBison5440 = value;
			PlayerPrefs.SetInt("gearboxBison5440", gearboxBison5440);
		}
	}
	public static int BrakeBison5440
	{
		get
		{
			return brakeBison5440;
		}
		set
		{
			brakeBison5440 = value;
			PlayerPrefs.SetInt("brakeBison5440", brakeBison5440);
		}
	}
	public static int FuelTankBison5440
	{
		get
		{
			return fuelTankBison5440;
		}
		set
		{
			fuelTankBison5440 = value;
			PlayerPrefs.SetInt("fuelTankBison5440", fuelTankBison5440);
		}
	}
	public static float FuelBison5440
	{
		get
		{
			return fuelBison5440;
		}
		set
		{
			fuelBison5440 = value;
			PlayerPrefs.SetFloat("fuelBison5440", fuelBison5440);
		}
	}
	public static int RearBogieBison5440
	{
		get
		{
			return rearBogieBison5440;
		}
		set
		{
			rearBogieBison5440 = value;
			PlayerPrefs.SetInt("rearBogieBison5440", rearBogieBison5440);
		}
	}
	public static int ExternalTuningBison5440
	{
		get
		{
			return externalTuningBison5440;
		}
		set
		{
			externalTuningBison5440 = value;
			PlayerPrefs.SetInt("externalTuningBison5440", externalTuningBison5440);
		}
	}
	///////////////////   D U B   1 5 7  //////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveDUB157
	{
		get
		{
			return xpActiveDUB157;
		}
		set
		{
			xpActiveDUB157 = value;
			PlayerPrefs.SetInt("xpActiveDUB157", xpActiveDUB157);
		}
	}
	public static int MoneyActiveDUB157
	{
		get
		{
			return moneyActiveDUB157;
		}
		set
		{
			moneyActiveDUB157 = value;
			PlayerPrefs.SetInt("moneyActiveDUB157", moneyActiveDUB157);
		}
	}
	public static int EngineDUB157
	{
		get
		{
			return engineDUB157;
		}
		set
		{
			engineDUB157 = value;
			PlayerPrefs.SetInt("engineDUB157", engineDUB157);
		}
	}
	public static int GearboxDUB157
	{
		get
		{
			return gearboxDUB157;
		}
		set
		{
			gearboxDUB157 = value;
			PlayerPrefs.SetInt("gearboxDUB157", gearboxDUB157);
		}
	}
	public static int BrakeDUB157
	{
		get
		{
			return brakeDUB157;
		}
		set
		{
			brakeDUB157 = value;
			PlayerPrefs.SetInt("brakeDUB157", brakeDUB157);
		}
	}
	public static int FuelTankDUB157
	{
		get
		{
			return fuelTankDUB157;
		}
		set
		{
			fuelTankDUB157 = value;
			PlayerPrefs.SetInt("fuelTankDUB157", fuelTankDUB157);
		}
	}
	public static float FuelDUB157
	{
		get
		{
			return fuelDUB157;
		}
		set
		{
			fuelDUB157 = value;
			PlayerPrefs.SetFloat("fuelDUB157", fuelDUB157);
		}
	}
	public static int RearBogieDUB157
	{
		get
		{
			return rearBogieDUB157;
		}
		set
		{
			rearBogieDUB157 = value;
			PlayerPrefs.SetInt("rearBogieDUB157", rearBogieDUB157);
		}
	}
	public static int ExternalTuningDUB157
	{
		get
		{
			return externalTuningDUB157;
		}
		set
		{
			externalTuningDUB157 = value;
			PlayerPrefs.SetInt("externalTuningDUB157", externalTuningDUB157);
		}
	}
	///////////////////   D U B   1 3 1  //////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveDUB131
	{
		get
		{
			return xpActiveDUB131;
		}
		set
		{
			xpActiveDUB131 = value;
			PlayerPrefs.SetInt("xpActiveDUB131", xpActiveDUB131);
		}
	}
	public static int MoneyActiveDUB131
	{
		get
		{
			return moneyActiveDUB131;
		}
		set
		{
			moneyActiveDUB131 = value;
			PlayerPrefs.SetInt("moneyActiveDUB131", moneyActiveDUB131);
		}
	}
	public static int EngineDUB131
	{
		get
		{
			return engineDUB131;
		}
		set
		{
			engineDUB131 = value;
			PlayerPrefs.SetInt("engineDUB131", engineDUB131);
		}
	}
	public static int GearboxDUB131
	{
		get
		{
			return gearboxDUB131;
		}
		set
		{
			gearboxDUB131 = value;
			PlayerPrefs.SetInt("gearboxDUB131", gearboxDUB131);
		}
	}
	public static int BrakeDUB131
	{
		get
		{
			return brakeDUB131;
		}
		set
		{
			brakeDUB131 = value;
			PlayerPrefs.SetInt("brakeDUB131", brakeDUB131);
		}
	}
	public static int FuelTankDUB131
	{
		get
		{
			return fuelTankDUB131;
		}
		set
		{
			fuelTankDUB131 = value;
			PlayerPrefs.SetInt("fuelTankDUB131", fuelTankDUB131);
		}
	}
	public static float FuelDUB131
	{
		get
		{
			return fuelDUB131;
		}
		set
		{
			fuelDUB131 = value;
			PlayerPrefs.SetFloat("fuelDUB131", fuelDUB131);
		}
	}
	public static int RearBogieDUB131
	{
		get
		{
			return rearBogieDUB131;
		}
		set
		{
			rearBogieDUB131 = value;
			PlayerPrefs.SetInt("rearBogieDUB131", rearBogieDUB131);
		}
	}
	public static int ExternalTuningDUB131
	{
		get
		{
			return externalTuningDUB131;
		}
		set
		{
			externalTuningDUB131 = value;
			PlayerPrefs.SetInt("externalTuningDUB131", externalTuningDUB131);
		}
	}
	///////////////////   D U B   1 3 0  //////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveDUB130
	{
		get
		{
			return xpActiveDUB130;
		}
		set
		{
			xpActiveDUB130 = value;
			PlayerPrefs.SetInt("xpActiveDUB130", xpActiveDUB130);
		}
	}
	public static int MoneyActiveDUB130
	{
		get
		{
			return moneyActiveDUB130;
		}
		set
		{
			moneyActiveDUB130 = value;
			PlayerPrefs.SetInt("moneyActiveDUB130", moneyActiveDUB130);
		}
	}
	public static int EngineDUB130
	{
		get
		{
			return engineDUB130;
		}
		set
		{
			engineDUB130 = value;
			PlayerPrefs.SetInt("engineDUB130", engineDUB130);
		}
	}
	public static int GearboxDUB130
	{
		get
		{
			return gearboxDUB130;
		}
		set
		{
			gearboxDUB130 = value;
			PlayerPrefs.SetInt("gearboxDUB130", gearboxDUB130);
		}
	}
	public static int BrakeDUB130
	{
		get
		{
			return brakeDUB130;
		}
		set
		{
			brakeDUB130 = value;
			PlayerPrefs.SetInt("brakeDUB130", brakeDUB130);
		}
	}
	public static int FuelTankDUB130
	{
		get
		{
			return fuelTankDUB130;
		}
		set
		{
			fuelTankDUB130 = value;
			PlayerPrefs.SetInt("fuelTankDUB130", fuelTankDUB130);
		}
	}
	public static float FuelDUB130
	{
		get
		{
			return fuelDUB130;
		}
		set
		{
			fuelDUB130 = value;
			PlayerPrefs.SetFloat("fuelDUB130", fuelDUB130);
		}
	}
	public static int RearBogieDUB130
	{
		get
		{
			return rearBogieDUB130;
		}
		set
		{
			rearBogieDUB130 = value;
			PlayerPrefs.SetInt("rearBogieDUB130", rearBogieDUB130);
		}
	}
	public static int ExternalTuningDUB130
	{
		get
		{
			return externalTuningDUB130;
		}
		set
		{
			externalTuningDUB130 = value;
			PlayerPrefs.SetInt("externalTuningDUB130", externalTuningDUB130);
		}
	}
	///////////////////   D U B   1 3 3  //////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveDUB133
	{
		get
		{
			return xpActiveDUB133;
		}
		set
		{
			xpActiveDUB133 = value;
			PlayerPrefs.SetInt("xpActiveDUB133", xpActiveDUB133);
		}
	}
	public static int MoneyActiveDUB133
	{
		get
		{
			return moneyActiveDUB133;
		}
		set
		{
			moneyActiveDUB133 = value;
			PlayerPrefs.SetInt("moneyActiveDUB133", moneyActiveDUB133);
		}
	}
	public static int EngineDUB133
	{
		get
		{
			return engineDUB133;
		}
		set
		{
			engineDUB133 = value;
			PlayerPrefs.SetInt("engineDUB133", engineDUB133);
		}
	}
	public static int GearboxDUB133
	{
		get
		{
			return gearboxDUB133;
		}
		set
		{
			gearboxDUB133 = value;
			PlayerPrefs.SetInt("gearboxDUB133", gearboxDUB133);
		}
	}
	public static int BrakeDUB133
	{
		get
		{
			return brakeDUB133;
		}
		set
		{
			brakeDUB133 = value;
			PlayerPrefs.SetInt("brakeDUB133", brakeDUB133);
		}
	}
	public static int FuelTankDUB133
	{
		get
		{
			return fuelTankDUB133;
		}
		set
		{
			fuelTankDUB133 = value;
			PlayerPrefs.SetInt("fuelTankDUB133", fuelTankDUB133);
		}
	}
	public static float FuelDUB133
	{
		get
		{
			return fuelDUB133;
		}
		set
		{
			fuelDUB133 = value;
			PlayerPrefs.SetFloat("fuelDUB133", fuelDUB133);
		}
	}
	public static int RearBogieDUB133
	{
		get
		{
			return rearBogieDUB133;
		}
		set
		{
			rearBogieDUB133 = value;
			PlayerPrefs.SetInt("rearBogieDUB133", rearBogieDUB133);
		}
	}
	public static int ExternalTuningDUB133
	{
		get
		{
			return externalTuningDUB133;
		}
		set
		{
			externalTuningDUB133 = value;
			PlayerPrefs.SetInt("externalTuningDUB133", externalTuningDUB133);
		}
	}
	///////////////////   D U B   4 4 2 1 /////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveDUB4421
	{
		get
		{
			return xpActiveDUB4421;
		}
		set
		{
			xpActiveDUB4421 = value;
			PlayerPrefs.SetInt("xpActiveDUB4421", xpActiveDUB4421);
		}
	}
	public static int MoneyActiveDUB4421
	{
		get
		{
			return moneyActiveDUB4421;
		}
		set
		{
			moneyActiveDUB4421 = value;
			PlayerPrefs.SetInt("moneyActiveDUB4421", moneyActiveDUB4421);
		}
	}
	public static int EngineDUB4421
	{
		get
		{
			return engineDUB4421;
		}
		set
		{
			engineDUB4421 = value;
			PlayerPrefs.SetInt("engineDUB4421", engineDUB4421);
		}
	}
	public static int GearboxDUB4421
	{
		get
		{
			return gearboxDUB4421;
		}
		set
		{
			gearboxDUB4421 = value;
			PlayerPrefs.SetInt("gearboxDUB4421", gearboxDUB4421);
		}
	}
	public static int BrakeDUB4421
	{
		get
		{
			return brakeDUB4421;
		}
		set
		{
			brakeDUB4421 = value;
			PlayerPrefs.SetInt("brakeDUB4421", brakeDUB4421);
		}
	}
	public static int FuelTankDUB4421
	{
		get
		{
			return fuelTankDUB4421;
		}
		set
		{
			fuelTankDUB4421 = value;
			PlayerPrefs.SetInt("fuelTankDUB4421", fuelTankDUB4421);
		}
	}
	public static float FuelDUB4421
	{
		get
		{
			return fuelDUB4421;
		}
		set
		{
			fuelDUB4421 = value;
			PlayerPrefs.SetFloat("fuelDUB4421", fuelDUB4421);
		}
	}
	public static int RearBogieDUB4421
	{
		get
		{
			return rearBogieDUB4421;
		}
		set
		{
			rearBogieDUB4421 = value;
			PlayerPrefs.SetInt("rearBogieDUB4421", rearBogieDUB4421);
		}
	}
	public static int ExternalTuningDUB4421
	{
		get
		{
			return externalTuningDUB4421;
		}
		set
		{
			externalTuningDUB4421 = value;
			PlayerPrefs.SetInt("externalTuningDUB4421", externalTuningDUB4421);
		}
	}
	///////////////////   D U B   5 4 2 3 /////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveDUB5423
	{
		get
		{
			return xpActiveDUB5423;
		}
		set
		{
			xpActiveDUB5423 = value;
			PlayerPrefs.SetInt("xpActiveDUB5423", xpActiveDUB5423);
		}
	}
	public static int MoneyActiveDUB5423
	{
		get
		{
			return moneyActiveDUB5423;
		}
		set
		{
			moneyActiveDUB5423 = value;
			PlayerPrefs.SetInt("moneyActiveDUB5423", moneyActiveDUB5423);
		}
	}
	public static int EngineDUB5423
	{
		get
		{
			return engineDUB5423;
		}
		set
		{
			engineDUB5423 = value;
			PlayerPrefs.SetInt("engineDUB5423", engineDUB5423);
		}
	}
	public static int GearboxDUB5423
	{
		get
		{
			return gearboxDUB5423;
		}
		set
		{
			gearboxDUB5423 = value;
			PlayerPrefs.SetInt("gearboxDUB5423", gearboxDUB5423);
		}
	}
	public static int BrakeDUB5423
	{
		get
		{
			return brakeDUB5423;
		}
		set
		{
			brakeDUB5423 = value;
			PlayerPrefs.SetInt("brakeDUB5423", brakeDUB5423);
		}
	}
	public static int FuelTankDUB5423
	{
		get
		{
			return fuelTankDUB5423;
		}
		set
		{
			fuelTankDUB5423 = value;
			PlayerPrefs.SetInt("fuelTankDUB5423", fuelTankDUB5423);
		}
	}
	public static float FuelDUB5423
	{
		get
		{
			return fuelDUB5423;
		}
		set
		{
			fuelDUB5423 = value;
			PlayerPrefs.SetFloat("fuelDUB5423", fuelDUB5423);
		}
	}
	public static int RearBogieDUB5423
	{
		get
		{
			return rearBogieDUB5423;
		}
		set
		{
			rearBogieDUB5423 = value;
			PlayerPrefs.SetInt("rearBogieDUB5423", rearBogieDUB5423);
		}
	}
	public static int ExternalTuningDUB5423
	{
		get
		{
			return externalTuningDUB5423;
		}
		set
		{
			externalTuningDUB5423 = value;
			PlayerPrefs.SetInt("externalTuningDUB5423", externalTuningDUB5423);
		}
	}
	///////////////////   F I I V   S E R I A   /////////////////////////////////////////////////////////////////////////////////////////
	///////////////////   F I I V   6 9 0   ///////////////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveFIIV690
	{
		get
		{
			return xpActiveFIIV690;
		}
		set
		{
			xpActiveFIIV690 = value;
			PlayerPrefs.SetInt("xpActiveFIIV690", xpActiveFIIV690);
		}
	}
	public static int MoneyActiveFIIV690
	{
		get
		{
			return moneyActiveFIIV690;
		}
		set
		{
			moneyActiveFIIV690 = value;
			PlayerPrefs.SetInt("moneyActiveFIIV690", moneyActiveFIIV690);
		}
	}
	public static int EngineFIIV690
	{
		get
		{
			return engineFIIV690;
		}
		set
		{
			engineFIIV690 = value;
			PlayerPrefs.SetInt("engineFIIV690", engineFIIV690);
		}
	}
	public static int GearboxFIIV690
	{
		get
		{
			return gearboxFIIV690;
		}
		set
		{
			gearboxFIIV690 = value;
			PlayerPrefs.SetInt("gearboxFIIV690", gearboxFIIV690);
		}
	}
	public static int BrakeFIIV690
	{
		get
		{
			return brakeFIIV690;
		}
		set
		{
			brakeFIIV690 = value;
			PlayerPrefs.SetInt("brakeFIIV690", brakeFIIV690);
		}
	}
	public static int FuelTankFIIV690
	{
		get
		{
			return fuelTankFIIV690;
		}
		set
		{
			fuelTankFIIV690 = value;
			PlayerPrefs.SetInt("fuelTankFIIV690", fuelTankFIIV690);
		}
	}
	public static float FuelFIIV690
	{
		get
		{
			return fuelFIIV690;
		}
		set
		{
			fuelFIIV690 = value;
			PlayerPrefs.SetFloat("fuelFIIV690", fuelFIIV690);
		}
	}
	public static int RearBogieFIIV690
	{
		get
		{
			return rearBogieFIIV690;
		}
		set
		{
			rearBogieFIIV690 = value;
			PlayerPrefs.SetInt("rearBogieFIIV690", rearBogieFIIV690);
		}
	}
	public static int ExternalTuningFIIV690
	{
		get
		{
			return externalTuningFIIV690;
		}
		set
		{
			externalTuningFIIV690 = value;
			PlayerPrefs.SetInt("externalTuningFIIV690", externalTuningFIIV690);
		}
	}
	///////////////////   F I I V   6 1 9   ///////////////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveFIIV619
	{
		get
		{
			return xpActiveFIIV619;
		}
		set
		{
			xpActiveFIIV619 = value;
			PlayerPrefs.SetInt("xpActiveFIIV619", xpActiveFIIV619);
		}
	}
	public static int MoneyActiveFIIV619
	{
		get
		{
			return moneyActiveFIIV619;
		}
		set
		{
			moneyActiveFIIV619 = value;
			PlayerPrefs.SetInt("moneyActiveFIIV619", moneyActiveFIIV619);
		}
	}
	public static int EngineFIIV619
	{
		get
		{
			return engineFIIV619;
		}
		set
		{
			engineFIIV619 = value;
			PlayerPrefs.SetInt("engineFIIV619", engineFIIV619);
		}
	}
	public static int GearboxFIIV619
	{
		get
		{
			return gearboxFIIV619;
		}
		set
		{
			gearboxFIIV619 = value;
			PlayerPrefs.SetInt("gearboxFIIV619", gearboxFIIV619);
		}
	}
	public static int BrakeFIIV619
	{
		get
		{
			return brakeFIIV619;
		}
		set
		{
			brakeFIIV619 = value;
			PlayerPrefs.SetInt("brakeFIIV619", brakeFIIV619);
		}
	}
	public static int FuelTankFIIV619
	{
		get
		{
			return fuelTankFIIV619;
		}
		set
		{
			fuelTankFIIV619 = value;
			PlayerPrefs.SetInt("fuelTankFIIV619", fuelTankFIIV619);
		}
	}
	public static float FuelFIIV619
	{
		get
		{
			return fuelFIIV619;
		}
		set
		{
			fuelFIIV619 = value;
			PlayerPrefs.SetFloat("fuelFIIV619", fuelFIIV619);
		}
	}
	public static int RearBogieFIIV619
	{
		get
		{
			return rearBogieFIIV619;
		}
		set
		{
			rearBogieFIIV619 = value;
			PlayerPrefs.SetInt("rearBogieFIIV619", rearBogieFIIV619);
		}
	}
	public static int ExternalTuningFIIV619
	{
		get
		{
			return externalTuningFIIV619;
		}
		set
		{
			externalTuningFIIV619 = value;
			PlayerPrefs.SetInt("externalTuningFIIV619", externalTuningFIIV619);
		}
	}
	///////////////////   F I I V   T S   ///////////////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveFIIVTS
	{
		get
		{
			return xpActiveFIIVTS;
		}
		set
		{
			xpActiveFIIVTS = value;
			PlayerPrefs.SetInt("xpActiveFIIVTS", xpActiveFIIVTS);
		}
	}
	public static int MoneyActiveFIIVTS
	{
		get
		{
			return moneyActiveFIIVTS;
		}
		set
		{
			moneyActiveFIIVTS = value;
			PlayerPrefs.SetInt("moneyActiveFIIVTS", moneyActiveFIIVTS);
		}
	}
	public static int EngineFIIVTS
	{
		get
		{
			return engineFIIVTS;
		}
		set
		{
			engineFIIVTS = value;
			PlayerPrefs.SetInt("engineFIIVTS", engineFIIVTS);
		}
	}
	public static int GearboxFIIVTS
	{
		get
		{
			return gearboxFIIVTS;
		}
		set
		{
			gearboxFIIVTS = value;
			PlayerPrefs.SetInt("gearboxFIIVTS", gearboxFIIVTS);
		}
	}
	public static int BrakeFIIVTS
	{
		get
		{
			return brakeFIIVTS;
		}
		set
		{
			brakeFIIVTS = value;
			PlayerPrefs.SetInt("brakeFIIVTS", brakeFIIVTS);
		}
	}
	public static int FuelTankFIIVTS
	{
		get
		{
			return fuelTankFIIVTS;
		}
		set
		{
			fuelTankFIIVTS = value;
			PlayerPrefs.SetInt("fuelTankFIIVTS", fuelTankFIIVTS);
		}
	}
	public static float FuelFIIVTS
	{
		get
		{
			return fuelFIIVTS;
		}
		set
		{
			fuelFIIVTS = value;
			PlayerPrefs.SetFloat("fuelFIIVTS", fuelFIIVTS);
		}
	}
	public static int RearBogieFIIVTS
	{
		get
		{
			return rearBogieFIIVTS;
		}
		set
		{
			rearBogieFIIVTS = value;
			PlayerPrefs.SetInt("rearBogieFIIVTS", rearBogieFIIVTS);
		}
	}
	public static int ExternalTuningFIIVTS
	{
		get
		{
			return externalTuningFIIVTS;
		}
		set
		{
			externalTuningFIIVTS = value;
			PlayerPrefs.SetInt("externalTuningFIIVTS", externalTuningFIIVTS);
		}
	}
	///////////////////   F I I V   E S   ///////////////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveFIIVES
	{
		get
		{
			return xpActiveFIIVES;
		}
		set
		{
			xpActiveFIIVES = value;
			PlayerPrefs.SetInt("xpActiveFIIVES", xpActiveFIIVES);
		}
	}
	public static int MoneyActiveFIIVES
	{
		get
		{
			return moneyActiveFIIVES;
		}
		set
		{
			moneyActiveFIIVES = value;
			PlayerPrefs.SetInt("moneyActiveFIIVES", moneyActiveFIIVES);
		}
	}
	public static int EngineFIIVES
	{
		get
		{
			return engineFIIVES;
		}
		set
		{
			engineFIIVES = value;
			PlayerPrefs.SetInt("engineFIIVES", engineFIIVES);
		}
	}
	public static int GearboxFIIVES
	{
		get
		{
			return gearboxFIIVES;
		}
		set
		{
			gearboxFIIVES = value;
			PlayerPrefs.SetInt("gearboxFIIVES", gearboxFIIVES);
		}
	}
	public static int BrakeFIIVES
	{
		get
		{
			return brakeFIIVES;
		}
		set
		{
			brakeFIIVES = value;
			PlayerPrefs.SetInt("brakeFIIVES", brakeFIIVES);
		}
	}
	public static int FuelTankFIIVES
	{
		get
		{
			return fuelTankFIIVES;
		}
		set
		{
			fuelTankFIIVES = value;
			PlayerPrefs.SetInt("fuelTankFIIVES", fuelTankFIIVES);
		}
	}
	public static float FuelFIIVES
	{
		get
		{
			return fuelFIIVES;
		}
		set
		{
			fuelFIIVES = value;
			PlayerPrefs.SetFloat("fuelFIIVES", fuelFIIVES);
		}
	}
	public static int RearBogieFIIVES
	{
		get
		{
			return rearBogieFIIVES;
		}
		set
		{
			rearBogieFIIVES = value;
			PlayerPrefs.SetInt("rearBogieFIIVES", rearBogieFIIVES);
		}
	}
	public static int ExternalTuningFIIVES
	{
		get
		{
			return externalTuningFIIVES;
		}
		set
		{
			externalTuningFIIVES = value;
			PlayerPrefs.SetInt("externalTuningFIIVES", externalTuningFIIVES);
		}
	}
	///////////////////   F I I V   S T   ///////////////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveFIIVST
	{
		get
		{
			return xpActiveFIIVST;
		}
		set
		{
			xpActiveFIIVST = value;
			PlayerPrefs.SetInt("xpActiveFIIVST", xpActiveFIIVST);
		}
	}
	public static int MoneyActiveFIIVST
	{
		get
		{
			return moneyActiveFIIVST;
		}
		set
		{
			moneyActiveFIIVST = value;
			PlayerPrefs.SetInt("moneyActiveFIIVST", moneyActiveFIIVST);
		}
	}
	public static int EngineFIIVST
	{
		get
		{
			return engineFIIVST;
		}
		set
		{
			engineFIIVST = value;
			PlayerPrefs.SetInt("engineFIIVST", engineFIIVST);
		}
	}
	public static int GearboxFIIVST
	{
		get
		{
			return gearboxFIIVST;
		}
		set
		{
			gearboxFIIVST = value;
			PlayerPrefs.SetInt("gearboxFIIVST", gearboxFIIVST);
		}
	}
	public static int BrakeFIIVST
	{
		get
		{
			return brakeFIIVST;
		}
		set
		{
			brakeFIIVST = value;
			PlayerPrefs.SetInt("brakeFIIVST", brakeFIIVST);
		}
	}
	public static int FuelTankFIIVST
	{
		get
		{
			return fuelTankFIIVST;
		}
		set
		{
			fuelTankFIIVST = value;
			PlayerPrefs.SetInt("fuelTankFIIVST", fuelTankFIIVST);
		}
	}
	public static float FuelFIIVST
	{
		get
		{
			return fuelFIIVST;
		}
		set
		{
			fuelFIIVST = value;
			PlayerPrefs.SetFloat("fuelFIIVST", fuelFIIVST);
		}
	}
	public static int RearBogieFIIVST
	{
		get
		{
			return rearBogieFIIVST;
		}
		set
		{
			rearBogieFIIVST = value;
			PlayerPrefs.SetInt("rearBogieFIIVST", rearBogieFIIVST);
		}
	}
	public static int ExternalTuningFIIVST
	{
		get
		{
			return externalTuningFIIVST;
		}
		set
		{
			externalTuningFIIVST = value;
			PlayerPrefs.SetInt("externalTuningFIIVST", externalTuningFIIVST);
		}
	}
	///////////////////   F I I V   S T R   ///////////////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveFIIVSTR
	{
		get
		{
			return xpActiveFIIVSTR;
		}
		set
		{
			xpActiveFIIVSTR = value;
			PlayerPrefs.SetInt("xpActiveFIIVSTR", xpActiveFIIVSTR);
		}
	}
	public static int MoneyActiveFIIVSTR
	{
		get
		{
			return moneyActiveFIIVSTR;
		}
		set
		{
			moneyActiveFIIVSTR = value;
			PlayerPrefs.SetInt("moneyActiveFIIVSTR", moneyActiveFIIVSTR);
		}
	}
	public static int EngineFIIVSTR
	{
		get
		{
			return engineFIIVSTR;
		}
		set
		{
			engineFIIVSTR = value;
			PlayerPrefs.SetInt("engineFIIVSTR", engineFIIVSTR);
		}
	}
	public static int GearboxFIIVSTR
	{
		get
		{
			return gearboxFIIVSTR;
		}
		set
		{
			gearboxFIIVSTR = value;
			PlayerPrefs.SetInt("gearboxFIIVSTR", gearboxFIIVSTR);
		}
	}
	public static int BrakeFIIVSTR
	{
		get
		{
			return brakeFIIVSTR;
		}
		set
		{
			brakeFIIVSTR = value;
			PlayerPrefs.SetInt("brakeFIIVSTR", brakeFIIVSTR);
		}
	}
	public static int FuelTankFIIVSTR
	{
		get
		{
			return fuelTankFIIVSTR;
		}
		set
		{
			fuelTankFIIVSTR = value;
			PlayerPrefs.SetInt("fuelTankFIIVSTR", fuelTankFIIVSTR);
		}
	}
	public static float FuelFIIVSTR
	{
		get
		{
			return fuelFIIVSTR;
		}
		set
		{
			fuelFIIVSTR = value;
			PlayerPrefs.SetFloat("fuelFIIVSTR", fuelFIIVSTR);
		}
	}
	public static int RearBogieFIIVSTR
	{
		get
		{
			return rearBogieFIIVSTR;
		}
		set
		{
			rearBogieFIIVSTR = value;
			PlayerPrefs.SetInt("rearBogieFIIVSTR", rearBogieFIIVSTR);
		}
	}
	public static int ExternalTuningFIIVSTR
	{
		get
		{
			return externalTuningFIIVSTR;
		}
		set
		{
			externalTuningFIIVSTR = value;
			PlayerPrefs.SetInt("externalTuningFIIVSTR", externalTuningFIIVSTR);
		}
	}
	///////////////////   F I I V   H W   ///////////////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveFIIVHW
	{
		get
		{
			return xpActiveFIIVHW;
		}
		set
		{
			xpActiveFIIVHW = value;
			PlayerPrefs.SetInt("xpActiveFIIVHW", xpActiveFIIVHW);
		}
	}
	public static int MoneyActiveFIIVHW
	{
		get
		{
			return moneyActiveFIIVHW;
		}
		set
		{
			moneyActiveFIIVHW = value;
			PlayerPrefs.SetInt("moneyActiveFIIVHW", moneyActiveFIIVHW);
		}
	}
	public static int EngineFIIVHW
	{
		get
		{
			return engineFIIVHW;
		}
		set
		{
			engineFIIVHW = value;
			PlayerPrefs.SetInt("engineFIIVHW", engineFIIVHW);
		}
	}
	public static int GearboxFIIVHW
	{
		get
		{
			return gearboxFIIVHW;
		}
		set
		{
			gearboxFIIVHW = value;
			PlayerPrefs.SetInt("gearboxFIIVHW", gearboxFIIVHW);
		}
	}
	public static int BrakeFIIVHW
	{
		get
		{
			return brakeFIIVHW;
		}
		set
		{
			brakeFIIVHW = value;
			PlayerPrefs.SetInt("brakeFIIVHW", brakeFIIVHW);
		}
	}
	public static int FuelTankFIIVHW
	{
		get
		{
			return fuelTankFIIVHW;
		}
		set
		{
			fuelTankFIIVHW = value;
			PlayerPrefs.SetInt("fuelTankFIIVHW", fuelTankFIIVHW);
		}
	}
	public static float FuelFIIVHW
	{
		get
		{
			return fuelFIIVHW;
		}
		set
		{
			fuelFIIVHW = value;
			PlayerPrefs.SetFloat("fuelFIIVHW", fuelFIIVHW);
		}
	}
	public static int RearBogieFIIVHW
	{
		get
		{
			return rearBogieFIIVHW;
		}
		set
		{
			rearBogieFIIVHW = value;
			PlayerPrefs.SetInt("rearBogieFIIVHW", rearBogieFIIVHW);
		}
	}
	public static int ExternalTuningFIIVHW
	{
		get
		{
			return externalTuningFIIVHW;
		}
		set
		{
			externalTuningFIIVHW = value;
			PlayerPrefs.SetInt("externalTuningFIIVHW", externalTuningFIIVHW);
		}
	}
	///////////////////   F I I V   S W   ///////////////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveFIIVSW
	{
		get
		{
			return xpActiveFIIVSW;
		}
		set
		{
			xpActiveFIIVSW = value;
			PlayerPrefs.SetInt("xpActiveFIIVSW", xpActiveFIIVSW);
		}
	}
	public static int MoneyActiveFIIVSW
	{
		get
		{
			return moneyActiveFIIVSW;
		}
		set
		{
			moneyActiveFIIVSW = value;
			PlayerPrefs.SetInt("moneyActiveFIIVSW", moneyActiveFIIVSW);
		}
	}
	public static int EngineFIIVSW
	{
		get
		{
			return engineFIIVSW;
		}
		set
		{
			engineFIIVSW = value;
			PlayerPrefs.SetInt("engineFIIVSW", engineFIIVSW);
		}
	}
	public static int GearboxFIIVSW
	{
		get
		{
			return gearboxFIIVSW;
		}
		set
		{
			gearboxFIIVSW = value;
			PlayerPrefs.SetInt("gearboxFIIVSW", gearboxFIIVSW);
		}
	}
	public static int BrakeFIIVSW
	{
		get
		{
			return brakeFIIVSW;
		}
		set
		{
			brakeFIIVSW = value;
			PlayerPrefs.SetInt("brakeFIIVSW", brakeFIIVSW);
		}
	}
	public static int FuelTankFIIVSW
	{
		get
		{
			return fuelTankFIIVSW;
		}
		set
		{
			fuelTankFIIVSW = value;
			PlayerPrefs.SetInt("fuelTankFIIVSW", fuelTankFIIVSW);
		}
	}
	public static float FuelFIIVSW
	{
		get
		{
			return fuelFIIVSW;
		}
		set
		{
			fuelFIIVSW = value;
			PlayerPrefs.SetFloat("fuelFIIVSW", fuelFIIVSW);
		}
	}
	public static int RearBogieFIIVSW
	{
		get
		{
			return rearBogieFIIVSW;
		}
		set
		{
			rearBogieFIIVSW = value;
			PlayerPrefs.SetInt("rearBogieFIIVSW", rearBogieFIIVSW);
		}
	}
	public static int ExternalTuningFIIVSW
	{
		get
		{
			return externalTuningFIIVSW;
		}
		set
		{
			externalTuningFIIVSW = value;
			PlayerPrefs.SetInt("externalTuningFIIVSW", externalTuningFIIVSW);
		}
	}
	///////////////////   H O R S E   S E R I A   /////////////////////////////////////////////////////////////////////////////////////////
	///////////////////   H O R S E   5 4 1 0   ///////////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveHORSE5410
	{
		get
		{
			return xpActiveHORSE5410;
		}
		set
		{
			xpActiveHORSE5410 = value;
			PlayerPrefs.SetInt("xpActiveHORSE5410", xpActiveHORSE5410);
		}
	}
	public static int MoneyActiveHORSE5410
	{
		get
		{
			return moneyActiveHORSE5410;
		}
		set
		{
			moneyActiveHORSE5410 = value;
			PlayerPrefs.SetInt("moneyActiveHORSE5410", moneyActiveHORSE5410);
		}
	}
	public static int EngineHORSE5410
	{
		get
		{
			return engineHORSE5410;
		}
		set
		{
			engineHORSE5410 = value;
			PlayerPrefs.SetInt("engineHORSE5410", engineHORSE5410);
		}
	}
	public static int GearboxHORSE5410
	{
		get
		{
			return gearboxHORSE5410;
		}
		set
		{
			gearboxHORSE5410 = value;
			PlayerPrefs.SetInt("gearboxHORSE5410", gearboxHORSE5410);
		}
	}
	public static int BrakeHORSE5410
	{
		get
		{
			return brakeHORSE5410;
		}
		set
		{
			brakeHORSE5410 = value;
			PlayerPrefs.SetInt("brakeHORSE5410", brakeHORSE5410);
		}
	}
	public static int FuelTankHORSE5410
	{
		get
		{
			return fuelTankHORSE5410;
		}
		set
		{
			fuelTankHORSE5410 = value;
			PlayerPrefs.SetInt("fuelTankHORSE5410", fuelTankHORSE5410);
		}
	}
	public static float FuelHORSE5410
	{
		get
		{
			return fuelHORSE5410;
		}
		set
		{
			fuelHORSE5410 = value;
			PlayerPrefs.SetFloat("fuelHORSE5410", fuelHORSE5410);
		}
	}
	public static int RearBogieHORSE5410
	{
		get
		{
			return rearBogieHORSE5410;
		}
		set
		{
			rearBogieHORSE5410 = value;
			PlayerPrefs.SetInt("rearBogieHORSE5410", rearBogieHORSE5410);
		}
	}
	public static int ExternalTuningHORSE5410
	{
		get
		{
			return externalTuningHORSE5410;
		}
		set
		{
			externalTuningHORSE5410 = value;
			PlayerPrefs.SetInt("externalTuningHORSE5410", externalTuningHORSE5410);
		}
	}
	///////////////////   H O R S E   6 4 6 0   ///////////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveHORSE6460
	{
		get
		{
			return xpActiveHORSE6460;
		}
		set
		{
			xpActiveHORSE6460 = value;
			PlayerPrefs.SetInt("xpActiveHORSE6460", xpActiveHORSE6460);
		}
	}
	public static int MoneyActiveHORSE6460
	{
		get
		{
			return moneyActiveHORSE6460;
		}
		set
		{
			moneyActiveHORSE6460 = value;
			PlayerPrefs.SetInt("moneyActiveHORSE6460", moneyActiveHORSE6460);
		}
	}
	public static int EngineHORSE6460
	{
		get
		{
			return engineHORSE6460;
		}
		set
		{
			engineHORSE6460 = value;
			PlayerPrefs.SetInt("engineHORSE6460", engineHORSE6460);
		}
	}
	public static int GearboxHORSE6460
	{
		get
		{
			return gearboxHORSE6460;
		}
		set
		{
			gearboxHORSE6460 = value;
			PlayerPrefs.SetInt("gearboxHORSE6460", gearboxHORSE6460);
		}
	}
	public static int BrakeHORSE6460
	{
		get
		{
			return brakeHORSE6460;
		}
		set
		{
			brakeHORSE6460 = value;
			PlayerPrefs.SetInt("brakeHORSE6460", brakeHORSE6460);
		}
	}
	public static int FuelTankHORSE6460
	{
		get
		{
			return fuelTankHORSE6460;
		}
		set
		{
			fuelTankHORSE6460 = value;
			PlayerPrefs.SetInt("fuelTankHORSE6460", fuelTankHORSE6460);
		}
	}
	public static float FuelHORSE6460
	{
		get
		{
			return fuelHORSE6460;
		}
		set
		{
			fuelHORSE6460 = value;
			PlayerPrefs.SetFloat("fuelHORSE6460", fuelHORSE6460);
		}
	}
	public static int RearBogieHORSE6460
	{
		get
		{
			return rearBogieHORSE6460;
		}
		set
		{
			rearBogieHORSE6460 = value;
			PlayerPrefs.SetInt("rearBogieHORSE6460", rearBogieHORSE6460);
		}
	}
	public static int ExternalTuningHORSE6460
	{
		get
		{
			return externalTuningHORSE6460;
		}
		set
		{
			externalTuningHORSE6460 = value;
			PlayerPrefs.SetInt("externalTuningHORSE6460", externalTuningHORSE6460);
		}
	}
	///////////////////   H O R S E   5 4 6 0   ///////////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveHORSE5460
	{
		get
		{
			return xpActiveHORSE5460;
		}
		set
		{
			xpActiveHORSE5460 = value;
			PlayerPrefs.SetInt("xpActiveHORSE5460", xpActiveHORSE5460);
		}
	}
	public static int MoneyActiveHORSE5460
	{
		get
		{
			return moneyActiveHORSE5460;
		}
		set
		{
			moneyActiveHORSE5460 = value;
			PlayerPrefs.SetInt("moneyActiveHORSE5460", moneyActiveHORSE5460);
		}
	}
	public static int EngineHORSE5460
	{
		get
		{
			return engineHORSE5460;
		}
		set
		{
			engineHORSE5460 = value;
			PlayerPrefs.SetInt("engineHORSE5460", engineHORSE5460);
		}
	}
	public static int GearboxHORSE5460
	{
		get
		{
			return gearboxHORSE5460;
		}
		set
		{
			gearboxHORSE5460 = value;
			PlayerPrefs.SetInt("gearboxHORSE5460", gearboxHORSE5460);
		}
	}
	public static int BrakeHORSE5460
	{
		get
		{
			return brakeHORSE5460;
		}
		set
		{
			brakeHORSE5460 = value;
			PlayerPrefs.SetInt("brakeHORSE5460", brakeHORSE5460);
		}
	}
	public static int FuelTankHORSE5460
	{
		get
		{
			return fuelTankHORSE5460;
		}
		set
		{
			fuelTankHORSE5460 = value;
			PlayerPrefs.SetInt("fuelTankHORSE5460", fuelTankHORSE5460);
		}
	}
	public static float FuelHORSE5460
	{
		get
		{
			return fuelHORSE5460;
		}
		set
		{
			fuelHORSE5460 = value;
			PlayerPrefs.SetFloat("fuelHORSE5460", fuelHORSE5460);
		}
	}
	public static int RearBogieHORSE5460
	{
		get
		{
			return rearBogieHORSE5460;
		}
		set
		{
			rearBogieHORSE5460 = value;
			PlayerPrefs.SetInt("rearBogieHORSE5460", rearBogieHORSE5460);
		}
	}
	public static int ExternalTuningHORSE5460
	{
		get
		{
			return externalTuningHORSE5460;
		}
		set
		{
			externalTuningHORSE5460 = value;
			PlayerPrefs.SetInt("externalTuningHORSE5460", externalTuningHORSE5460);
		}
	}
	///////////////////   H O R S E   1 8 4 0   ///////////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveHORSE1840
	{
		get
		{
			return xpActiveHORSE1840;
		}
		set
		{
			xpActiveHORSE1840 = value;
			PlayerPrefs.SetInt("xpActiveHORSE1840", xpActiveHORSE1840);
		}
	}
	public static int MoneyActiveHORSE1840
	{
		get
		{
			return moneyActiveHORSE1840;
		}
		set
		{
			moneyActiveHORSE1840 = value;
			PlayerPrefs.SetInt("moneyActiveHORSE1840", moneyActiveHORSE1840);
		}
	}
	public static int EngineHORSE1840
	{
		get
		{
			return engineHORSE1840;
		}
		set
		{
			engineHORSE1840 = value;
			PlayerPrefs.SetInt("engineHORSE1840", engineHORSE1840);
		}
	}
	public static int GearboxHORSE1840
	{
		get
		{
			return gearboxHORSE1840;
		}
		set
		{
			gearboxHORSE1840 = value;
			PlayerPrefs.SetInt("gearboxHORSE1840", gearboxHORSE1840);
		}
	}
	public static int BrakeHORSE1840
	{
		get
		{
			return brakeHORSE1840;
		}
		set
		{
			brakeHORSE1840 = value;
			PlayerPrefs.SetInt("brakeHORSE1840", brakeHORSE1840);
		}
	}
	public static int FuelTankHORSE1840
	{
		get
		{
			return fuelTankHORSE1840;
		}
		set
		{
			fuelTankHORSE1840 = value;
			PlayerPrefs.SetInt("fuelTankHORSE1840", fuelTankHORSE1840);
		}
	}
	public static float FuelHORSE1840
	{
		get
		{
			return fuelHORSE1840;
		}
		set
		{
			fuelHORSE1840 = value;
			PlayerPrefs.SetFloat("fuelHORSE1840", fuelHORSE1840);
		}
	}
	public static int RearBogieHORSE1840
	{
		get
		{
			return rearBogieHORSE1840;
		}
		set
		{
			rearBogieHORSE1840 = value;
			PlayerPrefs.SetInt("rearBogieHORSE1840", rearBogieHORSE1840);
		}
	}
	public static int ExternalTuningHORSE1840
	{
		get
		{
			return externalTuningHORSE1840;
		}
		set
		{
			externalTuningHORSE1840 = value;
			PlayerPrefs.SetInt("externalTuningHORSE1840", externalTuningHORSE1840);
		}
	}
	///////////////////   H O R S E   1 8 5 5   ///////////////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveHORSE1855
	{
		get
		{
			return xpActiveHORSE1855;
		}
		set
		{
			xpActiveHORSE1855 = value;
			PlayerPrefs.SetInt("xpActiveHORSE1855", xpActiveHORSE1855);
		}
	}
	public static int MoneyActiveHORSE1855
	{
		get
		{
			return moneyActiveHORSE1855;
		}
		set
		{
			moneyActiveHORSE1855 = value;
			PlayerPrefs.SetInt("moneyActiveHORSE1855", moneyActiveHORSE1855);
		}
	}
	public static int EngineHORSE1855
	{
		get
		{
			return engineHORSE1855;
		}
		set
		{
			engineHORSE1855 = value;
			PlayerPrefs.SetInt("engineHORSE1855", engineHORSE1855);
		}
	}
	public static int GearboxHORSE1855
	{
		get
		{
			return gearboxHORSE1855;
		}
		set
		{
			gearboxHORSE1855 = value;
			PlayerPrefs.SetInt("gearboxHORSE1855", gearboxHORSE1855);
		}
	}
	public static int BrakeHORSE1855
	{
		get
		{
			return brakeHORSE1855;
		}
		set
		{
			brakeHORSE1855 = value;
			PlayerPrefs.SetInt("brakeHORSE1855", brakeHORSE1855);
		}
	}
	public static int FuelTankHORSE1855
	{
		get
		{
			return fuelTankHORSE1855;
		}
		set
		{
			fuelTankHORSE1855 = value;
			PlayerPrefs.SetInt("fuelTankHORSE1855", fuelTankHORSE1855);
		}
	}
	public static float FuelHORSE1855
	{
		get
		{
			return fuelHORSE1855;
		}
		set
		{
			fuelHORSE1855 = value;
			PlayerPrefs.SetFloat("fuelHORSE1855", fuelHORSE1855);
		}
	}
	public static int RearBogieHORSE1855
	{
		get
		{
			return rearBogieHORSE1855;
		}
		set
		{
			rearBogieHORSE1855 = value;
			PlayerPrefs.SetInt("rearBogieHORSE1855", rearBogieHORSE1855);
		}
	}
	public static int ExternalTuningHORSE1855
	{
		get
		{
			return externalTuningHORSE1855;
		}
		set
		{
			externalTuningHORSE1855 = value;
			PlayerPrefs.SetInt("externalTuningHORSE1855", externalTuningHORSE1855);
		}
	}
	///////////////////   R I D G E   S E R I A   /////////////////////////////////////////////////////////////////////////////////
	///////////////////   R I D G E    3 7 5 C   //////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveRIDGE375
	{
		get
		{
			return xpActiveRIDGE375;
		}
		set
		{
			xpActiveRIDGE375 = value;
			PlayerPrefs.SetInt("xpActiveRIDGE375", xpActiveRIDGE375);
		}
	}
	public static int MoneyActiveRIDGE375
	{
		get
		{
			return moneyActiveRIDGE375;
		}
		set
		{
			moneyActiveRIDGE375 = value;
			PlayerPrefs.SetInt("moneyActiveRIDGE375", moneyActiveRIDGE375);
		}
	}
	public static int EngineRIDGE375
	{
		get
		{
			return engineRIDGE375;
		}
		set
		{
			engineRIDGE375 = value;
			PlayerPrefs.SetInt("engineRIDGE375", engineRIDGE375);
		}
	}
	public static int GearboxRIDGE375
	{
		get
		{
			return gearboxRIDGE375;
		}
		set
		{
			gearboxRIDGE375 = value;
			PlayerPrefs.SetInt("gearboxRIDGE375", gearboxRIDGE375);
		}
	}
	public static int BrakeRIDGE375
	{
		get
		{
			return brakeRIDGE375;
		}
		set
		{
			brakeRIDGE375 = value;
			PlayerPrefs.SetInt("brakeRIDGE375", brakeRIDGE375);
		}
	}
	public static int FuelTankRIDGE375
	{
		get
		{
			return fuelTankRIDGE375;
		}
		set
		{
			fuelTankRIDGE375 = value;
			PlayerPrefs.SetInt("fuelTankRIDGE375", fuelTankRIDGE375);
		}
	}
	public static float FuelRIDGE375
	{
		get
		{
			return fuelRIDGE375;
		}
		set
		{
			fuelRIDGE375 = value;
			PlayerPrefs.SetFloat("fuelRIDGE375", fuelRIDGE375);
		}
	}
	public static int RearBogieRIDGE375
	{
		get
		{
			return rearBogieRIDGE375;
		}
		set
		{
			rearBogieRIDGE375 = value;
			PlayerPrefs.SetInt("rearBogieRIDGE375", rearBogieRIDGE375);
		}
	}
	public static int ExternalTuningRIDGE375
	{
		get
		{
			return externalTuningRIDGE375;
		}
		set
		{
			externalTuningRIDGE375 = value;
			PlayerPrefs.SetInt("externalTuningRIDGE375", externalTuningRIDGE375);
		}
	}
	///////////////////   R I D G E    4 4 2 0   //////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveRIDGE4420
	{
		get
		{
			return xpActiveRIDGE4420;
		}
		set
		{
			xpActiveRIDGE4420 = value;
			PlayerPrefs.SetInt("xpActiveRIDGE4420", xpActiveRIDGE4420);
		}
	}
	public static int MoneyActiveRIDGE4420
	{
		get
		{
			return moneyActiveRIDGE4420;
		}
		set
		{
			moneyActiveRIDGE4420 = value;
			PlayerPrefs.SetInt("moneyActiveRIDGE4420", moneyActiveRIDGE4420);
		}
	}
	public static int EngineRIDGE4420
	{
		get
		{
			return engineRIDGE4420;
		}
		set
		{
			engineRIDGE4420 = value;
			PlayerPrefs.SetInt("engineRIDGE4420", engineRIDGE4420);
		}
	}
	public static int GearboxRIDGE4420
	{
		get
		{
			return gearboxRIDGE4420;
		}
		set
		{
			gearboxRIDGE4420 = value;
			PlayerPrefs.SetInt("gearboxRIDGE4420", gearboxRIDGE4420);
		}
	}
	public static int BrakeRIDGE4420
	{
		get
		{
			return brakeRIDGE4420;
		}
		set
		{
			brakeRIDGE4420 = value;
			PlayerPrefs.SetInt("brakeRIDGE4420", brakeRIDGE4420);
		}
	}
	public static int FuelTankRIDGE4420
	{
		get
		{
			return fuelTankRIDGE4420;
		}
		set
		{
			fuelTankRIDGE4420 = value;
			PlayerPrefs.SetInt("fuelTankRIDGE4420", fuelTankRIDGE4420);
		}
	}
	public static float FuelRIDGE4420
	{
		get
		{
			return fuelRIDGE4420;
		}
		set
		{
			fuelRIDGE4420 = value;
			PlayerPrefs.SetFloat("fuelRIDGE4420", fuelRIDGE4420);
		}
	}
	public static int RearBogieRIDGE4420
	{
		get
		{
			return rearBogieRIDGE4420;
		}
		set
		{
			rearBogieRIDGE4420 = value;
			PlayerPrefs.SetInt("rearBogieRIDGE4420", rearBogieRIDGE4420);
		}
	}
	public static int ExternalTuningRIDGE4420
	{
		get
		{
			return externalTuningRIDGE4420;
		}
		set
		{
			externalTuningRIDGE4420 = value;
			PlayerPrefs.SetInt("externalTuningRIDGE4420", externalTuningRIDGE4420);
		}
	}
	///////////////////   R I D G E    6 3 7 0   //////////////////////////////////////////////////////////////////////////////////
	public static int XpActiveRIDGE6370
	{
		get
		{
			return xpActiveRIDGE6370;
		}
		set
		{
			xpActiveRIDGE6370 = value;
			PlayerPrefs.SetInt("xpActiveRIDGE6370", xpActiveRIDGE6370);
		}
	}
	public static int MoneyActiveRIDGE6370
	{
		get
		{
			return moneyActiveRIDGE6370;
		}
		set
		{
			moneyActiveRIDGE6370 = value;
			PlayerPrefs.SetInt("moneyActiveRIDGE6370", moneyActiveRIDGE6370);
		}
	}
	public static int EngineRIDGE6370
	{
		get
		{
			return engineRIDGE6370;
		}
		set
		{
			engineRIDGE6370 = value;
			PlayerPrefs.SetInt("engineRIDGE6370", engineRIDGE6370);
		}
	}
	public static int GearboxRIDGE6370
	{
		get
		{
			return gearboxRIDGE6370;
		}
		set
		{
			gearboxRIDGE6370 = value;
			PlayerPrefs.SetInt("gearboxRIDGE6370", gearboxRIDGE6370);
		}
	}
	public static int BrakeRIDGE6370
	{
		get
		{
			return brakeRIDGE6370;
		}
		set
		{
			brakeRIDGE6370 = value;
			PlayerPrefs.SetInt("brakeRIDGE6370", brakeRIDGE6370);
		}
	}
	public static int FuelTankRIDGE6370
	{
		get
		{
			return fuelTankRIDGE6370;
		}
		set
		{
			fuelTankRIDGE6370 = value;
			PlayerPrefs.SetInt("fuelTankRIDGE6370", fuelTankRIDGE6370);
		}
	}
	public static float FuelRIDGE6370
	{
		get
		{
			return fuelRIDGE6370;
		}
		set
		{
			fuelRIDGE6370 = value;
			PlayerPrefs.SetFloat("fuelRIDGE6370", fuelRIDGE6370);
		}
	}
	public static int RearBogieRIDGE6370
	{
		get
		{
			return rearBogieRIDGE6370;
		}
		set
		{
			rearBogieRIDGE6370 = value;
			PlayerPrefs.SetInt("rearBogieRIDGE6370", rearBogieRIDGE6370);
		}
	}
	public static int ExternalTuningRIDGE6370
	{
		get
		{
			return externalTuningRIDGE6370;
		}
		set
		{
			externalTuningRIDGE6370 = value;
			PlayerPrefs.SetInt("externalTuningRIDGE6370", externalTuningRIDGE6370);
		}
	}
	///////////////////   R I D G E    N X   ///////////////////////////////////////////////////////////////////////////////
	public static int XpActiveRIDGENX
	{
		get
		{
			return xpActiveRIDGENX;
		}
		set
		{
			xpActiveRIDGENX = value;
			PlayerPrefs.SetInt("xpActiveRIDGENX", xpActiveRIDGENX);
		}
	}
	public static int MoneyActiveRIDGENX
	{
		get
		{
			return moneyActiveRIDGENX;
		}
		set
		{
			moneyActiveRIDGENX = value;
			PlayerPrefs.SetInt("moneyActiveRIDGENX", moneyActiveRIDGENX);
		}
	}
	public static int EngineRIDGENX
	{
		get
		{
			return engineRIDGENX;
		}
		set
		{
			engineRIDGENX = value;
			PlayerPrefs.SetInt("engineRIDGENX", engineRIDGENX);
		}
	}
	public static int GearboxRIDGENX
	{
		get
		{
			return gearboxRIDGENX;
		}
		set
		{
			gearboxRIDGENX = value;
			PlayerPrefs.SetInt("gearboxRIDGENX", gearboxRIDGENX);
		}
	}
	public static int BrakeRIDGENX
	{
		get
		{
			return brakeRIDGENX;
		}
		set
		{
			brakeRIDGENX = value;
			PlayerPrefs.SetInt("brakeRIDGENX", brakeRIDGENX);
		}
	}
	public static int FuelTankRIDGENX
	{
		get
		{
			return fuelTankRIDGENX;
		}
		set
		{
			fuelTankRIDGENX = value;
			PlayerPrefs.SetInt("fuelTankRIDGENX", fuelTankRIDGENX);
		}
	}
	public static float FuelRIDGENX
	{
		get
		{
			return fuelRIDGENX;
		}
		set
		{
			fuelRIDGENX = value;
			PlayerPrefs.SetFloat("fuelRIDGENX", fuelRIDGENX);
		}
	}
	public static int RearBogieRIDGENX
	{
		get
		{
			return rearBogieRIDGENX;
		}
		set
		{
			rearBogieRIDGENX = value;
			PlayerPrefs.SetInt("rearBogieRIDGENX", rearBogieRIDGENX);
		}
	}
	public static int ExternalTuningRIDGENX
	{
		get
		{
			return externalTuningRIDGENX;
		}
		set
		{
			externalTuningRIDGENX = value;
			PlayerPrefs.SetInt("externalTuningRIDGENX", externalTuningRIDGENX);
		}
	}
	///////////////////   P R E M I U M   S E R I A   /////////////////////////////////////////////////////////////////////////////
	///////////////////   F O R B   C A R G O   ///////////////////////////////////////////////////////////////////////////////////
	public static int DollarActiveFORBCARGO
	{
		get
		{
			return dollarActiveFORBCARGO;
		}
		set
		{
			dollarActiveFORBCARGO = value;
			PlayerPrefs.SetInt("dollarActiveFORBCARGO", dollarActiveFORBCARGO);
		}
	}
	public static int EngineFORBCARGO
	{
		get
		{
			return engineFORBCARGO;
		}
		set
		{
			engineFORBCARGO = value;
			PlayerPrefs.SetInt("engineFORBCARGO", engineFORBCARGO);
		}
	}
	public static int GearboxFORBCARGO
	{
		get
		{
			return gearboxFORBCARGO;
		}
		set
		{
			gearboxFORBCARGO = value;
			PlayerPrefs.SetInt("gearboxFORBCARGO", gearboxFORBCARGO);
		}
	}
	public static int BrakeFORBCARGO
	{
		get
		{
			return brakeFORBCARGO;
		}
		set
		{
			brakeFORBCARGO = value;
			PlayerPrefs.SetInt("brakeFORBCARGO", brakeFORBCARGO);
		}
	}
	public static int FuelTankFORBCARGO
	{
		get
		{
			return fuelTankFORBCARGO;
		}
		set
		{
			fuelTankFORBCARGO = value;
			PlayerPrefs.SetInt("fuelTankFORBCARGO", fuelTankFORBCARGO);
		}
	}
	public static float FuelFORBCARGO
	{
		get
		{
			return fuelFORBCARGO;
		}
		set
		{
			fuelFORBCARGO = value;
			PlayerPrefs.SetFloat("fuelFORBCARGO", fuelFORBCARGO);
		}
	}
	public static int RearBogieFORBCARGO
	{
		get
		{
			return rearBogieFORBCARGO;
		}
		set
		{
			rearBogieFORBCARGO = value;
			PlayerPrefs.SetInt("rearBogieFORBCARGO", rearBogieFORBCARGO);
		}
	}
	public static int ExternalTuningFORBCARGO
	{
		get
		{
			return externalTuningFORBCARGO;
		}
		set
		{
			externalTuningFORBCARGO = value;
			PlayerPrefs.SetInt("externalTuningFORBCARGO", externalTuningFORBCARGO);
		}
	}
	///////////////////   F O R B   F M A X   /////////////////////////////////////////////////////////////////////////////////////
	public static int DollarActiveFORBFMAX
	{
		get
		{
			return dollarActiveFORBFMAX;
		}
		set
		{
			dollarActiveFORBFMAX = value;
			PlayerPrefs.SetInt("dollarActiveFORBFMAX", dollarActiveFORBFMAX);
		}
	}
	public static int EngineFORBFMAX
	{
		get
		{
			return engineFORBFMAX;
		}
		set
		{
			engineFORBFMAX = value;
			PlayerPrefs.SetInt("engineFORBFMAX", engineFORBFMAX);
		}
	}
	public static int GearboxFORBFMAX
	{
		get
		{
			return gearboxFORBFMAX;
		}
		set
		{
			gearboxFORBFMAX = value;
			PlayerPrefs.SetInt("gearboxFORBFMAX", gearboxFORBFMAX);
		}
	}
	public static int BrakeFORBFMAX
	{
		get
		{
			return brakeFORBFMAX;
		}
		set
		{
			brakeFORBFMAX = value;
			PlayerPrefs.SetInt("brakeFORBFMAX", brakeFORBFMAX);
		}
	}
	public static int FuelTankFORBFMAX
	{
		get
		{
			return fuelTankFORBFMAX;
		}
		set
		{
			fuelTankFORBFMAX = value;
			PlayerPrefs.SetInt("fuelTankFORBFMAX", fuelTankFORBFMAX);
		}
	}
	public static float FuelFORBFMAX
	{
		get
		{
			return fuelFORBFMAX;
		}
		set
		{
			fuelFORBFMAX = value;
			PlayerPrefs.SetFloat("fuelFORBFMAX", fuelFORBFMAX);
		}
	}
	public static int RearBogieFORBFMAX
	{
		get
		{
			return rearBogieFORBFMAX;
		}
		set
		{
			rearBogieFORBFMAX = value;
			PlayerPrefs.SetInt("rearBogieFORBFMAX", rearBogieFORBFMAX);
		}
	}
	public static int ExternalTuningFORBFMAX
	{
		get
		{
			return externalTuningFORBFMAX;
		}
		set
		{
			externalTuningFORBFMAX = value;
			PlayerPrefs.SetInt("externalTuningFORBFMAX", externalTuningFORBFMAX);
		}
	}
	//////////////////////// B O A R D ////////////////////////////////////////////////////////////////////////////////////////////
	///
	public static int XpActiveB1
	{
		get
		{
			return xpActiveB1;
		}
		set
		{
			xpActiveB1 = value;
			PlayerPrefs.SetInt("xpActiveB1", xpActiveB1);
		}
	}	
	public static int MoneyActiveB1
	{
		get
		{
			return moneyActiveB1;
		}
		set
		{
			moneyActiveB1 = value;
			PlayerPrefs.SetInt("moneyActiveB1", moneyActiveB1);
		}
	}
	///
	public static int XpActiveB2
	{
		get
		{
			return xpActiveB2;
		}
		set
		{
			xpActiveB2 = value;
			PlayerPrefs.SetInt("xpActiveB2", xpActiveB2);
		}
	}
	public static int MoneyActiveB2
	{
		get
		{
			return moneyActiveB2;
		}
		set
		{
			moneyActiveB2 = value;
			PlayerPrefs.SetInt("moneyActiveB2", moneyActiveB2);
		}
	}
	///
	public static int XpActiveB3
	{
		get
		{
			return xpActiveB3;
		}
		set
		{
			xpActiveB3 = value;
			PlayerPrefs.SetInt("xpActiveB3", xpActiveB3);
		}
	}
	public static int MoneyActiveB3
	{
		get
		{
			return moneyActiveB3;
		}
		set
		{
			moneyActiveB3 = value;
			PlayerPrefs.SetInt("moneyActiveB3", moneyActiveB3);
		}
	}
	///
	public static int XpActiveB4
	{
		get
		{
			return xpActiveB4;
		}
		set
		{
			xpActiveB4 = value;
			PlayerPrefs.SetInt("xpActiveB4", xpActiveB4);
		}
	}
	public static int MoneyActiveB4
	{
		get
		{
			return moneyActiveB4;
		}
		set
		{
			moneyActiveB4 = value;
			PlayerPrefs.SetInt("moneyActiveB4", moneyActiveB4);
		}
	}
	///
	public static int XpActiveB5
	{
		get
		{
			return xpActiveB5;
		}
		set
		{
			xpActiveB5 = value;
			PlayerPrefs.SetInt("xpActiveB5", xpActiveB5);
		}
	}
	public static int MoneyActiveB5
	{
		get
		{
			return moneyActiveB5;
		}
		set
		{
			moneyActiveB5 = value;
			PlayerPrefs.SetInt("moneyActiveB5", moneyActiveB5);
		}
	}
	///
	public static int XpActiveB6
	{
		get
		{
			return xpActiveB6;
		}
		set
		{
			xpActiveB6 = value;
			PlayerPrefs.SetInt("xpActiveB6", xpActiveB6);
		}
	}
	public static int MoneyActiveB6
	{
		get
		{
			return moneyActiveB6;
		}
		set
		{
			moneyActiveB6 = value;
			PlayerPrefs.SetInt("moneyActiveB6", moneyActiveB6);
		}
	}
	///
	public static int XpActiveB7
	{
		get
		{
			return xpActiveB7;
		}
		set
		{
			xpActiveB7 = value;
			PlayerPrefs.SetInt("xpActiveB7", xpActiveB7);
		}
	}
	public static int MoneyActiveB7
	{
		get
		{
			return moneyActiveB7;
		}
		set
		{
			moneyActiveB7 = value;
			PlayerPrefs.SetInt("moneyActiveB7", moneyActiveB7);
		}
	}
	//////////////////////// B O A R D ///////////////////////////////////////////////////////////////////////////////////////////////
	///
	public static int XpActiveT1
	{
		get
		{
			return xpActiveT1;
		}
		set
		{
			xpActiveT1 = value;
			PlayerPrefs.SetInt("xpActiveT1", xpActiveT1);
		}
	}
	public static int MoneyActiveT1
	{
		get
		{
			return moneyActiveT1;
		}
		set
		{
			moneyActiveT1 = value;
			PlayerPrefs.SetInt("moneyActiveT1", moneyActiveT1);
		}
	}
	///
	public static int XpActiveT2
	{
		get
		{
			return xpActiveT2;
		}
		set
		{
			xpActiveT2 = value;
			PlayerPrefs.SetInt("xpActiveT2", xpActiveT2);
		}
	}
	public static int MoneyActiveT2
	{
		get
		{
			return moneyActiveT2;
		}
		set
		{
			moneyActiveT2 = value;
			PlayerPrefs.SetInt("moneyActiveT2", moneyActiveT2);
		}
	}
	///
	public static int XpActiveT3
	{
		get
		{
			return xpActiveT3;
		}
		set
		{
			xpActiveT3 = value;
			PlayerPrefs.SetInt("xpActiveT3", xpActiveT3);
		}
	}
	public static int MoneyActiveT3
	{
		get
		{
			return moneyActiveT3;
		}
		set
		{
			moneyActiveT3 = value;
			PlayerPrefs.SetInt("moneyActiveT3", moneyActiveT3);
		}
	}
	///
	public static int XpActiveT4
	{
		get
		{
			return xpActiveT4;
		}
		set
		{
			xpActiveT4 = value;
			PlayerPrefs.SetInt("xpActiveT4", xpActiveT4);
		}
	}
	public static int MoneyActiveT4
	{
		get
		{
			return moneyActiveT4;
		}
		set
		{
			moneyActiveT4 = value;
			PlayerPrefs.SetInt("moneyActiveT4", moneyActiveT4);
		}
	}
	///
	public static int XpActiveT5
	{
		get
		{
			return xpActiveT5;
		}
		set
		{
			xpActiveT5 = value;
			PlayerPrefs.SetInt("xpActiveT5", xpActiveT5);
		}
	}
	public static int MoneyActiveT5
	{
		get
		{
			return moneyActiveT5;
		}
		set
		{
			moneyActiveT5 = value;
			PlayerPrefs.SetInt("moneyActiveT5", moneyActiveT5);
		}
	}
	///
	public static int XpActiveT6
	{
		get
		{
			return xpActiveT6;
		}
		set
		{
			xpActiveT6 = value;
			PlayerPrefs.SetInt("xpActiveT6", xpActiveT6);
		}
	}
	public static int MoneyActiveT6
	{
		get
		{
			return moneyActiveT6;
		}
		set
		{
			moneyActiveT6 = value;
			PlayerPrefs.SetInt("moneyActiveT6", moneyActiveT6);
		}
	}
	///
	public static int XpActiveT7
	{
		get
		{
			return xpActiveT7;
		}
		set
		{
			xpActiveT7 = value;
			PlayerPrefs.SetInt("xpActiveT7", xpActiveT7);
		}
	}
	public static int MoneyActiveT7
	{
		get
		{
			return moneyActiveT7;
		}
		set
		{
			moneyActiveT7 = value;
			PlayerPrefs.SetInt("moneyActiveT7", moneyActiveT7);
		}
	}
	///
	public static int XpActiveT8
	{
		get
		{
			return xpActiveT8;
		}
		set
		{
			xpActiveT8 = value;
			PlayerPrefs.SetInt("xpActiveT8", xpActiveT8);
		}
	}
	public static int MoneyActiveT8
	{
		get
		{
			return moneyActiveT8;
		}
		set
		{
			moneyActiveT8 = value;
			PlayerPrefs.SetInt("moneyActiveT8", moneyActiveT8);
		}
	}
	//////////////////////// R E F /////////////////////////////////////////////////////////////////////////////////////////////////
	///
	public static int XpActiveR1
	{
		get
		{
			return xpActiveR1;
		}
		set
		{
			xpActiveR1 = value;
			PlayerPrefs.SetInt("xpActiveR1", xpActiveR1);
		}
	}
	public static int MoneyActiveR1
	{
		get
		{
			return moneyActiveR1;
		}
		set
		{
			moneyActiveR1 = value;
			PlayerPrefs.SetInt("moneyActiveR1", moneyActiveR1);
		}
	}
	///
	public static int XpActiveR2
	{
		get
		{
			return xpActiveR2;
		}
		set
		{
			xpActiveR2 = value;
			PlayerPrefs.SetInt("xpActiveR2", xpActiveR2);
		}
	}
	public static int MoneyActiveR2
	{
		get
		{
			return moneyActiveR2;
		}
		set
		{
			moneyActiveR2 = value;
			PlayerPrefs.SetInt("moneyActiveR2", moneyActiveR2);
		}
	}
	///
	public static int XpActiveR3
	{
		get
		{
			return xpActiveR3;
		}
		set
		{
			xpActiveR3 = value;
			PlayerPrefs.SetInt("xpActiveR3", xpActiveR3);
		}
	}
	public static int MoneyActiveR3
	{
		get
		{
			return moneyActiveR3;
		}
		set
		{
			moneyActiveR3 = value;
			PlayerPrefs.SetInt("moneyActiveR3", moneyActiveR3);
		}
	}
	///
	public static int XpActiveR4
	{
		get
		{
			return xpActiveR4;
		}
		set
		{
			xpActiveR4 = value;
			PlayerPrefs.SetInt("xpActiveR4", xpActiveR4);
		}
	}
	public static int MoneyActiveR4
	{
		get
		{
			return moneyActiveR4;
		}
		set
		{
			moneyActiveR4 = value;
			PlayerPrefs.SetInt("moneyActiveR4", moneyActiveR4);
		}
	}
	///
	public static int XpActiveR5
	{
		get
		{
			return xpActiveR5;
		}
		set
		{
			xpActiveR5 = value;
			PlayerPrefs.SetInt("xpActiveR5", xpActiveR5);
		}
	}
	public static int MoneyActiveR5
	{
		get
		{
			return moneyActiveR5;
		}
		set
		{
			moneyActiveR5 = value;
			PlayerPrefs.SetInt("moneyActiveR5", moneyActiveR5);
		}
	}
	///
	public static int XpActiveR6
	{
		get
		{
			return xpActiveR6;
		}
		set
		{
			xpActiveR6 = value;
			PlayerPrefs.SetInt("xpActiveR6", xpActiveR6);
		}
	}
	public static int MoneyActiveR6
	{
		get
		{
			return moneyActiveR6;
		}
		set
		{
			moneyActiveR6 = value;
			PlayerPrefs.SetInt("moneyActiveR6", moneyActiveR6);
		}
	}
	///
	//////////////////////// C O N /////////////////////////////////////////////////////////////////////////////////////////////////
	///
	public static int XpActiveC1
	{
		get
		{
			return xpActiveC1;
		}
		set
		{
			xpActiveC1 = value;
			PlayerPrefs.SetInt("xpActiveC1", xpActiveC1);
		}
	}
	public static int MoneyActiveC1
	{
		get
		{
			return moneyActiveC1;
		}
		set
		{
			moneyActiveC1 = value;
			PlayerPrefs.SetInt("moneyActiveC1", moneyActiveC1);
		}
	}
	///
	public static int XpActiveC2
	{
		get
		{
			return xpActiveC2;
		}
		set
		{
			xpActiveC2 = value;
			PlayerPrefs.SetInt("xpActiveC2", xpActiveC2);
		}
	}
	public static int MoneyActiveC2
	{
		get
		{
			return moneyActiveC2;
		}
		set
		{
			moneyActiveC2 = value;
			PlayerPrefs.SetInt("moneyActiveC2", moneyActiveC2);
		}
	}
	///
	public static int XpActiveC3
	{
		get
		{
			return xpActiveC3;
		}
		set
		{
			xpActiveC3 = value;
			PlayerPrefs.SetInt("xpActiveC3", xpActiveC3);
		}
	}
	public static int MoneyActiveC3
	{
		get
		{
			return moneyActiveC3;
		}
		set
		{
			moneyActiveC3 = value;
			PlayerPrefs.SetInt("moneyActiveC3", moneyActiveC3);
		}
	}
	///
	public static int XpActiveC4
	{
		get
		{
			return xpActiveC4;
		}
		set
		{
			xpActiveC4 = value;
			PlayerPrefs.SetInt("xpActiveC4", xpActiveC4);
		}
	}
	public static int MoneyActiveC4
	{
		get
		{
			return moneyActiveC4;
		}
		set
		{
			moneyActiveC4 = value;
			PlayerPrefs.SetInt("moneyActiveC4", moneyActiveC4);
		}
	}
	///
	public static int XpActiveC5
	{
		get
		{
			return xpActiveC5;
		}
		set
		{
			xpActiveC5 = value;
			PlayerPrefs.SetInt("xpActiveC5", xpActiveC5);
		}
	}
	public static int MoneyActiveC5
	{
		get
		{
			return moneyActiveC5;
		}
		set
		{
			moneyActiveC5 = value;
			PlayerPrefs.SetInt("moneyActiveC5", moneyActiveC5);
		}
	}
	///
	/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	///смена языка change language
	public static string Language
	{
		get
		{
			return language;
		}
		set
		{
			language = value;
			PlayerPrefs.SetString("language", language);
		}
	}
	///
	public static int DokiOk
	{
		get
		{
			return dokiOk;
		}
		set
		{
			dokiOk = value;
			PlayerPrefs.SetInt("dokiOk", dokiOk);
		}
	}
	/// 
	public static int Hitchhiker
	{
		get
		{
			return hitchhiker;
		}
		set
		{
			hitchhiker = value;
			PlayerPrefs.SetInt("hitchhiker", hitchhiker);
		}
	}
	/// 
	public static int Smoke
	{
		get
		{
			return smoke;
		}
		set
		{
			smoke = value;
			PlayerPrefs.SetInt("smoke", smoke);
		}
	}
	/// 
	public static int LightOn
	{
		get
		{
			return lightOn;
		}
		set
		{
			lightOn = value;
			PlayerPrefs.SetInt("lightOn", lightOn);
		}
	}
	/// 
	public static int LightOnStop
	{
		get
		{
			return lightOnStop;
		}
		set
		{
			lightOnStop = value;
			PlayerPrefs.SetInt("lightOnStop", lightOnStop);
			PlayerPrefs.SetInt("lightOnStop", lightOnStop);
			PlayerPrefs.SetInt("lightOnStop", lightOnStop);
		}
	}
	/// 
	public static int TruckSmoke
	{
		get
		{
			return truckSmoke;
		}
		set
		{
			truckSmoke = value;
			PlayerPrefs.SetInt("truckSmoke", truckSmoke);
		}
	}
	///
	///
	public static int CargoCondition
	{
		get
		{
			return cargo_condition;
		}
		set
		{
			cargo_condition = value;
			PlayerPrefs.SetInt("cargo_condition", cargo_condition);
		}
	}

	public static int SpecCargo
	{
		get
		{
			return specCargo;
		}
		set
		{
			specCargo = value;
			PlayerPrefs.SetInt("specCargo", specCargo);
		}
	}
	///
	public static int MuteAudio
	{
		get
		{
			return muteAudio;
		}
		set
		{
			muteAudio = value;
			PlayerPrefs.SetInt("muteAudio", muteAudio);
		}
	}

	/// 
	public static int Ads
	{
		get
		{
			return ads;
		}
		set
		{
			ads = value;
			PlayerPrefs.SetInt("ads", ads);
		}
	}
	///
	public static int Gear
	{
		get
		{
			return gear;
		}
		set
		{
			gear = value;
			PlayerPrefs.SetInt("gear", gear);
		}
	}
	///
	public static int BuyFuel
	{
		get
		{
			return buyFuel;
		}
		set
		{
			buyFuel = value;
			PlayerPrefs.SetInt("buyFuel", buyFuel);
		}
	}
	///
	public static int Mins
	{
		get
		{
			return mins;
		}
		set
		{
			mins = value;
			PlayerPrefs.SetInt("mins", mins);
		}
	}
	///
	public static int Hours
	{
		get
		{
			return hours;
		}
		set
		{
			hours = value;
			PlayerPrefs.SetInt("hours", hours);
		}
	}
	///
	public static int Days
	{
		get
		{
			return days;
		}
		set
		{
			days = value;
			PlayerPrefs.SetInt("days", days);
		}
	}
	///
	public static int ActiveRndEvent
	{
		get
		{
			return activeRndEvent;
		}
		set
		{
			activeRndEvent = value;
			PlayerPrefs.SetInt("activeRndEvent", activeRndEvent);
		}
	}
	///
	public static int Money {
		get {
			return money;
		}
		set {
			money = value;
			PlayerPrefs.SetInt ("money", money);
		}
	}
	///
	public static int Dollars
	{
		get
		{
			return dollars;
		}
		set
		{
			dollars = value;
			PlayerPrefs.SetInt("dollars", dollars);
		}
	}
	///
	public static float Kilometers
    {
        get
        {
            return kilometers;
        }
        set
        {
            kilometers = (float)value;
            PlayerPrefs.SetFloat("kilometers", kilometers);
        }
    }
	/// 
	public static float BankXpBison
	{
		get
		{
			return bankXpBison;
		}
		set
		{
			bankXpBison = value;
			PlayerPrefs.SetFloat("bankXpBison", bankXpBison);
		}
	}
	/// /// 
	public static float BankXpDUB
	{
		get
		{
			return bankXpDUB;
		}
		set
		{
			bankXpDUB = value;
			PlayerPrefs.SetFloat("bankXpDUB", bankXpDUB);
		}
	}
	public static float BankXpFIIV
	{
		get
		{
			return bankXpFIIV;
		}
		set
		{
			bankXpFIIV = value;
			PlayerPrefs.SetFloat("bankXpFIIV", bankXpFIIV);
		}
	}
	public static float BankXpHORSE
	{
		get
		{
			return bankXpHORSE;
		}
		set
		{
			bankXpHORSE = value;
			PlayerPrefs.SetFloat("bankXpHORSE", bankXpHORSE);
		}
	}
	public static float BankXpRIDGE
	{
		get
		{
			return bankXpRIDGE;
		}
		set
		{
			bankXpRIDGE = value;
			PlayerPrefs.SetFloat("bankXpRIDGE", bankXpRIDGE);
		}
	}
	public static float BankXpFree
	{
		get
		{
			return bankXpFree;
		}
		set
		{
			bankXpFree = value;
			PlayerPrefs.SetFloat("bankXpFree", bankXpFree);
		}
	}
	/// 
	public static float BankXpBoard
	{
		get
		{
			return bankXpBoard;
		}
		set
		{
			bankXpBoard = value;
			PlayerPrefs.SetFloat("bankXpBoard", bankXpBoard);
		}
	}
	/// 
	public static float BankXpTent
	{
		get
		{
			return bankXpTent;
		}
		set
		{
			bankXpTent = value;
			PlayerPrefs.SetFloat("bankXpTent", bankXpTent);
		}
	}
	///	
	public static float BankXpRef
	{
		get
		{
			return bankXpRef;
		}
		set
		{
			bankXpRef = value;
			PlayerPrefs.SetFloat("bankXpRef", bankXpRef);
		}
	}
	///	
	public static float BankXpCon
	{
		get
		{
			return bankXpCon;
		}
		set
		{
			bankXpCon = value;
			PlayerPrefs.SetFloat("bankXpCon", bankXpCon);
		}
	}
	public static float CargoWeight
	{
		get
		{
			return cargoWeight;
		}
		set
		{
			cargoWeight = value;
			PlayerPrefs.SetFloat("cargoWeight", cargoWeight);
		}
	}

	public static float Timer
	{
		get
		{
			return timer;
		}
		set
		{
			timer = value;
			PlayerPrefs.SetFloat("timer", timer);
		}
	}
	public static float RealSpeed
	{
		get
		{
			return realSpeed;
		}
		set
		{
			realSpeed = value;
			PlayerPrefs.SetFloat("realSpeed", realSpeed);
		}
	}
	public static int CarNumber
	{
		get
		{
			return carNumber;
		}
		set
		{
			carNumber = value;
			PlayerPrefs.SetInt("carNumber", carNumber);
		}
	}
	///
	public static int MasterVolume
	{
		get 
		{
			return masterVolume;
		}
		set {
			masterVolume = value;
			PlayerPrefs.SetInt ("masterVolume", masterVolume);
		}
	}
	///
	public static int PrcNumber
	{
		get
		{
			return prcNumber;
		}
		set
		{
			prcNumber = value;
			PlayerPrefs.SetInt("prcNumber", prcNumber);
		}
	}
	///	
	public static int FinishLoca
	{
		get
		{
			return finishLoca;
		}
		set
		{
			finishLoca = value;
			PlayerPrefs.SetInt("finishLoca", finishLoca);
		}
	}
	///	
	public static string MapLocation
	{
		get
		{
			return mapLocation;
		}
		set
		{
			mapLocation = value;
			PlayerPrefs.SetString("mapLocation", mapLocation);
		}
	}
	///	
	public static string SaveMapLocation
	{
		get
		{
			return saveMapLocation;
		}
		set
		{
			saveMapLocation = value;
			PlayerPrefs.SetString("saveMapLocation", saveMapLocation);
		}
	}
	///	
	public static string Road
	{
		get
		{
			return road;
		}
		set
		{
			road = value;
			PlayerPrefs.SetString("road", road);
		}
	}
	///////////////////   Н А Г Р А Д А   //////////////////////////////////////////////////////////////////////////////////////////////
	public static float PrizeRuly
	{
		get
		{
			return prizeRuly;
		}
		set
		{
			prizeRuly = value;
			PlayerPrefs.SetFloat("prizeRuly", prizeRuly);
		}
	}

	public static int PrizeDollars
	{
		get
		{
			return prizeDollars;
		}
		set
		{
			prizeDollars = value;
			PlayerPrefs.SetInt("prizeDollars", prizeDollars);
		}
	}

	public static float PrizeXpFree
	{
		get
		{
			return prizeXpFree;
		}
		set
		{
			prizeXpFree = value;
			PlayerPrefs.SetFloat("prizeXpFree", prizeXpFree);
		}
	}

	public static float PrizeXpCar
	{
		get
		{
			return prizeXpCar;
		}
		set
		{
			prizeXpCar = value;
			PlayerPrefs.SetFloat("prizeXpCar", prizeXpCar);
		}
	}

	public static float PrizeXpTrailer
	{
		get
		{
			return prizeXpTrailer;
		}
		set
		{
			prizeXpTrailer = value;
			PlayerPrefs.SetFloat("prizeXpTrailer", prizeXpTrailer);
		}
	}
	public static float CoefPrizeXpFree
	{
		get
		{
			return coefPrizeXpFree;
		}
		set
		{
			coefPrizeXpFree = value;
			PlayerPrefs.SetFloat("coefPrizeXpFree", coefPrizeXpFree);
		}
	}
	public static int PrizeHitchhikerR
	{
		get
		{
			return hitchhikerR;
		}
		set
		{
			hitchhikerR = value;
			PlayerPrefs.SetInt("hitchhikerR", hitchhikerR);
		}
	}
	public static int activeHitchhikerAndPatrol
	{
		get
		{
			return ActiveHitchhikerAndPatrol;
		}
		set
		{
			ActiveHitchhikerAndPatrol = value;
			PlayerPrefs.SetInt("ActiveHitchhikerAndPatrol", ActiveHitchhikerAndPatrol);
		}
	}
	public static int PrizeHitchhikerX
	{
		get
		{
			return hitchhikerX;
		}
		set
		{
			hitchhikerX = value;
			PlayerPrefs.SetInt("hitchhikerX", hitchhikerX);
		}
	}
	public static int PrizeHitchhikerD
	{
		get
		{
			return hitchhikerD;
		}
		set
		{
			hitchhikerD = value;
			PlayerPrefs.SetInt("hitchhikerD", hitchhikerD);
		}
	}
	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////	
	public static float camX
	{
		get
		{
			return CamX;
		}
		set
		{
			CamX = value;
			PlayerPrefs.SetFloat("CamX", CamX);
		}
	}
	public static float camY
	{
		get
		{
			return CamY;
		}
		set
		{
			CamY = value;
			PlayerPrefs.SetFloat("CamY", CamY);
		}
	}
	public static float camZ
	{
		get
		{
			return CamZ;
		}
		set
		{
			CamZ = value;
			PlayerPrefs.SetFloat("CamZ", CamZ);
		}
	}
	public static float camXGarage
	{
		get
		{
			return CamXGarage;
		}
		set
		{
			CamXGarage = value;
			PlayerPrefs.SetFloat("CamXGarage", CamXGarage);
		}
	}
	public static float camYGarage
	{
		get
		{
			return CamYGarage;
		}
		set
		{
			CamYGarage = value;
			PlayerPrefs.SetFloat("CamYGarage", CamYGarage);
		}
	}
	public static float camZGarage
	{
		get
		{
			return CamZGarage;
		}
		set
		{
			CamZGarage = value;
			PlayerPrefs.SetFloat("CamZGarage", CamZGarage);
		}
	}
	public static float camXTruck
	{
		get
		{
			return CamXTruck;
		}
		set
		{
			CamXTruck = value;
			PlayerPrefs.SetFloat("CamXTruck", CamXTruck);
		}
	}
	public static float camYTruck
	{
		get
		{
			return CamYTruck;
		}
		set
		{
			CamYTruck = value;
			PlayerPrefs.SetFloat("CamYTruck", CamYTruck);
		}
	}
	public static float camZTruck
	{
		get
		{
			return CamZTruck;
		}
		set
		{
			CamZTruck = value;
			PlayerPrefs.SetFloat("CamZTruck", CamZTruck);
		}
	}
	public static float camXTrailer
	{
		get
		{
			return CamXTrailer;
		}
		set
		{
			CamXTrailer = value;
			PlayerPrefs.SetFloat("CamXTrailer", CamXTrailer);
		}
	}
	public static float camYTrailer
	{
		get
		{
			return CamYTrailer;
		}
		set
		{
			CamYTrailer = value;
			PlayerPrefs.SetFloat("CamYTrailer", CamYTrailer);
		}
	}
	public static float camZTrailer
	{
		get
		{
			return CamZTrailer;
		}
		set
		{
			CamZTrailer = value;
			PlayerPrefs.SetFloat("CamZTrailer", CamZTrailer);
		}
	}
	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	public static float contPosX
	{
		get
		{
			return ContPosX;
		}
		set
		{
			ContPosX = value;
			PlayerPrefs.SetFloat("ContPosX", ContPosX);
		}
	}
	public static float contPosY
	{
		get
		{
			return ContPosY;
		}
		set
		{
			ContPosY = value;
			PlayerPrefs.SetFloat("ContPosY", ContPosY);
		}
	}	
}
