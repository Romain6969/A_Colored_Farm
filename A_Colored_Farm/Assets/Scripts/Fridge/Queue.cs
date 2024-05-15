using System.Collections.Generic;
using UnityEngine;

public class Queue : MonoBehaviour
{
    private Queue<int> _queue = new Queue<int>();

    [SerializeField] private KeepItem _keepItem;
    
    public void AddVegetable(int vegetable)
    {
        if (_queue.Count >= 10)
        {
            return;
        }

        _queue.Enqueue(vegetable);
    }

    public void RemoveVegetable(int vegetable)
    {
        if (_queue.Count == 0)
        {
            return;
        }

        _keepItem.Id = _queue.Dequeue();
        _keepItem.UpdateSprite();
    }
}
