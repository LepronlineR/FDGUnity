using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeData {

    public NodeData(){
        edges = new List<EdgeData>();
    }

    // Node
    string id;
    string name;
    Color color;
    
    // Misc
    List<string> other;
    // Edges
    List<EdgeData> edges;

    public string ID {
        get { return id; }
        set { id = value; }
    }

    public string Name {
        get { return name; }
        set { name = value; }
    }

    public Color COLOR {
        get { return color; }
        set { color = value; }
    }

    public List<EdgeData> Edges {
        get { return edges; }
        set { edges = value; }
    }

    public void addToEdge(EdgeData edge){ edges.Add(edge); }

}
