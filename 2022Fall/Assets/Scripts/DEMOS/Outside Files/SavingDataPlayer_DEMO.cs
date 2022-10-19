using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingDataPlayer_DEMO : MonoBehaviour
{
    //this script would typically be my player controller script, but for this demo I am just demonstrating how you would grab information off other scripts to save
    public int level = 10;

    //these do not need to be on the player script, you might have them on a saving manager or game manager, but for this demo they can be here. 
    //However you want these functions triggered, either at the start of a scene, on a button press, or every 30 seconds, you'll want these following functions sitting on that script
    #region Player Saving

    public void SavePlayer()
    {
        SaveSystem_DEMO.SaveGame(this); //"this" refers to this script, not necessarily this gameObject, which you represent with, well, "gameObject"
                                        //so by saying "this" we are feeding in this particular instance of SavingDataPlayer_DEMO, which we need to call .SaveGame()
    }

    public void LoadPlayer()
    {
        SavingData_DEMO data = SaveSystem_DEMO.LoadGame(); //now that we've loaded the data, we can grab the variables off of it and assign them to our player

        //player level
        level = data.playerLevel; 

        //player position
        Vector3 position;
        position.x = data.playerPosition[0];
        position.y = data.playerPosition[1];
        position.z = data.playerPosition[2];
        transform.position = position;
    }

    #endregion
}
