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
    [SerializeField] private GameObject _vfxWalk;
    [SerializeField] private OpenPause _openPause;
    [SerializeField] private PlaySounds _playSounds;
    [field: SerializeField] public bool FirstTuto { get; set; } = true;
    [field: SerializeField] public bool GeneratePowder { get; set; }
    private float _time;

    [SerializeField]private bool _didNotClose = true;

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
            _playSounds.PlayAudio(7);
            _animator.SetBool("IsWalking", true);
            _animator.SetFloat("Right", _movement.x);
            _animator.SetFloat("Left", _movement.y);
            _didNotClose = false;
        }
        else
        {
            _playSounds.StopAudio(7);
            _animator.SetBool("IsWalking", false);
        }

        if (_movement.x > 0)
        {
            GeneratePowder = true;
            _vfxWalk.transform.rotation = Quaternion.Euler(0, 0, 65);
        }
        else if (_movement.y > 0)
        {
            GeneratePowder = true;
            _vfxWalk.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if (_movement.x < 0)
        {
            GeneratePowder = true;
            _vfxWalk.transform.rotation = Quaternion.Euler(0, 0, -65);
        }
        else if (_movement.y < 0)
        {
            GeneratePowder = true;
            _vfxWalk.transform.rotation = Quaternion.Euler(0, 0, 0);
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
            _playSounds.StopAudio(7);
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

        if (_movement.x == 0 && _movement.y == 0)
        {
            GeneratePowder = false;
        }
    }
}
