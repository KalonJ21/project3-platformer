using UnityEngine;
// used to test that there is ground below player after jumping and landing 
public class PlayerController : MonoBehaviour
{
    public float jumpForce = 60f; // You can tweak this in the Inspector
    private Rigidbody2D rb;
    private bool isGrounded = false;

    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Check if touching ground
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        // Jump if on ground and Space is pressed
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }
}

