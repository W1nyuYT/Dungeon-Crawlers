using UnityEngine;

public class fried_chicken : MonoBehaviour
{

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
            if (rb2d != null)
            {
                rb2d.velocity = Vector2.zero;
            }
        }    
    }
}

