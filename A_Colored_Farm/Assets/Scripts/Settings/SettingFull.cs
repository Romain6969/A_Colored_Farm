using UnityEngine;

public class SettingFull : MonoBehaviour
{
    public int _isItFull = 0;

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
