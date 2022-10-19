using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus; //be sure to include Fungus

public class FungusControlDemo : MonoBehaviour
{

    //If you need to trigger a series of blocks through code, you will need to make a public BlockReference
    public BlockReference targetBlock;
    //Say this script is on a character. On that character object, you'll first drag the Flowchart into this variable which will be visable in the inspector
    //You will then be able to choose from a dropdown menu what block to start at (be sure to rename you blocks so that this is easy to find!)
    //the target block you want to trigger with code will need to have its "Execute on Event" set to <None>

    void Start()
    {
        targetBlock.Execute(); //now you can execute with code. I have it here in Start() but it can be triggered with a key press, an OnCollisionEnter2D, or really any
                                    //other way you would like this event triggered
    }


}
