using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventorySystemDEMO : MonoBehaviour
{
    private Dictionary<Item, InventoryItemDEMO> _itemDictionary;
    public List<InventoryItemDEMO> inventory;

    public GameObject[] canvasItems;

    private void Start()
    {
        inventory = new List<InventoryItemDEMO>();
        _itemDictionary = new Dictionary<Item, InventoryItemDEMO>();
    }

    public void Add(Item referenceData)
    {
        if(_itemDictionary.TryGetValue(referenceData, out InventoryItemDEMO value))
        {
            value.AddToStack();
            UpdateCanvas(referenceData);
        }
        else
        {
            InventoryItemDEMO newItem = new InventoryItemDEMO(referenceData);
            inventory.Add(newItem);
            _itemDictionary.Add(referenceData, newItem);
        }


    }

    public void Remove(Item referenceData)
    {
        if (_itemDictionary.TryGetValue(referenceData, out InventoryItemDEMO value))
        {
            value.RemoveFromStack();

            if(value.stackSize == 0)
            {
                inventory.Remove(value);
                _itemDictionary.Remove(referenceData);
            }
        }

    }

    void UpdateCanvas(Item item)
    {

    }
}
