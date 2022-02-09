using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    void Start()
    {
        
    }

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            transform.Translate(-3,0,0);
        }
        if(Input.GetKeyDown(KeyCode.X))
        {
            transform.Translate(3,0,0);
        }
        
    }
}
