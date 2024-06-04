using UnityEngine;
using UnityEngine.InputSystem;

public class PushButton : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private KeepItem _keepItem;
    [SerializeField] private GameObject _group1;
    [SerializeField] private GameObject _group2;
    private bool _isTrigger = false;
    private int _number = 0;

    public void OnPush(InputAction.CallbackContext context)
    {
        if (_isTrigger == true)
        {
            if (context.performed)
            {
                if (_keepItem.Id == 0)
                {
                    switch (_number)
                    {
                        case 0:
                            _group2.SetActive(true);
                            _group1.SetActive(false);
                            _number += 1;
                            break;
                        case 1:
                            _group1.SetActive(true);
                            _group2.SetActive(false);
                            _number -= 1;
                            break;
                    }
                }
            }
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Button")
        {
            _isTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Button")
        {
            _isTrigger = false;
        }
    }
}
