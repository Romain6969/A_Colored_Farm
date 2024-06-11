using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musics : MonoBehaviour
{
    [SerializeField] private List<AudioSource> _musicsAudio;
    [SerializeField] private float _time;
    [SerializeField] private bool _isPlaying = true;

    void Start()
    {
        PlayAudio(0);
        _musicsAudio[1].enabled = false;
    }

    void Update()
    {
        _time += Time.deltaTime;

        if (_time >= 128f && _isPlaying == false)
        {
            _musicsAudio[1].enabled = false;
            _musicsAudio[0].enabled = true;
            PlayAudio(0);
            StopAudio(1);
            _time = 0;
            _isPlaying = true;
        }
        if (_time >= 168f && _isPlaying == true)
        {
            StopAudio(0);
            _musicsAudio[0].enabled = false;
            _musicsAudio[1].enabled = true;
            PlayAudio(1);
            _time = 0;
            _isPlaying = false;
        }
        
        if (Time.timeScale == 0)
        {
            PauseAudio(0);
            PauseAudio(1);
        }
        if (Time.timeScale == 1)
        {
            UnPauseAudio(0);
            UnPauseAudio(1);
        }
    }

    public void PlayAudio(int wichAudio)
    {
        //_audioSources[wichAudio].PlayOneShot(_clips[wichAudio]);
        _musicsAudio[wichAudio].Play();
    }

    public void StopAudio(int wichAudio)
    {
        _musicsAudio[wichAudio].Stop();
    }

    public void PauseAudio(int wichAudio)
    {
        _musicsAudio[wichAudio].Pause();
    }

    public void UnPauseAudio(int wichAudio)
    {
        _musicsAudio[wichAudio].UnPause();
    }
}
