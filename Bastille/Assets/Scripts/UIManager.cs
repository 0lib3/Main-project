using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject winScreen;
public void LoadSceneWithKey()
    {
        SceneManager.LoadScene("Main");
    }
}
