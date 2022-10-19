using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Think of Scriptable Objects as a preset for another script to engage with. 
//For example, say you have an Enemy Controller but you want to use the same controller for different enemies, but those different enemies have differnt stats
//You would create a variable of type DEMO_Enemy and drag in the enemy preset you would like to use.

public enum EnemyDamageType //enums are great to use for readability, especially when you are creating a unique object that might want to have properties with names
{
    Slashing,
    Bludgeoning,
    Piercing,
    Ice,
    Fire,
    Lightning
}

//for quick access, you can add this at the beginning of your Scriptable Object script
//this will make it so that you can create new instances of this object, in this case an Enemy, from your project folder just as you can a script, or material
[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")] 
public class DEMO_Enemy : ScriptableObject
{
    //here you'll make every single variable that you might want to change up based on what type of enemy you are creating
    public string enemyName;
    public string enemyDescription;

    public Sprite enemyPortrait;

    public int enemyHealth;
    public int enemySpeed;

    public EnemyDamageType enemyDamageType;

    public string GetName() //you can also add simple methods to our Scriptable Object
    {
        Debug.Log("Enemy Name:" + enemyName);
        return enemyName;
    }
}
