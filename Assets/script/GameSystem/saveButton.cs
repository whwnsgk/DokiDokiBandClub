using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class saveButton : MonoBehaviour
{
    public void Save()
    {
        string SceneName = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("SceneName", SceneName);

        int SvLovePoint = GameManager.LovePoint;
        PlayerPrefs.SetInt("SvLovePoints",SvLovePoint);

    }
}
