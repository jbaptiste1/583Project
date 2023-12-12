using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform startingPoint; // Assign the starting point in the Inspector
    public TimerScript timerScript; // Reference to your TimerScript

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car") || collision.gameObject.CompareTag("Water"))
        {
            ResetPlayer();
        }
    }

    void ResetPlayer()
    {
        // Reset player position
        transform.position = startingPoint.position;
        transform.rotation = startingPoint.rotation;

        // Reset the timer
        if (timerScript != null)
        {
            timerScript.ResetTimer();
        }
    }
}

