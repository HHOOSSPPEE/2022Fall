using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Structs are more lightweight versions of classes - think of them as ways to store a list of attributes a more complex script might use!
//Structs can sit on their own scripts or other scripts - so long as they are public, other scripts can access them

public struct NPC
{
    public int level;
    public string name;
}

public struct Pants 
{
    public string material;
    public int size;
    public Color color;
}

//So if you find you want to quickly group data together under a certian name, but don't need something like a scriptable object or new class, struct is probably the right
//fit for you

public class ClassAndStructDEMO : MonoBehaviour //you are likely familiar with classes, it generates one here when we make a script
{
    //So say we are making an NPC script. We can now make instances of our above structs and fill in the info in code depending on how we want to use 
    //something like this.

    private NPC _npcName = new NPC();
    private Pants _npcPants = new Pants();

    public string npcName;

    private void Start() //we would assign our values here in start, either hardcoded or via a variable we grabbed from Unity
    {
        _npcName.name = npcName;
        _npcPants.size = 16; 
    }
    
}
