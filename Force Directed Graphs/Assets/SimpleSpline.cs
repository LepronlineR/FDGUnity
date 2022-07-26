using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSpline : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    private LineRenderer lr;
    private int vertices = 36;
    private float incrementAmount;
    private Vector3[] arr;

    public static SimpleSpline CreateSpline(GameObject obj, GameObject start, GameObject end, LineRenderer lr){
        SimpleSpline spline = obj.AddComponent<SimpleSpline>();
        GameObject empty = new GameObject("Bezier Point");
        empty.gameObject.transform.SetParent(obj.transform, false);
        spline.p1 = start;
        spline.p3 = end;
        spline.p2 = empty;
        spline.lr = lr;
        return spline;
    }

    void Start() {
        incrementAmount = 1.0f/vertices;
        arr = new Vector3[vertices + 1];
        //p2.transform.position = (p1.position + p3.position)/2;
        p2.transform.position = Vector3.zero;
        // make this transform closer to the circle
        // p2.transform.position = Vector3.Zero;
    }

    // Update is called once per frame
    void FixedUpdate() {
        //p2.transform.position = Vector3.zero;
        p2.transform.position = (p1.transform.position + p3.transform.position)/2;
        p2.transform.position = (Vector3.zero + p2.transform.position)/1.5f;
        if(p1 != null && p2 != null && p3 != null){
            float count = 0.0f;
            for(int x = 0; x <= vertices; x++){
                arr[x] = Vector3.Lerp(
                    Vector3.Lerp(p1.transform.position, p2.transform.position, count), 
                    Vector3.Lerp(p2.transform.position, p3.transform.position, count), 
                    count);
                count += incrementAmount;
            }
            lr.positionCount = vertices;
            lr.SetPositions(arr);
        }
    }
}
