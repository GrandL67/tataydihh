using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    
private InputAction _moveAction, _jumpAction;
private CharacterController _characterController;

    private void Awake()
    {
    _moveAction = InputSystem.actions.FindAction("Move");
    _jumpAction = InputSystem.actions.FindAction("Jump");

    _jumpAction.performed += jump;
    _characterController = GetComponent<CharacterController>();
    }

private void jump(InputAction.CallbackContext context)
    {
        
    _characterController.jump();


    }
void Update()
    {
        Vector2 moveVector = _moveAction.ReadValue<Vector2>();
        _characterController.Move(moveVector);

    }


}