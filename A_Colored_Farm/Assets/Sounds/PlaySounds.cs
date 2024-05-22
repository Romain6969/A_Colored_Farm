using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour
{
    [SerializeField] private List<AudioSource> _audioSources;
    
    public void PlayAudio(int wichAudio)
    {
        _audioSources[wichAudio].Play();
    }
}
