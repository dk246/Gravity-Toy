using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPannel : MonoBehaviour
{
    public GameObject startPannel;
    public int hide;
    //public int age;
    //public GameObject agePannel;
    //public static int ageInput;
    private void Awake()
    {
        //startPannel.SetActive(true);
        hide = PlayerPrefs.GetInt("hideButton");
        if (hide == 1)
        {
            startPannel.SetActive(false);

        }
        //age = PlayerPrefs.GetInt("ageSelect");
      /*  if(age == 1)
        {
            
            agePannel.SetActive(false);
            ageInput = 1;
        }
        if (age == 2)
        {
           
            agePannel.SetActive(false);
            ageInput = 2;
        }*/
    }

    public void startButton()
    {
        PlayerPrefs.SetInt("hideButton", 1);
     
        startPannel.SetActive(false);
    }
/*
    public void yesButton()
    {
        PlayerPrefs.SetInt("ageSelect", 1);
        ageInput = 1;
        agePannel.SetActive(false);
    }

    public void noButton()
    {
        PlayerPrefs.SetInt("ageSelect", 2);
        ageInput = 2;
        agePannel.SetActive(false);
    }*/

}
