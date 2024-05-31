using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class RebindingDesplayPlant : MonoBehaviour
{
    [field: SerializeField] public InputActionReference PlantAction { get; private set; }
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

        _rebindingOperation = PlantAction.action.PerformInteractiveRebinding()
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
        int bindingIndex = PlantAction.action.GetBindingIndexForControl(PlantAction.action.controls[0]);

        //_bindingDisplayNameText.text = InputControlPath.ToHumanReadableString(_plantAction.action.bindings[bindingIndex].effectivePath, InputControlPath.HumanReadableStringOptions.OmitDevice);
        _bindingDisplayNameText.text = PlantAction.action.GetBindingDisplayString(bindingIndex);
    }
}
