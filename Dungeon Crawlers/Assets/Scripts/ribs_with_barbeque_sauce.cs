using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ribs_with_barbeque_sauce : MonoBehaviour
{
    public float xOffset = 0f;
    public float yOffset = 0f;
    private bool mouseDown;
    public GameObject objectToMove;
    void Update()
    {
        if (Input.GetMouseButton(0)) 
        {   
            if (!mouseDown)
            {
                transform.position = Input.mousePosition;  
                mouseDown = true;
            }
            
        }
        else
        {
            Vector2 outBounds = new Vector2(1000, 10000);
            transform.position = (outBounds);
            mouseDown = false;
        }
    }   
}

