using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour {
	
	public GameObject node;
	public Node cylinder;
	public float size;

	// Algorithm for generating a random graph
	void GenerateRandomGraph(int total, float p){
		List<Node> nodes = new List<Node>();
		for(int x = 0; x < total; x++){
			GameObject obj = (GameObject) Instantiate(node, new Vector3(Random.Range(-size, size), 0.0f, Random.Range(-size, size)), Quaternion.identity);
			obj.transform.parent = transform;
			obj.GetComponent<Node>().setName("node " + x);
			nodes.Add(obj.GetComponent<Node>());
		}
		for(int i = 0; i < total; i++){
			for(int j = i+1; j < total; j++){
				if(Random.Range(0.0f, 1.0f) < p){
					nodes[i].addEdge(nodes[j], (int) (Random.Range(0.0f, 5.0f) * 10));
				}
			}
			nodes[i].addEdgeMain(cylinder);
		}
	}
  
    void Start(){
		int amount = 19;
		GenerateRandomGraph(amount, 0.2f);
		//string path = "C:\Users\zhengz5\Documents\GitHub\FDGUnity\Force Directed Graphs\Assets\data\asoiaf-master\data\asoiaf-all-edges.csv";
		//string[] dataset = System.IO.File.ReadAllLines(path);
		//var result = CSVParser.parseCSV(dataset.Split('\n'));
	}
    
}
