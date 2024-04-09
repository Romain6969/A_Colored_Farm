using UnityEngine;
using UnityEngine.InputSystem;

public class OpenInventory : MonoBehaviour
{
    private bool _open = false;
    [SerializeField] private GameObject _panelInventory;
    [SerializeField] private GameObject _panelInventoryColor;
    [SerializeField] private GameObject _panelInventoryPlant;

    public void OnInventory(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (_open == false)
            {
                Time.timeScale = 0;
                _panelInventory.SetActive(true);
                _open = true;
            }
            else
            {
                Time.timeScale = 1;
                _panelInventory.SetActive(false);
                _panelInventoryColor.SetActive(false);
                _panelInventoryPlant.SetActive(false);
                _open = false;
            }
        }
    }
}
