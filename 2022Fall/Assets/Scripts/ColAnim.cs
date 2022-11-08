using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColAnim : MonoBehaviour
{
    public string newAnimation;

   // private Trap1 _platform;

    private void Start()
    {
        //_platform = GameObject.FindGameObjectWithTag("Platform").GetComponent<Trap1>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerAnimator>().ChangeAnimationState(newAnimation);
        }
    }
}
