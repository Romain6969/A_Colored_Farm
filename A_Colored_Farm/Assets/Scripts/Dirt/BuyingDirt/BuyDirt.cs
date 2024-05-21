using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class BuyDirt : MonoBehaviour
{
    [SerializeField] private int _dirtCost;
    [SerializeField] private List<GameObject> _dirts;
    [SerializeField] private GameObject _confirmPanel;
    [SerializeField] private GameObject _gameObjectText;
    [SerializeField] private TMP_Text _textCost;
    [SerializeField] private Interactions _interaction;
    [SerializeField] private InventoryMain _inventoryMain;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (_interaction.IsPerformed == true)
        {
            _confirmPanel.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        _textCost.text = $"{_dirtCost}";
    }

    public void ConfirmDirt()
    {
        if (_inventoryMain.Money >= _dirtCost)
        {
            _inventoryMain.Money -= _dirtCost;
            _dirts[0].SetActive(true);
            _dirts[1].SetActive(true);
            _dirts[2].SetActive(true);
            _dirts[3].SetActive(true);
            _confirmPanel.SetActive(false);
            _gameObjectText.SetActive(false);
            gameObject.SetActive(false);
        }
        else
        {
            _confirmPanel.SetActive(false);
            Debug.Log("You're poor ha ha, looser !");
        }
    }
}
