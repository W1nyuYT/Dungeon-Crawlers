using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float moveSpeed = 0f;
    public float jumpForce = 10f; // Adjust this value to control jump force

    private Rigidbody2D rb2d;
    private bool isGrounded; // Flag to track if the object is grounded

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        if (rb2d == null)
        {
            Debug.LogError("Rigidbody2D component not found!");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Transform objectTransform = transform;
            Vector2 currentPosition = objectTransform.position;
            Vector2 newPosition = new Vector2(currentPosition.x + (0-moveSpeed), currentPosition.y);
            objectTransform.position = newPosition;
        }
        float moveInput = Input.GetAxisRaw("Horizontal");
        Vector2 moveVelocity = new Vector2(moveInput * moveSpeed, rb2d.velocity.y);
        rb2d.velocity = moveVelocity;

        // Jumping
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && isGrounded)
        {
            Jump();
        }
    }

    void Jump()
    {
        // Apply jump force
        rb2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        // Check if the object is grounded
        foreach (ContactPoint2D contact in collision.contacts)
        {
            // Check if the contact normal is pointing upwards (vertical)
            if (Vector2.Dot(contact.normal, Vector2.up) > 0.7f)
            {
                isGrounded = true;
                return;
            }
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        // Reset grounded flag when leaving the ground
        isGrounded = false;
    }
}
