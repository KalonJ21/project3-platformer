using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed = 5f;
    public float resetPositionX;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime); // keeps the background infinitely scrolling 

        if (transform.position.x < -resetPositionX)
        {
            transform.position = startPosition;
        }
    }

}