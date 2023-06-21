using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class missionsButtons : MonoBehaviour
{
    private int missionNo;
    public GameObject[] missionsBtn;
    void Start()
    {
        
        missionNo = PlayerPrefs.GetInt("missionNumber");
        for (int x = 0; x < missionNo + 1; x++)
        {
            //missionsBtn[x].SetActive(true);
            missionsBtn[x].GetComponent<Button>().interactable = true;
            missionsBtn[x].transform.GetChild(1).gameObject.SetActive(false);
            if (x < 10)
            {
                missionsBtn[x].transform.GetChild(0).GetComponent<Text>().text = 0 + (x + 1).ToString();
            }
            else
            {
                missionsBtn[x].transform.GetChild(0).GetComponent<Text>().text = (x + 1).ToString();

            }

        }

        
    }
    public void MissionSelect(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber+1);
     
    }
    public void LockButton()
    {

    }

    void Update()
    {
        
    }
}
