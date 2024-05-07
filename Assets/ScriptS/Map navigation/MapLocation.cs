using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLocation : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject StartZoneCity;
    public GameObject StartZoneVillage;
    public GameObject StartZoneRailway;
    public GameObject StartZoneAirport;
    public GameObject StartZonePort;

    public GameObject map;
    public GameObject mapGlobal;
    public GameObject mapLocations;
    public GameObject MapCity;
    public GameObject MapVillage;
    public GameObject MapRailway;
    public GameObject MapAirport;
    public GameObject MapPort;
    public GameObject MapBtnSklad;
    public GameObject MapBtnGarage;
    public GameObject MapBtnAZS;
    public GameObject MapBtnTransition;
    public GameObject PnlDw;
    public GameObject PnlUpravlenia;

    public GameObject BtnTrailler;
    public GameObject BtnCargo;
    public GameObject BtnSpecCargo;
    public GameObject PnlDwSalon;
    public GameObject PnlDwGarage;
    public GameObject PnlDwAZS;
    public GameObject PnlDwCargo;
    public GameObject SelectCargo;

    public GameObject Salon;
    public GameObject Garage;
    public GameObject AZS;
    public GameObject Sklad;
    public GameObject midleZaborCity;
    public GameObject midleZaborVillage;
    public GameObject midleZaborRailway;
    public GameObject midleZaborAirport;
    public GameObject midleZaborPort;

    public int CargoCondition;
    public string mapLocation;


    public void OpenMapLocations()
    {
        mainCamera.GetComponent<Movecar>().GarageCam();
        Main.MapLocation = Main.SaveMapLocation;
        mapLocation = Main.MapLocation;        
        mapGlobal.SetActive(false);
        mapLocations.SetActive(true);
        CloseAllMap();
        DataUpdate();
        switch (mapLocation)
        {
            case "C1":
            case "C2":
            case "C3":
            case "C4":
            case "C5":
            case "C6":
            case "C7":
                MapCity.SetActive(true);
                StartZoneCity.SetActive(true);
                break;
            case "V1":
            case "V2":
            case "V3":
            case "V4":
                MapVillage.SetActive(true);
                StartZoneVillage.SetActive(true);
                break;
            case "R1":
            case "R2":
                MapRailway.SetActive(true);
                StartZoneRailway.SetActive(true);
                break;
            case "A1":
            case "A2":
                MapAirport.SetActive(true);
                StartZoneAirport.SetActive(true);
                break;
            case "P1":
            case "P2":
                MapPort.SetActive(true);
                StartZonePort.SetActive(true);
                break;
        }
    }

    public void CloseAllMap()
    {
        StartZoneCity.SetActive(false);
        StartZoneVillage.SetActive(false);
        StartZoneRailway.SetActive(false);
        StartZoneAirport.SetActive(false);
        StartZonePort.SetActive(false);
        MapCity.SetActive(false);
        MapVillage.SetActive(false);
        MapRailway.SetActive(false);
        MapAirport.SetActive(false);
        MapPort.SetActive(false);
    }

    public void CloseMapLocations()
    {
        mapLocations.SetActive(false);
        OpenZabor();
    }

    public void OpenZabor()
    {
        switch (mapLocation)
        {
            case "C1":
            case "C2":
            case "C3":
            case "C4":
            case "C5":
            case "C6":
            case "C7":
                midleZaborCity.SetActive(true);
                break;
            case "V1":
            case "V2":
            case "V3":
            case "V4":
                midleZaborVillage.SetActive(true);
                break;
            case "R1":
            case "R2":
                midleZaborRailway.SetActive(true);
                break;
            case "A1":
            case "A2":
                midleZaborAirport.SetActive(true);
                break;
            case "P1":
            case "P2":
                midleZaborPort.SetActive(true);
                break;
        }
    }

    public void OpenSalon()
    {
        DataUpdate();
        CloseZabor();
        PnlDw.SetActive(true);
        PnlDwSalon.SetActive(true);
        Salon.SetActive(true);
        PnlUpravlenia.SetActive(false);
        mapLocations.SetActive(false);
        Time.timeScale = 1;
    }
    public void OpenGarage()
    {
        DataUpdate();
        CloseZabor();
        PnlDw.SetActive(true);
        PnlDwGarage.SetActive(true);
        Garage.SetActive(true);
        PnlUpravlenia.SetActive(false);
        mapLocations.SetActive(false);
        Time.timeScale = 1;
    }
    public void OpenAZS()
    {
        DataUpdate();
        OpenZabor();
        PnlDw.SetActive(true);
        PnlDwAZS.SetActive(true);
        AZS.SetActive(true);
        PnlUpravlenia.SetActive(false);
        mapLocations.SetActive(false);
        Time.timeScale = 1;
    }
    public void OpenSklad()
    {
        DataUpdate();
        CloseZabor();
        PnlDw.SetActive(true);
        PnlDwCargo.SetActive(true);
        Sklad.SetActive(true);
        PnlUpravlenia.SetActive(false);
        mapLocations.SetActive(false);
        mainCamera.GetComponent<RewAds>().LoadADS();
        mainCamera.GetComponent<InterAd>().RequestInterstitial();
        Time.timeScale = 1;
    }
    public void Transition()
    {
        mainCamera.GetComponent<Movecar>().UserCam();
        mapLocations.SetActive(false);
        PnlDw.SetActive(false);
        PnlUpravlenia.SetActive(true);
        OpenZabor();
        Main.MuteAudio = 1;
        Time.timeScale = 1;
    }

    public void CloseAllPlaces()
    {
        OpenMapLocations();
        PnlDw.SetActive(false);
        PnlUpravlenia.SetActive(false);
        PnlDwSalon.SetActive(false);
        Salon.SetActive(false);
        PnlDwGarage.SetActive(false);
        Garage.SetActive(false);
        PnlDwAZS.SetActive(false);
        AZS.SetActive(false);
        PnlDwCargo.SetActive(false);
        Sklad.SetActive(false);
        OpenZabor();
    }

    public void CloseZabor()
    {
        midleZaborCity.SetActive(false);
        midleZaborVillage.SetActive(false);
        midleZaborRailway.SetActive(false);
        midleZaborAirport.SetActive(false);
        midleZaborPort.SetActive(false);
    }

    public void OpenCargo()
    {
        SelectCargo.SetActive(true);
    }

    public void FalseCargo()
    {
        BtnCargo.SetActive(false);
        BtnSpecCargo.SetActive(false);
    }
    public void TrueCargo()
    {
        BtnCargo.SetActive(true);
        BtnSpecCargo.SetActive(true);
    }

    public void DataUpdate()
    {
        if (Main.CarNumber == 0)
        {
            MapBtnGarage.SetActive(false);
            MapBtnAZS.SetActive(false);
            MapBtnTransition.SetActive(false);
        }
        else
        {
            MapBtnGarage.SetActive(true);
            MapBtnAZS.SetActive(true);
            MapBtnTransition.SetActive(true);
        }

        if (Main.PrcNumber == 0 || CargoCondition > 0 || Main.SpecCargo == 1)
        {
            MapBtnSklad.SetActive(false);
            BtnCargo.SetActive(false);
            BtnSpecCargo.SetActive(false);
        }
        else
        {
            MapBtnSklad.SetActive(true);
            BtnCargo.SetActive(true);
            if (Main.Timer <= 0) BtnSpecCargo.SetActive(true);
            else BtnSpecCargo.SetActive(false);
        }

        if (CargoCondition <= 0 && Main.SpecCargo == 0) BtnTrailler.SetActive(true);
        else BtnTrailler.SetActive(false);
    }

    void Awake()
    {
        mapLocation = Main.MapLocation;
        CargoCondition = Main.CargoCondition;
    }

    void Start()
    {
        if (Main.MapLocation == "cr1" || Main.MapLocation == "cr2" || Main.MapLocation == "cr3")
        {
            map.GetComponent<Map>().LocationDefinition();
            map.GetComponent<Map>().PathChoice();
            mapGlobal.SetActive(true);
            Time.timeScale = 0;
        }
        else OpenMapLocations();
    }

    void Update()
    {
        mapLocation = Main.MapLocation;
        CargoCondition = Main.CargoCondition;
    }
}
