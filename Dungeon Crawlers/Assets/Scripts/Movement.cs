using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{
    public float speed;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
 
        rb2d.transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
    }
}
