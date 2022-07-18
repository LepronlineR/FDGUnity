using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Node : MonoBehaviour {

    NodeData nodeData;
    [SerializeField] TMP_Text nodeName;
    List<Edge> edges = new List<Edge>();

    public NodeData Data {
        get { return nodeData; }
        set { nodeData = value; }
    }

    public void setName(){
        nodeName.text = nodeData.Name;
    }

    void Update(){
        foreach(Edge edge in edges){
            edge.setLinePosition(this.transform.position);
        }
    }

    public void addEdge(Node node, int weight){
        if(node.gameObject == null){
            Debug.Log("ERROR: node is NULL for " + node.Data.Name);
        }
        SpringJoint spring = this.gameObject.AddComponent<SpringJoint>();
        spring.autoConfigureConnectedAnchor = false;
        spring.connectedAnchor = Vector3.zero;
        spring.enableCollision = true;
        spring.connectedBody = node.GetComponent<Rigidbody>();
        spring.spring = weight;
        Edge edge = new Edge(node.gameObject);
        edges.Add(edge);
    }

    public void addEdgeMain(Node node){
        SpringJoint spring = this.gameObject.AddComponent<SpringJoint>();
        spring.autoConfigureConnectedAnchor = false;
        spring.connectedAnchor = Vector3.zero;
        spring.enableCollision = true;
        spring.connectedBody = node.GetComponent<Rigidbody>();
        spring.spring = 5000;
        Edge edge = new Edge(node.gameObject, false);
        edges.Add(edge);
    }
}
