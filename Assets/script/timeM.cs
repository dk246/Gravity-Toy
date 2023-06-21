using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeM : MonoBehaviour
{

    public float timeCount = 15;
    public static string timeDisplay;

    public GameObject timeBox;

    public GameObject gameOver;
    public GameObject ball;
    public GameObject goal;
    void Update()
    {

        timeCount -= Time.deltaTime * 1;
        timeDisplay = timeCount.ToString("f0");
        timeBox.GetComponent<Text>().text =" " + timeDisplay ;

        if(timeCount <= 9)
        {
            timeBox.GetComponent<Text>().text = " 0" + timeDisplay;

        }

        if(timeCount <=1)
        {
            timeBox.GetComponent<Text>().text = " 00";
            ball.SetActive(false);
            goal.SetActive(false);
            gameOver.SetActive(true);

        }
        

        
    }
}
