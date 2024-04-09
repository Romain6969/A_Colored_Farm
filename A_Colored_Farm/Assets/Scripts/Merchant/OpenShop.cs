using UnityEngine;
using UnityEngine.InputSystem;

public class OpenShop : MonoBehaviour
{
    [SerializeField] private GameObject _shopPanel;
    private bool _open = false;
    private bool _isTrigger = false;

    public void OnShop(InputAction.CallbackContext context)
    {
        if (_isTrigger == true)
        {
            if (_open == false)
            {
                if (context.performed)
                {
                    Time.timeScale = 0;
                    _shopPanel.SetActive(true);
                    _open = true;
                }
            }
            else
            {
                if (context.performed)
                {
                    Time .timeScale = 1;
                    _shopPanel.SetActive(false);
                    _open = false;
                }
            }
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shop")
        {
            _isTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shop")
        {
            _isTrigger = false;
        }
    }
}
