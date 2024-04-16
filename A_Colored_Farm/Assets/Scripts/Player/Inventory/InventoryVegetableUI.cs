using TMPro;
using UnityEngine;

public class InventoryVegetableUI : MonoBehaviour
{
    [SerializeField] private InventoryVegetable _inventory;
    [SerializeField] private TMP_Text _greyVegetableText;
    [SerializeField] private TMP_Text _blueVegetableText;
    [SerializeField] private TMP_Text _yellowVegetableText;
    [SerializeField] private TMP_Text _redVegetableText;
    [SerializeField] private TMP_Text _purpleVegetableText;
    [SerializeField] private TMP_Text _greenVegetableText;
    [SerializeField] private TMP_Text _orangeVegetableText;

    // Update is called once per frame
    void Update()
    {
        _greyVegetableText.text = ($"{_inventory.NumberGreyVegetable}");

        _blueVegetableText.text = ($"{_inventory.NumberBlueVegetable}");

        _yellowVegetableText.text = ($"{_inventory.NumberYellowVegetable}");

        _redVegetableText.text = ($"{_inventory.NumberRedVegetable}");

        _purpleVegetableText.text = ($"{_inventory.NumberPurpleVegetable}");

        _greenVegetableText.text = ($"{_inventory.NumberGreenVegetable}");

        _orangeVegetableText.text = ($"{_inventory.NumberOrangeVegetable}");
    }
}
