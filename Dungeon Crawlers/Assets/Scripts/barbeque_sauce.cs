using UnityEngine.SceneManagement;
using UnityEngine;


public class barbecue_sauce : MonoBehaviour
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
