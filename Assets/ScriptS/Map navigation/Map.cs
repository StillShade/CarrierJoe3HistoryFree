using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public int finishLoca;
    public string Road;
    public string mapLocation;
    public string saveMapLocation;
    public GameObject map;
    public GameObject exitMap;
    [Header("Start City")]
    public GameObject C1, C2, C3, C4, C5, C6, C7;
    [Header("Start Village")]
    public GameObject V1, V2, V3, V4;
    [Header("Start Airport")]
    public GameObject A1, A2;
    [Header("Start Railway")]
    public GameObject R1, R2;
    [Header("Start Port")]
    public GameObject P1, P2;
    [Header("Finish City")]
    public GameObject Cf1, Cf2, Cf3, Cf4, Cf5, Cf6, Cf7;
    [Header("Finish Village")]
    public GameObject Vf1, Vf2, Vf3, Vf4;
    [Header("Finish Airport")]
    public GameObject Af1, Af2;
    [Header("Finish Railway")]
    public GameObject Rf1, Rf2;
    [Header("Finish Port")]
    public GameObject Pf1, Pf2;
    [Header("cr")]
    public GameObject cr1, cr2, cr3;
    [Header("road")]
    public GameObject M1_1, M1_2, M1_3, M1_4, M2_1, M2_2, M2_3, M3_1, M3_2, M3_3, M3_4, M4_1, M4_2, M5_1, M5_2, a1, a2, a3, e1, e2, e3, e4, e5, e6, e7;
    [Header("Route ->")]
    public GameObject route1, route2, route3, route4, route5, route6, route7, route8, route9, route10, route11, route12, route13, route14, route15, route16, route17, route18, route19, route20, route21, route22, route23, route24, route25;
    [Header("Route <-")]
    public GameObject route1_2, route2_2, route3_2, route4_2, route5_2, route6_2, route7_2, route8_2, route9_2, route10_2, route11_2, route12_2, route13_2, route14_2, route15_2, route16_2, route17_2, route18_2, route19_2, route20_2, route21_2, route22_2, route23_2, route24_2, route25_2;
    

    [Header("Road ->")]
    public GameObject RoadM1_1, RoadM1_2, RoadM1_3, RoadM1_4, RoadM2_1, RoadM2_2, RoadM2_3, RoadM3_1, RoadM3_2, RoadM3_3, RoadM3_4, RoadM4_1, RoadM4_2, RoadM5_1, RoadM5_2, RoadA1, RoadA2, RoadA3, RoadE1, RoadE2, RoadE3, RoadE4, RoadE5, RoadE6, RoadE7;
    [Header("Road <-")]
    public GameObject RoadM1_1_2, RoadM1_2_2, RoadM1_3_2, RoadM1_4_2, RoadM2_1_2, RoadM2_2_2, RoadM2_3_2, RoadM3_1_2, RoadM3_2_2, RoadM3_3_2, RoadM3_4_2, RoadM4_1_2, RoadM4_2_2, RoadM5_1_2, RoadM5_2_2, RoadA1_2, RoadA2_2, RoadA3_2, RoadE1_2, RoadE2_2, RoadE3_2, RoadE4_2, RoadE5_2, RoadE6_2, RoadE7_2;
    

    public void CloseAllFinishLoca()
    {
        Cf1.SetActive(false);
        Cf2.SetActive(false);
        Cf3.SetActive(false);
        Cf4.SetActive(false);
        Cf5.SetActive(false);
        Vf1.SetActive(false);
        Vf4.SetActive(false);
        Rf1.SetActive(false);
        Af1.SetActive(false);
        Pf1.SetActive(false);
    }

    public void OpenFinishLoca()
    {
        CloseAllFinishLoca();

        switch (finishLoca)
        {
            case 0:
                CloseAllFinishLoca();
                break;
            case 1:
                Cf1.SetActive(true);
                break;
            case 2:
                Cf2.SetActive(true);
                break;
            case 3:
                Cf3.SetActive(true);
                break;
            case 4:
                Cf4.SetActive(true);
                break;
            case 5:
                Cf5.SetActive(true);
                break;
            case 6:
                Vf1.SetActive(true);
                break;
            case 7:
                Vf4.SetActive(true);
                break;
            case 8:
                Rf1.SetActive(true);
                break;
            case 9:
                Af1.SetActive(true);
                break;
            case 10:
                Pf1.SetActive(true);
                break;
            case 11:
                Cf1.SetActive(true);
                break;
        }
    }

    public void OpenMap()
    {
        map.SetActive(true);
        LocationDefinition();
        exitMap.SetActive(true);
        CloseAllMapRoads();
        OpenFinishLoca();
        Time.timeScale = 0;
    }
    public void CloseMap()
    {
        map.SetActive(false);
        CloseAllPoints();
        CloseAllMapRoads();
        Time.timeScale = 1;
    }

    public void LocationDefinition()
    {
        CloseAllPoints();
        OpenFinishLoca();
        exitMap.SetActive(false);
        switch (mapLocation)
        {
            case "C1":
                C1.SetActive(true);
                break;
            case "C2":
                C2.SetActive(true);
                break;
            case "C3":
                C3.SetActive(true);
                break;
            case "C4":
                C4.SetActive(true);
                break;
            case "C5":
                C5.SetActive(true);
                break;
            case "C6":
                C6.SetActive(true);
                break;
            case "C7":
                C7.SetActive(true);
                break;
            case "V1":
                V1.SetActive(true);
                break;
            case "V2":
                V2.SetActive(true);
                break;
            case "V3":
                V3.SetActive(true);
                break;
            case "V4":
                V4.SetActive(true);
                break;
            case "A1":
                A1.SetActive(true);
                break;
            case "A2":
                A2.SetActive(true);
                break;
            case "R1":
                R1.SetActive(true);
                break;
            case "R2":
                R2.SetActive(true);
                break;
            case "P1":
                P1.SetActive(true);
                break;
            case "P2":
                P2.SetActive(true);
                break;
            case "cr1":
                cr1.SetActive(true);
                break;
            case "cr2":
                cr2.SetActive(true);
                break;
            case "cr3":
                cr3.SetActive(true);
                break;
            case "M1_1":
                M1_1.SetActive(true);
                break;
            case "M1_2":
                M1_2.SetActive(true);
                break;
            case "M1_3":
                M1_3.SetActive(true);
                break;
            case "M1_4":
                M1_4.SetActive(true);
                break;
            case "M2_1":
                M2_1.SetActive(true);
                break;
            case "M2_2":
                M2_2.SetActive(true);
                break;
            case "M2_3":
                M2_3.SetActive(true);
                break;
            case "M3_1":
                M3_1.SetActive(true);
                break;
            case "M3_2":
                M3_2.SetActive(true);
                break;
            case "M3_3":
                M3_3.SetActive(true);
                break;
            case "M3_4":
                M3_4.SetActive(true);
                break;
            case "M4_1":
                M4_1.SetActive(true);
                break;
            case "M4_2":
                M4_2.SetActive(true);
                break;
            case "M5_1":
                M5_1.SetActive(true);
                break;
            case "M5_2":
                M5_2.SetActive(true);
                break;
            case "a1":
                a1.SetActive(true);
                break;
            case "a2":
                a2.SetActive(true);
                break;
            case "a3":
                a3.SetActive(true);
                break;
            case "e1":
                e1.SetActive(true);
                break;
            case "e2":
                e2.SetActive(true);
                break;
            case "e3":
                e3.SetActive(true);
                break;
            case "e4":
                e4.SetActive(true);
                break;
            case "e5":
                e5.SetActive(true);
                break;
            case "e6":
                e6.SetActive(true);
                break;
            case "e7":
                e7.SetActive(true);
                break;
            case "M1_1_2":
                M1_1.SetActive(true);
                break;
            case "M1_2_2":
                M1_2.SetActive(true);
                break;
            case "M1_3_2":
                M1_3.SetActive(true);
                break;
            case "M1_4_2":
                M1_4.SetActive(true);
                break;
            case "M2_1_2":
                M2_1.SetActive(true);
                break;
            case "M2_2_2":
                M2_2.SetActive(true);
                break;
            case "M2_3_2":
                M2_3.SetActive(true);
                break;
            case "M3_1_2":
                M3_1.SetActive(true);
                break;
            case "M3_2_2":
                M3_2.SetActive(true);
                break;
            case "M3_3_2":
                M3_3.SetActive(true);
                break;
            case "M3_4_2":
                M3_4.SetActive(true);
                break;
            case "M4_1_2":
                M4_1.SetActive(true);
                break;
            case "M4_2_2":
                M4_2.SetActive(true);
                break;
            case "M5_1_2":
                M5_1.SetActive(true);
                break;
            case "M5_2_2":
                M5_2.SetActive(true);
                break;
            case "a1_2":
                a1.SetActive(true);
                break;
            case "a2_2":
                a2.SetActive(true);
                break;
            case "a3_2":
                a3.SetActive(true);
                break;
            case "e1_2":
                e1.SetActive(true);
                break;
            case "e2_2":
                e2.SetActive(true);
                break;
            case "e3_2":
                e3.SetActive(true);
                break;
            case "e4_2":
                e4.SetActive(true);
                break;
            case "e5_2":
                e5.SetActive(true);
                break;
            case "e6_2":
                e6.SetActive(true);
                break;
            case "e7_2":
                e7.SetActive(true);
                break;
        }
    }

    public void PathChoice()
    {
        CloseAllMapRoads();
        switch (mapLocation)
        {
            case "C1":
                route2.SetActive(true);
                route7.SetActive(true);
                route1_2.SetActive(true);
                route6_2.SetActive(true);
                break;
            case "C2":
                //route3.SetActive(true);
                route9.SetActive(true);
                route2_2.SetActive(true);
                //route8_2.SetActive(true);
                break;
            case "C3":
                route10.SetActive(true);
                route9_2.SetActive(true);
                break;
            case "C4":
                route24.SetActive(true);
                route17_2.SetActive(true);
                break;
            case "C5":
                route18_2.SetActive(true);
                route23_2.SetActive(true);
                break;
            case "C6":
                route13_2.SetActive(true);
                route15_2.SetActive(true);
                break;
            case "C7":
                route5.SetActive(true);
                route20.SetActive(true);
                route19_2.SetActive(true);
                break;
            case "V1":
                route6.SetActive(true);
                break;
            case "V2":
                route19.SetActive(true);
                break;
            case "V3":
                route22.SetActive(true);
                route21_2.SetActive(true);
                break;
            case "V4":
                route25.SetActive(true);
                route24_2.SetActive(true);
                break;
            case "A1":
                route23.SetActive(true);
                route7_2.SetActive(true);
                break;
            case "A2":
                route15.SetActive(true);
                route4_2.SetActive(true);
                route14_2.SetActive(true);
                break;
            case "R1":
                route18.SetActive(true);
                route11_2.SetActive(true);
                route25_2.SetActive(true);
                break;
            case "R2":
                route12.SetActive(true);
                route14.SetActive(true);
                route22_2.SetActive(true);
                break;
            case "P1":
                route1.SetActive(true);
                break;
            case "P2":
                route8.SetActive(true);
                route21.SetActive(true);
                route20_2.SetActive(true);
                break;
            case "cr1":
                route4.SetActive(true);
                route13.SetActive(true);
                route3_2.SetActive(true);
                route12_2.SetActive(true);
                break;
            case "cr2":
                route6.SetActive(true);
                route16.SetActive(true);
                route5_2.SetActive(true);
                break;
            case "cr3":
                route11.SetActive(true);
                route17.SetActive(true);
                route10_2.SetActive(true);
                break;
        }
    }
    public void RoadActive()
    {
        CloseAllPoints();
        CloseAllRoads();
        Road = Main.Road;
        switch (Road)
        {
            case "M1_1":
                RoadM1_1.SetActive(true);
                Main.MapLocation = "M1_1";
                break;
            case "M1_2":
                RoadM1_2.SetActive(true);
                Main.MapLocation = "M1_2";
                break;
            case "M1_3":
                RoadM1_3.SetActive(true);
                Main.MapLocation = "M1_3";
                break;
            case "M1_4":
                RoadM1_4.SetActive(true);
                Main.MapLocation = "M1_4";
                break;
            case "M2_1":
                RoadM2_1.SetActive(true);
                Main.MapLocation = "M2_1";
                break;
            case "M2_2":
                RoadM2_2.SetActive(true);
                Main.MapLocation = "M2_2";
                break;
            case "M2_3":
                RoadM2_3.SetActive(true);
                Main.MapLocation = "M2_3";
                break;
            case "M3_1":
                RoadM3_1.SetActive(true);
                Main.MapLocation = "M3_1";
                break;
            case "M3_2":
                RoadM3_2.SetActive(true);
                Main.MapLocation = "M3_2";
                break;
            case "M3_3":
                RoadM3_3.SetActive(true);
                Main.MapLocation = "M3_3";
                break;
            case "M3_4":
                RoadM3_4.SetActive(true);
                Main.MapLocation = "M3_4";
                break;
            case "M4_1":
                RoadM4_1.SetActive(true);
                Main.MapLocation = "M4_1";
                break;
            case "M4_2":
                RoadM4_2.SetActive(true);
                Main.MapLocation = "M4_2";
                break;
            case "M5_1":
                RoadM5_1.SetActive(true);
                Main.MapLocation = "M5_1";
                break;
            case "M5_2":
                RoadM5_2.SetActive(true);
                Main.MapLocation = "M5_2";
                break;
            case "a1":
                RoadA1.SetActive(true);
                Main.MapLocation = "a1";
                break;
            case "a2":
                RoadA2.SetActive(true);
                Main.MapLocation = "a2";
                break;
            case "a3":
                RoadA3.SetActive(true);
                Main.MapLocation = "a3";
                break;
            case "e1":
                RoadE1.SetActive(true);
                Main.MapLocation = "e1";
                break;
            case "e2":
                RoadE2.SetActive(true);
                Main.MapLocation = "e2";
                break;
            case "e3":
                RoadE3.SetActive(true);
                Main.MapLocation = "e3";
                break;
            case "e4":
                RoadE4.SetActive(true);
                Main.MapLocation = "e4";
                break;
            case "e5":
                RoadE5.SetActive(true);
                Main.MapLocation = "e5";
                break;
            case "e6":
                RoadE6.SetActive(true);
                Main.MapLocation = "e6";
                break;
            case "e7":
                RoadE7.SetActive(true);
                Main.MapLocation = "e7";
                break;
            case "M1_1_2":
                RoadM1_1_2.SetActive(true);
                Main.MapLocation = "M1_1_2";
                break;
            case "M1_2_2":
                RoadM1_2_2.SetActive(true);
                Main.MapLocation = "M1_2_2";
                break;
            case "M1_3_2":
                RoadM1_3_2.SetActive(true);
                Main.MapLocation = "M1_3_2";
                break;
            case "M1_4_2":
                RoadM1_4_2.SetActive(true);
                Main.MapLocation = "M1_4_2";
                break;
            case "M2_1_2":
                RoadM2_1_2.SetActive(true);
                Main.MapLocation = "M2_1_2";
                break;
            case "M2_2_2":
                RoadM2_2_2.SetActive(true);
                Main.MapLocation = "M2_2_2";
                break;
            case "M2_3_2":
                RoadM2_3_2.SetActive(true);
                Main.MapLocation = "M2_3_2";
                break;
            case "M3_1_2":
                RoadM3_1_2.SetActive(true);
                Main.MapLocation = "M3_1_2";
                break;
            case "M3_2_2":
                RoadM3_2_2.SetActive(true);
                Main.MapLocation = "M3_2_2";
                break;
            case "M3_3_2":
                RoadM3_3_2.SetActive(true);
                Main.MapLocation = "M3_3_2";
                break;
            case "M3_4_2":
                RoadM3_4_2.SetActive(true);
                Main.MapLocation = "M3_4_2";
                break;
            case "M4_1_2":
                RoadM4_1_2.SetActive(true);
                Main.MapLocation = "M4_1_2";
                break;
            case "M4_2_2":
                RoadM4_2_2.SetActive(true);
                Main.MapLocation = "M4_2_2";
                break;
            case "M5_1_2":
                RoadM5_1_2.SetActive(true);
                Main.MapLocation = "M5_1_2";
                break;
            case "M5_2_2":
                RoadM5_2_2.SetActive(true);
                Main.MapLocation = "M5_2_2";
                break;
            case "a1_2":
                RoadA1_2.SetActive(true);
                Main.MapLocation = "a1_2";
                break;
            case "a2_2":
                RoadA2_2.SetActive(true);
                Main.MapLocation = "a2_2";
                break;
            case "a3_2":
                RoadA3_2.SetActive(true);
                Main.MapLocation = "a3_2";
                break;
            case "e1_2":
                RoadE1_2.SetActive(true);
                Main.MapLocation = "e1_2";
                break;
            case "e2_2":
                RoadE2_2.SetActive(true);
                Main.MapLocation = "e2_2";
                break;
            case "e3_2":
                RoadE3_2.SetActive(true);
                Main.MapLocation = "e3_2";
                break;
            case "e4_2":
                RoadE4_2.SetActive(true);
                Main.MapLocation = "e4_2";
                break;
            case "e5_2":
                RoadE5_2.SetActive(true);
                Main.MapLocation = "e5_2";
                break;
            case "e6_2":
                RoadE6_2.SetActive(true);
                Main.MapLocation = "e6_2";
                break;
            case "e7_2":
                RoadE7_2.SetActive(true);
                Main.MapLocation = "e7_2";
                break;
        }        
    }

    public void CloseAllPoints()
    {
        C1.SetActive(false); C2.SetActive(false); C3.SetActive(false); C4.SetActive(false); C5.SetActive(false); C6.SetActive(false); C7.SetActive(false);
        V1.SetActive(false); V2.SetActive(false); V3.SetActive(false); V4.SetActive(false);
        A1.SetActive(false); A2.SetActive(false);
        R1.SetActive(false); R2.SetActive(false);
        P1.SetActive(false); P2.SetActive(false);
        cr1.SetActive(false); cr2.SetActive(false); cr3.SetActive(false);
        M1_1.SetActive(false); M1_2.SetActive(false); M1_3.SetActive(false); M1_4.SetActive(false); M2_1.SetActive(false); M2_2.SetActive(false); M2_3.SetActive(false); M3_1.SetActive(false); M3_2.SetActive(false); M3_3.SetActive(false); M3_4.SetActive(false); M4_1.SetActive(false); M4_2.SetActive(false); M5_1.SetActive(false); M5_2.SetActive(false); a1.SetActive(false); a2.SetActive(false); a3.SetActive(false); e1.SetActive(false); e2.SetActive(false); e3.SetActive(false); e4.SetActive(false); e5.SetActive(false); e6.SetActive(false); e7.SetActive(false);        
    }
    public void CloseAllMapRoads()
    {     
        route1.SetActive(false); route2.SetActive(false); route3.SetActive(false); route4.SetActive(false); route5.SetActive(false); route6.SetActive(false); route7.SetActive(false); route8.SetActive(false); route9.SetActive(false); route10.SetActive(false); route11.SetActive(false); route12.SetActive(false); route13.SetActive(false); route14.SetActive(false); route15.SetActive(false); route16.SetActive(false); route17.SetActive(false); route18.SetActive(false); route19.SetActive(false); route20.SetActive(false); route21.SetActive(false); route22.SetActive(false); route23.SetActive(false); route24.SetActive(false); route25.SetActive(false);
        route1_2.SetActive(false); route2_2.SetActive(false); route3_2.SetActive(false); route4_2.SetActive(false); route5_2.SetActive(false); route6_2.SetActive(false); route7_2.SetActive(false); route8_2.SetActive(false); route9_2.SetActive(false); route10_2.SetActive(false); route11_2.SetActive(false); route12_2.SetActive(false); route13_2.SetActive(false); route14_2.SetActive(false); route15_2.SetActive(false); route16_2.SetActive(false); route17_2.SetActive(false); route18_2.SetActive(false); route19_2.SetActive(false); route20_2.SetActive(false); route21_2.SetActive(false); route22_2.SetActive(false); route23_2.SetActive(false); route24_2.SetActive(false); route25_2.SetActive(false);
    }
    public void CloseAllRoads()
    {
        RoadM1_1.SetActive(false); RoadM1_2.SetActive(false); RoadM1_3.SetActive(false); RoadM1_4.SetActive(false); RoadM2_1.SetActive(false); RoadM2_2.SetActive(false);
        RoadM2_3.SetActive(false); RoadM3_1.SetActive(false); RoadM3_2.SetActive(false); RoadM3_3.SetActive(false); RoadM3_4.SetActive(false); RoadM4_1.SetActive(false);
        RoadM4_2.SetActive(false); RoadM5_1.SetActive(false); RoadM5_2.SetActive(false); RoadA1.SetActive(false); RoadA2.SetActive(false); RoadA3.SetActive(false);
        RoadE1.SetActive(false); RoadE2.SetActive(false); RoadE3.SetActive(false); RoadE4.SetActive(false); RoadE5.SetActive(false); RoadE5.SetActive(false);
        RoadE6.SetActive(false); RoadE7.SetActive(false);
        RoadM1_1_2.SetActive(false); RoadM1_2_2.SetActive(false); RoadM1_3_2.SetActive(false); RoadM1_4_2.SetActive(false); RoadM2_1_2.SetActive(false); RoadM2_2_2.SetActive(false);
        RoadM2_3_2.SetActive(false); RoadM3_1_2.SetActive(false); RoadM3_2_2.SetActive(false); RoadM3_3_2.SetActive(false); RoadM3_4_2.SetActive(false); RoadM4_1_2.SetActive(false);
        RoadM4_2_2.SetActive(false); RoadM5_1_2.SetActive(false); RoadM5_2_2.SetActive(false); RoadA1_2.SetActive(false); RoadA2_2.SetActive(false); RoadA3_2.SetActive(false);
        RoadE1_2.SetActive(false); RoadE2_2.SetActive(false); RoadE3_2.SetActive(false); RoadE4_2.SetActive(false); RoadE5_2.SetActive(false); RoadE5_2.SetActive(false);
        RoadE6_2.SetActive(false); RoadE7_2.SetActive(false);
    }

    void Start()
    {
        mapLocation = Main.SaveMapLocation;
    }

    void Update()
    {
        finishLoca = Main.FinishLoca;
        mapLocation = Main.MapLocation;
        saveMapLocation = Main.SaveMapLocation;
        Road = Main.Road;
    }
}
