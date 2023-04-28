using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 300;
    [SerializeField] float moveSpeed = 15;
    [SerializeField] float boostSpeed = 30;
    [SerializeField] float slowSpeed = 15;

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost" && moveSpeed != 30)
        {
            Debug.Log("Booooost");
            moveSpeed = boostSpeed;
            Destroy(other.gameObject);
        }
    }
}
