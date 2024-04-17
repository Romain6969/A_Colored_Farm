using System.Collections.Generic;
using UnityEngine;

public class InventoryColor : MonoBehaviour
{
    [field: SerializeField] public Dictionary<string, int> Inventory { get; set; } = new();

    public void AddSeed(string color, int amount)
    {
        if (Inventory.ContainsKey(color))
        {
            Inventory[color] += amount;
        }
        else
        {
            Inventory.Add(color, amount);
        }
    }

    public void RemoveSeed(string color, int amount)
    {
        if (Inventory.ContainsKey(color))
        {
            if (Inventory[color] > 0)
            {
                // Vérifier si on  a assez de graines de ce type avant de les enlever
                Inventory[color] -= amount;
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

    public int GetAmount(string color)
    {
        return Inventory[color];
    }
}
