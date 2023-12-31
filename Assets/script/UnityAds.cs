﻿using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class UnityAds : MonoBehaviour, IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener
{
    //public string _androidGameId = "3758503";
    //[SerializeField] string _iOSGameId;
    string _gameId = "5176735";
    private bool _testMode = false;
    //private string myPlacementId = "Android_Interstitial";
    private int missionNumber = 0;
    private void Awake()
    {
        missionNumber = PlayerPrefs.GetInt("missionNumber");
        InitializeAds();
        /*if (Advertisement.isInitialized)
        {
            InitializeAds();
            //Debug.Log("Advertisement is Initialized");
            //LoadRewardedAd();
        }
        else
        {
            InitializeAds();
        }*/
    }
    public void InitializeAds()
    {
        // _gameId = (Application.platform == RuntimePlatform.IPhonePlayer) ? _iOSGameId : _androidGameId;
        Advertisement.Initialize(_gameId, _testMode, this);
    }

    public void OnInitializationComplete()
    {
        Debug.Log("Unity Ads initialization complete.");
        LoadInerstitialAd();
        LoadBannerAd();
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log($"Unity Ads Initialization Failed: {error.ToString()} - {message}");
    }

    public void LoadInerstitialAd()
    {
        Advertisement.Load("Interstitial_Android", this);
    }

    public void LoadRewardedAd()
    {
        Advertisement.Load("Rewarded_Android", this);
    }
    public void DisplayInterstitialAD()
    {
        Advertisement.Show("Interstitial_Android", this);


    }
    public void ShowRewardedVideo()
    {


        Advertisement.Show("Rewarded_Android", this);


    }
    public void OnUnityAdsAdLoaded(string placementId)
    {
        Debug.Log("OnUnityAdsAdLoaded");
        //Advertisement.Show(placementId, this);
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        Debug.Log($"Error showing Ad Unit {placementId}: {error.ToString()} - {message}");
    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        Debug.Log("OnUnityAdsShowFailure");
    }

    public void OnUnityAdsShowStart(string placementId)
    {
        Debug.Log("OnUnityAdsShowStart");
        Time.timeScale = 0;
        //Advertisement.Banner.Hide();
    }

    public void OnUnityAdsShowClick(string placementId)
    {
        Debug.Log("OnUnityAdsShowClick");
    }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        Debug.Log("OnUnityAdsShowComplete " + showCompletionState);
        if (placementId == "Rewarded_Android" && showCompletionState.ToString() == "COMPLETED")
        {
            if (SceneManager.GetActiveScene().buildIndex == missionNumber + 2)
            {
                missionNumber++;
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //Time.timeScale = 1;
            //missionNumber++;
            PlayerPrefs.SetInt("missionNumber", missionNumber);

        }

        Time.timeScale = 1;
        //Advertisement.Banner.Show("Banner_Android");
    }



    public void LoadBannerAd()
    {
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        Advertisement.Banner.Load("Banner_Android",
            new BannerLoadOptions
            {
                loadCallback = OnBannerLoaded,
                errorCallback = OnBannerError
            }
            );
    }

    void OnBannerLoaded()
    {
        //Advertisement.Banner.Show("Banner_Android");
    }

    void OnBannerError(string message)
    {

    }

}