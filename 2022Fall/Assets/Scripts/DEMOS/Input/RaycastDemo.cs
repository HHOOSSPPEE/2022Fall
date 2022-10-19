using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastDemo : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float _jumpVelocity = 10f;

    private BoxCollider2D _bc;
    private bool _isGrounded;

    public LayerMask ground; //A layermask is a way for use to raycast to hit only certain things, masking off things you don't want to hit. Things you add are the things your raycast CAN hit.
    public Color debugColor;

    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _isGrounded = false;
        _bc = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(_bc.bounds.center, Vector2.down, _bc.bounds.extents.y + 0.1f, ground);

        _isGrounded = hit;

        if(Input.GetKeyDown(KeyCode.Space) && _isGrounded == true)
        {
            _rb.velocity = Vector2.up * _jumpVelocity;
        }

        Debug.DrawRay(_bc.bounds.center, Vector2.down *(_bc.bounds.extents.y + 0.1f), debugColor, ground);
    }
}
