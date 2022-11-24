using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = -100f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float speedSpeed = 25f;
    [SerializeField] float slowSpeed = 15f;



    void Start()
    {

    }

    void Update()
    {
        float streeAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, streeAmount);
        transform.Translate(0, moveAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "boost")
        {
            moveSpeed = speedSpeed;
        }
    }
}
