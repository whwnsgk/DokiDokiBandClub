using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonGenerator : MonoBehaviour
{
    public GameObject buttonPrefab;
    float span = 0.05f ;
    float delta = 0;
    

    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(buttonPrefab) as GameObject;
            int px = Random.Range(-2, 2);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
