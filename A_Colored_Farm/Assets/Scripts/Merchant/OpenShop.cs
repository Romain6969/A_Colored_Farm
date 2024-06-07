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
    [SerializeField] private Tutorial _tutorial;
    [SerializeField] private MoneyAnimation _moneyAnimation;
    [SerializeField] private PlaySounds _playSounds;
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
                            _playSounds.PlayAudio(8);
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
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_seedMain.GreySeed.SellValue);
                        _keepItem.Id = 0;
                        if (_tutorial.WhenplayerSellPlant == false)
                        {
                            _tutorial.IndicatorsList[0].SetActive(false);
                            _tutorial.WhenplayerSellPlant = true;
                        }
                        break;
                    case 2:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_seedMain.BlueSeed.SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 3:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_seedMain.YellowSeed.SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 4:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_seedMain.RedSeed.SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 5:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_seedMain.PurpleSeed.SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 6:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_seedMain.GreenSeed.SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 7:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_seedMain.OrangeSeed.SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 8:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_seedMain.CyanSeed.SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 9:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_seedMain.IndigoSeed.SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 10:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_seedMain.LimeSeed.SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 11:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_seedMain.OcreSeed.SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 12:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_seedMain.MagentaSeed.SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 13:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_seedMain.OrSeed.SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 22:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_colorMain.ColorsList[0].SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 23:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_colorMain.ColorsList[1].SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 24:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_colorMain.ColorsList[2].SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 25:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_colorMain.ColorsList[3].SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 26:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_colorMain.ColorsList[4].SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 27:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_colorMain.ColorsList[5].SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 28:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_colorMain.ColorsList[6].SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 29:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_colorMain.ColorsList[7].SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 30:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_colorMain.ColorsList[8].SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 31:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_colorMain.ColorsList[9].SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 32:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_colorMain.ColorsList[10].SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 33:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_colorMain.ColorsList[11].SellValue);
                        _keepItem.Id = 0;
                        break;
                    case 34:
                        _playSounds.PlayAudio(7);
                        _moneyAnimation.OnAnimation(0);
                        _inventoryMain.AddValue(_colorMain.ColorsList[12].SellValue);
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
