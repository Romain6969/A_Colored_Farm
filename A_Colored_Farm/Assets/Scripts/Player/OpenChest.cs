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
                        case 0:
                            if (_chestInventory.GraySeed >= 1)
                            {
                                _keepItem.Id = 14;
                                _chestInventory.GraySeed -= 1;
                                _keepItem.Here = true;
                                return;
                            }
                            break;
                        case 1:
                            if (_chestInventory.BlueSeed >= 1)
                            {
                                _keepItem.Id = 15;
                                _chestInventory.BlueSeed -= 1;
                                _keepItem.Here = true;
                                return;
                            }
                            break;
                        case 2:
                            if (_chestInventory.YellowSeed >= 1)
                            {
                                _keepItem.Id = 16;
                                _chestInventory.YellowSeed -= 1;
                                _keepItem.Here = true;
                                return;
                            }
                            break;
                        case 3:
                            if (_chestInventory.RedSeed >= 1)
                            {
                                _keepItem.Id = 17;
                                _chestInventory.RedSeed -= 1;
                                _keepItem.Here = true;
                                return;
                            }
                            break;
                        case 4:
                            if (_chestInventory.PurpleSeed >= 1)
                            {
                                _keepItem.Id = 18;
                                _chestInventory.PurpleSeed -= 1;
                                _keepItem.Here = true;
                                return;
                            }
                            break;
                        case 5:
                            if (_chestInventory.GreenSeed >= 1)
                            {
                                _keepItem.Id = 19;
                                _chestInventory.GreenSeed -= 1;
                                _keepItem.Here = true;
                                return;
                            }
                            break;
                        case 6:
                            if (_chestInventory.OrangeSeed >= 1)
                            {
                                _keepItem.Id = 20;
                                _chestInventory.OrangeSeed -= 1;
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
                    case 0:
                        if (_keepItem.Id == 14)
                        {
                            _keepItem.Id = 0;
                            _chestInventory.GraySeed += 1;
                            _keepItem.Here = false;
                            return;
                        }
                        break;
                    case 1:
                        if (_keepItem.Id == 15)
                        {
                            _keepItem.Id = 0;
                            _chestInventory.BlueSeed += 1;
                            _keepItem.Here = false;
                            return;
                        }
                        break;
                    case 2:
                        if (_keepItem.Id == 16)
                        {
                            _keepItem.Id = 0;
                            _chestInventory.YellowSeed += 1;
                            _keepItem.Here = false;
                            return;
                        }
                        break;
                    case 3:
                        if (_keepItem.Id == 17)
                        {
                            _keepItem.Id = 0;
                            _chestInventory.RedSeed += 1;
                            _keepItem.Here = false;
                            return;
                        }
                        break;
                    case 4:
                        if (_keepItem.Id == 18)
                        {
                            _keepItem.Id = 0;
                            _chestInventory.PurpleSeed += 1;
                            _keepItem.Here = false;
                            return;
                        }
                        break;
                    case 5:
                        if (_keepItem.Id == 19)
                        {
                            _keepItem.Id = 0;
                            _chestInventory.GreenSeed += 1;
                            _keepItem.Here = false;
                            return;
                        }
                        break;
                    case 6:
                        if (_keepItem.Id == 20)
                        {
                            _keepItem.Id = 0;
                            _chestInventory.OrangeSeed += 1;
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
        if (collision.gameObject.tag == "ChestGray")
        {
            _isTrigger = true;
            _chest = 0;
        }

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

        if (collision.gameObject.tag == "ChestPurple")
        {
            _isTrigger = true;
            _chest = 4;
        }

        if (collision.gameObject.tag == "ChestGreen")
        {
            _isTrigger = true;
            _chest = 5;
        }

        if (collision.gameObject.tag == "ChestOrange")
        {
            _isTrigger = true;
            _chest = 6;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ChestGray")
        {
            _isTrigger = false;
            _chest = -1;
        }

        if (collision.gameObject.tag == "ChestBlue")
        {
            _isTrigger = false;
            _chest = -1;
        }

        if (collision.gameObject.tag == "ChestYellow")
        {
            _isTrigger = false;
            _chest = -1;
        }

        if (collision.gameObject.tag == "ChestRed")
        {
            _isTrigger = false;
            _chest = -1;
        }

        if (collision.gameObject.tag == "ChestPurple")
        {
            _isTrigger = false;
            _chest = -1;
        }

        if (collision.gameObject.tag == "ChestGreen")
        {
            _isTrigger = false;
            _chest = -1;
        }

        if (collision.gameObject.tag == "ChestOrange")
        {
            _isTrigger = false;
            _chest = -1;
        }
    }
}
