using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questionSelector : MonoBehaviour
{
    InitialData problemascr;
     
    public Text problemlabel;
    public Transform pos;
    public string[] problemasTry;
    public string[] problemas; //Arreglo que contendra las respuestas de la pirmera pregunta
    string  problema; //Variable que obtendra un elemento del arreglo
    public GameObject ButtonstoInstantiate;
    public GameObject[]objectsToInstantiate;
    public int n;
   
    void awake(){ 
       
        problemascr=FindObjectOfType<InitialData>();
      
    }
    void Start()
    {   
        randomButtons();
        
    }

    public void instantiateObject(){
        Debug.Log("Objeto"+n);
        
        
    }
    public void randomButtons(){
        problemas= new string[20];
        problemasTry= new string[4];
        problemas[0]="1/2"; 
        problemas[1]="1/3";
        problemas[2]="2/8";
        problemas[3]="2/5";
        problemas[4]="4/7";
        problemas[5]="2/6";

        problemasTry[0]=""; 
        problemasTry[1]="";
        problemasTry[2]="";
        problemasTry[3]="";
        int m=Random.Range(0,4);
        for(int i=0;i<problemasTry.Length;i++){
            n= Random.Range(0,objectsToInstantiate.Length);
            problemasTry[i]=problemas[n];
            Debug.Log(i);
            GameObject buttonFrac= Instantiate(ButtonstoInstantiate,  new Vector2(i*180,100), pos.transform.rotation) as GameObject;
            buttonFrac.name = ("button"+i.ToString());
            GameObject.Find("button"+i.ToString()).GetComponentInChildren<Text>().text = problemasTry[i];
            buttonFrac.transform.parent=pos.transform;
            if(i==m){
                GameObject imagenFrac = Instantiate(objectsToInstantiate[n], pos.position, pos.transform.rotation) as GameObject;
                imagenFrac.transform.parent=pos.transform;
            }
        }
        //instantiateObject();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
