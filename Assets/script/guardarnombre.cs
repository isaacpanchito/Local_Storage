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

   
/* Este metodo regresa un valor tipo string */
    public string getName(){
        PlayerPrefs.SetString("name", inputNombre.text);
        Debug.Log("Bienvendio "+PlayerPrefs.GetString("name"));
        nombre=inputNombre.text;//Asignamos a una variable el valor que ingresa el usuario
        labelNombre.text=nombre;
        return nombre;//Regresamos la variable con el valor a guardar
    }
    public void setNombre(string userN){
       inputNomgreG.text=userN;
    }
}
