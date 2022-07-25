using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] GameObject player;
    void Update()
    {
        Vector3 position = player.transform.position;
        transform.position = new Vector3(position.x,position.y, -10);
    }
}
