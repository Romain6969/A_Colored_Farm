using UnityEngine;
using UnityEngine.InputSystem;

public class OpenCrusher : MonoBehaviour
{
    [field: SerializeField] public bool Open { get; set; }
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private KeepItem _keepItem;
    [SerializeField] private Crusher _crusher;
    private bool _isTrigger = false;

    public PlayerInput PlayerInput => _playerInput;

    public void OnCrusher(InputAction.CallbackContext context)
    {
        if (_isTrigger == true)
        {
            if (context.performed)
            {
                if (_keepItem.Id == 1 || _keepItem.Id == 2 || _keepItem.Id == 3 || _keepItem.Id == 4 || _keepItem.Id == 5 || _keepItem.Id == 6 || _keepItem.Id == 7)
                {
                    if (_keepItem.Here == true)
                    {
                        _crusher.OnActivated();
                        _keepItem.Id = 0;
                        _keepItem.Here = false;
                    }
                }

                if (_keepItem.Here == false)
                {
                    if (_crusher.Ready == true)
                    {
                        switch (_crusher.CopyId)
                        {
                            case 1:
                                _keepItem.Id = 13;
                                break;
                            case 2:
                                _keepItem.Id = 14;
                                break;
                            case 3:
                                _keepItem.Id = 15;
                                break;
                            case 4:
                                _keepItem.Id = 16;
                                break;
                            case 5:
                                _keepItem.Id = 17;
                                break;
                            case 6:
                                _keepItem.Id = 18;
                                break;
                            case 7:
                                _keepItem.Id = 19;
                                break;
                        }
                    }
                }
            }
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Crusher")
        {
            _isTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Crusher")
        {
            _isTrigger = false;
        }
    }
}
