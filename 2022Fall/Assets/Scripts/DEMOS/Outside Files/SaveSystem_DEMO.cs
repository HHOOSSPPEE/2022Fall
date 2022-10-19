using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; //include this to let your script interat with files on your operating system
using System.Runtime.Serialization.Formatters.Binary; //we are including this so that we can save in a binary file format, making our save data harder to tamper with

public static class SaveSystem_DEMO //I have made this class static just so that we don't accidentally have multiple instances of it. You don't want multiple save systems firing off!
{

    //making this static because you already have a static class, and now you can call this from anywhere without a reference!
    public static void SaveGame(SavingDataPlayer_DEMO player) //make sure this function calls everything your SavingData_DEMO constructor does!
    {
        BinaryFormatter formatter = new BinaryFormatter(); //we need to make our binary formatter for us to use
        string path = Application.persistentDataPath + "/SaveData.save"; //we can Unity's persistantDataPath to generate where this folder will end up, so that we don't have to deal with directory weirdness
                                                                         //and at the nd of the string we can add a subdirectory with our file name
                                                                         //because we are converting it to binary, it can have any file extension, so i just type in .save, but you can make it whatever

        FileStream stream = new FileStream(path, FileMode.Create); //now we need to open up a file stream. This is like opening a door between our game and your computer's file system

        SavingData_DEMO data = new SavingData_DEMO(player); //now we can use our constructor and feed it the data we need to save and format
        formatter.Serialize(stream, data); //convert the data we just created using out constructor into binary and serialize, or save it to our stream, which is out open door leading to the file path we made
        stream.Close(); //now we close the door and prevent anything bad from happening. ALWAYS CLOSE YOUR FILESTREAMS!!
    }


    public static SavingData_DEMO LoadGame() //instead of void, we want to return our data to use in our game
    {
        string path = Application.persistentDataPath + "/SaveData.save"; //load up our file location
        if (File.Exists(path)) //check if something is there, can't load what we haven't saved
        {
            //start off by setting up a lot of the same stuff
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open); //do .Open, not .Create
            SavingData_DEMO data = formatter.Deserialize(stream) as SavingData_DEMO; //we now deserialize, the opposite of serializing, our stream and assigning it to our data
                                                                                     // you will need to cast it, the "as SavingData_DEMO", to tell your script what kind of data it is getting is

            stream.Close();
            return data;
        }
        else //throw an error
        {
            Debug.LogError("No save data found.");
            return null;
        }
    }
}
