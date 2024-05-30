using UnityEngine;

public class PurchaseSeed : MonoBehaviour
{
    [SerializeField] private InventoryMain _inventoryMain;
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private ChestInventory _chestInventory;
    [SerializeField] private Tutorial _tutorial;
    [SerializeField] private float _id;

    public void OnClick()
    {
        switch (_id)
        {
            case 0:
                if (_inventoryMain.TargetValue >= _seedMain.GreySeed.PurchaseValue)
                {
                    _inventoryMain.RemoveValue(_seedMain.GreySeed.PurchaseValue);
                    _chestInventory.GraySeed += 1;
                    
                    if(_tutorial.WhenMove == false)
                    {
                        _tutorial.IndicatorsList[0].SetActive(false);
                        _tutorial.IndicatorsList[1].SetActive(true);
                        _tutorial.WhenMove = true;
                    }
                }
                break;
            case 1:
                if (_inventoryMain.TargetValue >= _seedMain.BlueSeed.PurchaseValue)
                {
                    _inventoryMain.RemoveValue(_seedMain.BlueSeed.PurchaseValue);
                    _chestInventory.BlueSeed += 1;
                }
                break;
            case 2:
                if (_inventoryMain.TargetValue >= _seedMain.YellowSeed.PurchaseValue)
                {
                    _inventoryMain.RemoveValue(_seedMain.YellowSeed.PurchaseValue);
                    _chestInventory.YellowSeed += 1;
                }
                break;
            case 3:
                if (_inventoryMain.TargetValue >= _seedMain.RedSeed.PurchaseValue)
                {
                    _inventoryMain.RemoveValue(_seedMain.RedSeed.PurchaseValue);
                    _chestInventory.RedSeed += 1;
                }
                break;
        }
    }
}
