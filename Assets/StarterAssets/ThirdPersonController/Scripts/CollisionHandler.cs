using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object is an iceberg
        if (collision.gameObject.CompareTag("Iceberg"))
        {
            // Parent the character to the iceberg
            this.transform.parent = collision.transform;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // Check if the character is leaving an iceberg
        if (collision.gameObject.CompareTag("Iceberg"))
        {
            // Unparent the character
            this.transform.parent = null;
        }
    }

    public void DetachFromIceberg()
    {
        // Call this method to detach the character from the iceberg, e.g., when jumping
        this.transform.parent = null;
    }
}
