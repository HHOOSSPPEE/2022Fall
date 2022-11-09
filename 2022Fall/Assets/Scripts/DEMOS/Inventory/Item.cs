using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item Data")]
public class Item : ScriptableObject
{
    //list everything you will need to access from the inventory - do not worry about item functionality here
    public string itemId;
    public string itemName;
    public string itemDescription;

    public Sprite itemIcon;
    
}
