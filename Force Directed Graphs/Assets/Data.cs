using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data {

    public Data(){
        data = new List<string[]>();
    }

    public string[] fields;     // Source, Target, Type, id, weight
    public List<string[]> data; // Addam-Marbrand,Brynden-Tully,Undirected,0,3...

    public void printList(){
        Debug.Log("================== FIELD ==================");
        foreach(string s in fields){
            Debug.Log(s);
        }
        Debug.Log("================== DATA ==================");
        foreach(string[] line in data){
            foreach(string s in line){
                Debug.Log(s);
            }
        }
    }

    public int getTotalPoints(){
        return data.Count;
    }

    public Pair<int, int> evaluateMinMaxWeights(){
        int save = 0;
        foreach(string str in fields){
            if(str.Equals("weights")){
                break;
            }
            save += 1;
        }
        int max = int.MaxValue;
        int min = data[0][save];
        foreach(string[] line in data){
            foreach(string str in line[save]){
                
            }
        }
    }

}
