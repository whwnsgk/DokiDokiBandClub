using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoorBGM : MonoBehaviour
{
    void Awake()
    {
        GetComponent<AudioSource>().Play();
    }

}
