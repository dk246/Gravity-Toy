using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    //string GooglePlay_ID = "5176735";
    public static music instans;
    public AudioSource AS;
    public AudioSource Button;
    public AudioSource fail;
    public AudioSource win;
    void Start()
    {
        instans = this;
        AS = GetComponent<AudioSource>();
        
        //soundON();
       
    }
    private void Awake()
    {
        instans = this;
    }
    public void soundON()
    {
        AS.Play(); 
    }
    public void soundOFF()
    {
        AS.Pause();
    }
    public void Click()
    {
        Button.Play();
    }
    public void Win()
    {
        win.Play();
    }
    public void Fail()
    {
        fail.Play();
    }

}
