using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitialData : MonoBehaviour
{
    string[] problemas; //Arreglo que contendra las respuestas de la pirmera pregunta
    string  problema; //Variable que obtendra un elemento del arreglo
    public Text problemlabel; //Texto donde se mostrara el elemento
    public Text problemlabelG; //texto que carga el valor guardado localmente


    

    void Awake(){
        problemas= new string[20];//arreglo
        problemas[0]="1/2"; //indice y valores...
        problemas[1]="1/3";
        problemas[2]="2/8";
        problemas[3]="2/5";
        problemas[4]="4/7";
        problemas[5]="1/8";
        problemas[6]="7/4";
        problemas[7]="2/6";
        problemas[8]="6/6";
        problemas[9]="1/4";
        problemas[10]="10/8";
        problemas[11]="4/6";
        problemas[12]="4/5";
        problemas[13]="1/5";
        problemas[14]="1/9";
        problemas[15]="3/8";
        problemas[16]="3/3";
        problemas[17]="3/12";
        problemas[18]="7/10";
        problemas[19]="6/8";
        

    }

    /* metodo que asigna aleatoriamente un elemento del arreglo y muestra el valor al usuario */
    public void randomProblemas(){
        problema=problemas[Random.Range(0, 19)];//asigna valor
        problemlabel.text=problema;//asigna valor al label para que se muestre
    }
        //Este metodo devuelve el valor de la variable problema
    public string getProblemas(){
        return problema;
    }
    //Este metodo recibe un valor igual al de porblema y se lo asigna a un label para mostrarlo
    public void setProblemas(string problemaN){
        problemlabelG.text=problemaN;
    }
}
