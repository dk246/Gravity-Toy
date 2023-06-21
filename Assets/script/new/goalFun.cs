using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalFun : MonoBehaviour
{
    public bool is_complete = false;
    public bool check;
    public Animator playerAnim;
    public GameObject plyr;
    public GameObject goal;
    private Animator anim;
    public GameObject completePanel;
    public GameObject[] counts;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "ball")
        {
            yield return new WaitForSeconds(0f);
            is_complete = true;
            StartCoroutine("CountDown");

        }

    }
    private IEnumerator OnTriggerExit2D(Collider2D collision)
    {
    
        if (collision.tag == "ball")
        {
            yield return new WaitForSeconds(0f);
            is_complete = false;
            counts[0].SetActive(false);
            counts[1].SetActive(false);
            counts[2].SetActive(false);
            plyr.GetComponent<dragBall>().enabled = true;
            StopCoroutine("CountDown");

        }
    }
    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(0f);
        check = is_complete;
        counts[0].SetActive(true);
        yield return new WaitForSeconds(1f);
        counts[1].SetActive(true);
        yield return new WaitForSeconds(1f);
        counts[2].SetActive(true);
        yield return new WaitForSeconds(1f);
        plyr.GetComponent<dragBall>().enabled = false;
        counts[0].SetActive(false);
        counts[1].SetActive(false);
        counts[2].SetActive(false);
        //plyr.GetComponent<dragBall>().enabled = false;
        if (is_complete == check)
        {
            print("complete");
            anim.SetBool("finish", true);
            playerAnim.SetBool("finish", true);
            completePanel.SetActive(true);

        }
        
    }
}
