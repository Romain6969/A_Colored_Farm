using UnityEngine;
using TMPro;

public class AmeliorationCrusher : MonoBehaviour
{
    [SerializeField] private InventoryMain _inventoryMain;
    [SerializeField] private Crusher _crusher;
    [SerializeField] private TMP_Text _priceText;
    private int _price = 50;
    private int _use = 10;

    public void OnClick()
    {
        if (_inventoryMain.Money >= _price)
        {
            _crusher.TimeObjectif -= 1;
            _inventoryMain.Money -= _price;
            _price += 25;
            _use -= 1;
        }
    }
    
    void Update()
    {
        if (_use == 0)
        {
            this.gameObject.SetActive(false);
        }

        _priceText.text = $"Upgrade cooltdown of blender : {_price}";
    }
}
