using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastingDEMO : MonoBehaviour
{
    public Rigidbody rigidBody;
    public BoxCollider boxCollider;

    //public float jumpVelocity = 10f;

    private bool _grounded;
    public LayerMask ground;

    public Color debugLine;

    // Start is called before the first frame update
    void Start()
    {
        _grounded = true;
    }

    private void Update()
    {

    }

    void FixedUpdate()
    {
        RaycastHit hit;

        /*
        if(Physics.Raycast(transform.position, Vector3.down, out hit))
        {
            Debug.Log(hit.distance);
        }*/

        if(Physics.Raycast(transform.position, Vector3.down, out hit, 
            boxCollider.bounds.extents.y + .1f, ground)){
            _grounded = true;
        }
        else
        {
            _grounded = false;
        }

        Debug.DrawRay(boxCollider.bounds.center,
            Vector3.down * (boxCollider.bounds.extents.y + .1f), debugLine);
        Debug.Log(_grounded);

    }
}
