using UnityEngine;
using UnityEngine.Audio;

public class SettingSounds : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;

    public void SetVolume(float volume)
    {
        _audioMixer.SetFloat("Sounds", volume);
    }
}
