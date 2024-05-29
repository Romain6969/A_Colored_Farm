using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private Vector2 _movement;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed;
    [SerializeField] private PlayerInput _playerInput;
    [field : SerializeField] public bool MovementBool { get; set; } = true;
    [SerializeField] private Animator _animator;

    public PlayerInput PlayerInput => _playerInput;

    public void OnMovement(InputAction.CallbackContext context)
    {
        if (MovementBool == true)
        {
            _movement = context.ReadValue<Vector2>();
            if (_movement != Vector2.zero)
            {
                _animator.SetFloat("Right", _movement.x);
                _animator.SetFloat("Left", _movement.y);
            }
        }
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2(_movement.x * _speed, _movement.y * _speed);

    }
}
