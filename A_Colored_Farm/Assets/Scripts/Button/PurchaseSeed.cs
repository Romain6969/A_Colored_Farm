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
        }
    }
}
