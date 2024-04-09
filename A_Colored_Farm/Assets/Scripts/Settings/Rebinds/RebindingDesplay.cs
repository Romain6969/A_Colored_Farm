using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class RebindingDesplay : MonoBehaviour
{
    [SerializeField] private InputActionReference _moveAction;
    [SerializeField] private Movement _movement;
    [SerializeField] private TMP_Text _bindingDisplayNameText;
    [SerializeField] private GameObject _startRebindObject;
    [SerializeField] private GameObject _waitingForInputObject;

    private InputActionRebindingExtensions.RebindingOperation _rebindingOperation;
    public void StartRebiding()
    {
        _startRebindObject.SetActive(false);
        _waitingForInputObject.SetActive(true);

        _movement.PlayerInput.SwitchCurrentActionMap("UI");

        _moveAction.action.PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .OnMatchWaitForAnother(0.1f)
            .OnComplete(operation => RebindComplete())
            .Start();
    }

    public void RebindComplete()
    {
        _rebindingOperation.Dispose();

        _startRebindObject.SetActive(true);
        _waitingForInputObject.SetActive(false);

        _movement.PlayerInput.SwitchCurrentActionMap("Inputs");
    }
}
