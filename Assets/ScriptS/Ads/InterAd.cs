using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class InterAd : MonoBehaviour
{
    private InterstitialAd interstitialAd;
    public GameObject noAds;

    private void Start()
    {
        MobileAds.Initialize(initStatus => { });
        RequestInterstitial();
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

    public void RequestInterstitial()
    {
        string interstitialUnitId = "ca-app-pub-1724628854723373/3827998824";
        interstitialAd = new InterstitialAd(interstitialUnitId);
        AdRequest adRequest = new AdRequest.Builder().Build();
        interstitialAd.LoadAd(adRequest);
    }

    public void ShowAd()
    {
        if (Main.Ads == 0)
        {
            if (interstitialAd.IsLoaded())
            {
                interstitialAd.Show();
            }
            else
            {
                noAds.SetActive(true);
                OffNoAds();
                //RequestInterstitial();
            }
        }
    }
}
