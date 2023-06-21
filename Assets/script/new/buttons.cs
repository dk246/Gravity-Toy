using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttons : MonoBehaviour
{

    public GameObject[] pausePanel;
    private int missionNumber =0;
    public GameObject[] notif;
    //public UnityAds ads;
    public GameObject rewardpanel;
    //public Button[] missionsBtn; 
    void Start()
    {
        //print(SceneManager.GetActiveScene().buildIndex);
        missionNumber = PlayerPrefs.GetInt("missionNumber");
        //notif.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Notiffication()
    {
        notif[0].SetActive(false);
        notif[1].SetActive(true);

    }
    public void NotifExit()
    {
        notif[0].SetActive(false);
        notif[1].SetActive(false);
        notif[2].SetActive(false);

    }
    public void Home()
    {
        SceneManager.LoadScene(0);
    }

    public void missions()
    {
        SceneManager.LoadScene(1);
    }

    public void NextMission()
    {
        if (SceneManager.GetActiveScene().buildIndex == missionNumber + 2)
        {
            missionNumber++;
        }
        else
        {
            missionNumber = PlayerPrefs.GetInt("missionNumber");
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        //Time.timeScale = 1;
        //missionNumber++;
        PlayerPrefs.SetInt("missionNumber", missionNumber);
       
    }
    
    public void Pause()
    {
        triggerOfdrag.is_trigger = false;
        pausePanel[0].SetActive(true);
        pausePanel[1].SetActive(true);
    }

    public void resume()
    {
        triggerOfdrag.is_trigger = true;
        pausePanel[0].SetActive(false);
        pausePanel[1].SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void SkipMission()
    {
        //ads.ShowRewardedVideo();
        rewardpanel.SetActive(true);
        triggerOfdrag.is_trigger = false;

    }

    public void CloseReward()
    {
        rewardpanel.SetActive(false);
        triggerOfdrag.is_trigger = true;
    }

    public void WatchReward()
    {
        //ads.ShowRewardedVideo();
    }

    

    

}
