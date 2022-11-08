using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeakerManager : MonoBehaviour
{

    private void Pour(Beaker to, Beaker from)
    {
        if(to.currentVolume + from.currentVolume > to.maxVolume)
        {
            int temp = to.currentVolume + from.currentVolume; // 9 = 4 + 5
            from.currentVolume = temp - to.maxVolume; // 1 = 9 - 8

            to.currentVolume = to.maxVolume; // 8 = 8
            
        }
        else
        {
            to.currentVolume = to.currentVolume + from.currentVolume;
        }
    }

}
