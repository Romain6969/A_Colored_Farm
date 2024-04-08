using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private Vector2 _movement;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed;

    public void OnMovement(InputAction.CallbackContext context)
    {
        _movement = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2(_movement.x * _speed, _movement.y * _speed);

    }
}
