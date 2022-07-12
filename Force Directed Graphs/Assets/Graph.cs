using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour {
	
	public GameObject node;
	public float size;

	// Algorithm for generating a random graph
	void GenerateRandomGraph(int total, float p){
		List<Node> nodes = new List<Node>();
		for(int x = 0; x < total; x++){
			GameObject obj = (GameObject) Instantiate(node, new Vector3(Random.Range(-size, size), Random.Range(-size, size), Random.Range(-size, size)), Quaternion.identity);
			obj.transform.parent = transform;
			obj.GetComponent<Node>().setName("node " + x);
			nodes.Add(obj.GetComponent<Node>());
		}
		for(int i = 0; i < total; i++){
			for(int j = i+1; j < total; j++){
				if(Random.Range(0.0f, 1.0f) < p){
					nodes[i].addEdge(nodes[j]);
				}
			}
		}
	}
  
    void Start(){      
		GenerateRandomGraph(10, 0.5f);
    }
    
}
