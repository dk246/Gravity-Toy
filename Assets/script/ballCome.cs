using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballCome : MonoBehaviour
{
    public GameObject ball;

 
    public GameObject win;
    public Color bg_color;
    private void Update()
    {

    }

    IEnumerator OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == "ball")
        {
            Camera.main.backgroundColor = Color.Lerp(bg_color, Color.black, Time.time * 2f);
            //music.instans.Win();
         
            yield return new WaitForSeconds(1f);
            //UnityAds.instance.DisplayInterstitialAD();
            win.SetActive(true);
            //Time.SetActive(false);
        }

    }
    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.tag == "ball")
        {

            Camera.main.backgroundColor = Color.Lerp(Color.black, bg_color, Time.time * 2f);

        }
  
    }
}
