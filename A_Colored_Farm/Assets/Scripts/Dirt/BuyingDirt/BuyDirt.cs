using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class BuyDirt : MonoBehaviour
{
    [SerializeField] private int _dirtCost;
    [SerializeField] private GameObject _dirts;
    [SerializeField] private GameObject _confirmPanel;
    [SerializeField] private GameObject _gameObjectText;
    [SerializeField] private TMP_Text _textCost;
    [SerializeField] private Interactions _interaction;
    [SerializeField] private InventoryMain _inventoryMain;
    [SerializeField] private Movement _movement;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (_interaction.IsPerformed == true)
        {
            _movement.CanMove = false;
            _confirmPanel.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        _textCost.text = $"{_dirtCost}";
    }

    public void ConfirmDirt()
    {
        if (_inventoryMain.TargetValue >= _dirtCost)
        {
            _inventoryMain.RemoveValue(_dirtCost);
            _dirts.SetActive(true);
            _confirmPanel.SetActive(false);
            _gameObjectText.SetActive(false);
            gameObject.SetActive(false);
            _movement.CanMove = true;
        }
        else
        {
            _confirmPanel.SetActive(false);
            Debug.Log("You're poor ha ha, looser !");
            _movement.CanMove = true;
        }
    }

    public void CloseConfirm()
    {
        _confirmPanel.SetActive(false);
        _movement.CanMove = true;
    }
}
