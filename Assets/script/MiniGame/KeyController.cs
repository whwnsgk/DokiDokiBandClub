using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }

    void Update()
    {
       
       

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Invoke("Turnoff", 0.2f);
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
           
            //Debug.Log("ÄÑÁü");
        }

        else if(Input.GetKeyDown(KeyCode.X))
        {
            Invoke("Turnoff", 0.2f);
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            Invoke("Turnoff", 0.2f);
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }

        else if (Input.GetKeyDown(KeyCode.M))
        {
            Invoke("Turnoff", 0.2f);
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }

    }

    void Turnoff()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        //Debug.Log("²¨Áü");
    }

}


