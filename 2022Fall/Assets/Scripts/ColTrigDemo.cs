using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColTrigDemo : MonoBehaviour
{
    public Transform newTarget;

    private SpriteRenderer _spriteRenderer;
    private CameraScript _cc;
    
    // Start is called before the first frame update
    void Start()
    {
        //get our sprite renderer and turn it off so we don't see our trigger
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        _spriteRenderer.enabled = false;

        _cc = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _cc.ChangeTarget(newTarget);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Hello");
        }
    }


}
