using UnityEngine;
using UnityEngine.InputSystem;

public class OpenShop : MonoBehaviour
{
    [field: SerializeField] public bool Open { get; set; }
    [SerializeField] private GameObject _shopPanel;
    [SerializeField] private InventoryMain _inventoryMain;
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private ColorMain _colorMain;
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private KeepItem _keepItem;
    [SerializeField] private Movement _movement;
    [SerializeField] private OpenPause _pause;
    private bool _isTrigger = false;

    public PlayerInput PlayerInput => _playerInput;

    public void OnShop(InputAction.CallbackContext context)
    {
        if (_isTrigger == true)
        {
            if (context.performed)
            {
                switch (_keepItem.Id)
                {
                    case 0:
                        if (Open == false)
                        {
                            _shopPanel.SetActive(true);
                            _movement.CanMove = false;
                            _pause.Open = 1;
                            Open = true;
                        }
                        else
                        {
                            _shopPanel.SetActive(false);
                            _movement.CanMove = true;
                            _pause.Open = 2;
                            Open = false;
                        }
                        break;
                    case 1:
                        _inventoryMain.AddValue(_seedMain.GreySeed.SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 2:
                        _inventoryMain.AddValue(_seedMain.BlueSeed.SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 3:
                        _inventoryMain.AddValue(_seedMain.YellowSeed.SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 4:
                        _inventoryMain.AddValue(_seedMain.RedSeed.SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 5:
                        _inventoryMain.AddValue(_seedMain.PurpleSeed.SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 6:
                        _inventoryMain.AddValue(_seedMain.GreenSeed.SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 7:
                        _inventoryMain.AddValue(_seedMain.OrangeSeed.SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 13:
                        _inventoryMain.AddValue(_colorMain.ColorsList[0].SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 14:
                        _inventoryMain.AddValue(_colorMain.ColorsList[1].SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 15:
                        _inventoryMain.AddValue(_colorMain.ColorsList[2].SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 16:
                        _inventoryMain.AddValue(_colorMain.ColorsList[3].SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 17:
                        _inventoryMain.AddValue(_colorMain.ColorsList[4].SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 18:
                        _inventoryMain.AddValue(_colorMain.ColorsList[5].SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 19:
                        _inventoryMain.AddValue(_colorMain.ColorsList[6].SellValue);
                        _keepItem.Id = 0;
                        break;
                }
            }
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shop")
        {
            _isTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shop")
        {
            _isTrigger = false;
        }
    }
}
