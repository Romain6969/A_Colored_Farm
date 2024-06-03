using UnityEngine;

public class SettingFull : MonoBehaviour
{
    public int _isItFull = 0;

    private void Start()
    {
        Screen.fullScreen = false;
    }

    private void Update()
    {
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
