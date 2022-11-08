using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beaker : MonoBehaviour
{
    public int maxVolume;
    public int currentVolume;

    public SpriteRenderer[] segments;

    public bool isBeingMoved; //make this true if being dragged

    public Vector3 defaultPosition;

    private void DisplaySegments()
    {

        for (int i = 0; i < segments.Length; i++)
        {
            if (i <= currentVolume)
            {
                segments[i].enabled = true;
            }
            else
            {
                segments[i].enabled = false;
            }
        }
    }
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Beaker")
        {
            Beaker to;
            to = collision.gameObject.GetComponent<Beaker>();

            if (to.currentVolume + currentVolume > to.maxVolume)
            {
                int temp = to.currentVolume + currentVolume; // 9 = 4 + 5
                currentVolume = temp - to.maxVolume; // 1 = 9 - 8

                to.currentVolume = to.maxVolume; // 8 = 8

            }
            else
            {
                to.currentVolume = to.currentVolume + currentVolume;
            }
        }
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isBeingMoved == true)
        {
            if (collision.gameObject.tag == "Beaker")
            {
                Beaker to;
                to = collision.gameObject.GetComponent<Beaker>();

                if (to.currentVolume + currentVolume > to.maxVolume)
                {
                    int temp = to.currentVolume + currentVolume; // 9 = 4 + 5
                    currentVolume = temp - to.maxVolume; // 1 = 9 - 8

                    to.currentVolume = to.maxVolume; // 8 = 8

                }
                else
                {
                    to.currentVolume = to.currentVolume + currentVolume;
                }
            }
        }
    }



    void ReleaseObject(GameObject objSelected) //release mousebutton, put this in your drag and drop script not here
    {
       objSelected.gameObject.transform.position = defaultPosition;
       isBeingMoved = false;
    }

}
