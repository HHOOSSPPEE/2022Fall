using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public CameraManager cameraManager;
    public KeyCode cameraSwitchKey;
    private bool _isInZone;
    private bool _isOverhead;
    // Start is called before the first frame update
    void Start()
    {
        _isInZone = false;
        _isOverhead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(cameraSwitchKey) && _isInZone == true && _isOverhead == false) //if pressing key, is in zone, and not already overhead
        {
            cameraManager.ShowOverheadView();
        }

        if (Input.GetKeyDown(cameraSwitchKey) &&  _isOverhead == true) //if pressing key and CURRENTLY overhead
        {
            cameraManager.ShowFirstPersonView();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        { 
            _isInZone = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
            _isInZone = false;
    }

}
