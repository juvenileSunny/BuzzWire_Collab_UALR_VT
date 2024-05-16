using UnityEngine;
using UnityEngine.SceneManagement; // Required for changing scenes

public class HoverChangeScene : MonoBehaviour
{
    // The name of the scene you want to load
    public string sceneNameToLoad;

    public void OnMouseEnter()
    {
        ChangeScene();
    }

    public void ChangeScene()
    {
        // Make sure the scene you're trying to load is added to the build settings
        SceneManager.LoadScene(sceneNameToLoad);
    }
}

