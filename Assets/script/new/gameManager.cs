using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class gameManager : MonoBehaviour
{
    private int coinsNo;
    public GameObject[] coins;
    private int levelCount;
    public coinBlast coinblst;
    public Text steps;
    public Text Level;
    
    public dragBall count;
    public GameObject startpanel;
    public Text lvlCount;
    private GameObject[] gos;

  
    void Start()
    {
        gos = GameObject.FindGameObjectsWithTag("coin");
        coinsNo = gos.Length;
        //print(coinsNo);
        levelCount = (SceneManager.GetActiveScene().buildIndex - 1);
        Level.text = levelCount.ToString();
        lvlCount.text = (SceneManager.GetActiveScene().buildIndex - 1).ToString();
        startpanel.SetActive(true);
        
        for(int i =0; i < coinsNo; i++)
        {
            print(i);
            coins[i].SetActive(true);
        }
    }

   
    void Update()
    {
        int current = GameObject.FindGameObjectsWithTag("coin").Length;
        //int current = coinblst.currentCount;
       
        if (coinsNo> current)
        {
            //StartCoroutine("delay");
    
            coins[current].SetActive(false);
            coinsNo--;
        }

//moves.text = count.steps.ToString();
        

        steps.text = count.steps.ToString();
        
    }

  
}
