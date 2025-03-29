using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuController : MonoBehaviour
{
    public void LoadScene (string sceneName)
    {
        Debug.Log($"trying to load Scene: {sceneName}");
        SceneManager.LoadScene (sceneName);
    }
}
