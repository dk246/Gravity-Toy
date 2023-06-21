using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class dragBall : MonoBehaviour
{
    public float power;
    public Rigidbody2D rb;
    public int steps=0;
    public Vector2 minPower;
    public Vector2 maxPower;


    Camera cam;
    Vector2 force;
    Vector2 startPoint;
    Vector2 endPoint;

    public drawLine lr;

    private void Start()
    {
        cam = Camera.main;
        lr = GetComponent<drawLine>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            
            
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 CurrentPos = cam.ScreenToWorldPoint(Input.mousePosition);
            lr.lineShow(startPoint, CurrentPos);


        }

        if (Input.GetMouseButtonUp(0))
        {
            endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            

            force = new Vector2(Mathf.Clamp(startPoint.x - endPoint.x, minPower.x, maxPower.x), Mathf.Clamp(startPoint.y - endPoint.y, minPower.y, maxPower.y));
            rb.AddForce(force * power, ForceMode2D.Impulse);
            if (startPoint!= endPoint)
            {
                steps++;
            }
        
            lr.endLine();
        }
    }
}
