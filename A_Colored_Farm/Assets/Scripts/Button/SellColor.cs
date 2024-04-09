using UnityEngine;

public class SellColor : MonoBehaviour
{
    [SerializeField] private InventoryMain _inventoryMain;
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private float _id;

    public void OnClick()
    {
        switch (_id)
        {
            case 1:
                if (_inventoryMain.InventoryColor.NumberBlue >= 1)
                {
                    _inventoryMain.Money += _seedMain.BlueSeed.SellValue;
                    _inventoryMain.InventoryColor.NumberBlue -= 1;
                }
                break;
            case 2:
                if (_inventoryMain.InventoryColor.NumberYellow >= 1)
                {
                    _inventoryMain.Money += _seedMain.YellowSeed.SellValue;
                    _inventoryMain.InventoryColor.NumberYellow -= 1;
                }
                break;
            case 3:
                if (_inventoryMain.InventoryColor.NumberRed >= 1)
                {
                    _inventoryMain.Money += _seedMain.RedSeed.SellValue;
                    _inventoryMain.InventoryColor.NumberRed -= 1;
                }
                break;
        }
    }
}
