using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start6 : SceneDirector
{
    public override void NextScene()
    {
        SceneManager.LoadScene("Begin1");
    }
}
