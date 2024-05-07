using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queue : MonoBehaviour
{
    private Queue<int> queue = new Queue<int>();

    [SerializeField] private KeepVegetable keepVegetable;
    
    public void AddVegetable(int vegetable)
    {
        queue.Enqueue(vegetable);
    }

    public void RemoveVegetable(int vegetable)
    {
        if (queue.Count == 0)
        {
            return;
        }

        keepVegetable.id = queue.Dequeue();
        keepVegetable.UpdateSprite();
    }
}
