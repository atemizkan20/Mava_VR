using UnityEngine;

public class BodyCollision : MonoBehaviour
{
    public Transform head; // Reference to the head
    private Rigidbody rb;  // Rigidbody of the BodyCollision object

    void Start()
    {
        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("No Rigidbody attached to BodyCollision object!");
        }
    }

    void FixedUpdate()
    {
        if (rb != null && head != null)
        {
            // Move the Rigidbody to the head's position
            Vector3 newPosition = head.position;
            rb.MovePosition(newPosition);
        }
    }
}
