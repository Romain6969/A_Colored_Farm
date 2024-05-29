using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class RebindingDesplayPlant : MonoBehaviour
{
    [SerializeField] private InputActionReference _plantAction;
    [SerializeField] private PlaceSeed _plantSeed;
    [SerializeField] private OpenShop _openShop;
    [SerializeField] private TMP_Text _bindingDisplayNameText;
    [SerializeField] private GameObject _startRebindObject;
    [SerializeField] private GameObject _waitingForInputObject;

    private InputActionRebindingExtensions.RebindingOperation _rebindingOperation;

    public void StartRebiding()
    {
        _startRebindObject.SetActive(false);
        _waitingForInputObject.SetActive(true);

        Cursor.lockState = CursorLockMode.Locked;

        _plantSeed.PlayerInput.SwitchCurrentActionMap("UI");
        _openShop.PlayerInput.SwitchCurrentActionMap("UI");

        _rebindingOperation = _plantAction.action.PerformInteractiveRebinding()
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

        _plantSeed.PlayerInput.SwitchCurrentActionMap("Inputs");
        _openShop.PlayerInput.SwitchCurrentActionMap("Inputs");

        Cursor.lockState = CursorLockMode.None;
    }

    private void Update()
    {
        int bindingIndex = _plantAction.action.GetBindingIndexForControl(_plantAction.action.controls[0]);

        //_bindingDisplayNameText.text = InputControlPath.ToHumanReadableString(_plantAction.action.bindings[bindingIndex].effectivePath, InputControlPath.HumanReadableStringOptions.OmitDevice);
        _bindingDisplayNameText.text = _plantAction.action.GetBindingDisplayString(bindingIndex);
    }
}
