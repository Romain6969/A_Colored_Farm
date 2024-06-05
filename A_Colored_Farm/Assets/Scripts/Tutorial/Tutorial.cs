using UnityEngine;
using System.Collections.Generic;
using TMPro;
using UnityEngine.InputSystem;
using UnityEditor.XR;

public class Tutorial : MonoBehaviour
{
    [field: SerializeField] public List<GameObject> IndicatorsList;
    [SerializeField] private List<TMP_Text> _inputText;
    [SerializeField] private List<GameObject> _listDirtInactif;
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
    [field: SerializeField] public bool WhenCanMix = false;
    [field: SerializeField] public bool WhenMix { get; set; } = false;
    [field: SerializeField] public bool ForClosingPanel { get; set; } = false;
    [field: SerializeField] public bool WhenMix2 { get; set; } = false;
    [field: SerializeField] public bool WhenColor { get; set; } = false;
    [field: SerializeField] public bool EndTuto;

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
            IndicatorsList[4].SetActive(true);
            _secondTutorialPanel.SetActive(true);
            _movement.CanMove = false;
            _openPause.Open = 1;
            _keepItem.NumberGreySeedPlanted += 1;
        }
        if ((_chestInventory.BlueSeed >= 1) && (_chestInventory.YellowSeed >= 1) || (_chestInventory.BlueSeed >= 1) && (_chestInventory.RedSeed >= 1) || (_chestInventory.BlueSeed >= 1) && (_chestInventory.PurpleSeed >= 1) || (_chestInventory.BlueSeed >= 1) && (_chestInventory.GreenSeed >= 1) || (_chestInventory.BlueSeed >= 1) && (_chestInventory.OrangeSeed >= 1) || (_chestInventory.YellowSeed >= 1) && (_chestInventory.RedSeed >= 1) || (_chestInventory.YellowSeed >= 1) && (_chestInventory.PurpleSeed >= 1) || (_chestInventory.YellowSeed >= 1) && (_chestInventory.GreenSeed >= 1) || (_chestInventory.YellowSeed >= 1) && (_chestInventory.OrangeSeed >= 1) || (_chestInventory.RedSeed >= 1) && (_chestInventory.PurpleSeed >= 1) || (_chestInventory.RedSeed >= 1) && (_chestInventory.GreenSeed >= 1) || (_chestInventory.RedSeed >= 1) && (_chestInventory.OrangeSeed >= 1))
        {
            WhenCanMix = true;
            if (ForClosingPanel == false)
            {
                _thirdTutorialPanel.SetActive(true);
                _movement.CanMove = false;
                _openPause.Open = 1;
            }
        }
        if (ForClosingPanel == true)
        {
            if (WhenColor == true)
            {
                IndicatorsList[5].SetActive(true);
            }
        }
        if (_keepItem.Id == 15 && WhenColor == false && ForClosingPanel == true)
        {
            if (EndTuto == false)
            {
                IndicatorsList[2].SetActive(true);
                IndicatorsList[3].SetActive(true);
                if (_listDirtInactif[0] == true)
                {
                    IndicatorsList[6].SetActive(true);
                }
                if (_listDirtInactif[1] == true)
                {
                    IndicatorsList[7].SetActive(true);
                }
                if (_listDirtInactif[2] == true)
                {
                    IndicatorsList[8].SetActive(true);
                }
                if (_listDirtInactif[3] == true)
                {
                    IndicatorsList[9].SetActive(true);
                }
                if (_listDirtInactif[4] == true)
                {
                    IndicatorsList[10].SetActive(true);
                }
                if (_listDirtInactif[5] == true)
                {
                    IndicatorsList[11].SetActive(true);
                }
            }
            
        }
        if (EndTuto == true)
        {
            IndicatorsList[2].SetActive(false);
            IndicatorsList[3].SetActive(false);
            IndicatorsList[6].SetActive(false);
            IndicatorsList[7].SetActive(false);
            IndicatorsList[8].SetActive(false);
            IndicatorsList[9].SetActive(false);
            IndicatorsList[10].SetActive(false);
            IndicatorsList[11].SetActive(false);
        }
    }
}
