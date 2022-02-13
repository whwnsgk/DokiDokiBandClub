using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MiniGameManager : MonoBehaviour
{
    void Awake()
    {
        GetComponent<AudioSource>().Play();
    }
    void Start()
    {
        Invoke("NextScene", 50f);
    }

    public void NextScene()
    {
        if (GameManager.LovePoint <= 0)
        {
            SceneManager.LoadScene("BadEnding");
            Debug.Log(GameManager.EdPoint);
            Debug.Log(GameManager.LovePoint);
           
        }
        else if (((GameManager.MiniGamePoint/30)+(GameManager.LovePoint)) > 4)
        {
            SceneManager.LoadScene("TrueEnding1");
            Debug.Log(GameManager.EdPoint);
            Debug.Log(GameManager.LovePoint);
            Debug.Log(((GameManager.MiniGamePoint / 30) + (GameManager.LovePoint)));
        }
        else
            SceneManager.LoadScene("NormalEnding");
            Debug.Log(GameManager.EdPoint);
            Debug.Log(GameManager.LovePoint);
            

    }
    
}
