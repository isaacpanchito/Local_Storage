using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guardarnombre : MonoBehaviour
{
    public InputField inputNombre;
    public Text inputNomgreG;
    public Text labelNombre;
    string nombre;

   

    public string getName(){
        PlayerPrefs.SetString("name", inputNombre.text);
        Debug.Log("Bienvendio "+PlayerPrefs.GetString("name"));
        nombre=inputNombre.text;
        labelNombre.text=nombre;
        return nombre;
    }
    public void setNombre(string userN){
       inputNomgreG.text=userN;
    }
}
