using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guardarnombre : MonoBehaviour
{
    public InputField Nombre;
    public Text labelNombre;
    string nombrere;

    public string clicksaveButton(){
        PlayerPrefs.SetString("name", Nombre.text);
        Debug.Log("Bienvendio "+PlayerPrefs.GetString("name"));
        nombrere=Nombre.text;
        return nombrere;
    }
    public void setNombre(string userN){
        labelNombre.text=userN;
    }
}
