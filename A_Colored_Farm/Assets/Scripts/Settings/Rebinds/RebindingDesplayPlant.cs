using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class RebindingDesplayPlant : MonoBehaviour
{
    [SerializeField] private InputActionReference _PlantAction;
    [SerializeField] private Interactions _interactions;
    [SerializeField] private TMP_Text _bindingDisplayNameText;
    [SerializeField] private GameObject _startRebindObject;
    [SerializeField] private GameObject _waitingForInputObject;

    private InputActionRebindingExtensions.RebindingOperation _rebindingOperation;

    public void StartRebiding()
    {
        _startRebindObject.SetActive(false);
        _waitingForInputObject.SetActive(true);

        _interactions.PlayerInput.SwitchCurrentActionMap("UI");

        _rebindingOperation = _PlantAction.action.PerformInteractiveRebinding()
            .WithControlsExcluding("Mouse")
            .OnMatchWaitForAnother(0.1f)
            .OnComplete(operation => RebindComplete())
            .Start();
    }

    public void RebindComplete()
    {
        int bindingIndex = _PlantAction.action.GetBindingIndexForControl(_PlantAction.action.controls[0]);

        _bindingDisplayNameText.text = InputControlPath.ToHumanReadableString(_PlantAction.action.bindings[bindingIndex].effectivePath);

        _rebindingOperation.Dispose();

        _startRebindObject.SetActive(true);
        _waitingForInputObject.SetActive(false);

        _interactions.PlayerInput.SwitchCurrentActionMap("Inputs");
    }
}
