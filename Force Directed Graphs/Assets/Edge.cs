using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edge {

    private LineRenderer lr;
    private SimpleSpline spline;

    public Edge(GameObject source, GameObject target, string ID, Material mat){
        lr = new GameObject().AddComponent<LineRenderer>();
        spline = SimpleSpline.CreateSpline(lr.gameObject, source, target, lr);

        lr.gameObject.transform.SetParent(source.transform, false);
        lr.gameObject.name = ID;
        lr.gameObject.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
        lr.startWidth = 0.2f;
        lr.endWidth = 0.2f;
        Color startColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        Color endColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        float alpha = 1.0f;
        Gradient gradient = new Gradient();
        gradient.SetKeys(
            new GradientColorKey[] { new GradientColorKey(startColor, 0.0f), new GradientColorKey(endColor, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 1.0f) }
        );
        lr.material = mat;
        lr.colorGradient = gradient;
    }

    public Edge(GameObject source, bool none){
        //obj = go;
    }

    public LineRenderer getLineRenderer(){
        return lr;
    }
    /*
    public void setLinePosition(Vector3 pos){
        lr.SetPosition(0, obj.transform.position);
        lr.SetPosition(1, pos);
    }*/
}