using UnityEngine;

public class JustForClosingPanel : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private Movement _movement;
    [SerializeField] private OpenPause _pause;
    
    public void ClosePanel()
    {
        _movement.CanMove = true;
        _movement.FirstTuto = false;
        _panel.SetActive(false);
        _pause.Open = 2;
    }
}
