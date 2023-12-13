using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MuteAudio : MonoBehaviour
{
    private bool isMuted = false;

    // Update is called once per frame
    void Update()
    {
        // Check if the M key is pressed
        if (Input.GetKeyDown(KeyCode.M))
        {
            // Toggle the mute state
            isMuted = !isMuted;

            // Call the MuteToggle function with the new state
            MuteToggle(isMuted);
        }
    }

    public void MuteToggle(bool muted)
    {
        if (muted)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = 1;
        }
    }
}
