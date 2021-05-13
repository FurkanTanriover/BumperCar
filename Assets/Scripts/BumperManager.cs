using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperManager : MonoBehaviour
{
    Rigidbody rb;
    RaycastHit hit;

    public float hitRange = 50f;
    public float hitForce = 1000f;

    


    private Transform carBody;
    

    void Start()
    {
        rb = transform.parent.GetComponent<Rigidbody>();
        
    }


    void Bump(Rigidbody enemyRb)
    {

        enemyRb.AddForce(transform.forward * hitForce);

        //RaycastHit hit;
        //if( Physics.Raycast(fpsCar.transform.position,fpsCar.transform.forward,out hit, hitRange))
        //{
        //    Debug.Log(hit.transform.name);

        //    hit.rigidbody.AddForce(hit.normal * hitForce);
        //}
    }

    private void Force()
    {

    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            Rigidbody enemyRb;
            enemyRb = other.gameObject.GetComponent<Rigidbody>();
            Debug.Log("xxxxxx");
            Bump(enemyRb);
        }   
        else if(other.CompareTag("Player"))
        {
            CarMovement carMovement = other.GetComponent<CarMovement>();
            carMovement.SetBumpedValue();
            Rigidbody playerRb;
            playerRb = other.gameObject.GetComponent<Rigidbody>();
            Debug.Log("yyyy");
            Bump(playerRb);
        }

    }

}
