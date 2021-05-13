using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CarMovement : MonoBehaviour
{

    public CharacterController controller;


    public float moveForce;
    public float gravity = -10f;
    public Vector3 point;
    public float rotationSpeed;
    public bool isBumped;
    public float bumpDelayTime=.2f;

    Rigidbody rb;


    Vector3 velocity;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Time.timeScale = 0.8f;

    }

    void Update()
    {
        if (!isBumped)
        {
            Movement();
        }
    }

    public void SetBumpedValue()
    {
        isBumped = true;
        StartCoroutine(ReverseBumpedValue());
    }

    IEnumerator ReverseBumpedValue()
    {
        yield return new WaitForSeconds(bumpDelayTime);
        isBumped = false;

    }


    private void Movement()
    {
        float z = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");

        Vector3 move = transform.forward * z;
        rb.velocity = move * moveForce;
        rb.angularVelocity = Vector3.zero;

        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles += Vector3.up * rotationSpeed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles -= Vector3.up * rotationSpeed;
        }

    }
}
