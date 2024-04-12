using UnityEngine;
using UnityEngine.InputSystem;

public class OpenInventory : MonoBehaviour
{
    [field : SerializeField] public bool Open { get; set; }
    [SerializeField] private GameObject _panelInventory;
    [SerializeField] private GameObject _panelInventoryColor;
    [SerializeField] private GameObject _panelInventoryPlant;
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private OpenShop _openShop;

    public PlayerInput PlayerInput => _playerInput;

    public void OnInventory(InputAction.CallbackContext context)
    {
        if (_openShop.Open == false)
        {
            if (context.performed)
            {
                if (Open == false)
                {
                    Time.timeScale = 0;
                    _panelInventory.SetActive(true);
                    Open = true;
                }
                else
                {
                    Time.timeScale = 1;
                    _panelInventory.SetActive(false);
                    _panelInventoryColor.SetActive(false);
                    _panelInventoryPlant.SetActive(false);
                    Open = false;
                }
            }
        }
    }
}
