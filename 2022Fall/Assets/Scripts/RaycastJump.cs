using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastJump : MonoBehaviour
{
    private Rigidbody2D _rb;
    private BoxCollider2D _bc;

    public float jumpVelocity = 10f;
    private bool _isGrounded;

    public LayerMask ground; 
    public Color debugColor;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _bc = gameObject.GetComponent<BoxCollider2D>();

        _isGrounded = false;
    }

    private void FixedUpdate()
    {
        Vector2 playerOffset = new Vector2();
        Vector2 offset = new Vector2(0f, 2f);
        playerOffset = _bc.bounds.center;
        playerOffset = playerOffset + offset;

        //RaycastHit2D hit = Physics2D.Raycast(_bc.bounds.center, Vector2.down, _bc.bounds.extents.y + 0.1f);
        RaycastHit2D hit = Physics2D.Raycast(_bc.bounds.center, Vector2.down, _bc.bounds.extents.y + 0.1f, ground);
        _isGrounded = hit;
        Debug.Log(_isGrounded);

        if(Input.GetKeyDown(KeyCode.Space) && _isGrounded == true)
        {
            _rb.velocity = Vector2.up * jumpVelocity;
        }

        Debug.DrawRay(_bc.bounds.center, Vector2.down * (_bc.bounds.extents.y + 0.1f), debugColor, ground);
    }
}
