using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class SpawnScript : MonoBehaviour
{

    public GameObject objectToSpawn;
    private Vector3 originalPosition = new Vector3(68.61f, 1.6f, -58.99f); // Starting position
    private GameObject movingObject;
    public float speed = 5f;
    public float respawnThreshold = 3000f; // Distance after which the object should respawn


    void Update()
    {
        if (movingObject != null)
        {
            // Move the object
            Vector3 movementDirection = new Vector3(0, 0, 1); // Modify as needed
            movingObject.transform.position += movementDirection * speed * Time.deltaTime;

            // Check if the object has reached the respawn threshold
            if (Vector3.Distance(movingObject.transform.position, originalPosition) > respawnThreshold)
            {
                movingObject.transform.position = originalPosition; // Reset position
            }
        }
    }



    void Start()
        {
            SpawnObject();
        }
    

    void SpawnObject()
    {
        if (movingObject == null)
        {
            movingObject = Instantiate(objectToSpawn, originalPosition, UnityEngine.Quaternion.identity);
        }
    }
}
