using UnityEngine;
using UnityEngine.SceneManagement;

public class exitToMenu : MonoBehaviour
{
    public void ReturnToMenu()
    {
        Debug.Log("back to menu");
        SceneManager.LoadScene("Menu");
    }

}

