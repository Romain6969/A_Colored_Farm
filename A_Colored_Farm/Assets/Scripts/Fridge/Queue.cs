using System.Collections.Generic;
using UnityEngine;

public class Queue : MonoBehaviour
{
    private Queue<int> _queue = new Queue<int>();

    [SerializeField] private KeepItem _keepItem;
    [SerializeField] private AnimationFridge _animationfridge;

    public void AddVegetable(int vegetable)
    {
        if (_queue.Count == 10)
        {
            return;
        }

        _animationfridge.OnAnimation();
        _queue.Enqueue(vegetable);
        _keepItem.Id = 0;
    }

    public void RemoveVegetable()
    {
        if (_queue.Count == 0)
        {
            return;
        }

        _animationfridge.OnAnimation();
        _keepItem.Id = _queue.Dequeue();
        _keepItem.UpdateSprite();
    }
}
