using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteController : MonoBehaviour
{

    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player");
    }


    void Update()
    {



        
        transform.Translate(0, -0.01f, 0);

        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }



       

        /*
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;


        if (d < r1 + r2)
        {
            Destroy(gameObject);
        }
        */
    }


    void OnTriggerEnter2D(Collider2D collision)

    {

        if (collision.gameObject.tag == "FailLine")

        {
            Destroy(gameObject);
            Debug.Log("실패");
            GameObject.Find("Canvas").transform.Find("verysad").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.FindChild("happy").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.FindChild("bad").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.FindChild("perfect").gameObject.SetActive(false);



        }
        else if (collision.gameObject.tag == "Zkey")
        {
               Destroy(gameObject);
               Debug.Log("성공");
               GameObject.Find("Canvas").transform.FindChild("happy").gameObject.SetActive(true);
               GameObject.Find("Canvas").transform.Find("verysad").gameObject.SetActive(false);
               GameObject.Find("Canvas").transform.FindChild("perfect").gameObject.SetActive(true);
               GameObject.Find("Canvas").transform.FindChild("bad").gameObject.SetActive(false);
        }

        else if (collision.gameObject.tag == "Xkey")
        {
            Destroy(gameObject);
            Debug.Log("성공");
            GameObject.Find("Canvas").transform.FindChild("happy").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.Find("verysad").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.FindChild("perfect").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.FindChild("bad").gameObject.SetActive(false);
        }

        else if (collision.gameObject.tag == "Nkey")
        {
            Destroy(gameObject);
            Debug.Log("성공");
            GameObject.Find("Canvas").transform.FindChild("happy").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.Find("verysad").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.FindChild("perfect").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.FindChild("bad").gameObject.SetActive(false);
        }

        else if (collision.gameObject.tag == "Mkey")
        {
            Destroy(gameObject);
            Debug.Log("성공");
            GameObject.Find("Canvas").transform.FindChild("happy").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.Find("verysad").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.FindChild("perfect").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.FindChild("bad").gameObject.SetActive(false);
        }
    }


}




