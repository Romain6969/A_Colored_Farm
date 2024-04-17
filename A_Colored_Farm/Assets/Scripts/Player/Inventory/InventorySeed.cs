using System.Collections.Generic;
using UnityEngine;

public class InventorySeed : MonoBehaviour
{
    public Dictionary<SeedData, int> Inventory { get; set; } = new();

    public void AddSeed(SeedData seed, int amount)
    {
        if (Inventory.ContainsKey(seed))
        {
            Inventory[seed] += amount;
            Debug.Log(Inventory[seed]);
        }
        else
        {
            Inventory.Add(seed, amount);
        }
    }

    public void RemoveSeed(SeedData seed, int amount) 
    {
        if (Inventory.ContainsKey(seed))
        {
            if (Inventory[seed] > 0) 
            {
                // Vérifier si on  a assez de graines de ce type avant de les enlever
                Inventory[seed] -= amount;
            }
            else
            {
                Debug.Log("Dumbass you are seedless, also fuck you");
            }
            
        }
        else
        {
            // Probablement une erreur ici
        }
    }

    public int GetAmount(SeedData seed)
    {
        return Inventory[seed];
    }
}
