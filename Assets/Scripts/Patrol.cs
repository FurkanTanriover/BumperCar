
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;
   
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;
        GoToNextPoint();
    }

    void GoToNextPoint()
    {
        if(points.Length==0)
        {
            return;
        }
        agent.destination = points[destPoint].position;
        destPoint = (destPoint + 1) % points.Length;
    }

    void Flee(Vector3 location) 
    {
        Vector3 fleeVector = location - this.transform.position;
        agent.SetDestination(this.transform.position - fleeVector);
    }

   
   


    
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 1.5f)
        {
            GoToNextPoint();
        }
        
    }
}
