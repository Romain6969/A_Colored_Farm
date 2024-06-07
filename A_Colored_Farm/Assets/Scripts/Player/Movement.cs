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
    [SerializeField] private Tutorial _tutorial;
    [SerializeField] private GameObject _firstPanelTutorial;
    [SerializeField] private OpenPause _openPause;
    [SerializeField] private PlaySounds _playSounds;
    [field: SerializeField] public bool FirstTuto { get; set; } = true;
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
            _playSounds.PlayAudio(6);
            _animator.SetBool("IsWalking", true);
            _animator.SetFloat("Right", _movement.x);
            _animator.SetFloat("Left", _movement.y);
            _didNotClose = false;
        }
        else
        {
            _playSounds.StopAudio(6);
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
                if (_tutorial.WhenMove == false)
                {
                    if (FirstTuto == true)
                    {
                        _firstPanelTutorial.SetActive(true);
                        CanMove = false;
                        _openPause.Open = 1;
                    }
                    _tutorial.IndicatorsList[0].SetActive(true);
                }
            }
        }
    }
}
