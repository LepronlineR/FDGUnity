using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edge : MonoBehaviour {

    private GameObject obj;
    private LineRenderer lr;

    public Edge(GameObject go){
        obj = go;
        lr = new GameObject().AddComponent<LineRenderer>();
        lr.gameObject.transform.SetParent(obj.transform, false);
        lr.gameObject.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
        //lr.StartColor(Color.white);
    }

    public Edge(GameObject go, bool none){
        obj = go;
    }

    public LineRenderer getLineRenderer(){
        return lr;
    }

    public void setLinePosition(Vector3 pos){
        lr.SetPosition(0, obj.transform.position);
        lr.SetPosition(1, pos);
    }
}