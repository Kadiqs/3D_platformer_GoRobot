using UnityEngine;
using System.Collections;
public class UIManager : MonoBehaviour
{
    // Singleton Instance so other scripts can call UIManager.instance.ShowGameOver();
    public static UIManager instance;

    [SerializeField] GameObject EndDisplay;
    public GameObject gameOverPanel; // Drag your Game Over Panel here
    public GameObject victoryPanel;  // Drag your Win/Victory Panel here
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Call this function when the player dies
    public void ShowGameOver()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
            //Time.timeScale = 0f; // Pauses the game
            StartCoroutine(StopAfterDely(3));
        }
    }
    // Call this function when the player triggers the win condition
    public void ShowVictory()
    {
        if (victoryPanel != null)
        {
            victoryPanel.SetActive(true);
            //Time.timeScale = 0f; // Pauses the game
            StartCoroutine(StopAfterDely(1));
        }

    }
    IEnumerator StopAfterDely(float time)
    {
        yield return new WaitForSeconds(time);
        Time.timeScale = 0f;
    }

}
