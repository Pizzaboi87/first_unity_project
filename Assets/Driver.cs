using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.2f;
    [SerializeField] float moveSpeed = 0.01f;

    void Start()
    {

    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal");
        transform.Rotate(0, 0, steerAmount);
        transform.Translate(0, moveSpeed, 0);
    }
}
