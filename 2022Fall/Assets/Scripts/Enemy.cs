using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyTypes
{
    Melee,
    Magic,
    Archer

}

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy 2")]
public class Enemy : ScriptableObject
{
    public string enemyName;
    public int enemyHealth;
    public EnemyTypes enemyType;

    public Sprite enemySprite;
}
