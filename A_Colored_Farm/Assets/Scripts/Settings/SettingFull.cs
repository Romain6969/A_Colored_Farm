using UnityEngine;
using UnityEngine.UI;

public class SettingFull : MonoBehaviour
{
    public int _isItFull = 0;
    [SerializeField] private Toggle _toggle;
    [SerializeField] private float _number;

    private void Start()
    {
        Screen.fullScreen = false;
    }

    private void Update()
    {
        if (_number <= 1)
        {
            if (_isItFull == 0)
            {
                _toggle.isOn = false;
                _number += 1;
            }
            else 
            {
                _toggle.isOn = true;
                _number += 1;
            }
            return;
        }

        if (_isItFull == 0)
        {
            Screen.fullScreen = false;
        }
        else
        {
            Screen.fullScreen = true;
        }
    }

    public void SetfullScreen()
    {
        if (_number <= 1) return;

        _isItFull += 1;

        if (_isItFull == 1)
        {
            Screen.fullScreen = true;
        }
        else
        {
            Screen.fullScreen = false;
            _isItFull = 0;
        }
    }
}
