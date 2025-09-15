using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f; // Match the background scroll speed and keeps enemy coming at you

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
