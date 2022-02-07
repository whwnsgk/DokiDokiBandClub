using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    
    public void SceneChange()
    {
        SceneManager.LoadScene("start1");
    }

    public void LoadScene()
    {
        if (PlayerPrefs.HasKey("SceneName"))
        {
            string SceneName = PlayerPrefs.GetString("SceneName");
            SceneManager.LoadScene(SceneName);
        }
    }

}
