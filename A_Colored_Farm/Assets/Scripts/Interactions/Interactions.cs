using UnityEngine;
using UnityEngine.InputSystem;

public class Interactions : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    [field: SerializeField] public bool IsPerformed { get; set; } = false;

    public PlayerInput PlayerInput => _playerInput;

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            IsPerformed = true;
        }
        if (context.canceled)
        {
            IsPerformed = false;
        }
    }
}
