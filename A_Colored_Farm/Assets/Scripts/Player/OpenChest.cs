using UnityEngine;
using UnityEngine.InputSystem;

public class OpenChest : MonoBehaviour
{
    [SerializeField] private int _chest;
    [SerializeField] private ChestInventory _chestInventory;
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private KeepItem _keepItem;
    [SerializeField] private bool _isTrigger = false;

    public PlayerInput PlayerInput => _playerInput;

    public void OnChest(InputAction.CallbackContext context)
    {
        if (_keepItem.Here == false)
        {
            if (context.performed)
            {
                Debug.Log("je fonctionne");
                if (_keepItem.Id == 0)
                {
                    switch (_chest)
                    {
                        case 1:
                            if (_chestInventory.BlueSeed >= 1)
                            {
                                Debug.Log("je fonctionne 2");
                                _keepItem.Id = 9;
                                _chestInventory.BlueSeed -= 1;
                                _keepItem.Here = true;
                                Debug.Log(_chestInventory.BlueSeed);
                                return;
                            }
                            break;
                        case 2:
                            if (_chestInventory.YellowSeed >= 1)
                            {
                                _keepItem.Id = 10;
                                _chestInventory.YellowSeed -= 1;
                                _keepItem.Here = true;
                                return;
                            }
                            break;
                        case 3:
                            if (_chestInventory.RedSeed >= 1)
                            {
                                _keepItem.Id = 11;
                                _chestInventory.RedSeed -= 1;
                                _keepItem.Here = true;
                                return;
                            }
                            break;
                    }
                }
            }
        }

        if (_keepItem.Here == true)
        {
            if (context.performed)
            {
                switch (_chest)
                {
                    case 1:
                        if (_keepItem.Id == 9)
                        {
                            _keepItem.Id = 0;
                            _chestInventory.BlueSeed += 1;
                            _keepItem.Here = false;
                            return;
                        }
                        break;
                    case 2:
                        if (_keepItem.Id == 10)
                        {
                            _keepItem.Id = 0;
                            _chestInventory.YellowSeed += 1;
                            _keepItem.Here = false;
                            return;
                        }
                        break;
                    case 3:
                        if (_keepItem.Id == 11)
                        {
                            _keepItem.Id = 0;
                            _chestInventory.RedSeed += 1;
                            _keepItem.Here = false;
                            return;
                        }
                        break;
                }
            }
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ChestBlue")
        {
            _isTrigger = true;
            _chest = 1;
        }

        if (collision.gameObject.tag == "ChestYellow")
        {
            _isTrigger = true;
            _chest = 2;
        }

        if (collision.gameObject.tag == "ChestRed")
        {
            _isTrigger = true;
            _chest = 3;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ChestBlue")
        {
            _isTrigger = false;
            _chest = 0;
        }

        if (collision.gameObject.tag == "ChestYellow")
        {
            _isTrigger = false;
            _chest = 0;
        }

        if (collision.gameObject.tag == "ChestRed")
        {
            _isTrigger = false;
            _chest = 0;
        }
    }
}
