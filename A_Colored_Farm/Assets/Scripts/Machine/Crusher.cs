using UnityEngine;
using UnityEngine.UI;

public class Crusher : MonoBehaviour
{
    [SerializeField] private KeepItem _keepItem;
    [field : SerializeField] public int CopyId { get; set; }
    [field : SerializeField] public bool Activate { get; set; } = false;
    [field : SerializeField] public bool Ready { get; set; } = false;
    [SerializeField] private float _time;
    [field : SerializeField] public float TimeObjectif { get; set; } = 15;
    [SerializeField] private PlaySounds _playSounds;
    [SerializeField] private ListAnimation _listAnimation;
    [SerializeField] private Image _image;
    [SerializeField] private GameObject _progressBarGameObject;
    [SerializeField] private Tutorial _tutorial;

    public void OnActivated()
    {
        CopyId = _keepItem.Id;
        Activate = true;
        _playSounds.PlayAudio(1);
        _listAnimation.PlayAnimation(CopyId);
    }

    void Update()
    {
        if (Activate == true)
        {
            _progressBarGameObject.SetActive(true);
            _time += Time.deltaTime;
            _image.fillAmount = _time / TimeObjectif;

            if (_time >= TimeObjectif)
            {
                Ready = true;
                _time = 0;
                Activate = false;
                _playSounds.StopAudio(1);
                _playSounds.PlayAudio(2);
                _listAnimation.StopAnimation(CopyId);
                if (_tutorial.WhenMix == false)
                {
                    _tutorial.IndicatorsList[4].SetActive(true);
                }
                if (_tutorial.WhenMix2 == false && _tutorial.ForClosingPanel == true)
                {
                    _tutorial.IndicatorsList[4].SetActive(true);
                }
            }
        }
        if (Time.timeScale == 0)
        {
            _playSounds.PauseAudio(1);
        }
        if (Time.timeScale == 1)
        {
            _playSounds.UnPauseAudio(1);
        }
    }
}
