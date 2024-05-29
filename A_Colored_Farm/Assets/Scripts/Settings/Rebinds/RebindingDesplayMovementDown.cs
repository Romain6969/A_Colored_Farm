using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class RebindingDesplayMovementDown : MonoBehaviour
{
    [SerializeField] private InputActionReference _actionMovement;
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

        Cursor.lockState = CursorLockMode.Locked;

        var moveAction = new InputAction(expectedControlType: "Vector2");
        moveAction.AddCompositeBinding("2DVector")
            .With("Up", "<Keyboard>/w")
            .With("Down", "<Keyboard>/s")
            .With("Left", "<Keyboard>/a")
            .With("Right", "<Keyboard>/d");

        _rebindingOperation = _actionMovement.action.PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .WithTargetBinding(2)
            .OnMatchWaitForAnother(.1f)
            .OnComplete(operation => RebindComplete())
            .Start();
    }

    public void RebindComplete()
    {
        _rebindingOperation.Dispose();

        _startRebindObject.SetActive(true);
        _waitingForInputObject.SetActive(false);

        _movement.PlayerInput.SwitchCurrentActionMap("Inputs");

        Cursor.lockState = CursorLockMode.None;
    }

    private void Update()
    {
        _bindingDisplayNameText.text = InputControlPath.ToHumanReadableString(_actionMovement.action.bindings[2].effectivePath, InputControlPath.HumanReadableStringOptions.OmitDevice);
    }
}
