using UnityEngine;
using TMPro;

public class ChestUi : MonoBehaviour
{
    [SerializeField] private ChestInventory _chestInventory;
    [SerializeField] private TMP_Text _blueText;
    [SerializeField] private TMP_Text _yellowText;
    [SerializeField] private TMP_Text _redText;
    [SerializeField] private TMP_Text _grayTest;

    void Update()
    {
        _blueText.text = $"{_chestInventory.BlueSeed}";
        _yellowText.text = $"{_chestInventory.YellowSeed}";
        _redText.text = $"{_chestInventory.RedSeed}";
        _grayTest.text = $"{_chestInventory.GraySeed}";
    }
}
