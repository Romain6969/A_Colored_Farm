using UnityEngine;

public class ButtonPanelCloseOnly : MonoBehaviour
{
    [SerializeField] private GameObject _closePanel;

    public void OnClick()
    {
        _closePanel.SetActive(false);
    }
}
