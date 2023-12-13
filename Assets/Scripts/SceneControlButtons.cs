using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControlButtons : MonoBehaviour
{
    public void LoadPreviousScene()
    {
        // Load the previous scene (or scene index 1)
        SceneManager.LoadScene(1);
    }

    public void LoadMainMenu()
    {
        // Load the Main Menu scene (scene index 0)
        SceneManager.LoadScene(0);
    }
}
