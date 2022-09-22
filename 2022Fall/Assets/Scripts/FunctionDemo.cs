using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionDemo : MonoBehaviour
{
    int number = 6;
    bool isSix = true;

    public KeyCode jumpKey;

    private Vector2 _movement;
    public float movementSpeed;
    private Rigidbody2D _rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //player is moving up
        //int sum = Add(1, 2, 3);

        if (Input.GetKeyDown(jumpKey)){
            //character jump here
        }

        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");

        /*
        if (Input.GetKey(KeyCode.A))
        {
            _movement.x = -1;
        }*/
    }

    private void FixedUpdate()
    {
        _rigidBody.MovePosition(_rigidBody.position + _movement * movementSpeed);
        
    }

    public void ChangeColor(int number)
    {
        Debug.Log("Pink");
    }
 



}
