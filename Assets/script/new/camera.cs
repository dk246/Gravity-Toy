using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target;
    public bool isVertical;
    public float smoothSpeed = 0.001f;

    public Vector3 offset;
    void FixedUpdate()
    {
        //Vector3 desiredposition = target.position + offset;
        //Vector3 smoothedposition = Vector3.Lerp(transform.position, desiredposition, smoothSpeed);
        //transform.position = smoothedposition; 
        if (!isVertical)
        {
            Vector3 desiredposition = target.position + offset;
            Vector3 targetPos = new Vector3(desiredposition.x, transform.position.y, transform.position.z);
            Vector3 smoothedposition = Vector3.Lerp(transform.position, targetPos, smoothSpeed);
            transform.position = smoothedposition;
        }
        else
        {
            Vector3 desiredposition = target.position + offset;
            Vector3 targetPos = new Vector3(transform.position.x, desiredposition.y, transform.position.z);
            Vector3 smoothedposition = Vector3.Lerp(transform.position, targetPos, smoothSpeed);
            transform.position = smoothedposition;
        }
    }
}
