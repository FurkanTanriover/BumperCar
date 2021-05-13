using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperManager : MonoBehaviour
{
    Rigidbody rb;
    RaycastHit hit;

    public float hitRange = 50f;
    public float hitForce = 0f;


    private Transform carBody;
    public GameObject fpsCar;
    


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }


    void Bump()
    {
        RaycastHit hit;
        if( Physics.Raycast(fpsCar.transform.position,fpsCar.transform.forward,out hit, hitRange))
        {
            Debug.Log(hit.transform.name);

            hit.rigidbody.AddForce(hit.normal * hitForce);
        }
    }

    private void Force()
    {

    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Rigidbody enemyRb;
            enemyRb = collision.gameObject.GetComponent<Rigidbody>();
            Debug.Log("xxxxxx");
           // Bump();
        }
    }

}
