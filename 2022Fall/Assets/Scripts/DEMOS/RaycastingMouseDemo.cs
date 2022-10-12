using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastingMouseDemo : MonoBehaviour
{
    private Vector3 _worldPosition;

    public LayerMask ground;
    //public Color highlight;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        _worldPosition = Camera.main.ScreenToWorldPoint(mousePos);

        gameObject.transform.position = _worldPosition;

        RaycastHit2D hit = Physics2D.Raycast(_worldPosition, Vector2.zero, 100f, ground);

        if(hit.collider != null)
        {
            Debug.Log("HIT!");
            //hit.transform.gameObject.GetComponent<SpriteRenderer>().color = highlight;
        }
    }
}
