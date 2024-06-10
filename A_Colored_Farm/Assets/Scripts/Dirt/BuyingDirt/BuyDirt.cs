using UnityEngine;
using TMPro;

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
    [SerializeField] private MoneyAnimation _moneyAnimation;
    [SerializeField] private PlaySounds _playSounds;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (_interaction.IsPerformed == true)
        {
            _movement.CanMove = false;
            _confirmPanel.SetActive(true);
            _playSounds.PlayAudio(9);
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
            _playSounds.PlayAudio(8);
            _moneyAnimation.OnAnimation(1);
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
        _playSounds.PlayAudio(9);
        _confirmPanel.SetActive(false);
        _movement.CanMove = true;
    }
}
