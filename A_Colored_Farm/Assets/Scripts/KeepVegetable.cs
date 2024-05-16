using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepVegetable : MonoBehaviour
{
    public InventoryColor InventoryColor;
    public int id;
    
    private void Start()
    {
        InventoryColor.AddSeed("Yellow", 1);
    }
    
}
