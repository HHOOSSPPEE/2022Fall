using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithMouse : MonoBehaviour
{
    bool pressed;
    private Rigidbody _rigidBody;
    public float movementSpeed = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        pressed = false;
        _rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pressed = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            pressed = false;
        }

        if(pressed == true)
        {
            // this.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
            //     Input.mousePosition.y, Mathf.Clamp(Input.mousePosition.z, 4, 8)));


            //get the difference of current x,y vs mouse x,y and put it in movement

            Vector3 currentPosition = new Vector3(); //getting my current position
            currentPosition = transform.position;

            Vector3 newPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, //use mouseposition to find newposition
                 Input.mousePosition.y, Mathf.Clamp(Input.mousePosition.z, 4, 8)));

            newPosition = newPosition - currentPosition;

            


            _rigidBody.MovePosition(_rigidBody.position + newPosition * .01f);
        }
    }
}
