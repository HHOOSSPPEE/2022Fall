using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColTrigDemo : MonoBehaviour
{
    public Transform newTarget;

    private SpriteRenderer _spriteRenderer;
    private CameraScript _cc;
    private MusicManager _mm;

    public AudioClip triggerClip;
    
    // Start is called before the first frame update
    void Start()
    {
        //get our sprite renderer and turn it off so we don't see our trigger
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        //_spriteRenderer.enabled = false;

        _cc = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraScript>();
        _mm = GameObject.FindGameObjectWithTag("MusicManager").GetComponent<MusicManager>();
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
            _mm.PlayMusic(triggerClip);
            Debug.Log("Hello");
        }
    }


}
