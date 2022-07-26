using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;

public class ImageSearch : MonoBehaviour
{
    private string query = "ratatouille";
    private string APIKEY = "AIzaSyDCg1nyeDqMCrpaVB_YZ9VTyM9gVKJQffs";
    private string SEKEY = "d3adb34127ae42013";

    void Start(){
        //StartCoroutine(GetRequest("GET https://www.googleapis.com/customsearch/v1?key=AIzaSyDCg1nyeDqMCrpaVB_YZ9VTyM9gVKJQffs&cref=&q=" + query));
        //StartCoroutine(GetRequest("https://www.sidsavage.com/images/prods/popup/P8889.jpg"));
        var url = "https://www.googleapis.com/customsearch/v1?key=" + APIKEY + "&cx=" + SEKEY + "&q=" + query + "&searchType=image";
        
        
        StartCoroutine(GetRequest(url));
        //Debug.Log(url);
    }
    //KEY: AIzaSyDCg1nyeDqMCrpaVB_YZ9VTyM9gVKJQffs

    void SubmitRequest(string query){

    }

    [System.Serializable]
    public class URLUtility {
        public string link;
    }

    [System.Serializable]
    public class ItemsUtility {
        public URLUtility[] items;
    }

    public ItemsUtility iu = new PlayList();

    IEnumerator GetRequest(string url){
        // retrieve info + parse json file
        string imgurl = "";
        using (UnityWebRequest uwri = UnityWebRequest.Get(url)){
            yield return uwri.SendWebRequest();
            if (uwri.result != UnityWebRequest.Result.Success){
                Debug.Log(uwri.error);
            } else {
                // Get downloaded asset bundle
                var json = uwri.downloadHandler.text;
                var parse = JsonUtility.FromJson<>
                imgurl = uwri.downloadHandler.text;
                Debug.Log(imgurl);
            }
        }

        using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture(imgurl)){

            yield return uwr.SendWebRequest();
            if (uwr.result != UnityWebRequest.Result.Success){
                Debug.Log(uwr.error);
            } else {
                // Get downloaded asset bundle
                var texture = DownloadHandlerTexture.GetContent(uwr);

                this.GetComponent<MeshRenderer>().material.mainTexture = texture;
            }
        }
    }
}
