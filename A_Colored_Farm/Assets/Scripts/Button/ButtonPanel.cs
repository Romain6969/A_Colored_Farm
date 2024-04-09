using UnityEngine;

public class ButtonPanel : MonoBehaviour
{
    [SerializeField] private GameObject _panelActivated;
    [SerializeField] private GameObject _panelDesactivated;

    public void OnClick()
    {
        _panelActivated.SetActive(true);
        _panelDesactivated.SetActive(false);
    }
}
