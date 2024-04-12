using UnityEngine;

public class PurchaseSeed : MonoBehaviour
{
    [SerializeField] private InventoryMain _inventoryMain;
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private float _id;

    public void OnClick()
    {

        switch (_id)
        {
            case 0:
                if (_inventoryMain.Money >= _seedMain.GreySeed.PurchaseValue)
                {
                    _inventoryMain.Money -= _seedMain.GreySeed.PurchaseValue;
                    _inventoryMain.InventorySeed.NumberGreySeed += 1;
                }
                break;
            case 1:
                if (_inventoryMain.Money >= _seedMain.BlueSeed.PurchaseValue)
                {
                    _inventoryMain.Money -= _seedMain.BlueSeed.PurchaseValue;
                    _inventoryMain.InventorySeed.NumberBlueSeed += 1;
                }
                break;
            case 2:
                if (_inventoryMain.Money >= _seedMain.YellowSeed.PurchaseValue)
                {
                    _inventoryMain.Money -= _seedMain.YellowSeed.PurchaseValue;
                    _inventoryMain.InventorySeed.NumberYellowSeed += 1;
                }
                break;
            case 3:
                if (_inventoryMain.Money >= _seedMain.RedSeed.PurchaseValue)
                {
                    _inventoryMain.Money -= _seedMain.RedSeed.PurchaseValue;
                    _inventoryMain.InventorySeed.NumberRedSeed += 1;
                }
                break;
            case 4:
                if (_inventoryMain.Money >= _seedMain.PurpleSeed.PurchaseValue)
                {
                    _inventoryMain.Money -= _seedMain.PurpleSeed.PurchaseValue;
                    _inventoryMain.InventorySeed.NumberPurpleSeed += 1;
                }
                break;
            case 5:
                if (_inventoryMain.Money >= _seedMain.GreenSeed.PurchaseValue)
                {
                    _inventoryMain.Money -= _seedMain.GreenSeed.PurchaseValue;
                    _inventoryMain.InventorySeed.NumberGreenSeed += 1;
                }
                break;
            case 6:
                if (_inventoryMain.Money >= _seedMain.OrangeSeed.PurchaseValue)
                {
                    _inventoryMain.Money -= _seedMain.OrangeSeed.PurchaseValue;
                    _inventoryMain.InventorySeed.NumberOrangeSeed += 1;
                }
                break;
        }
    }
}
