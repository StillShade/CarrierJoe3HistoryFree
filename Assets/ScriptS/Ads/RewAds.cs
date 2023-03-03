using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using System;

public class RewAds : MonoBehaviour
{
    public GameObject btnRulyX2;
    public Text rulyTx;

    public GameObject btnFreeXpX2;
    public Text freeXpTx;

    public GameObject btnTruckXpX2;
    public Text truckXpTx;

    public GameObject btnTrailerXpX2;
    public Text trailerXpTx;

    private int _IdADS;
    public GameObject noAds;

    string RewardedUnitId = "ca-app-pub-8038378620385023/9140831185";

    private RewardedAd rewardedAd;

    private void Start()
    {
        MobileAds.Initialize(initStatus => { });
        LoadADS();
    }

    public void On2xBtn()
    {
        btnRulyX2.SetActive(true);
        btnFreeXpX2.SetActive(true);
        btnTruckXpX2.SetActive(true);
        btnTrailerXpX2.SetActive(true);
    }

    public void OffNoAds()
    {
        StartCoroutine(delay());
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(3f);
        noAds.SetActive(false);
    }

    public void LoadADS()
    {
        rewardedAd = new RewardedAd(RewardedUnitId);
        AdRequest adRequest = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(adRequest);
        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
    }

    private void OnDisable()
    {
        rewardedAd.OnUserEarnedReward -= HandleUserEarnedReward;
    }

    private void HandleUserEarnedReward(object sender, Reward e)
    {
        switch (_IdADS)
        {
            case 1:
                Main.PrizeRuly = Main.PrizeRuly * 2;
                btnRulyX2.SetActive(false);
                btnFreeXpX2.SetActive(false);
                btnTruckXpX2.SetActive(false);
                btnTrailerXpX2.SetActive(false);
                rulyTx.text = Main.PrizeRuly.ToString("0") + " R";
                break;
            case 2:
                Main.PrizeXpFree = Main.PrizeXpFree * 2;
                btnRulyX2.SetActive(false);
                btnFreeXpX2.SetActive(false);
                btnTruckXpX2.SetActive(false);
                btnTrailerXpX2.SetActive(false);
                freeXpTx.text = Main.PrizeXpFree.ToString("0") + " XP";
                break;
            case 3:
                Main.PrizeXpCar = Main.PrizeXpCar * 2;
                btnRulyX2.SetActive(false);
                btnFreeXpX2.SetActive(false);
                btnTruckXpX2.SetActive(false);
                btnTrailerXpX2.SetActive(false);
                truckXpTx.text = Main.PrizeXpCar.ToString("0") + " XP";
                break;
            case 4:
                Main.PrizeXpTrailer = Main.PrizeXpTrailer * 2;
                btnRulyX2.SetActive(false);
                btnFreeXpX2.SetActive(false);
                btnTruckXpX2.SetActive(false);
                btnTrailerXpX2.SetActive(false);
                trailerXpTx.text = Main.PrizeXpTrailer.ToString("0") + " XP";
                break;
        }        
    }

    public void ShowAd (int typeNumber)
    {
        _IdADS = typeNumber;
        if (rewardedAd.IsLoaded())
        {
            rewardedAd.Show();
        }
        else
        {
            noAds.SetActive(true);
            OffNoAds();
            //LoadADS();
        }
    }
}
