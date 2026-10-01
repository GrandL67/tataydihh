using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 10f;
    public LayerMask groundLayer;
    public Transform groundCheck;

    private Rigidbody2D rb;
    private bool isGrounded;
    private bool jumpRequested; // Fixed: Removed the broken playerInput initialization

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 1. Always capture discrete button presses in Update so they are never missed
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("stupid lil devil tried to jump");
            Debug.Log($"Space pressed! Am I grounded? {isGrounded}");
            jumpRequested = true;
        }
    }

    void FixedUpdate()
    {
        // 2. Check if the player is touching the ground
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.3f, groundLayer);

        // 3. Apply physics using the jumpRequested flag captured from Update
        if (jumpRequested && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        // 4. Reset the flag at the end of the physics frame
        jumpRequested = false;
    }
}
