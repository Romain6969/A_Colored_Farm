using UnityEngine;

public class Resume : MonoBehaviour
{
    [SerializeField] private OpenPause _pause;
    [SerializeField] private PlaySounds _playSounds;
    [SerializeField] private GameObject _panel;
    public void OnClick()
    {
        _playSounds.PlayAudio(9);
        _panel.SetActive(false);
        Time.timeScale = 1;
        _pause.Open = 2;
    }
}
