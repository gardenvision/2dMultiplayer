using System;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "New InputReader", menuName = "Input/InputReader")]
public class InputReader : ScriptableObject, Controls.IPlayerActions
{
    public event Action<bool> primaryFireEvent;
    private Controls controls;

    private void OnEnable()
    {
        if (controls == null)
        {
            controls = new Controls();
            controls.Player.SetCallbacks(this);
        }

        controls.Enable();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Vector2 movementInput = context.ReadValue<Vector2>();
            // Handle movement input here
            Debug.Log($"Movement Input: {movementInput}");
            
        }
    }

    public void OnPrimaryFire(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            primaryFireEvent?.Invoke(true);
        } else if (context.canceled)
        {
            primaryFireEvent?.Invoke(false);
        }
    }
}