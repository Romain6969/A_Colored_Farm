using UnityEngine;
using UnityEngine.InputSystem;

public class OpenFridge : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private KeepItem _keepItem;
    [SerializeField] private Queue _queue;
    private bool _isTrigger = false;

    public void OnQueue(InputAction.CallbackContext context)
    {
        if (_isTrigger == true)
        {
            if (context.performed)
            {
                if (_keepItem.Here == true)
                {
                    if (_keepItem.Id == 1 || _keepItem.Id == 2 || _keepItem.Id == 3 || _keepItem.Id == 4 || _keepItem.Id == 5 || _keepItem.Id == 6 || _keepItem.Id == 7 || _keepItem.Id == 8 || _keepItem.Id == 9 || _keepItem.Id == 10 || _keepItem.Id == 11 || _keepItem.Id == 12 || _keepItem.Id == 13)
                    {
                        _queue.AddVegetable(_keepItem.Id);
                    }
                }
                else
                {
                    if (_keepItem.Id == 0)
                    {
                        _queue.RemoveVegetable();
                    }
                }
            }
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fridge")
        {
            _isTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fridge")
        {
            _isTrigger = false;
        }
    }
}
