using UnityEngine;

public class CarMovement : MonoBehaviour
{

    public CharacterController controller;


    public float moveForce;
    public float gravity = -10f;
    public Vector3 point;
    public float rotationSpeed;

    Rigidbody rb;


    Vector3 velocity;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Movement();
       
    }



    private void Movement()
    {
        float z = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");

        Vector3 move = transform.forward * z;
        rb.velocity = move * moveForce;
        rb.angularVelocity = Vector3.zero;
        Debug.Log(move);

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
