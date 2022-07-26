using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ImageSearch : MonoBehaviour
{
    //private string query = "ratatouille";

    void Start(){
        //StartCoroutine(GetRequest("GET https://www.googleapis.com/customsearch/v1?key=AIzaSyDCg1nyeDqMCrpaVB_YZ9VTyM9gVKJQffs&cref=&q=" + query));
        StartCoroutine(GetRequest("https://www.sidsavage.com/images/prods/popup/P8889.jpg"));
    }
    //KEY: AIzaSyDCg1nyeDqMCrpaVB_YZ9VTyM9gVKJQffs


    IEnumerator GetRequest(string uri){
        using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture(uri)){
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
