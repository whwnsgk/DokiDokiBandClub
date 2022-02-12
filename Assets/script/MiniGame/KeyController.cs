using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{


    void Update()
    {
       
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        //Debug.Log("²¨Áü");

        if (Input.GetKeyDown(KeyCode.Z))
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
            //Debug.Log("ÄÑÁü");
        }

        else if(Input.GetKeyDown(KeyCode.X))
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }

        else if (Input.GetKeyDown(KeyCode.M))
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }

    }
   
}


