using System.Collections.Generic;
using UnityEngine;

public class InventorySeed : MonoBehaviour
{
    [field: SerializeField] public int NumberGreySeed { get; set; }
    [field: SerializeField] public int NumberBlueSeed { get; set; }
    [field: SerializeField] public int NumberYellowSeed { get; set; }
    [field: SerializeField] public int NumberRedSeed { get; set; }
    [field: SerializeField] public int NumberPurpleSeed { get; set; }
    [field: SerializeField] public int NumberGreenSeed { get; set; }
    [field: SerializeField] public int NumberOrangeSeed { get; set; }

    public Dictionary<SeedData, int> Inventory { get; set; } = new();

    public void AddSeed(SeedData seed, int amount)
    {
        if (Inventory.ContainsKey(seed))
        {
            Inventory[seed] += amount;
        }
        else
        {
            Inventory.Add(seed, amount);
        }
    }
}
