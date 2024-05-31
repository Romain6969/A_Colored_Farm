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
    [field: SerializeField] public bool WhenMove = false;
    [field: SerializeField] public bool WhenPlayerPlant = false;
    [field: SerializeField] public bool WhenplayerSellPlant = false;

    private void FixedUpdate()
    {
        for (var i = 0; i < _inputText.Count; i++)
        {
            _inputText[i].text = _desplayPlant.PlantAction.action.GetBindingDisplayString(0);
        }

        if (WhenPlayerPlant == false)
        {
            if (_keepItem.Id == 8)
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
    }
}
