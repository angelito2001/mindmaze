using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Add this for scene management

public class SceneNav : MonoBehaviour
{
    public GameObject activeScene; // The current menu or scene
    public GameObject nextScene; // The next scene to navigate to

    public void BtnNextScene()
    {
        activeScene.SetActive(false); // Hide the current scene
        nextScene.SetActive(true); // Show the next scene
    }

    // Method to start the game
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene"); // Replace with your game's starting scene name
    }

    // Method to quit the game
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is quitting"); // Logs to the console for testing in the editor
    }
}
