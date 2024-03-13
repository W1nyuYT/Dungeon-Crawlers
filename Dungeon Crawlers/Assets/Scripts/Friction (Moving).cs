using UnityEngine;

public class Friction : MonoBehaviour
{
    public float frictionCoefficient = 0.5f;

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (rb2d != null)
        {
            ApplyFriction();
        }
    }

    void ApplyFriction()
    {
        
        Vector2 frictionForce = -rb2d.velocity.normalized * frictionCoefficient;

        rb2d.AddForce(frictionForce, ForceMode2D.Force);
    }
}
