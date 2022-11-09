using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InventoryItemDEMO
{
    public Item data;
    public int stackSize;

    public InventoryItemDEMO(Item source)
    {
        data = source;
        AddToStack();
    }

    public void AddToStack()
    {
        stackSize++;
    }

    public void RemoveFromStack()
    {
        stackSize--;
    }
}
