using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class internetC : MonoBehaviour
{
    public GameObject pannelIn;
    void Start()   
    {
        StartCoroutine(checkInternetConnection((isConnected) =>
        {
            if (isConnected)
            {
                pannelIn.SetActive(false);

            }
            else
            {
                pannelIn.SetActive(true);
                Time.timeScale = 0;
            }
        }));

    }

  
    IEnumerator checkInternetConnection(Action<bool> action)
    {
        WWW www = new WWW("http://google.com");
        yield return www;
        if(www.error != null)
        {
            action(false);
        }
        else
        {
            action(true);
        }

    }
}
