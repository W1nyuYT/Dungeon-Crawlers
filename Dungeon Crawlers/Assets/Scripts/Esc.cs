using UnityEngine.SceneManagement;
using UnityEngine;


public class Esc : MonoBehaviour
{
    public string sceneBack;
    void Update()
    {   
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(sceneBack);
        }
    }
}
