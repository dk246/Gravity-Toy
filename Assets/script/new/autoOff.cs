using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoOff : MonoBehaviour
{
    
    
    void Start()
    {
        triggerOfdrag.is_trigger = false;
        StartCoroutine("ScreenOff");
    }

    IEnumerator ScreenOff()
    {
        yield return new WaitForSeconds(2f);
        triggerOfdrag.is_trigger = true;
        yield return new WaitForSeconds(0f);
        gameObject.SetActive(false);
    }
  
}
