using UnityEngine;
using TMPro;

public class InventorySeedUI : MonoBehaviour
{
    [SerializeField] private InventorySeed _inventory;
    [SerializeField] private TMP_Text _greySeedText;
    [SerializeField] private TMP_Text _blueSeedText;
    [SerializeField] private TMP_Text _yellowSeedText;
    [SerializeField] private TMP_Text _redSeedText;
    [SerializeField] private TMP_Text _purpleSeedText;
    [SerializeField] private TMP_Text _greenSeedText;
    [SerializeField] private TMP_Text _orangeSeedText;

    // Update is called once per frame
    void Update()
    {
        _greySeedText.text = ($"{_inventory.NumberGreySeed}");

        _blueSeedText.text = ($"{_inventory.NumberBlueSeed}");

        _yellowSeedText.text = ($"{_inventory.NumberYellowSeed}");

        _redSeedText.text = ($"{_inventory.NumberRedSeed}");

        _purpleSeedText.text = ($"{_inventory.NumberPurpleSeed}");

        _greenSeedText.text = ($"{_inventory.NumberGreenSeed}");

        _orangeSeedText.text = ($"{_inventory.NumberOrangeSeed}");
    }
}
