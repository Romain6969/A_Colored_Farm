using UnityEngine;
using UnityEngine.InputSystem;

public class OpenCrusher : MonoBehaviour
{
    [field: SerializeField] public bool Open { get; set; }
    [SerializeField] private GameObject _crusherPanel;
    [SerializeField] private OpenInventory _openInventory;
    [SerializeField] private PlayerInput _playerInput;
    private bool _isTrigger = false;

    public PlayerInput PlayerInput => _playerInput;

    public void OnCrusher(InputAction.CallbackContext context)
    {
        if (_isTrigger == true)
        {
            if (_openInventory.Open == false)
            {
                if (Open == false)
                {
                    if (context.performed)
                    {
                        _crusherPanel.SetActive(true);
                        Open = true;
                        Time.timeScale = 0;
                    }
                }
                else
                {
                    if (context.performed)
                    {
                        _crusherPanel.SetActive(false);
                        Open = false;
                        Time.timeScale = 1;
                    }
                }
            }
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Crusher")
        {
            _isTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Crusher")
        {
            _isTrigger = false;
        }
    }
}
