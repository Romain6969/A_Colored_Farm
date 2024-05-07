using UnityEngine;
using UnityEngine.InputSystem;

public class OpenPause : MonoBehaviour
{
    [field: SerializeField] public bool Open { get; set; }
    [SerializeField] private GameObject _pausePanel;
    [SerializeField] private GameObject _RebindsPanel;
    [SerializeField] private GameObject _SettingsPanel;

    public void OnPause(InputAction.CallbackContext context)
    {
        if (Open == false)
        {
            if (context.performed)
            {
                _pausePanel.SetActive(true);
                Open = true;
                Time.timeScale = 0;
            }
        }
        else
        {
            if (context.performed)
            {
                _pausePanel.SetActive(false);
                _RebindsPanel.SetActive(false);
                _SettingsPanel.SetActive(false);
                Open = false;
                Time.timeScale = 1;
            }
        }
    }
}
