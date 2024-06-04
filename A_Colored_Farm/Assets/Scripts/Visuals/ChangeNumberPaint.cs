using UnityEngine;
using TMPro;

public class ChangeNumberPaint : MonoBehaviour
{
    [SerializeField] private InventoryColor _inventoryColor;
    [SerializeField] private TMP_Text _redPaint;
    [SerializeField] private TMP_Text _bluePaint;
    [SerializeField] private TMP_Text _yellowPaint;
    [SerializeField] private TMP_Text _greyPaint;
    [SerializeField] private TMP_Text _greenPaint;
    [SerializeField] private TMP_Text _purplePaint;
    [SerializeField] private TMP_Text _orangePaint;

    private void FixedUpdate()
    {
        _redPaint.text = $"{_inventoryColor.GetAmount("Red")}";
        _bluePaint.text = $"{_inventoryColor.GetAmount("Blue")}";
        _yellowPaint.text = $"{_inventoryColor.GetAmount("Yellow")}";
        _greyPaint.text = $"{_inventoryColor.GetAmount("Grey")}";
        _greenPaint.text = $"{_inventoryColor.GetAmount("Green")}";
        _purplePaint.text = $"{_inventoryColor.GetAmount("Purple")}";
        _orangePaint.text = $"{_inventoryColor.GetAmount("Orange")}";
    }
}
