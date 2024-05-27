using UnityEngine;

public class SettingFull : MonoBehaviour
{

    public void SetfullScreen(bool isFullScreen)
    {
        if (isFullScreen == true)
        {
            Screen.fullScreen = isFullScreen;
        }
        else
        {
            Screen.fullScreen = isFullScreen;
        }
    }
}
