using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene"); // replace with your scene name
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
