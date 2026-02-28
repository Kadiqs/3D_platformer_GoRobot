using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtonControls : MonoBehaviour
{
    // Start Button
    public void startLevel()
    {
        Time.timeScale = 1f;
        // Reloads the current active scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // "Restart" Button
    public void RestartLevel()
    {
        Time.timeScale = 1f;
        // Reloads the current active scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    // "Main Menu" Button
    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        //Debug.Log("Quitting Game..."); // Shows in Unity Console
        Application.Quit(); // Closes the game window (only works in the built game)

    }
}
