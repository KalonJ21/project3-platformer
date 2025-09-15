using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // used to restart the game


public class GameTimer : MonoBehaviour
{
    public TMP_Text timerText;
    public GameObject winScreen;

    public float timeLeft = 30f; // set game time of 30 sec (can change in Inspector window of Timertext as well)
    private bool hasWon = false;

    void Update()
    {
        if (!hasWon)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = "Time: " + Mathf.CeilToInt(timeLeft);

            if (timeLeft <= 0)
            {
                hasWon = true;
                WinGame();
            }
        }
    }

    void WinGame()
    {
        winScreen.SetActive(true);
        timerText.gameObject.SetActive(false);
        Time.timeScale = 0f; // freezes all time-based actions (physics, Update, etc)
    }

    public void StopTimer() // stops the timer when 30 seconds is up
    {
        hasWon = true;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // Unpause the game after it's been frozen to either "Game Over" or "You Win" 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reloads the current scene
    }


}
