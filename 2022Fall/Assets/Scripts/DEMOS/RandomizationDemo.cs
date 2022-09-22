using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizationDemo : MonoBehaviour
{

    void Start()
    {
        //much of your randomization will utilizae Random.Range. The first number in the () is the min, and the second value is the max. From there, it will generate a number between those values

        float randomFloat = Random.Range(-5.0f, 5.0f); // randomize between -5, 5, but with 1 decimal place
        int randomInt = Random.Range(-5, 5); //randomize between -5, 5, not decimal places

        //REMINDER: the max is very rarely randomized. If you need to choose a number from 1-10, you'll need to randomize 1,11, and then have an edge case test for the very unlikely case that it lands on 11 
        //this is because Random.Range spits out a float, even when you are assigning it to an int. So. For every number it will have decimal places that cause it to round down to that number, as per how integers work. Therefore, the final number will never have decimal places and any varation of that number will neer come up
        //Basically: 1.1, 1.45, 1.99 -> will all round down to 1. But the upper limit of 11 can ONLY generate 11.0, making it almost impossibly small to hit

        //here I'll add my test
        bool valid = false;

        while (valid == false)
        {
            int randomInt2 = Random.Range(1, 11);
            
            if(randomInt2 >= 11) //if it managed to roll 11, make sure wedon't escape the loop and make it generate a new number
                valid = false;
            else
                valid = true;
        }

        //often you won't need this test, but if you need to randomly choose an index without an out of index error, you'll wanna add something like this in

    }


}
