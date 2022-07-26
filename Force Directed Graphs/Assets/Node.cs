using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Node : MonoBehaviour {

    NodeData nodeData;
    [SerializeField] TMP_Text nodeName;
    List<Edge> edges = new List<Edge>();
    public bool show = false;
    private Vector3 vec = new Vector3(0.0f, 0.0f, 0.0f);

    // represents the GO/Transform that holds Node
    public GameObject gameObj { get; set; }

    public NodeData Data {
        get { return nodeData; }
        set { nodeData = value; }
    }

    public void setName(){
        nodeName.text = nodeData.Name;
    }

    public string getName(){
        return nodeData.Name;
    }

    public void setColor(){
        Renderer mr = GetComponent<Renderer>();
        mr.material.color = nodeData.COLOR;
    }

    void Update() {
        this.transform.LookAt(vec);
        //setColor();
    }

    void FixedUpdate(){
        /*
        if(show){
            foreach(Edge edge in edges){
                edge.setLinePosition(this.transform.position);
            }
        }*/
    }


    public void addEdge(Node node, int weight, string name, Material mat){
        SpringJoint spring = this.gameObject.AddComponent<SpringJoint>();
        spring.autoConfigureConnectedAnchor = false;
        spring.connectedAnchor = Vector3.zero;
        spring.enableCollision = true;
        spring.connectedBody = node.GetComponent<Rigidbody>();
        spring.spring = weight;
        Edge edge = new Edge(this.gameObject, node.gameObject, name, mat);
        edges.Add(edge);
    }

    public void addEdgeMain(Node node){
        SpringJoint spring = this.gameObject.AddComponent<SpringJoint>();
        spring.autoConfigureConnectedAnchor = false;
        spring.connectedAnchor = Vector3.zero;
        spring.enableCollision = true;
        spring.connectedBody = node.GetComponent<Rigidbody>();
        spring.spring = 9999;
        Edge edge = new Edge(node.gameObject, false);
        edges.Add(edge);
    }
}
