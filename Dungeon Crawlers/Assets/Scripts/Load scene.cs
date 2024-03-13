using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseTriggerEvents : MonoBehaviour
{
    // Name of the scene to load
    public string sceneToLoad;

    // Update is called once per frame
    void Update()
    {
        // Check for left mouse button click
        if (Input.GetMouseButtonDown(0))
        {
            // Create a ray from the camera to the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray intersects with any collider
            if (Physics.Raycast(ray, out hit))
            {
                // Check if the collider hit has a tag "Player" (or any other tag you prefer)
                if (hit.collider.CompareTag("Player"))
                {
                    // Load the scene specified by sceneToLoad
                    SceneManager.LoadScene(sceneToLoad);
                }
            }
        }
    }
}
