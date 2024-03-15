using UnityEngine;

public class soup : MonoBehaviour
{
    public float moveSpeed = 0f;
    public float jumpForce = 10f; 

    private Rigidbody2D rb2d;
    private bool isGrounded; 

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
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            Transform objectTransform = transform;
            Vector2 currentPosition = objectTransform.position;
            Vector2 newPosition = new Vector2(currentPosition.x + (0-moveSpeed), currentPosition.y);
            objectTransform.position = newPosition;
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            Transform objectTransform = transform;
            Vector2 currentPosition = objectTransform.position;
            Vector2 newPosition = new Vector2(currentPosition.x + moveSpeed, currentPosition.y);
            objectTransform.position = newPosition;
        }

       
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && isGrounded)
        {
            Jump();
        }

        if (transform.position.y < -100f)
        {
            transform.position = Vector3.zero;
        }
    }

    void Jump()
    {
        
        rb2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        
        foreach (ContactPoint2D contact in collision.contacts)
        {
           
            if (Vector2.Dot(contact.normal, Vector2.up) > 0.7f)
            {
                isGrounded = true;
                return;
            }
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {

        isGrounded = false;
    }
}
