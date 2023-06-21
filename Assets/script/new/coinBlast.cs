using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinBlast : MonoBehaviour
{
    public int count = 0;
    public int currentCount;
    public GameObject goal;


    void Start()
    {
        count = transform.childCount;
        goal.SetActive(false);
    }

    void Update()
    {
        //print(currentCount);
        currentCount = GetComponentsInChildren<Transform>().GetLength(0); 
        if (currentCount == 1)
        {
            goal.SetActive(true);
        }

    }
}
