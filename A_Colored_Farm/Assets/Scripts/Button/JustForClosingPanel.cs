using UnityEngine;

public class JustForClosingPanel : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private Movement _movement;
    
    public void ClosePanel()
    {
        _movement.MovementBool = true;
        _panel.SetActive(false);
    }
}
