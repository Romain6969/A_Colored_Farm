using UnityEngine;
using UnityEngine.Audio;

public class SettingMusic : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;

    public void SetVolume(float volume)
    {
        _audioMixer.SetFloat("Music", volume);
    }
}
