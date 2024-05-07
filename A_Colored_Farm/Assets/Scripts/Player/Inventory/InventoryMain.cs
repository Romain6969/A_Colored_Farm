using UnityEngine;

public class InventoryMain : MonoBehaviour
{
    [field : SerializeField] public int Money { get; set; }
    [field : SerializeField] public InventorySeed InventorySeed { get; set; }
    [field : SerializeField] public InventoryColor InventoryColor { get; set; }
    [field: SerializeField] public InventoryVegetable InventoryVegetable { get; set; }
}
