using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    public float limitLeft, limitRight, limitBottom, limitTop;

    private Vector3 _velocity = Vector3.zero;
    
    // Start is called before the first frame update
    void Start()
    {
        if(target == null)
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    private void LateUpdate()
    {
        Transform currentTarget = target;
        Vector3 desiredPostion = currentTarget.position + offset;

        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPostion, ref _velocity, smoothSpeed);
        transform.position = new Vector3(Mathf.Clamp(smoothedPosition.x, limitLeft, limitRight),
            Mathf.Clamp(smoothedPosition.y, limitBottom, limitTop),
            smoothedPosition.z);
    }

    public void ChangeTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
