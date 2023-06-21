using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlocked : MonoBehaviour
{

    public GameObject text;
    public GameObject lockicon;
    public int count;
   
    void Start()
    {
        count = PlayerPrefs.GetInt("m1");

        if(count == 1)
        {
            text.SetActive(true);
            lockicon.SetActive(false);
        }
    }

  
}
