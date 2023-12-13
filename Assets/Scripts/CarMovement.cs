using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarMovement: MonoBehaviour
{
    public float speed = 5f;
    public GameObject resetPositionObject; // GameObject for the reset position
    public GameObject targetPointObject;   // GameObject for the target point

    private Vector3 resetPosition;

    void Start()
    {
        // Initialize the reset position from the resetPositionObject's current position
        if (resetPositionObject != null)
        {
            resetPosition = resetPositionObject.transform.position;
        }
        else
        {
            Debug.LogError("Reset Position Object not set!");
        }
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (targetPointObject != null && transform.position.z >= targetPointObject.transform.position.z)
        {
            transform.position = resetPosition;
        }
        else if (targetPointObject == null)
        {
            Debug.LogError("Target Point Object not set!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        other.transform.SetParent(transform);
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.SetParent(null);
    }

    
}
