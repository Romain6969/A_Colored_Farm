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
                            Open = true;
                            Time.timeScale = 0;
                        }
                        else
                        {
                            _shopPanel.SetActive(false);
                            Open = false;
                            Time.timeScale = 1;
                        }
                        break;
                    case 1:
                        _inventoryMain.Money += _seedMain.GreySeed.SellValue;
                        _keepItem.Id = 0;
                        break;
                    case 2:
                        _inventoryMain.Money += _seedMain.BlueSeed.SellValue;
                        _keepItem.Id = 0;
                        break;
                    case 3:
                        _inventoryMain.Money += _seedMain.YellowSeed.SellValue;
                        _keepItem.Id = 0;
                        break;
                    case 4:
                        _inventoryMain.Money += _seedMain.RedSeed.SellValue;
                        _keepItem.Id = 0;
                        break;
                    case 5:
                        _inventoryMain.Money += _seedMain.PurpleSeed.SellValue;
                        _keepItem.Id = 0;
                        break;
                    case 6:
                        _inventoryMain.Money += _seedMain.GreenSeed.SellValue;
                        _keepItem.Id = 0;
                        break;
                    case 7:
                        _inventoryMain.Money += _seedMain.OrangeSeed.SellValue;
                        _keepItem.Id = 0;
                        break;
                    case 13:
                        _inventoryMain.Money += _colorMain.ColorsList[0].SellValue;
                        _keepItem.Id = 0;
                        break;
                    case 14:
                        _inventoryMain.Money += _colorMain.ColorsList[1].SellValue;
                        _keepItem.Id = 0;
                        break;
                    case 15:
                        _inventoryMain.Money += _colorMain.ColorsList[2].SellValue;
                        _keepItem.Id = 0;
                        break;
                    case 16:
                        _inventoryMain.Money += _colorMain.ColorsList[3].SellValue;
                        _keepItem.Id = 0;
                        break;
                    case 17:
                        _inventoryMain.Money += _colorMain.ColorsList[4].SellValue;
                        _keepItem.Id = 0;
                        break;
                    case 18:
                        _inventoryMain.Money += _colorMain.ColorsList[5].SellValue;
                        _keepItem.Id = 0;
                        break;
                    case 19:
                        _inventoryMain.Money += _colorMain.ColorsList[6].SellValue;
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
