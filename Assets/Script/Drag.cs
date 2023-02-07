using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    private Vector3 offset;
    [SerializeField] private Rigidbody2D _rb;
    void OnMouseDown()
    { 
        offset = gameObject.transform.position -
        Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, 10.0f));
    }

    void OnMouseDrag()
    {
       Vector2 newPosition = new Vector2(Input.mousePosition.x, 10.0f);
       _rb.velocity = new Vector2(0,0);
        transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
    }
}
