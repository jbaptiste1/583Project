using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
using UnityEngine.SceneManagement; // Required for scene management

public class SpawnScript : MonoBehaviour
{
    public GameObject objectToMove;
    public float velocity = 5.0f;
    public float resetDistance = 100.0f;

    private Vector3 originalPosition;
    private Vector3 movementDirection = Vector3.forward;

    void Start()
    {
        if (objectToMove != null)
        {
            originalPosition = objectToMove.transform.position;
        }
        else
        {
            Debug.LogError("No GameObject assigned to objectToMove in MoveAndReset script.");
        }
    }

    void Update()
    {
        if (objectToMove != null)
        {
            objectToMove.transform.Translate(movementDirection * velocity * Time.deltaTime);

            if (Vector3.Distance(originalPosition, objectToMove.transform.position) >= resetDistance)
            {
                objectToMove.transform.position = originalPosition;
            }
        }
    }

    // Collision detection method
    void OnCollisionEnter(Collision collision)
    {
        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
