using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

[System.Serializable] //include this at the top to make it savable as a file
public class SavingData_DEMO //we do not use : MonoBehaviour because this will not be a component on an object
{
    //you will list every variable that you want to save

    public int playerLevel;
    public float[] playerPosition; //here we are planning to save a Vector3, but because Vector3 isn't really a data type outside of Unity, we need to convert it to something else
    
    //Here we need to make a way our script can get the data from the objects we want to save, such as the player
    public SavingData_DEMO(SavingDataPlayer_DEMO player) //this is a Constructor. A Constructor for a class is essentially a setup function otherscripts can call
    {
        playerLevel = player.level;

        playerPosition = new float[3]; //here I am breaking up my player's position into individual floats so I can save
        playerPosition[0] = player.transform.position.x;
        playerPosition[1] = player.transform.position.y;
        playerPosition[2] = player.transform.position.z;
    }

}
