using UnityEngine;

public class JustForClosingPanel : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    
    public void ClosePanel()
    {
        Time.timeScale = 1;
        _panel.SetActive(false);
    }
}
