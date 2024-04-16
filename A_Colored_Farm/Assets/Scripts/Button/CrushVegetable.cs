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
                if (_inventoryMain.InventoryVegetable.NumberGreyVegetable >= 1)
                {
                    _inventoryMain.InventoryVegetable.NumberGreyVegetable -= 1;
                    _inventoryMain.InventoryColor.NumberGrey += 1;
                }
                break;
            case 1:
                if (_inventoryMain.InventoryVegetable.NumberBlueVegetable >= 1)
                {
                    _inventoryMain.InventoryVegetable.NumberBlueVegetable -= 1;
                    _inventoryMain.InventoryColor.NumberBlue += 1;
                }
                break;
            case 2:
                if (_inventoryMain.InventoryVegetable.NumberYellowVegetable >= 1)
                {
                    _inventoryMain.InventoryVegetable.NumberYellowVegetable -= 1;
                    _inventoryMain.InventoryColor.NumberYellow += 1;
                }
                break;
            case 3:
                if (_inventoryMain.InventoryVegetable.NumberRedVegetable >= 1)
                {
                    _inventoryMain.InventoryVegetable.NumberRedVegetable -= 1;
                    _inventoryMain.InventoryColor.NumberRed += 1;
                }
                break;
            case 4:
                if (_inventoryMain.InventoryVegetable.NumberPurpleVegetable >= 1)
                {
                    _inventoryMain.InventoryVegetable.NumberPurpleVegetable -= 1;
                    _inventoryMain.InventoryColor.NumberPurple += 1;
                }
                break;
            case 5:
                if (_inventoryMain.InventoryVegetable.NumberGreenVegetable >= 1)
                {
                    _inventoryMain.InventoryVegetable.NumberGreenVegetable -= 1;
                    _inventoryMain.InventoryColor.NumberGreen += 1;
                }
                break;
            case 6:
                if (_inventoryMain.InventoryVegetable.NumberOrangeVegetable >= 1)
                {
                    _inventoryMain.InventoryVegetable.NumberOrangeVegetable -= 1;
                    _inventoryMain.InventoryColor.NumberOrange += 1;
                }
                break;
        }
    }
}
