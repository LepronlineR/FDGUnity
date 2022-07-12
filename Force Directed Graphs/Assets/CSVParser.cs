using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSVParser {
    public class Data {

        public Data(){
            data = new List<string[]>();
        }

        public string[] fields;     // Source, Target, Type, id, weight
        public List<string[]> data; // Addam-Marbrand,Brynden-Tully,Undirected,0,3...
    }

    public Data parseCSV(string[] lines){
        Data d = new Data();

        d.fields = lines[0].Split(',');
        for(int x = 1; x < lines.Length; x++){
            d.data.Add(lines[x].Split(','));
        }
        return d;
    }
}
