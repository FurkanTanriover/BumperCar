using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{

    private bool gameEnded;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void Lose()
    {
        if (!gameEnded)
        {
            Debug.Log("lose");
            gameEnded = true;
            Destroy(gameObject);
        }
    }

    public void Win()
    {
        if (!gameEnded)
        {
            gameEnded = true;
            Debug.Log("win");
        }
    }
}


