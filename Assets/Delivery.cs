using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool _hasPackage = false;

    SpriteRenderer _spriteRenderer;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Package") && _hasPackage == false)
        {
            _hasPackage = true;
            Destroy(other.gameObject);
            _spriteRenderer.color = other.GetComponent<SpriteRenderer>().color;
            Debug.Log("Package Picked Up");
        }
        
        if (other.CompareTag("Customer") && _hasPackage)
        {
            _hasPackage = false;
            _spriteRenderer.color = Color.white;
            Debug.Log("Package Delivered");
        }
    }
}
