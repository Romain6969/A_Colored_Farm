using UnityEngine;
using UnityEngine.InputSystem;

public class InteractClient : MonoBehaviour
{
    [SerializeField] private Client _client;
    [SerializeField] private ClientMovement _movement;
    private bool _isTrigger = false;

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (_isTrigger == true && _client.Received == true && _movement.Back == false)
        {
            if (context.performed)
            {
                _client.Received = false;
                _movement.Back = true;
            }
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Client")
        {
            _isTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Client")
        {
            _isTrigger = false;
        }
    }
}
