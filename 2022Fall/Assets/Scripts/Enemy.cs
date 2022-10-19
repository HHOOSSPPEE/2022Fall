using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum EnemyDamageTypes
{
    Sladhing,
    Bludgeoning,
    Piercing,
    Magic
}
[CreateAssetMenu(fileName= "New Enemy", menuName = "New Enemy")]
public class Enemy : ScriptableObject
{
    public string enemyName;
    public string enemyDescription;

    public Sprite enemyPortrait;

    public int enemyHealth;
    public float enemySpeed;

    public EnemyDamageTypes damage;
}
