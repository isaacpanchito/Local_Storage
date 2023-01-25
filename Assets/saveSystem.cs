using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class saveSystem : MonoBehaviour
{
    guardarnombre userscr;
    string savePath;
    saveData data;

    public void Awake()  {
        userscr=FindObjectOfType<guardarnombre>();
        savePath=Application.persistentDataPath+"/save.dat";
        if(!File.Exists(savePath)){
            saveData newData= new saveData();
            newData.username="jugador";
            saveGame(newData);
        }
        data=LoadGame();
    
    }

    void saveGame(saveData dataToSave){
        string JsonData=JsonUtility.ToJson(dataToSave);
        File.WriteAllText(savePath, JsonData);
    }

    saveData LoadGame(){
        string loadedData=File.ReadAllText(savePath);
        saveData datatoReturn=JsonUtility.FromJson<saveData>(loadedData);
        return datatoReturn;
    }
    public void saveGameButton(){
        string userN=userscr.clicksaveButton();
        data.username=userN;
        saveGame(data);
    }
    public void loadGameButton(){
        string userN=data.username;
        userscr.setNombre(userN);
    }


    public class saveData{
            public string username;
    }
}
