
using UnityEngine;

public class BumperManager : MonoBehaviour
{
    Rigidbody rb;


    public float hitRange = 50f;
    public float hitForce = 1000f;

    public CameraShake cameraShake;
 
    

    void Start()
    {
        rb = transform.parent.GetComponent<Rigidbody>();
        
    }


    void Bump(Rigidbody enemyRb)
    {

        enemyRb.AddForce(transform.forward * hitForce);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            Rigidbody enemyRb;
            enemyRb = other.gameObject.GetComponent<Rigidbody>();;
            Bump(enemyRb);
            if(gameObject.transform.parent.name=="PlayerCar")
            StartCoroutine(cameraShake.Shake(.2f, .2f));

        }
        else if(other.CompareTag("Player"))
        {
            CarMovement carMovement = other.GetComponent<CarMovement>();
            carMovement.SetBumpedValue();
            Rigidbody playerRb;
            playerRb = other.gameObject.GetComponent<Rigidbody>();
            Bump(playerRb);
            if (gameObject.transform.parent.name == "PlayerCar")
                StartCoroutine(cameraShake.Shake(.2f, .2f));
        }

    }

}
