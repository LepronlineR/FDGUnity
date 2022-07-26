using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour {
	
	public GameObject nodePrefab;
	public Node cylinder;
	public float size;
	public Gradient weightGradient;
	[SerializeField] Material defaultLRMaterial;

	// Algorithm for generating a random graph
	/*
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
	}*/

	/*	=========================================================================================
	*		A dictionary of nodeDatas are generated with edgeData as adjacencies,
	*		this is done before parsing into a node for ease of implementation and abstraction
	* 		Input: nodes and edges have their data parsed
	* 		Output: dictionary of NodeDatas with their key being their respective ID
	*	=========================================================================================
	*	TODO: read from the fields Id, Label, Source, Target, Type, ..., etc instead of based on index
	*/ 	 
	Dictionary<string, NodeData> generateNodeDataFromCSV(Data nodes, Data edges){
		// obtain the nodes
		/*		From the example
				Id,						Label
				Addam-Marbrand,			Addam Marbrand
				[0] --> ID				[1] --> Name
		*/
		Dictionary<string, NodeData> result = new Dictionary<string, NodeData>();
		foreach(string[] line in nodes.data){
			NodeData node = new NodeData();
			node.ID = line[0];
			node.Name = line[1];
			// set the node's color to random
			node.COLOR = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
			result.Add(node.ID, node);
		}
		// set the edges
		/*		From the example
				Source,				Target,			Type,		id,			weight
				Addam-Marbrand,		Brynden-Tully,	Undirected,	0,			3
		*/
		/*
			Person -> One
			search for Person 
			NodeData:

			Person ID: Person-Person, List<EdgeData> = [One];
		*/
		foreach(string[] line in edges.data){
			NodeData source;
			// get source
			if(result.TryGetValue(line[0], out source)){
				// get target
				NodeData target;
				if(result.TryGetValue(line[1], out target)){
					EdgeData newEdge = new EdgeData(target, line[4]);
					source.addToEdge(newEdge);
				} else {
					Debug.Log("Target: " + line[1] + " has not been found.");
				}
			} else {
				Debug.Log("Source: " + line[0] + " has not been found.");
			}
		}
		return result;
	}

	/*	=========================================================================================
	*		Given a generated dictionary of nodedatas, generate a graph 
	* 		Input: dictionary of nodeDatas
	* 		Output: NULLL
	*	=========================================================================================
	*	TODO: probably spread this into 2 functions so we can have a more usable intf.
	*/ 	 
	void generateGraphFromNodeData(Dictionary<string, NodeData> nodeData){
		Dictionary<NodeData, Node> nodes = new Dictionary<NodeData, Node>();
		// generate the nodes
		int count = 5;
		foreach(KeyValuePair<string, NodeData> data in nodeData){
			GameObject obj = (GameObject) Instantiate(nodePrefab, new Vector3(Random.Range(-size, size), 0.0f, Random.Range(-size, size)), Quaternion.identity);
			obj.name = data.Key;
			obj.transform.parent = transform;
			obj.GetComponent<Node>().Data = data.Value;
			obj.GetComponent<Node>().gameObj = obj;
			nodes.Add(data.Value, obj.GetComponent<Node>());
			if(count > 0){
				obj.GetComponent<Node>().setName();
				obj.GetComponent<Node>().setColor();
				obj.GetComponent<Node>().show = true;
			}
			count--;
		}
		// set the edges based on each node
		foreach(KeyValuePair<NodeData, Node> node in nodes){
			foreach(EdgeData edge in node.Key.Edges){
				// get target
				NodeData target = edge.Node;
				Node recievingNode;
				if(nodes.TryGetValue(target, out recievingNode)){
					// add the edge
					node.Value.addEdge(recievingNode, edge.Weight, node.Value.getName() + " (Edge)", defaultLRMaterial);
				} else {
					Debug.Log("[generateGraphFromNodeData()] Target: " + target.ID + " has not been found.");
				}
			}
			node.Value.addEdgeMain(cylinder);
		}
	}
  
    void Start(){
		CSVParser csvparser = new CSVParser();
		Data edges = csvparser.parseCSVPath("/data/asoiaf-master/data/asoiaf-all-edges.csv");
		Data nodes = csvparser.parseCSVPath("/data/asoiaf-master/data/asoiaf-all-nodes.csv");
		Dictionary<string, NodeData> data = generateNodeDataFromCSV(nodes, edges);
		generateGraphFromNodeData(data);
		//d.printList();
		//int amount = 19;
		//GenerateRandomGraph(amount, 0.2f);
		//string[] dataset = System.IO.File.ReadAllLines(path);
		//var result = CSVParser.parseCSV(dataset.Split('\n'));
	}
    
}
