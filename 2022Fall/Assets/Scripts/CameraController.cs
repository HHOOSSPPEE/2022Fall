using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//!! If your camera is stuttering while trying to follow the target, go to the target's rigidbody and change the interpolate value from none to interpolate
public class CameraController : MonoBehaviour
{
    public Transform target; //whatever our camera tracks. This can be changed by changing what transform this is linked to
    public float smoothSpeed = 0.125f; //how much our camera lags behind the target
    public Vector3 offset; //even in a 2D game, our camera technically exists in 3D space, so be sure to use Vector3's

    private Vector3 _velocity = Vector3.zero; //Vector3.zero essentially initializes a Vector3 as (0,0,0)

    public float limitLeft, limitRight, limitBottom, limitTop; //these are as far as the camera can go in each direction in Unity units
    
    void Start()
    {
        if(target == null) //if we never assigned a target in our inspector in Unity, find the player
        {
            target = GameObject.FindGameObjectWithTag("Player").transform; 
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Transform currentTarget = target; //at the start of our LateUpdate, the camera will try to move to our target
        Vector3 desiredPosition = currentTarget.position + offset; //we calculate a desired offset to this movement utilizing the offset we set above

        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref _velocity, smoothSpeed); //we use smoothdamp instead of lerp because our target is likely moving (lerp can get jittery) and it, over time, calculates a smooth movement from our current to our desired position


        //boundaries 
        transform.position = new Vector3(Mathf.Clamp(smoothedPosition.x, limitLeft, limitRight), Mathf.Clamp(smoothedPosition.y, limitBottom, limitTop), smoothedPosition.z); //we now adjust our calculation to make sure we don't move out of the boundaries we've set. IE, if our calculated smoothPosition is 11 on the x axis, but we have a rightLimit of 10, it will automatically bring 11 down to 10
    }

    public void ChangeTarget(GameObject newTarget) //we make this public so that other scripts can feed in new game objects for our camera to track
    {
        target = newTarget.transform;
    }
}
