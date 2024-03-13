using UnityEngine;

public class fried_chicken : MonoBehaviour
{
    public float frictionCoefficient = 0.5f; // Adjust this value as needed

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        if (rb2d == null)
        {
            Debug.LogError("Rigidbody2D component not found!");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Stationary"))
        {
            if (rb2d != null && rb2d.velocity.magnitude < 0.01f)
            {
                rb2d.velocity = Vector2.zero;
            }
        }
    }

    void FixedUpdate()
    {
        ApplyFriction();
    }

    void ApplyFriction()
    {
        // Check if the object is not moving (if its velocity is close to zero)
        if (rb2d.velocity.magnitude < 0.01f)
        {
            // Apply friction force based on the opposite direction of the velocity
            Vector2 frictionForce = -rb2d.velocity.normalized * frictionCoefficient;

            // Apply the friction force
            rb2d.AddForce(frictionForce, ForceMode2D.Force);
        }
    }
}
