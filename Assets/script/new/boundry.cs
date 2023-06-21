using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundry : MonoBehaviour
{

    public GameObject fail;
    void Start()
    {
        fail.SetActive(false);
    }

    void Update()
    {
        
    }

    private IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ball")
        {
            yield return new WaitForSeconds(0f);
            //is_complete = true;
            //StartCoroutine("CountDown");
            fail.SetActive(true);
        }
    }

}
