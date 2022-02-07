using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CG1 : MonoBehaviour
{
    public Image Image;

    void Start()
    {
        StartCoroutine(FadeCoroutine());
        Invoke("NextScene", 5f);
    }

    IEnumerator FadeCoroutine()
    {
        float fadeCount = 0;
        while (fadeCount < 1.0f)
        {
            fadeCount += 0.01f;
            yield return new WaitForSeconds(0.01f);
            Image.color = new Color(255, 255, 255, fadeCount );
        }


    }


    public void NextScene()
    {
        SceneManager.LoadScene("Begin2");

    }

    

    /*void Start()
    {
        Invoke("NextScene", 2f);
    }

    public void NextScene()
    {
       // if (Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene("Begin2");
    }*/

}

