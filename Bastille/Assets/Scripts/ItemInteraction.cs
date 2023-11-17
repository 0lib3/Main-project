using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemInteraction : MonoBehaviour
{
public float delayBeforeReload = 3.0f;

private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            LoadWinScene();
        }
    }

    void LoadWinScene()
    {
        // Load the scene with the key or next level
        SceneManager.LoadScene("winScreen");
        Invoke("ReloadLevel", delayBeforeReload);
    }
        void ReloadLevel()
    {
        SceneManager.LoadScene("Level");
    }
}

