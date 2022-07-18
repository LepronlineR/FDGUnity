using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// the edge data is an edge that has the ID of the node this edge is connected to
// i.e. (1) -> (2), EdgeData for (1) = -> (2) -- otherID = (2), weight = weight of ->

public class EdgeData {

    public EdgeData(NodeData otherNode, string weight){
        this.otherNode = otherNode;
        this.weight = Int32.Parse(weight);
    }

    // info
    NodeData otherNode;
    int weight;

    public NodeData Node {
        get { return otherNode; }
        set { otherNode = value; }
    }

    public int Weight {
        get { return weight; }
        set { weight = value; }
    }

}

