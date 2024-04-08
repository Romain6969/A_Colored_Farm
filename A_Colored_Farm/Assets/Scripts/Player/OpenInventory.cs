using UnityEngine;
using UnityEngine.InputSystem;

public class OpenInventory : MonoBehaviour
{
    private bool _open = false;
    [SerializeField] private GameObject _panelInventory;
    [SerializeField] private GameObject _panelInventoryPaint;
    [SerializeField] private GameObject _panelInventoryPlant;

    public void OnInventory(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (_open == false)
            {
                _panelInventory.SetActive(true);
                _open = true;
            }
            else
            {
                _panelInventory.SetActive(false);
                _panelInventoryPaint.SetActive(false);
                _panelInventoryPlant.SetActive(false);
                _open = false;
            }
        }
    }
}
