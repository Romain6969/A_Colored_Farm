using UnityEngine;

public class CrushVegetable : MonoBehaviour
{
    [SerializeField] private InventoryMain _inventoryMain;
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private float _id;

    public void OnClick()
    {
        switch (_id)
        {
            case 0:
                if (_inventoryMain.InventoryVegetable.GetAmount("GreyPlant") > 0)
                {
                    _inventoryMain.InventoryVegetable.RemoveSeed("GreyPlant", 1);
                    _inventoryMain.InventoryColor.AddSeed("GreyColor", 1);
                }
                break;
            case 1:
                if (_inventoryMain.InventoryVegetable.GetAmount("BluePlant") > 0)
                {
                    _inventoryMain.InventoryVegetable.RemoveSeed("BluePlant", 1);
                    _inventoryMain.InventoryColor.AddSeed("BlueColor", 1);
                }
                break;
            case 2:
                if (_inventoryMain.InventoryVegetable.GetAmount("YellowPlant") > 0)
                {
                    _inventoryMain.InventoryVegetable.RemoveSeed("YellowPlant", 1);
                    _inventoryMain.InventoryColor.AddSeed("YellowColor", 1);
                }
                break;
            case 3:
                if (_inventoryMain.InventoryVegetable.GetAmount("RedPlant") > 0 )
                {
                    _inventoryMain.InventoryVegetable.RemoveSeed("RedPlant", 1);
                    _inventoryMain.InventoryColor.AddSeed("RedColor", 1);
                }
                break;
            case 4:
                if (_inventoryMain.InventoryVegetable.GetAmount("PurplePlant") > 0)
                {
                    _inventoryMain.InventoryVegetable.RemoveSeed("PurplePlant", 1);
                    _inventoryMain.InventoryColor.AddSeed("PurpleColor", 1);
                }
                break;
            case 5:
                if (_inventoryMain.InventoryVegetable.GetAmount("GreenPlant") > 0)
                {
                    _inventoryMain.InventoryVegetable.RemoveSeed("GreenPlant", 1);
                    _inventoryMain.InventoryColor.AddSeed("GreenColor", 1);
                }
                break;
            case 6:
                if (_inventoryMain.InventoryVegetable.GetAmount("OrangePlant") > 0)
                {
                    _inventoryMain.InventoryVegetable.RemoveSeed("OrangePlant", 1);
                    _inventoryMain.InventoryColor.AddSeed("OrangeColor", 1);
                }
                break;
        }
    }
}
