using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questionSelector : MonoBehaviour
{
    InitialData problemascr;
     
     public Text problemlabel;
     public Transform pos;

     public GameObject[]objectsToInstantiate;
   
    void awake(){
        problemascr=FindObjectOfType<InitialData>();
      
    }


    void Start()
    {
        instantiateObject();
    }

    void instantiateObject(){
         int n= Random.Range(0,objectsToInstantiate.Length);
         Debug.Log("Objeto");
         Instantiate(objectsToInstantiate[n], pos.position, objectsToInstantiate[n].transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
