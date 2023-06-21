using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCollect : MonoBehaviour
{
    

    public GameObject coinEffect;
    public AudioSource coinSound;

   
    public void soundPlay()
    {
        coinSound.Play();
    }
    IEnumerator OnTriggerEnter2D(Collider2D coin)
    {
        if (coin.tag == "ball")
        {
            soundPlay();
            Instantiate(coinEffect, transform.position, Quaternion.identity);
            //coinBal.totalCoins += 1;
            //PlayerPrefs.SetInt("Coins", coinBal.totalCoins);
            yield return new WaitForSeconds(0.15f);
            gameObject.SetActive(false);
            yield return new WaitForSeconds(1f);
            
            
            
        }

    }
}
