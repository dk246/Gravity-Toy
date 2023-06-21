using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorial : MonoBehaviour
{
    public GameObject Canvas;

    void Start()
    {

    }
    public void tutorialButton()
    {
        StartCoroutine(tutorialON());
    }

    IEnumerator tutorialON()
    {
        yield return new WaitForSeconds(0f);
        Canvas.SetActive(true);

        yield return new WaitForSeconds(11f);
        Canvas.SetActive(false);
    }
   
}
