using System.Collections.Generic;
using UnityEngine;

public class InventoryVegetable : MonoBehaviour
{
    [field : SerializeField] public Dictionary<string, int> Inventory { get; set; } = new();

    public void AddSeed(string plant, int amount)
    {
        if (Inventory.ContainsKey(plant))
        {
            Inventory[plant] += amount;
            Debug.Log(Inventory[plant]);
        }
        else
        {
            Inventory.Add(plant, amount);
            Debug.Log(Inventory[plant]);
        }
    }

    public void RemoveSeed(string plant, int amount)
    {
        if (Inventory.ContainsKey(plant))
        {
            if (Inventory[plant] > 0)
            {
                // Vérifier si on  a assez de graines de ce type avant de les enlever
                Inventory[plant] -= amount;
            }
            else
            {
                Debug.Log("Dumbass you are seedless, also fuck you.");
            }
        }
        else
        {
            // Probablement une erreur ici
        }
    }

    public int GetAmount(string plant)
    {
        return Inventory[plant];
    }
}
