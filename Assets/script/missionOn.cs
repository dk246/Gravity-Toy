using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missionOn : MonoBehaviour
{

    public int number;
    public GameObject pannel;
    public GameObject start;
    public GameObject mission;
    public GameObject musicTF;
    public GameObject m1;
    public GameObject m2;
    public GameObject m3;
    public GameObject m4;
    public GameObject m5;
    public GameObject m6;
    public GameObject m7;
    public GameObject m8;
    public GameObject m9;
    public GameObject m10;
    public GameObject p2m1;
    public GameObject p2m2;
    public GameObject p2m3;
    public GameObject p2m4;
    public GameObject p2m5;
    public GameObject p2m6;
    public GameObject p2m7;
    public GameObject p2m8;
    public GameObject p2m9;
    public GameObject p2m10;

    private void Start()
    {
        number = getmission.count;
        if (number == 50)
        {
            pannel.SetActive(false);
            start.SetActive(true); 
        }

        if (number == 60)
        {
            musicTF.SetActive(true);
            pannel.SetActive(false);
            mission.SetActive(true);
            start.SetActive(false);

            music.instans.soundON();
        }



        if (number == 1)
        {
            m1.SetActive(true);
        }
        if (number == 2)
        {
            m2.SetActive(true);
        }
        if (number == 3)
        {
            m3.SetActive(true);
        }
        if (number == 4)
        {
            m4.SetActive(true); 
        }
        if(number == 5)
        {
            m5.SetActive(true);
        }
        if (number == 6)
        {
            m6.SetActive(true);
        }
        if (number == 7)
        {
            m7.SetActive(true);
        }
        if (number == 8)
        {
            m8.SetActive(true);
        }
        if (number == 9)
        {
            m9.SetActive(true);
        }
        if (number == 10)
        {
            m10.SetActive(true);
        }

        //page2


        if (number == 11)
        {
            p2m1.SetActive(true);
        }
        if (number == 12)
        {
            p2m2.SetActive(true);
        }
        if (number == 13)
        {
            p2m3.SetActive(true);
        }
        if (number == 14)
        {
            p2m4.SetActive(true);
        }
        if (number == 15)
        {
            p2m5.SetActive(true);
        }
        if (number == 16)
        {
            p2m6.SetActive(true);
        }
        if (number == 17)
        {
            p2m7.SetActive(true);
        }
        if (number == 18)
        {
            p2m8.SetActive(true);
        }
        if (number == 19)
        {
            p2m9.SetActive(true);
        }
        if (number == 20)
        {
            p2m10.SetActive(true);
        }

    }


}
