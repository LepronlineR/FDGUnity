using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Graph))]
public class GraphBuilder : Editor
{
    public override void OnInspectorGUI(){
        EditorGUILayout.LabelField("Graph Builder", EditorStyles.boldLabel);
        DrawDefaultInspector();
        // Generate Graph
        if(GUILayout.Button("Generate Graph")){
            (target as Graph).generateGraph();
        }
    }
}
