using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliderSizeChange : MonoBehaviour
{
    public Vector2 standingCollider;
    public Vector2 jumpingCollider;

    public BoxCollider2D playerCollider;
    

    // Update is called once per frame
    void Update()
    {
        //when im standing/walking
        playerCollider.size = standingCollider;

        //when im jumping
        playerCollider.size = jumpingCollider;
    }
}
