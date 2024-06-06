using UnityEngine;

public class JustForClosingPanel : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private Movement _movement;
    [SerializeField] private OpenPause _pause;
    [SerializeField] private Tutorial _tutorial;
    
    public void ClosePanel()
    {
        _movement.CanMove = true;
        _movement.FirstTuto = false;
        _panel.SetActive(false);
        _pause.Open = 2;
        if (_tutorial.WhenCanMix == true)
        {
            _tutorial.ForClosingPanel = true;
            _pause.Open = 1;
            _movement.CanMove = false;
        }
    }
}
