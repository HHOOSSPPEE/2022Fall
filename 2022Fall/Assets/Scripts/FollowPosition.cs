using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPosition : MonoBehaviour
{
    public Transform playerCapsule;
    public Vector3 offset;


    private void Update()
    {
        gameObject.transform.position = playerCapsule.position + offset;
    }
}
