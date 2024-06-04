using UnityEngine;
using UnityEngine.InputSystem;

public class PlaceSeed : MonoBehaviour
{
    [field: SerializeField] public bool IsPlanting { get; set; }
    [SerializeField] private PlayerInput _playerInput;
    private bool _triggered;
    [SerializeField] private Tutorial _tutorial;
    [SerializeField] private KeepItem _keepItem;

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
                if (_keepItem.Id == 14)
                {
                    _tutorial.WhenPlayerPlant = true;
                }
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

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Dirt")
        {
            _triggered = false;
        }
    }
}
