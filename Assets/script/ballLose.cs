using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballLose : MonoBehaviour
{
    public GameObject ball;
    public float under;
    public float up;
    public float left;
    public float right;
    public GameObject deathEffect;
    public GameObject gameOver;


    IEnumerator OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "ball")
        {
  
            yield return new WaitForSeconds(0);
            Instantiate(deathEffect, new Vector3(ball.transform.position.x-left+right, ball.transform.position.y-under+up,0), Quaternion.identity);
         
        }

    }



}
