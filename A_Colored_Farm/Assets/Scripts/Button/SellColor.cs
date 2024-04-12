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
            case 0:
                if (_inventoryMain.InventoryColor.NumberGrey >= 1)
                {
                    _inventoryMain.Money += _seedMain.GreySeed.SellValue;
                    _inventoryMain.InventoryColor.NumberGrey -= 1;
                }
                break;
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
            case 4:
                if (_inventoryMain.InventoryColor.NumberPurple >= 1)
                {
                    _inventoryMain.Money += _seedMain.PurpleSeed.SellValue;
                    _inventoryMain.InventoryColor.NumberPurple -= 1;
                }
                break;
            case 5:
                if (_inventoryMain.InventoryColor.NumberGreen >= 1)
                {
                    _inventoryMain.Money += _seedMain.GreenSeed.SellValue;
                    _inventoryMain.InventoryColor.NumberGreen -= 1;
                }
                break;
            case 6:
                if (_inventoryMain.InventoryColor.NumberOrange >= 1)
                {
                    _inventoryMain.Money += _seedMain.OrangeSeed.SellValue;
                    _inventoryMain.InventoryColor.NumberOrange -= 1;
                }
                break;
        }
    }
}
