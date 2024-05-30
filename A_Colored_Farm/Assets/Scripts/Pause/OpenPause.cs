using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenPause : MonoBehaviour
{
    [field: SerializeField] public int Open { get; set; } = 2;
    [SerializeField] private GameObject _pausePanel;
    [SerializeField] private GameObject _RebindsPanel;
    [SerializeField] private GameObject _SettingsPanel;
    [SerializeField] private List<GameObject> _exitPanel;
    [SerializeField] private Movement _movement;
    [SerializeField] private OpenShop _shop;

    public void OnPause(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            switch (Open)
            {
                case 1:
                    _exitPanel[0].SetActive(false);
                    _exitPanel[1].SetActive(false);
                    _movement.CanMove = true;
                    _shop.Open = false;
                    Open = 2;
                    break;
                case 2:
                    _pausePanel.SetActive(true);
                    Time.timeScale = 0;
                    Open = 3;
                    break;
                case 3:
                    _pausePanel.SetActive(false);
                    _RebindsPanel.SetActive(false);
                    _SettingsPanel.SetActive(false);
                    Time.timeScale = 1;
                    Open = 2;
                    break;
            }
            /*if (_exitPanel[0] || _exitPanel[1])
            {
                _exitPanel[0].SetActive(false);
                _exitPanel[1].SetActive(false);
                _movement.CanMove = true;
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
            }*/
        }
    }
}
