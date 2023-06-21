using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    private float rotz;
    public float speed;
    void Start()
    {
        
    }

    void Update()
    {
        rotz += Time.deltaTime * speed;
        transform.rotation = Quaternion.Euler(0, 0, rotz);
       
    }
}
