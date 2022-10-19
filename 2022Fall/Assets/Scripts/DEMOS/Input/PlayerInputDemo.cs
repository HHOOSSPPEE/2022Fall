using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputDemo : MonoBehaviour
{

    public KeyCode jumpKey; //KeyCode can be used as a variable so that it can be changed for quick iteration. Also a great way to handle remapping

    //typically, you want any player inputs kept in Update as they are likely needed to be more precise with the speed the game is running at
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift)) //you can have multiple inputs for the same action
        {
            //character crouch
        }


        if (Input.GetKeyDown(jumpKey)) //you can replace with KeyCode. with a variable of type KeyCode for quick adjustments!
        {
            //character jump
        }
    }
}
