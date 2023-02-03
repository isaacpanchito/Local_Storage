using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guardarnombre : MonoBehaviour
{
    public InputField inputNombre;
    public InputField inputContrasena;
    
    string nombre;
    string contrasena;

   
/* Este metodo regresa un valor tipo string */
    public string getName(){
       /*  PlayerPrefs.SetString("name", inputNombre.text);
        Debug.Log("Bienvendio "+PlayerPrefs.GetString("name")); */
        nombre=inputNombre.text;//Asignamos a una variable el valor que ingresa el usuario
    
        return nombre;//Regresamos la variable con el valor a guardar
    }
    public string getContrasena(){
        contrasena=inputContrasena.text;
        return contrasena;
    }

    public void setNombre(string userN){
    
    }
}
