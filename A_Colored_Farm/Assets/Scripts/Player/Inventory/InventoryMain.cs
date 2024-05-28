using UnityEngine;
using TMPro;
using System.Collections;

public class InventoryMain : MonoBehaviour
{
    [field : SerializeField] public InventorySeed InventorySeed { get; set; }
    [field : SerializeField] public InventoryColor InventoryColor { get; set; }
    [field: SerializeField] public InventoryVegetable InventoryVegetable { get; set; }
    [SerializeField] private TMP_Text _textMoney;
    [SerializeField] private float _countDuration = 1;
    [SerializeField] private float _currentValue = 0;
    [SerializeField] public float TargetValue { get; set; }
    [SerializeField] private Coroutine _C2T;

    private void Start()
    {
        _currentValue = float.Parse(_textMoney.text);
        TargetValue = _currentValue;
    }

    IEnumerator CountTo(float targetValue)
    {
        var rate = Mathf.Abs(targetValue - _currentValue) / _countDuration;
        while (_currentValue != targetValue)
        {
            _currentValue = Mathf.MoveTowards(_currentValue, targetValue, rate * Time.deltaTime);
            _textMoney.text = ((int)_currentValue).ToString();
            yield return null;
        }
    }

    public void AddValue(float value)
    {
        TargetValue += value;
        if (_C2T != null)
        {
            StopCoroutine(_C2T);
        }
        _C2T = StartCoroutine(CountTo(TargetValue));
    }

    public void RemoveValue(float value)
    {
        TargetValue -= value;
        if (_C2T != null)
        {
            StopCoroutine(_C2T);
        }
        _C2T = StartCoroutine(CountTo(TargetValue));
    }

    public void SetTarget(float target)
    {
        TargetValue = target;
        if (_C2T != null)
        {
            StopCoroutine(_C2T);
        }
        _C2T = StartCoroutine(CountTo(TargetValue));
    }
}
