using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraSystem : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float cameraSpeed = 50.0f;
    
    private Vector3 _inputDirection = Vector3.zero;
    private void Update()
    {
        Vector3 moveDirection = transform.forward * _inputDirection.z + transform.right * _inputDirection.x;
        transform.position += moveDirection * (cameraSpeed * Time.deltaTime);
    }

    public void MoveForward(InputAction.CallbackContext context)
    {
        Debug.Log("Moviendo Delante");
        if (context.performed) // Cuando se presiona la tecla
        {
            _inputDirection.z = +1f;
        }
        else if (context.canceled) // Cuando se suelta la tecla
        {
            _inputDirection.z = 0f;
        }
    }

    public void MoveBackward(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _inputDirection.z = -1f;
        }
        else if (context.canceled)
        {
            _inputDirection.z = 0f;
        }
    }

    public void MoveLeft(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _inputDirection.x = -1f;
        }
        else if (context.canceled)
        {
            _inputDirection.x = 0f;
        }
    }

    public void MoveRight(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _inputDirection.x = +1f;
        }
        else if (context.canceled)
        {
            _inputDirection.x = 0f;
        }
    }
}
