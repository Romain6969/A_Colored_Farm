using UnityEngine;

public class KeepVegetable : MonoBehaviour
{
    [SerializeField] private InventoryColor InventoryColor;
    
    private void Start()
    {
        InventoryColor.AddSeed("Yellow", 0);
        InventoryColor.AddSeed("Red", 0);
        InventoryColor.AddSeed("Blue", 0);
        InventoryColor.AddSeed("Green", 0);
        InventoryColor.AddSeed("Purple", 0);
        InventoryColor.AddSeed("Orange", 0);
        InventoryColor.AddSeed("Grey", 0);
    }
    
}
