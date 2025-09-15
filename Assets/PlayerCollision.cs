using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            Debug.Log("Game Over! Player hit an enemy.");// to test collision in the console

            PlayerManager.isGameOver = true; 
            Time.timeScale = 0f; // Freeze everything
            
        }
    }
}








/* FIRST CODE (og)
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private bool isGameOver = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && !isGameOver)
        {
            isGameOver = true;
            Debug.Log("Game Over! Player hit an enemy.");
            Time.timeScale = 0f; // Freeze everything
            // Optional: Trigger game over logic here later
        }
    }
}
*/



