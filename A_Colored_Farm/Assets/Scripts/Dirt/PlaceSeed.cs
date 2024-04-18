using UnityEngine;
using UnityEngine.InputSystem;

public class PlaceSeed : MonoBehaviour
{
    [field: SerializeField] public bool IsPlanting { get; set; }
    [SerializeField] private PlayerInput _playerInput;
    private float _time;
    private bool _triggered;

    public PlayerInput PlayerInput => _playerInput;

    private void Start()
    {
        IsPlanting = false;
    }

    public void OnPlant(InputAction.CallbackContext context)
    {
        if (_triggered == true)
        {
            if (context.performed)
            {
                IsPlanting = true;
            }

            if (context.canceled)
            {
                IsPlanting = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Dirt")
        {
            _triggered = true;
        }
    }
}
