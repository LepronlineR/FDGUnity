using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSVParser {

    public Data parseCSVPath(string path){
        string[] lines = File.ReadAllLines(Application.dataPath + path);
        Data d = new Data();
        d.fields = lines[0].Split(',');
        for(int x = 1; x < lines.Length; x++){
            d.data.Add(lines[x].Split(','));
        }
        return d;
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
