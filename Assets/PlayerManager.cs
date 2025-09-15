using UnityEngine;
// calls and keeps tracks of the game timer and the game over function if player touches an enemy
public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;

    private GameTimer gameTimer; // reference to timer

    private void Awake()
    {
        isGameOver = false;
    }

    void Start() 
    {
        // Find the GameTimer in the scene
        gameTimer = Object.FindFirstObjectByType<GameTimer>();
    }

    void Update() 
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);

            if (gameTimer != null)
            {
                gameTimer.StopTimer(); // stop the timer from counting down
            }
        }
    }
}



/* //OG CODE

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;
    private void Awake()
    {
        isGameOver = false;
    }


    void Start() 
    {

    }

    void Update() 
    {
        if(isGameOver)
        {
            gameOverScreen.SetActive(true);

        }
    }
    

}
*/
