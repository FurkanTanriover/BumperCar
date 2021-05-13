using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public WinLose winLoseScript;
    void Start()
    {

    }

    void Update()
    {
        if (transform.position.y < -8.0)
        {
            winLoseScript.Lose();

        }
        
    }

}
