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
                if (_inventoryMain.InventoryColor.GetAmount("GreyColor") > 0)
                {
                    _inventoryMain.AddValue(_seedMain.GreySeed.SellValue);
                    _inventoryMain.InventoryColor.RemoveSeed("GreyColor", 1);
                }
                break;
            case 1:
                if (_inventoryMain.InventoryColor.GetAmount("BlueColor") > 0)
                {
                    _inventoryMain.AddValue(_seedMain.BlueSeed.SellValue);
                    _inventoryMain.InventoryColor.RemoveSeed("BlueColor", 1);
                }
                break;
            case 2:
                if (_inventoryMain.InventoryColor.GetAmount("YellowColor") > 0)
                {
                    _inventoryMain.AddValue(_seedMain.YellowSeed.SellValue);
                    _inventoryMain.InventoryColor.RemoveSeed("YellowColor", 1);
                }
                break;
            case 3:
                if (_inventoryMain.InventoryColor.GetAmount("RedColor") > 0)
                {
                    _inventoryMain.AddValue(_seedMain.RedSeed.SellValue);
                    _inventoryMain.InventoryColor.RemoveSeed("RedColor", 1);
                }
                break;
            case 4:
                if (_inventoryMain.InventoryColor.GetAmount("PurpleColor") > 0)
                {
                    _inventoryMain.AddValue(_seedMain.PurpleSeed.SellValue);
                    _inventoryMain.InventoryColor.RemoveSeed("PurpleColor", 1);
                }
                break;
            case 5:
                if (_inventoryMain.InventoryColor.GetAmount("GreenColor") > 0)
                {
                    _inventoryMain.AddValue(_seedMain.GreenSeed.SellValue);
                    _inventoryMain.InventoryColor.RemoveSeed("GreenColor", 1);
                }
                break;
            case 6:
                if (_inventoryMain.InventoryColor.GetAmount("OrangeColor") > 0)
                {
                    _inventoryMain.AddValue(_seedMain.OrangeSeed.SellValue);
                    _inventoryMain.InventoryColor.RemoveSeed("OrangeColor", 1);
                }
                break;
        }
    }
}
