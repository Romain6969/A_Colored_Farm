using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenPause : MonoBehaviour
{
    [field: SerializeField] public bool Open { get; set; }
    [SerializeField] private GameObject _pausePanel;
    [SerializeField] private GameObject _RebindsPanel;
    [SerializeField] private GameObject _SettingsPanel;
    [SerializeField] private List<GameObject> _exitPanel;

    public void OnPause(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (_exitPanel[0] || _exitPanel[1])
            {
                _exitPanel[0].SetActive(false);
                _exitPanel[1].SetActive(false);
            }
            else
            {
                if (Open == false)
                {
                    _pausePanel.SetActive(true);
                    Open = true;
                    Time.timeScale = 0;
                }
                else
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
}
