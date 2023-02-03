using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class saveSystem : MonoBehaviour
{
    /*Iniciar variable tipo script*/
    guardarnombre userscr;
    InitialData problemascr;/*Iniciar variable string para guardar la ruta del archivo que guardara  todo*/
    string savePath; /* Esta variable se crea a partir de una clase creada "SaveData" */

    saveData data;

    public void Awake(){/* En awake buscamos el obejeto de tipo script "nombre del script" */
        
        userscr=FindObjectOfType<guardarnombre>();
        problemascr=FindObjectOfType<InitialData>();  /* Aqui asignamos la ruta */
        savePath=Application.persistentDataPath+"/save.dat"; //"Save.dat" puede ser cualquier nombre y terminacion. Al final se creara un archivo de texto
       
        if(!File.Exists(savePath)){ /* Aqui preguntamos si existe la ruta */
            /* Si no existe, creará un archivo nuevo */
            saveData newData= new saveData();//Se crea un nuevo objeto tipo saveData
            newData.username="jugador"; //Le asignamos un valor a la propiedad username de newData
            newData.problem="1/2";//Le asignamos un valor a la propiedad username de newData
            newData.contrasena="secret";
            saveGame(newData);//Llamamos el metodo saveGame con nuestra variable newData para que guarde el archivo nuevo
        }
        /* data inicializa LoadGame, "data == informacion del archivo local"
        LoadGame regresa el/los valores que se almacenara/n en data */
        data=LoadGame();
    
    }
    
    /* En este metodo lo declaramos pidiendo de entrada una variable de tipo SaveData */
    void saveGame(saveData dataToSave){
        string JsonData=JsonUtility.ToJson(dataToSave); //Aqui asignamos a la variable JsonData la converison json de nuestra variable de tipo saveData
        File.WriteAllText(savePath, JsonData);//Con esto escribimos en el archivo local. Los parametros son(ruta del archivo, Valores)
    }

    /* El metodo Load game es un metodo tipo saveData
     */
    saveData LoadGame(){
        string loadedData=File.ReadAllText(savePath);//En una variable "leemos todo lo que este en el archivo". Los parametros de ReadAllText es (Ruta del archivo)
        saveData datatoReturn=JsonUtility.FromJson<saveData>(loadedData);//En una variable tipo saveData convertimos con Json todo el texto que habia
        return datatoReturn;        //return nos regresa la variable y su valor/es
    }

    /* este metodo reune los datos de otros scripts y los junta para llevarlos al metodo saveGame */
    public void saveGameButton(){
        string userN=userscr.getName();//En esta variable asignamos el valor que se obtiene de otro script que manda el valor deseado
        /* tipo|nombrevariable|objetoScript|metodo */
        string contrasenaN=userscr.getContrasena();

        data.username=userN;//En el objeto data, en la propiedad username se asigna el valor que recibio userN
        
        data.contrasena=contrasenaN;
        saveGame(data);//Ejecutamos el metodo SaveGame con data, que tiene todos los datos que recibimos
    
    }
    /* Este metodo carga los datos guardados localmente y los regresa */
    public void loadGameButton(){
        string userN=data.username;//Creamos una variable con el valor del objeto data.username
       
        string contrasenaN=data.contrasena;
       /*problemascr.setProblemas(problemN);desde el objeto script llamamos un metodo con el parametro que enviaremos
        userscr.setNombre(userN); objetoScript|Metodo a llamar|(valor que enviamos)*/ 
    
    }

    /* Esta clase saveData contendra los campos que guardaremos
        Los objetos tipos saveData tendran todas las variables declaradas en esta clase
    */
    public class saveData{
            public string username;
            public string problem;
            public string contrasena;
    }
}
