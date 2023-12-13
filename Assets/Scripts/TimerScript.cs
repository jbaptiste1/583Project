using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // Make sure you're using the TextMeshPro namespace
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public TMP_Text timerText;  // The TextMeshPro text component
    public float countdownTime = 30f;  // Set this to your desired start time in seconds
    private float timeRemaining;

    void Start()
    {
        timeRemaining = countdownTime;
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            DisplayTime(timeRemaining);
        }
        else
        {
            timeRemaining = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reset the scene
            // Optionally, add any logic you want to occur when the timer reaches zero
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("Timer: {0:00}:{1:00}", minutes, seconds);
    }

    public void ResetTimer()
    {
        timeRemaining = countdownTime;
    }
}