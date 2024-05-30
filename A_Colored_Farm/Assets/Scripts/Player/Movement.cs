using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private Vector2 _movement;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed;
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private Animator _animator;
    [SerializeField] private Animator _animationCloseShowInputs;
    private float _time;
    private bool _didNotClose = true;

    [SerializeField]
    private bool _canMove = true;
    public bool CanMove
    {
        get => _canMove;
        set
        {
            if (_canMove && !value)
            {
                _movement = Vector2.zero;
            }
            _canMove = value;
        }
    }

    public PlayerInput PlayerInput => _playerInput;

    public void OnMovement(InputAction.CallbackContext context)
    {
        if (!CanMove) return;

        _movement = context.ReadValue<Vector2>();

        if (_movement != Vector2.zero)
        {
            _animator.SetBool("IsWalking", true);
            _animator.SetFloat("Right", _movement.x);
            _animator.SetFloat("Left", _movement.y);
            _didNotClose = false;
        }
        else
        {
            _animator.SetBool("IsWalking", false);
        }
    }

    private void FixedUpdate()
    {
        if (CanMove)
        {
            _rigidbody.velocity = new Vector2(_movement.x * _speed, _movement.y * _speed);
        }
        else
        {
            _rigidbody.velocity = Vector2.zero;
            _animator.SetBool("IsWalking", false);
        }
        if (_didNotClose == false)
        {
            _time += Time.deltaTime;
            _animationCloseShowInputs.enabled = true;
            _animationCloseShowInputs.Play("ShowInputsAnimReturn");
            if (_time >= 1)
            {
                _animationCloseShowInputs.enabled = false;
            }
        }
    }
}
