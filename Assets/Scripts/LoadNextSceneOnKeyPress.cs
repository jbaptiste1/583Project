using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextSceneOnKeyPress : MonoBehaviour
{
    public KeyCode keyToPress = KeyCode.Y; // The key that triggers the scene load is now set to 'Y'

    void Update()
    {
        // Check if the 'Y' key is pressed
        if (Input.GetKeyDown(keyToPress))
        {
            // Load the next scene
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        // Get the current scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // Calculate the next scene index
        int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
        // Load the next scene
        SceneManager.LoadScene(nextSceneIndex);
    }
}
