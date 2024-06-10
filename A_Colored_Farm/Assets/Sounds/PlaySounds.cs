using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour
{
    [SerializeField] private List<AudioSource> _audioSources;
    [SerializeField] private List<AudioClip> _clips;
    public void PlayAudio(int wichAudio)
    {
        //_audioSources[wichAudio].PlayOneShot(_clips[wichAudio]);
        _audioSources[wichAudio].Play();
    }

    public void StopAudio(int wichAudio)
    {
        _audioSources[wichAudio].Stop();
    }

    public void PauseAudio(int wichAudio)
    {
        _audioSources[wichAudio].Pause();
    }

    public void UnPauseAudio(int wichAudio)
    {
        _audioSources[wichAudio].UnPause();
    }
}
