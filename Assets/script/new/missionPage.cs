using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class missionPage : MonoBehaviour
{
    private int pageNo;
    public int max;
    public int min;
    public Button[] btn;
    private int currentPg;
    public GameObject[] pg;
    public Text txt;

    void Start()
    {
        currentPg = PlayerPrefs.GetInt("missionNumber");
        if (currentPg < 25)
        {
            pageNo = 1;
        }
        else if (currentPg < 49 && currentPg>24)
        {
            pageNo = 2;
        }
        else if(currentPg > 49 && currentPg < 73)
        {
            pageNo = 3;
        }
        else if (currentPg > 72 && currentPg < 97)
        {
            pageNo = 4;
        }
        else
        {
            pageNo = 5;
        }
    }
    public void Next()
    {
        if(pageNo < max)
        {
            pageNo++;
        }
        else
        {
            pageNo = max;
        }
       
    }

    public void Back()
    {
        if (pageNo > min)
        {
            pageNo--;
        }
        else
        {
            pageNo = min;
        }

    }
    // Update is called once per frame
    void Update()
    {
        if(pageNo == 1)
        {
            pg[1].SetActive(false);
            pg[0].SetActive(true);
            pg[2].SetActive(false);
            pg[3].SetActive(false);
            pg[4].SetActive(false);
        }
        else if (pageNo == 2)
        {
            pg[1].SetActive(true);
            pg[0].SetActive(false);
            pg[2].SetActive(false);
            pg[3].SetActive(false);
            pg[4].SetActive(false);
        }
        else if (pageNo == 3)
        {
            pg[1].SetActive(false);
            pg[0].SetActive(false);
            pg[2].SetActive(true);
            pg[3].SetActive(false);
            pg[4].SetActive(false);
        }
        else if (pageNo == 4)
        {
            pg[1].SetActive(false);
            pg[0].SetActive(false);
            pg[2].SetActive(false);
            pg[3].SetActive(true);
            pg[4].SetActive(false);
        }
        else if (pageNo == 5)
        {
            pg[1].SetActive(false);
            pg[0].SetActive(false);
            pg[2].SetActive(false);
            pg[3].SetActive(false);
            pg[4].SetActive(true);
        }
        txt.text = pageNo.ToString();
        if (pageNo == min)
        {
            btn[0].interactable = false;
            btn[1].interactable = true;
        }
        else if (pageNo == max)
        {
            btn[1].interactable = false;
            btn[0].interactable = true;
        }
        else
        {
            btn[1].interactable = true;
            btn[0].interactable = true;
        }
    }
}
