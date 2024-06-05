using UnityEngine;
using System.Collections.Generic;
using TMPro;
using UnityEngine.InputSystem;

public class Tutorial : MonoBehaviour
{
    [field: SerializeField] public List<GameObject> IndicatorsList;
    [SerializeField] private List<TMP_Text> _inputText;
    [SerializeField] private KeepItem _keepItem;
    [SerializeField] private RebindingDesplayPlant _desplayPlant;
    [SerializeField] private Movement _movement;
    [SerializeField] private OpenPause _openPause;
    [SerializeField] private ChestInventory _chestInventory;
    [field: SerializeField] public bool WhenMove = false;
    [field: SerializeField] public bool WhenPlayerPlant = false;
    [field: SerializeField] public bool WhenplayerSellPlant = false;
    [SerializeField] private GameObject _secondTutorialPanel;
    [SerializeField] private GameObject _thirdTutorialPanel;
    private bool _whenCanMix = false;

    private void FixedUpdate()
    {
        for (var i = 0; i < _inputText.Count; i++)
        {
            _inputText[i].text = _desplayPlant.PlantAction.action.GetBindingDisplayString(0);
        }

        if (WhenPlayerPlant == false)
        {
            if (_keepItem.Id == 14)
            {
                IndicatorsList[2].SetActive(true);
                IndicatorsList[3].SetActive(true);
            }
        }
        else
        {
            IndicatorsList[1].SetActive(false);
            IndicatorsList[2].SetActive(false);
            IndicatorsList[3].SetActive(false);
        }
        if (WhenplayerSellPlant == false)
        {
            if (_keepItem.Id == 1)
            {
                IndicatorsList[0].SetActive(true);
            }
        }
        if (_keepItem.NumberGreySeedPlanted == 3)
        {
            _secondTutorialPanel.SetActive(true);
            _movement.CanMove = false;
            _openPause.Open = 1;
            _keepItem.NumberGreySeedPlanted += 1;
        }
        if ((_chestInventory.BlueSeed >= 1) && (_chestInventory.YellowSeed >= 1) || (_chestInventory.BlueSeed >= 1) && (_chestInventory.RedSeed >= 1) || (_chestInventory.BlueSeed >= 1) && (_chestInventory.PurpleSeed >= 1) || (_chestInventory.BlueSeed >= 1) && (_chestInventory.GreenSeed >= 1) || (_chestInventory.BlueSeed >= 1) && (_chestInventory.OrangeSeed >= 1) || (_chestInventory.YellowSeed >= 1) && (_chestInventory.RedSeed >= 1) || (_chestInventory.YellowSeed >= 1) && (_chestInventory.PurpleSeed >= 1) || (_chestInventory.YellowSeed >= 1) && (_chestInventory.GreenSeed >= 1) || (_chestInventory.YellowSeed >= 1) && (_chestInventory.OrangeSeed >= 1) || (_chestInventory.RedSeed >= 1) && (_chestInventory.PurpleSeed >= 1) || (_chestInventory.RedSeed >= 1) && (_chestInventory.GreenSeed >= 1) || (_chestInventory.RedSeed >= 1) && (_chestInventory.OrangeSeed >= 1))
        {
            if (_whenCanMix == false)
            {
                _thirdTutorialPanel.SetActive(true);
                _movement.CanMove = false;
                _openPause.Open = 1;
            }
        }
    }
}
