using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerOfdrag : MonoBehaviour
{
    public static bool is_trigger;
    public dragBall drag;
    void Start()
    {
        
    }

    void Update()
    {
        if (is_trigger == false)
        {
            drag.enabled = false;
        }
        else
        {
            drag.enabled = true;
        }
    }
}
