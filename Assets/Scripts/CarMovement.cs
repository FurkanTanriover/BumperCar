using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CarMovement : MonoBehaviour
{

    public CharacterController controller;

    [SerializeField] Joystick joystick;
    [SerializeField] Joystick joystick2;



    public float moveForce;
    public float gravity = -10f;
    public Vector3 point;
    public float rotationSpeed;
    public bool isBumped;
    public float bumpDelayTime = .2f;
    [SerializeField] Transform wheelDirection;

    Rigidbody rb;




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
            JoystickMovement();
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

    private void JoystickMovement()
    {
        float x = joystick.Horizontal;
        float z = joystick2.Vertical;


        Vector3 move = transform.forward * z;
        rb.velocity = move * moveForce;
        rb.angularVelocity = Vector3.zero;

        if (x > 0)
        {
            wheelDirection.eulerAngles -= Vector3.forward * rotationSpeed / 4;
            transform.eulerAngles += Vector3.up * rotationSpeed;
        }
        else if (x < 0)
        {
            wheelDirection.eulerAngles += Vector3.forward * rotationSpeed / 4;
            transform.eulerAngles -= Vector3.up * rotationSpeed;
        }
    }


    #region for computer control
    private void Movement()
    {
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.forward * z;
        rb.velocity = move * moveForce;
        rb.angularVelocity = Vector3.zero;

        if (Input.GetKey(KeyCode.D))
        {
            wheelDirection.eulerAngles -= Vector3.forward * rotationSpeed / 4;
            transform.eulerAngles += Vector3.up * rotationSpeed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            wheelDirection.eulerAngles += Vector3.forward * rotationSpeed / 4;
            transform.eulerAngles -= Vector3.up * rotationSpeed;
        }
    }
    #endregion
}
