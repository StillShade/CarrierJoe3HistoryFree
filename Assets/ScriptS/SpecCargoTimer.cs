using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using System;

public class SpecCargoTimer : MonoBehaviour
{
    public GameObject btnSpecCargo;
    public GameObject btnAds;
    public GameObject noAds;
    [Header("Таймер")]
    public float timer;
    float seconds;
    float minutes;
    float hourse;

    string RewardedUnitId = "ca-app-pub-8038378620385023/8478486202";

    private RewardedAd rewardedAd;

    [SerializeField] Text stopWatchText;

    void Start()
    {
        MobileAds.Initialize(initStatus => { });
        timer = Main.Timer;
        LoadADS();
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

    private void Update()
    {
        Main.Timer = timer;

        if (timer > 0)
        {
            StopWatchCalcul();
        }

        if (timer <= 0 && Main.CargoCondition == 0)
        {
            timer = 0;
            btnSpecCargo.SetActive(true);
        }
        else
            btnSpecCargo.SetActive(false);
    }
    void StopWatchCalcul()
    {
        timer -= Time.deltaTime;
        seconds = (int)(timer % 60);
        minutes = (int)((timer / 60) % 60);
        hourse = (int)(timer / 3600);

        stopWatchText.text = hourse.ToString("00") + " : " + minutes.ToString("00") + " : " + seconds.ToString("00");
    }
    public void RestartTimer()
    {
        timer = 3600;
    }

    private void HandleUserEarnedReward(object sender, Reward e)
    {
        timer -= 900f;
    }
    private void LoadADS()
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

    public void ShowAd()
    {
        if (rewardedAd.IsLoaded())
        {
            rewardedAd.Show();
            LoadADS();
        }
        else
        {
            noAds.SetActive(true);
            OffNoAds();
        }
    }
}
