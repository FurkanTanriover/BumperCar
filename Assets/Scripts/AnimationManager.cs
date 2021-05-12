using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{

    public Animation bumperAnim;
    

    void Start()
    {
        bumperAnim = gameObject.GetComponent<Animation>();
    }


    void Update()
    {
    
         //   bumperAnim.Play();
       
    }

}
