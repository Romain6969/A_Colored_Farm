using UnityEngine;
using TMPro;

public class ChangeNumberPaint : MonoBehaviour
{
    [SerializeField] private InventoryColor _inventoryColor;
    [SerializeField] private TMP_Text _redPaint;
    [SerializeField] private TMP_Text _bluePaint;
    [SerializeField] private TMP_Text _yellowPaint;
    [SerializeField] private TMP_Text _greyPaint;

    private void FixedUpdate()
    {
        _redPaint.text = $"You have : {_inventoryColor.GetAmount("Red")} paint.";
        _bluePaint.text = $"You have : {_inventoryColor.GetAmount("Blue")} paint.";
        _yellowPaint.text = $"You have : {_inventoryColor.GetAmount("Yellow")} paint.";
        _greyPaint.text = $"You have : {_inventoryColor.GetAmount("Grey")} paint.";
    }
}
