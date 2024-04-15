using UnityEngine;
using UnityEngine.InputSystem;

public class PlaceSeed : MonoBehaviour
{
    [field: SerializeField] public bool IsPlanting { get; set; }
    [SerializeField] private PlayerInput _playerInput;

    public PlayerInput PlayerInput => _playerInput;

    private void Start()
    {
        IsPlanting = false;
    }

    public void OnPlant(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            IsPlanting = true;
        }
    }
}
