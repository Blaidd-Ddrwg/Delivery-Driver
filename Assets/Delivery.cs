using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision");
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Package") && hasPackage == false)
        {
            hasPackage = true;
            Destroy(other.gameObject);
            Debug.Log("Package Picked Up");
        }
        
        if (other.CompareTag("Customer") && hasPackage)
        {
            hasPackage = false;
            Debug.Log("Package Delivered");
        }
    }
}
