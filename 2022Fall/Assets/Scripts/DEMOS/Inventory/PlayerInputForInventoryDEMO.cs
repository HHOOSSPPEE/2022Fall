using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputForInventoryDEMO : MonoBehaviour 
{
    public GameObject inventoryUI;
    private bool _isOpen;

    public InventorySystemDEMO inventory;

    private bool _isTouchingItem;
    private Item _touchingItem;

    private void Start()
    {
        inventoryUI.SetActive(false);
        _isOpen = false;
        _isTouchingItem = false;
    }

    void Update() //open the inventory if right key press
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (_isOpen == false)
            {
                inventoryUI.SetActive(true);
                _isOpen = true;
            }
            else if (_isOpen == true)
            {
                inventoryUI.SetActive(false);
                _isOpen = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && _isTouchingItem == true)
        {
            inventory.Add(_touchingItem);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Cat")
        {
            _touchingItem = collision.gameObject.GetComponent<ItemManagerDEMO>().item;
            _isTouchingItem = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _isTouchingItem = false;
    }
}
