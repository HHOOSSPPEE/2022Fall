using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesDemo : MonoBehaviour
{
    //common variable types
    int number = 1; //int, or integer is a number that doesn't have a decimal place. All decimals will be cut off when converting from float (ie, 3.1 -> 3, but 3.99 -> 3 too, regardless of it almost being 4)
    float decimalNumber = 1.1f; //float is a number with a decimal place. Be sure to follow all floats with f to denote when the decimal places end
    bool trueOrFalse = true; //bool, or boolean, is a true or false value, used to determine, well, if something is true or false

    char letter = 'c'; //char, or character is a single character you might see on your keyboard. It could be c, or %, or 5. However, be aware char 5 and int 5 are distinctly different. As far as the computer is concerned anything that is a char is a picture and it can't compare that to a nuamber value. Must be declared in ''
    string word = "cat"; //string, or string of characters, is a series of characters used to form a phrase or word. Must be declared with ""

    public string firstName; //public varibles can be accessed by other scripts as well as be editted in our inspector when this script sits on an object
    private string _secretName; //private scripts can only be modified from within this script. While not neccary, to keep you code nice I recommend putting _ in front of an private variable names
    //by default, all variables without public or private in front are private in Unity C#, though it is always good to get into the habit of writing it anyway

    public static int score; //a static variable is the same everywhere, regardless of how many instances of this script there is. Good for things that there should never be multiple values of but multiple scripts need to modify, such as player health or game score. Use them sparingly, though.

    //you can also make variables based off of the names of components/scripts you've made:
    private Rigidbody _rigidBody;
    private PlayerController _playerController;

    void Start()
    {
        //notice how I made those last two variables private? While we can drag and drop them in our inspector, in order to keep them private we can search for them and assign them in start. This is also a good check to have in case you forgot to assign them.
        _rigidBody = gameObject.GetComponent<Rigidbody>(); //I go onto my gameObject, the object this script is attached to, and GetComponent the component I need

        _playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>(); //you can also find certain instances of a script and assign them here using tags, which you set at the top of the inspector of the object
                                                                                                         //we are searching for something with the tag "Player", and then grabbing its PlayerController component, rather than grabbing a component off of this gameObject

        //REMEMBER: gameObject refers to the game object this code is attached to, whereas GameObject, with a capital G, refers to other game objects

        //I can declare variables within functions, but I cannot access them in other functions unless I explicitly feed them into another function

        int temp = 1; //only exists and useable in Start()

        if(trueOrFalse == true)
        {
            int superTemp = 2; //superTemp only exists within this if statement within Start();

        }
    }


}
