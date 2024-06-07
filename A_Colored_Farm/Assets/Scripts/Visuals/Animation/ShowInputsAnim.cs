using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class ShowInputsAnim : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private float _time;
    [SerializeField] private RebindingDesplayMovementup _movementUp;
    [SerializeField] private TMP_Text _text;

    private void Start()
    {
        _animator.Play("ShowInputsAnim");
    }

    private void FixedUpdate()
    {
        _time += Time.deltaTime;

        if (_time >= 1)
        {
            _animator.enabled = false;
        }

        _text.text = $"Move with : {_movementUp.ActionMovement.action.GetBindingDisplayString(1)} / {_movementUp.ActionMovement.action.GetBindingDisplayString(3)} / {_movementUp.ActionMovement.action.GetBindingDisplayString(2)} / {_movementUp.ActionMovement.action.GetBindingDisplayString(4)}";
    }
}
