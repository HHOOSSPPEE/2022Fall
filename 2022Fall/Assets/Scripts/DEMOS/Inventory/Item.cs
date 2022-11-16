using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item Data")] //this will make it soyou can create these in your asset folder
public class Item : ScriptableObject
{
    //list everything you will need to access from the inventory - do not worry about item functionality here
    public string itemName;
    public string itemDescription;
    

    public Sprite itemIcon;

    //public GameObject itemPrefab; //this might be useful if you need to grab the object out of this reference
    //public int itemID; //might be useful if you want to organize based on ID - this is something you'll want to plan for outside of your project, such as in a spreadsheet
    
}
