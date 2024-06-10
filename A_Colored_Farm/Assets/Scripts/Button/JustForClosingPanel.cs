using UnityEngine;

public class JustForClosingPanel : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private Movement _movement;
    [SerializeField] private OpenPause _pause;
    [SerializeField] private Tutorial _tutorial;
    [SerializeField] private PlaySounds _playSounds;
    [SerializeField] private Interactions _interactions;
    [SerializeField] private PlaceColor _placeColor;
    
    public void ClosePanel()
    {
        _playSounds.PlayAudio(9);
        _movement.CanMove = true;
        _movement.FirstTuto = false;
        _panel.SetActive(false);
        _pause.Open = 2;
        _interactions.CanPerform = true;
        _placeColor.CanPaint = true;
        if (_tutorial.WhenCanMix == true)
        {
            _tutorial.ForClosingPanel = true;
            _pause.Open = 1;
            _movement.CanMove = false;
            _tutorial.WhenCanMix = false;
        }
    }
}
