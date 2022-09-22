using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayAndListDemo : MonoBehaviour
{
    //arrays cannot expand but they are faster for the computer to search through - think of an array as a box with so many slots for markers - you can't suddenly add more
    public string[] names = new string[10]; //I have created an array of strings called names, where I would presumably hold names. It can hold up to 10 names addressed 0-9.

    //lists can expand as needed but as they bigger, or carry more complex variable types, they get slower - think of a list as a grocery list that gets longer as you remember things you need to buy
    public List<string> lastNames = new List<string>(); //I have created a list of strings called lastNames, to store lastNames. I didn't define a size because I don't need to

    //typically, wherever possible you'll want to use arrays because they are more performant
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        //you can access the values of an array/list by calling their address
        //REMEMBER: address counting starts at 0. The first element of an array/list is always 0, the second is 1, and so on.

        string name1 = names[0]; //I have set my variable name1 to whatever string is sitting in the first slot of my array names[]
        string lastName1 = lastNames[0]; //getting values from lists works the same way!

        //we can manipulate the values of our array/list elements the same way we can any other variable, it just has different syntax
        names[0] = "Merry"; //the first element of names[] now says Merry. If I were to call names[0] elsewhere it is the same as using "Merry"

        //count through an array
        //we can iterate, or count, through our arrays/lists using for loops
        for(int i = 0; i < names.Length; i++) //remember, start at 0; count for the length of the array/list using .Length
        {
            Debug.Log(names[i]); //each iteration of the array i will go up one. So the first time i is 0 and we call names[0]. The second time i is 1, so we call names[1], and so on.
        }
    }

}
