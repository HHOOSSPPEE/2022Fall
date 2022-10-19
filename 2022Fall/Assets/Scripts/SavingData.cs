using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SavingData
{
    public int playerLevel;
    public float[] playerPosition;

    public SavingData(SavingPlayer player)
    {
        playerLevel = player.level;

        playerPosition = new float[3];
        playerPosition[0] = player.transform.position.x;
        playerPosition[1] = player.transform.position.y;
        playerPosition[2] = player.transform.position.z;
    }

}
