using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveLoadManager : Singleton<SaveLoadManager>
{
    SerializedData mydata = new SerializedData();

    public void SaveData()
    {
        
        mydata.ser_score = GameData.Score;
        mydata.ser_health = GameData.PlayerHealth;

        string jsonToSave = JsonUtility.ToJson(mydata);
        Debug.Log(jsonToSave);
        //Debug.Log(Application.persistentDataPath);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/SuperCannonData.json", jsonToSave);
    }


    public void LoadData()
    {
        

        if (File.Exists(Application.persistentDataPath + "/SuperCannonData.json"))
        {
            string loadedJson = System.IO.File.ReadAllText(Application.persistentDataPath + "/SuperCannonData.json");
            Debug.Log(loadedJson);
            //Debug.Log(Application.persistentDataPath);
            mydata = JsonUtility.FromJson<SerializedData>(loadedJson);
            GameData.Score = mydata.ser_score;
            GameData.PlayerHealth = mydata.ser_health;
        }
    }


}
