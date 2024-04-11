using UnityEngine;
using UnityEngine.InputSystem;

public class Interactions : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    [field: SerializeField] public bool IsPerformed { get; set; }

    public PlayerInput PlayerInput => _playerInput;

    private void Start()
    {
        IsPerformed = false;
    }

    public void OnShop(InputAction.CallbackContext context)
    {
        if (context.performed == true)
        {
            if (IsPerformed == false)
            {
                IsPerformed = true;
            }
            else
            {
                IsPerformed = false;
            }
        }
    }
}
