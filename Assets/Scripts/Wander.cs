
using UnityEngine;
using UnityEngine.AI;

public class Wander : MonoBehaviour
{
    private NavMeshAgent agent;

    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }
    void Seek(Vector3 location)
    {
        agent.SetDestination(location);
    }


    Vector3 wanderTarget = Vector3.zero;

    void Wanderr()
    {
        float wanderRadius = 4;
        float wanderDistance = 2;
        float wanderJitter = 1;

        wanderTarget += new Vector3(Random.Range(-2.0f, 2.0f) * wanderJitter, 0, Random.Range(-2.0f, 2.0f) * wanderJitter);

        wanderTarget.Normalize();
        wanderTarget *= wanderRadius;

        Vector3 targetLocal = wanderTarget + new Vector3(0, 0, wanderDistance);
        Vector3 targetWorld = this.gameObject.transform.InverseTransformVector(targetLocal);

        Seek(targetWorld);
    }

    
    void Update()
    {
        Wanderr();
    }
}
