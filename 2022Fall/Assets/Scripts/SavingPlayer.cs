using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingPlayer : MonoBehaviour
{
    public int level = 10;

    public void SavePlayer()
    {
        SaveSystem.SaveGame(this);
    }

    public void LoadPlayer()
    {
        SavingData data = SaveSystem.LoadGame();

        level = data.playerLevel;

        Vector3 position;
        position.x = data.playerPosition[0];
        position.y = data.playerPosition[1];
        position.z = data.playerPosition[2];

        transform.position = position;
    }
}
