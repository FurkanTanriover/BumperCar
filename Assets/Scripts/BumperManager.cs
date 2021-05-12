using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperManager : MonoBehaviour
{

    Rigidbody rb;
    public float bounceForce;
    public string playerTag;




    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }



    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            rb = collision.rigidbody;

            rb.AddExplosionForce(bounceForce, collision.contacts[0].point,20);
        }
    }

}
