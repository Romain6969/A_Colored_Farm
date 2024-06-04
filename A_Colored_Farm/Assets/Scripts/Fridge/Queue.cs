using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Queue : MonoBehaviour
{
    private Queue<int> _queue = new Queue<int>();

    [SerializeField] private KeepItem _keepItem;
    [SerializeField] private AnimationFridge _animationfridge;
    [field :SerializeField] public int MaxStockFridge { get; set; } = 10;
    [SerializeField] private TMP_Text _numberInStockText;

    public void AddVegetable(int vegetable)
    {
        if (_queue.Count == MaxStockFridge)
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

    private void FixedUpdate()
    {
        _numberInStockText.text = $"{_queue.Count} / {MaxStockFridge}";
    }
}
