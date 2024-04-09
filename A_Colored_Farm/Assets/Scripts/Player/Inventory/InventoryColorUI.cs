using TMPro;
using UnityEngine;

public class InventoryColorUI : MonoBehaviour
{
    [SerializeField] private InventoryColor _inventory;
    [SerializeField] private TMP_Text _blueText;
    [SerializeField] private TMP_Text _yellowText;
    [SerializeField] private TMP_Text _redText;

    // Update is called once per frame
    void Update()
    {
        _blueText.text = ($"{_inventory.NumberBlue}");

        _yellowText.text = ($"{_inventory.NumberYellow}");

        _redText.text = ($"{_inventory.NumberRed}");
    }
}
