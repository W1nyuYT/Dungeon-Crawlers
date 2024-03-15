using UnityEngine;
using UnityEngine.SceneManagement;

public class chicken_sandwich : MonoBehaviour
{

    public string sceneName;

    void OnTriggerExit(Collider other)
    {
        Debug.Log("debug");
        if (other.CompareTag("Mouse"))
        {
            LoadScene();
        }
    }

    void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
