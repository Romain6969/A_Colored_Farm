using UnityEngine;
using UnityEngine.InputSystem;

public class PlaceColor : MonoBehaviour
{
    [field: SerializeField] public bool IsPainting { get; set; }
    [SerializeField] private PlayerInput _playerInput;

    public PlayerInput PlayerInput => _playerInput;

    private void Start()
    {
        IsPainting = false;
    }

    public void OnPaint(InputAction.CallbackContext context)
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
