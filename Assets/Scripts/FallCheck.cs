using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FallCheck : MonoBehaviour
{
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("**" + LevelController.instance.enemyCount);
            LevelController.instance.enemyCount--;
            Debug.Log(LevelController.instance.enemyCount + "**");
            other.GetComponent<NavMeshAgent>().enabled = false;
            if (LevelController.instance.enemyCount==0)
            {
                Debug.Log("Win");
            }
        }
        else if(other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<NavMeshAgent>().enabled = false;
            Debug.Log("Lose");
        }
    }
}
