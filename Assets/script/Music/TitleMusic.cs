using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GetComponent<AudioSource>().Play();
    }

    
}
