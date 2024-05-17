using UnityEngine;
using TMPro;

public class MoneyUi : MonoBehaviour
{
    [SerializeField] private InventoryMain _inventoryMain;
    [SerializeField] private TMP_Text _textMoney;

    void Update()
    {
        _textMoney.text = $"Money : {_inventoryMain.Money}";
    }
}
