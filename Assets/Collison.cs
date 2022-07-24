using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collison : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision");
    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Triggered");
    }
}
