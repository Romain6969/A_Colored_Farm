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
    [SerializeField] private float _value = 2;
    [SerializeField] public int RandomLimit { get; set; } = 8;
    [field : SerializeField] public int Command { get; set; }
    private bool _isTrigger = false;
    [SerializeField] private MoneyAnimation _moneyAnimation;

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
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_seedMain.GreySeed.SellValue * _value));
                            OnRestart();
                        }
                        break;
                    case 1:
                        if (_keepItem.Id == 2)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_seedMain.BlueSeed.SellValue * _value));
                            OnRestart();
                        }
                        break;
                    case 2:
                        if (_keepItem.Id == 3)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_seedMain.YellowSeed.SellValue * _value));
                            OnRestart();
                        }
                        break;
                    case 3:
                        if (_keepItem.Id == 4)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_seedMain.RedSeed.SellValue * _value));
                            OnRestart();
                        }
                        break;
                    case 4:
                        if (_keepItem.Id == 22)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_colorMain.ColorsList[0].SellValue * _value));
                            OnRestart();
                        }
                        break;
                    case 5:
                        if (_keepItem.Id == 23)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_colorMain.ColorsList[1].SellValue * _value));
                            OnRestart();
                        }
                        break;
                    case 6:
                        if (_keepItem.Id == 24)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_colorMain.ColorsList[2].SellValue * _value));
                            OnRestart();
                        }
                        break;
                    case 7:
                        if (_keepItem.Id == 25)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_colorMain.ColorsList[3].SellValue *   _value));
                            OnRestart();
                        }
                        break;
                    case 8:
                        if (_keepItem.Id == 5)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_seedMain.PurpleSeed.SellValue * _value));
                            OnRestart();
                        }
                        break;
                    case 9:
                        if (_keepItem.Id == 6)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_seedMain.GreenSeed.SellValue * _value));
                            OnRestart();
                        }
                        break;
                    case 10:
                        if (_keepItem.Id == 7)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_seedMain.OrangeSeed.SellValue *   _value));
                            OnRestart();
                        }
                        break;
                    case 11:
                        if (_keepItem.Id == 26)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_colorMain.ColorsList[4].SellValue * _value));
                            OnRestart();
                        }
                        break;
                    case 12:
                        if (_keepItem.Id == 27)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_colorMain.ColorsList[5].SellValue * _value));
                            OnRestart();
                        }
                        break;
                    case 13:
                        if (_keepItem.Id == 28)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_colorMain.ColorsList[6].SellValue * _value));
                            OnRestart();
                        }
                        break;
                    case 14:
                        if (_keepItem.Id == 8)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_seedMain.CyanSeed.SellValue * _value));
                            OnRestart();
                        }
                        break;
                    case 15:
                        if (_keepItem.Id == 9)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_seedMain.IndigoSeed.SellValue * _value));
                            OnRestart();
                        }
                        break;
                    case 16:
                        if (_keepItem.Id == 10)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_seedMain.LimeSeed.SellValue * _value));
                            OnRestart();
                        }
                        break;
                    case 17:
                        if (_keepItem.Id == 11)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_seedMain.OcreSeed.SellValue * _value));
                            OnRestart();
                        }
                        break;
                    case 18:
                        if (_keepItem.Id == 12)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_seedMain.MagentaSeed.SellValue * _value));
                            OnRestart();
                        }
                        break;
                    case 19:
                        if (_keepItem.Id == 13)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_seedMain.OrSeed.SellValue * _value));
                            OnRestart();
                        }
                        break;
                    case 20:
                        if (_keepItem.Id == 29)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_colorMain.ColorsList[7].SellValue * _value));
                            OnRestart();
                        }
                        break;
                    case 21:
                        if (_keepItem.Id == 30)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_colorMain.ColorsList[8].SellValue * _value));
                            OnRestart();
                        }
                        break;
                    case 22:
                        if (_keepItem.Id == 31)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_colorMain.ColorsList[9].SellValue * _value));
                            OnRestart();
                        }
                        break;
                    case 23:
                        if (_keepItem.Id == 32)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_colorMain.ColorsList[10].SellValue * _value));
                            OnRestart();
                        }
                        break;
                    case 24:
                        if (_keepItem.Id == 33)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_colorMain.ColorsList[11].SellValue * _value));
                            OnRestart();
                        }
                        break;
                    case 25:
                        if (_keepItem.Id == 34)
                        {
                            _moneyAnimation.OnAnimation(0);
                            _inventoryMain.AddValue((_colorMain.ColorsList[12].SellValue * _value));
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
        _movement.Time2 = 0;
        _movement.ProgressBarGameObject.SetActive(false);
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
