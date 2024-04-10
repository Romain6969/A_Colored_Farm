using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class RebindingDesplayInventory : MonoBehaviour
{
    [SerializeField] private InputActionReference _openAction;
    [SerializeField] private OpenInventory _openInventory;
    [SerializeField] private TMP_Text _bindingDisplayNameText;
    [SerializeField] private GameObject _startRebindObject;
    [SerializeField] private GameObject _waitingForInputObject;

    private InputActionRebindingExtensions.RebindingOperation _rebindingOperation;

    public void StartRebiding()
    {
        _startRebindObject.SetActive(false);
        _waitingForInputObject.SetActive(true);

        _openInventory.PlayerInput.SwitchCurrentActionMap("UI");

        _rebindingOperation = _openAction.action.PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .OnMatchWaitForAnother(0.1f)
            .OnComplete(operation => RebindComplete())
            .Start();
    }

    public void RebindComplete()
    {
        int bindingIndex = _openAction.action.GetBindingIndexForControl(_openAction.action.controls[0]);

        _bindingDisplayNameText.text = InputControlPath.ToHumanReadableString(_openAction.action.bindings[bindingIndex].effectivePath);

        _rebindingOperation.Dispose();

        _startRebindObject.SetActive(true);
        _waitingForInputObject.SetActive(false);

        _openInventory.PlayerInput.SwitchCurrentActionMap("Inputs");
    }
}
