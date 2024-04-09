using UnityEngine;
using TMPro;

public class InventorySeedUI : MonoBehaviour
{
    [SerializeField] private InventorySeed _inventory;
    [SerializeField] private TMP_Text _blueSeedText;
    [SerializeField] private TMP_Text _yellowSeedText;
    [SerializeField] private TMP_Text _redSeedText;

    // Update is called once per frame
    void Update()
    {
        _blueSeedText.text = ($"{_inventory.NumberBlueSeed}");

        _yellowSeedText.text = ($"{_inventory.NumberYellowSeed}");

        _redSeedText.text = ($"{_inventory.NumberRedSeed}");
    }
}
