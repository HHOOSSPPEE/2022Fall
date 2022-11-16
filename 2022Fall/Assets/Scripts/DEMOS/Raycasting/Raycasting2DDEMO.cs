using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Raycasting2DDEMO : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public BoxCollider2D boxCollider;

    //private bool _grounded;
    //public LayerMask ground;

    //NPC Stuff
    private bool _canTalk;
    public LayerMask NPC;
    private NPCController _currentNPC;

    public Color debugLine;

    void Start()
    {
        //_grounded = true;
        _canTalk = false;
        _currentNPC = null;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _canTalk == true && _currentNPC != null)
        {
            Talk();
        }
    }

    void FixedUpdate()
    {
        /*
        RaycastHit2D hit = Physics2D.Raycast(boxCollider.bounds.center,
            Vector2.down,
            boxCollider.bounds.extents.y + .1f,
            ground);

        _grounded = hit;
        Debug.Log(_grounded);
        Debug.DrawRay(boxCollider.bounds.center,
            Vector2.down * (boxCollider.bounds.extents.y + .1f), 
            debugLine);
            */

        RaycastHit2D hit = Physics2D.Raycast(boxCollider.bounds.center,
            Vector2.right,
            boxCollider.bounds.extents.y + .5f,
            NPC);

        Debug.DrawRay(boxCollider.bounds.center,
            Vector2.right * (boxCollider.bounds.extents.y + .5f),
            debugLine);

        _canTalk = hit;

        if (_canTalk == true)
        { 
            _currentNPC = hit.collider.gameObject.GetComponent<NPCController>();
        }
        else
            _currentNPC = null;


    }

    void Talk()
    {
        _currentNPC.targetBlock.Execute(); //.execute

    }
}
