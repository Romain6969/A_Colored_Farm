using TMPro;
using UnityEngine;

public class InventoryColorUI : MonoBehaviour
{
    [SerializeField] private InventoryColor _inventory;
    [SerializeField] private TMP_Text _greySeedText;
    [SerializeField] private TMP_Text _blueText;
    [SerializeField] private TMP_Text _yellowText;
    [SerializeField] private TMP_Text _redText;
    [SerializeField] private TMP_Text _purpleSeedText;
    [SerializeField] private TMP_Text _greenSeedText;
    [SerializeField] private TMP_Text _orangeSeedText;

    // Update is called once per frame
    void Update()
    {
        _greySeedText.text = ($"{_inventory.NumberGrey}");

        _blueText.text = ($"{_inventory.NumberBlue}");

        _yellowText.text = ($"{_inventory.NumberYellow}");

        _redText.text = ($"{_inventory.NumberRed}");

        _purpleSeedText.text = ($"{_inventory.NumberPurple}");

        _greenSeedText.text = ($"{_inventory.NumberGreen}");

        _orangeSeedText.text = ($"{_inventory.NumberOrange}");
    }
}
