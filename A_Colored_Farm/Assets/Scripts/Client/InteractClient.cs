using UnityEngine;
using UnityEngine.InputSystem;

public class InteractClient : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private ClientMovement _movement;
    [SerializeField] private InventoryMain _inventoryMain;
    [SerializeField] private KeepItem _keepItem;
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private ColorMain _colorMain;
    [SerializeField] public int RandomLimit { get; set; } = 8;
    [SerializeField] public int Command { get; set; }
    private bool _isTrigger = false;

    public PlayerInput PlayerInput => _playerInput;

    void Start()
    {
        OnRandom();
    }

    public void OnRandom()
    {
        Command = Random.Range(0, RandomLimit);
        Debug.Log($"La commande numéro {Command}");
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (_isTrigger == true)
        {
            if (context.performed) 
            {
                switch (Command)
                {
                    case 0:
                        if (_keepItem.Id == 1)
                        {
                            _inventoryMain.AddValue((_seedMain.GreySeed.SellValue * 3));
                            OnRestart();
                        }
                        break;
                    case 1:
                        if (_keepItem.Id == 2)
                        {
                            _inventoryMain.AddValue((_seedMain.BlueSeed.SellValue * 3));
                            OnRestart();
                        }
                        break;
                    case 2:
                        if (_keepItem.Id == 3)
                        {
                            _inventoryMain.AddValue((_seedMain.YellowSeed.SellValue * 3));
                            OnRestart();
                        }
                        break;
                    case 3:
                        if (_keepItem.Id == 4)
                        {
                            _inventoryMain.AddValue((_seedMain.RedSeed.SellValue * 3));
                            OnRestart();
                        }
                        break;
                    case 4:
                        if (_keepItem.Id == 13)
                        {
                            _inventoryMain.AddValue((_colorMain.ColorsList[0].SellValue * 3));
                            OnRestart();
                        }
                        break;
                    case 5:
                        if (_keepItem.Id == 14)
                        {
                            _inventoryMain.AddValue((_colorMain.ColorsList[1].SellValue * 3));
                            OnRestart();
                        }
                        break;
                    case 6:
                        if (_keepItem.Id == 15)
                        {
                            _inventoryMain.AddValue((_colorMain.ColorsList[2].SellValue * 3));
                            OnRestart();
                        }
                        break;
                    case 7:
                        if (_keepItem.Id == 16)
                        {
                            _inventoryMain.AddValue((_colorMain.ColorsList[3].SellValue * 3));
                            OnRestart();
                        }
                        break;
                    case 8:
                        if (_keepItem.Id == 5)
                        {
                            _inventoryMain.AddValue((_seedMain.PurpleSeed.SellValue * 3));
                            OnRestart();
                        }
                        break;
                    case 9:
                        if (_keepItem.Id == 6)
                        {
                            _inventoryMain.AddValue((_seedMain.GreenSeed.SellValue * 3));
                            OnRestart();
                        }
                        break;
                    case 10:
                        if (_keepItem.Id == 7)
                        {
                            _inventoryMain.AddValue((_seedMain.OrangeSeed.SellValue * 3));
                            OnRestart();
                        }
                        break;
                    case 11:
                        if (_keepItem.Id == 17)
                        {
                            _inventoryMain.AddValue((_colorMain.ColorsList[4].SellValue * 3));
                            OnRestart();
                        }
                        break;
                    case 12:
                        if (_keepItem.Id == 18)
                        {
                            _inventoryMain.AddValue((_colorMain.ColorsList[5].SellValue * 3));
                            OnRestart();
                        }
                        break;
                    case 13:
                        if (_keepItem.Id == 19)
                        {
                            _inventoryMain.AddValue((_colorMain.ColorsList[6].SellValue * 3));
                            OnRestart();
                        }
                        break;
                }
            }
        }
    }

    public void OnRestart()
    {
        _keepItem.Id = 0;
        Command = -1;
        _movement.Back = true;
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Client")
        {
            _isTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Client")
        {
            _isTrigger = false;
        }
    }
}
