using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FallCheck : MonoBehaviour
{
    List<GameObject> loseCar;
    public WinLoseScreen winLose;

    public GameObject winScreen;
    public GameObject loseScreen;
    public GameObject joystick;

    private void Start()
    {
        loseCar = new List<GameObject>();
    }

    public bool LoseEnemyAddController(GameObject enemy)
    {
        bool isEnemyLosed = false;
        int loseCarCount = loseCar.Count;

        for (int i = 0; i < loseCarCount; i++)
        {
            if (loseCar[i] == enemy)
            {
                isEnemyLosed = true;
            }
        }

        if (!isEnemyLosed)
        {
            loseCar.Add(enemy);
            return true;
        }
        else
        {
            return false;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            if (LoseEnemyAddController(other.gameObject))
            {
                LevelController.instance.enemyCount--;
                other.GetComponent<NavMeshAgent>().enabled = false;
                if (LevelController.instance.enemyCount == 0)
                {
                    winScreen.SetActive(true);
                    joystick.SetActive(false);
                }

            }
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<NavMeshAgent>().enabled = false;
            loseScreen.SetActive(true);
            joystick.SetActive(false);
        }

    }
}
