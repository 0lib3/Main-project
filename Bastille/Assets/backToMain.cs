using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressAnyKeyToContinue : MonoBehaviour
{
    public string sceneToLoad = "Main";

    void Update()
    {
        if (Input.anyKeyDown)
        {
            LoadMainScene();
        }
    }

    void LoadMainScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
