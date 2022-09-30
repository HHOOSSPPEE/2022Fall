using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public KeyCode startKey;
    private Rigidbody2D _rb;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _rb.simulated = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(startKey))
        {
            _rb.simulated = true;
            
        }
    }
}
