using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawLine : MonoBehaviour
{
    public LineRenderer lr;

    private void Awoke()
    {
        lr = GetComponent<LineRenderer>();
    }

    public void lineShow(Vector3 StartPoint, Vector3 EndPoint)
    {
        lr.positionCount = 2;

        Vector3[] points = new Vector3[2];
        points[0] = StartPoint;
        points[1] = EndPoint;

        lr.SetPositions(points);



    }
    public void endLine()
    {
        lr.positionCount = 0;
    }

}
