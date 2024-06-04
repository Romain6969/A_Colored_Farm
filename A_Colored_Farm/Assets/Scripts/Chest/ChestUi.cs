using UnityEngine;
using TMPro;

public class ChestUi : MonoBehaviour
{
    [SerializeField] private ChestInventory _chestInventory;
    [SerializeField] private TMP_Text _blueText;
    [SerializeField] private TMP_Text _yellowText;
    [SerializeField] private TMP_Text _redText;
    [SerializeField] private TMP_Text _grayText;
    [SerializeField] private TMP_Text _purpleText;
    [SerializeField] private TMP_Text _greenText;
    [SerializeField] private TMP_Text _orangeText;

    void Update()
    {
        _blueText.text = $"{_chestInventory.BlueSeed}";
        _yellowText.text = $"{_chestInventory.YellowSeed}";
        _redText.text = $"{_chestInventory.RedSeed}";
        _grayText.text = $"{_chestInventory.GraySeed}";
        _purpleText.text = $"{_chestInventory.PurpleSeed}";
        _greenText.text = $"{_chestInventory.GreenSeed}";
        _orangeText.text = $"{_chestInventory.OrangeSeed}";
    }
}
