using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementDemo : MonoBehaviour
{
    #region Movement Variables
    public float movementSpeed = 0.1f; //the speed our character moves at. It will multiplied to our movement to increase/decrease against the default 1 unit

    private Rigidbody2D _rigidBody; //access the rigidbody. Rigidbody is a component that tells Unity hey I want this gameObject to be part of physics calculations. It has a lot of built in movement scripts for us to use!
    private Vector2 _movement; //A Vector2 is an (x,y) coordinate. It, along with Vector3 (x,y,z), is typically used for positional data.

    #endregion


    // You can assign private variables here in start!
    void Start()
    {
        _rigidBody = gameObject.GetComponent<Rigidbody2D>(); //assign the _rigidbody by search the gameObject this script is attached to and finding a component on it called Rigidbody2D
    }

    void Update()
    {
        //Unity has GetAxisRaw built in for us so for basic 2D movement we may as well use it!
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate() //We use FixedUpdate for any movement/physics because we don't want those interactions to be frame dependant - slowing down and speeding up depending on our hardware
    {
        _rigidBody.MovePosition(_rigidBody.position + _movement * movementSpeed); //MovePosition is a built-in method for rigidbody2D that takes in a Vector2 to move to, taking care of the movement for use rather than just teleporting to a new position
        //it takes our starting position and adds how much to move in each direction depending on what keys we press. That amount to move is modified by our speed. Ie, if I wanted to move up, pressing W might say "hey, add 1 to the y axis" that'll then be modified down to .1f by our movement speed. 
        
    }
}
