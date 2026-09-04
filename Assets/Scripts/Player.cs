using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    private bool isGrounded;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private InputAction playerControls;
    [SerializeField] private Vector2 moveDirection;

    void Update()
    {
        moveDirection = playerControls.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveDirection * moveSpeed;

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        if (isGrounded && playerControls.triggered)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }
}