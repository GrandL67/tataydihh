using Unity.VisualScripting;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
[SerializeField] private float _movementSpeed = 5f, _jumpForce = 5f;

private Rigidbody2D _rigidbody;
private Vector2 _moveVector;

private bool _jumpRequested = false;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();





    }

private void FixedUpdate()
    {
        
        _rigidbody.linearVelocityX = _moveVector.x*_movementSpeed;

        if (_jumpRequested)
        {
            _rigidbody.linearVelocityY = _jumpForce;
            _jumpRequested = false;

        }
    }

    public void Move(Vector2 moveVector)
    {
        _moveVector = moveVector;

    }

    public void jump()
    {
        _jumpRequested = true;

    }
}
