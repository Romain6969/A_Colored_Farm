using UnityEngine;
using UnityEngine.InputSystem;

public class TakeBrush : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] InventoryColor InventoryColor;
    [SerializeField] private KeepItem _keepItem;
    [SerializeField] private SpriteSwap _spriteswap;
    [SerializeField] private AnimationFridge _animationFridge;
    private bool _isTrigger = false;

    public PlayerInput PlayerInput => _playerInput;

    public void OnBrush(InputAction.CallbackContext context)
    {
        if (_isTrigger == true)
        {
            if (context.performed)
            {
                switch (_keepItem.Id)
                {
                    case 0:
                        _keepItem.Id = 21;
                        _spriteswap.Use = true;
                        break;
                    case 21:
                        _keepItem.Id = 0;
                        _spriteswap.Use = false;
                        break;
                    case 22:
                        InventoryColor.AddSeed("Grey", 1);
                        _keepItem.Id = 0;
                        break;
                    case 23:
                        InventoryColor.AddSeed("Blue", 1);
                        _keepItem.Id = 0;
                        break;
                    case 24:
                        InventoryColor.AddSeed("Yellow", 1);
                        _keepItem.Id = 0;
                        break;
                    case 25:
                        InventoryColor.AddSeed("Red", 1);
                        _keepItem.Id = 0;
                        break;
                    case 26:
                        InventoryColor.AddSeed("Purple", 1);
                        _keepItem.Id = 0;
                        break;
                    case 27:
                        InventoryColor.AddSeed("Green", 1);
                        _keepItem.Id = 0;
                        break;
                    case 28:
                        InventoryColor.AddSeed("Orange", 1);
                        _keepItem.Id = 0;
                        break;
                }
                _animationFridge.OnAnimation();
            }
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Brush")
        {
            _isTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Brush")
        {
            _isTrigger = false;
        }
    }
}
