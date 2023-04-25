using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    float steerSpeed = 0.2f;
    float moveSpeed = 0.01f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, 0, steerSpeed);
        transform.Translate(0, moveSpeed, 0);
    }
}
