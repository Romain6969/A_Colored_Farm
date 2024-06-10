using UnityEngine;

public class ButtonPanel : MonoBehaviour
{
    [SerializeField] private GameObject _panelActivated;
    [SerializeField] private GameObject _panelDesactivated;
    [SerializeField] private PlaySounds _playSounds;

    public void OnClick()
    {
        _playSounds.PlayAudio(9);
        _panelActivated.SetActive(true);
        _panelDesactivated.SetActive(false);
    }
}
