using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Make the scene name customizable through the Inspector
    public string sceneName = "MainMenu";
    

    public void LoadMainMenuScene()
    {
        // Load the scene using the provided scene name
        SceneManager.LoadScene(sceneName);
    }
}