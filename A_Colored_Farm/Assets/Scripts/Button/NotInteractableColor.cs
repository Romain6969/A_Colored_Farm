using UnityEngine;
using UnityEngine.UI;

public class NotInteractableColor : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private int _color;
    [SerializeField] private InventoryColor _inventoryColor;

    void Update()
    {
        switch (_color)
        {
            case 1:
                if (_inventoryColor.GetAmount("Grey") >= 1)
                {
                    _button.interactable = true;
                }
                else
                {
                    _button.interactable = false;
                }
                break;
            case 2:
                if (_inventoryColor.GetAmount("Blue") >= 1)
                {
                    _button.interactable = true;
                }
                else
                {
                    _button.interactable = false;
                }
                break;
            case 3:
                if (_inventoryColor.GetAmount("Yellow") >= 1)
                {
                    _button.interactable = true;
                }
                else
                {
                    _button.interactable = false;
                }
                break;
            case 4:
                if (_inventoryColor.GetAmount("Red") >= 1)
                {
                    _button.interactable = true;
                }
                else
                {
                    _button.interactable = false;
                }
                break;
            case 5:
                if (_inventoryColor.GetAmount("Green") >= 1)
                {
                    _button.interactable = true;
                }
                else
                {
                    _button.interactable = false;
                }
                break;
            case 6:
                if (_inventoryColor.GetAmount("Purple") >= 1)
                {
                    _button.interactable = true;
                }
                else
                {
                    _button.interactable = false;
                }
                break;
            case 7:
                if (_inventoryColor.GetAmount("Orange") >= 1)
                {
                    _button.interactable = true;
                }
                else
                {
                    _button.interactable = false;
                }
                break;
        }
    }
}
