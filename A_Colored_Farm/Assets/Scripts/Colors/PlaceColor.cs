using UnityEngine;
using UnityEngine.InputSystem;

public class PlaceColor : MonoBehaviour
{
    [field: SerializeField] public bool IsPainting { get; set; } = false;
    [field: SerializeField] public bool IsOpen { get; set; }
    [SerializeField] private PlayerInput _playerInput;
    [field: SerializeField] public bool CanPaint { get; set; } = true;

    public PlayerInput PlayerInput => _playerInput;

    public void OnPaint(InputAction.CallbackContext context)
    {
        if (CanPaint)
        {
            if (context.performed)
            {
                IsPainting = true;
            }
            if (context.canceled)
            {
                IsPainting = false;
            }
        }
    }

    /*
    public bool Open()
    {
        if (IsOpen == true)
        {
            return IsOpen = false;
        }
        else
        {
            return IsOpen = true;
        }
    }
    */
}
