using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyManager : MonoBehaviour
{
    public Enemy enemyType;

    public string enemyName;
    public int enemyHealth;

    public Sprite enemySprite;

    public void LoadInfo()
    {
        enemyName = enemyType.enemyName;
    }
    
}
