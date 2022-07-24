using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10.0f;
    [SerializeField] float turnSpeed = 85.0f;

     void Update()
    {
        float driveDirection = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float rotationDirection = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        
        transform.Translate(0, driveDirection, 0);
        transform.Rotate(0, 0, -rotationDirection);
    }
}