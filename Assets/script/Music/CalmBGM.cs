using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalmBGM : MonoBehaviour
{
    void Awake()
    {
        GetComponent<AudioSource>().Play();
        DontDestroyOnLoad(gameObject);
    }

    


}
