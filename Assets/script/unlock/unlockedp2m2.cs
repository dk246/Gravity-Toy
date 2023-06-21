using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockedp2m2 : MonoBehaviour
{

    public GameObject text;
    public GameObject lockicon; 
    public int count;
   
    void Start()
    {
        count = PlayerPrefs.GetInt("p2m2");

        if(count == 1)
        {
            text.SetActive(true);
            lockicon.SetActive(false); 
        }
    }

  
}
