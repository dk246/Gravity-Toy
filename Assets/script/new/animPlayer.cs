using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animPlayer : MonoBehaviour
{
    public GameObject eyeOn;
    public GameObject eyeOff;
    public GameObject eyeChange;
    public bool isIdle;
    public bool isDrag;

    void Start()
    {
        isIdle = true;
        isDrag = false;
        eyeOn.SetActive(true);
        eyeOff.SetActive(false);
        eyeChange.SetActive(false);
      
    }


    void Update()
    {
    
        if (isIdle == true)
        {
            StopCoroutine("Drag");

            StartCoroutine("Idle");
            isIdle = false;
        }

        if (Input.GetMouseButtonDown(0))
        {
            isDrag = true;
            isIdle = false;
            StopCoroutine("Idle");
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isIdle = true;
            StopCoroutine("Drag");
        }
        if (isDrag == true)
        {
            StartCoroutine("Drag");
            isDrag = false;
        }
    }
    public void Test()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isDrag = true;
            isIdle = false;

        }
        else if (Input.GetMouseButtonUp(0))
        {
            //isIdle = true;

        }
        else if (isDrag == true)
        {
            StartCoroutine("Drag");
            isDrag = false;
        }
    }
    IEnumerator Idle()
    {
        while (2 > 0)
        {
            yield return new WaitForSeconds(0);
            eyeOn.SetActive(true);
            eyeOff.SetActive(false);
            eyeChange.SetActive(false);
            yield return new WaitForSeconds(1.5f);
            eyeOn.SetActive(false);
            eyeOff.SetActive(true);
            eyeChange.SetActive(false);
            yield return new WaitForSeconds(0.3f);
            eyeOn.SetActive(true);
            eyeOff.SetActive(false);
            eyeChange.SetActive(false);
            yield return new WaitForSeconds(1.5f);
            eyeOn.SetActive(false);
            eyeOff.SetActive(true);
            eyeChange.SetActive(false);
            yield return new WaitForSeconds(0.3f);
            eyeOn.SetActive(false);
            eyeOff.SetActive(false);
            Vector3 scale1 = eyeChange.transform.localScale;
            scale1.x = 1f;
            eyeChange.transform.localScale = scale1;
            eyeChange.SetActive(true);
            yield return new WaitForSeconds(1.5f);
            Vector3 scale2 = eyeChange.transform.localScale;
            scale2.x = -1f;
            eyeChange.transform.localScale = scale2;
            yield return new WaitForSeconds(1.5f);
            eyeOn.SetActive(false);
            eyeOff.SetActive(true);
            eyeChange.SetActive(false);
            yield return new WaitForSeconds(0.3f);
        }


    }

    IEnumerator Drag()
    {
        while (2 > 0)
        {
            yield return new WaitForSeconds(0);
            eyeOn.SetActive(true);
            eyeOff.SetActive(false);
            eyeChange.SetActive(false);
            yield return new WaitForSeconds(2);
            eyeOn.SetActive(false);
            eyeOff.SetActive(true);
            eyeChange.SetActive(false);
            yield return new WaitForSeconds(0.2f);
            eyeOn.SetActive(true);
            eyeOff.SetActive(false);
            eyeChange.SetActive(false);
            yield return new WaitForSeconds(2);
        }
    }
}