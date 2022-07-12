using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Node : MonoBehaviour {

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

        public LineRenderer getLineRenderer(){
            return lr;
        }

        public void setLinePosition(Vector3 pos){
            lr.SetPosition(0, obj.transform.position);
            lr.SetPosition(1, pos);
        }
    }

    List<Edge> edges = new List<Edge>();
    [SerializeField] TMP_Text nodeName;

    void Update(){
        foreach(Edge edge in edges){
            edge.setLinePosition(this.transform.position);
        }
    }

    public void setName(string name){
        nodeName.text = name;
    }

    public void addEdge(Node node){
        SpringJoint spring = this.gameObject.AddComponent<SpringJoint>();
        spring.autoConfigureConnectedAnchor = false;
        spring.connectedAnchor = Vector3.zero;
        spring.enableCollision = true;
        spring.connectedBody = node.GetComponent<Rigidbody>();
        Edge edge = new Edge(node.gameObject);
        edges.Add(edge);
    }
}
