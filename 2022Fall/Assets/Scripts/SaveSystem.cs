using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{

    public static void SaveGame(SavingPlayer player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/SaveData.save";

        FileStream stream = new FileStream(path, FileMode.Create);

        SavingData data = new SavingData(player);
        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static SavingData LoadGame()
    {
        string path = Application.persistentDataPath + "/SaveData.save";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            SavingData data = formatter.Deserialize(stream) as SavingData;

            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("No save data found.");
            return null;
        }
    }

}
