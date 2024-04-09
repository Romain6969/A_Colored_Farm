using UnityEngine;
using UnityEngine.Audio;

public class SettingGeneral : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;

    public void SetVolume(float volume)
    {
        _audioMixer.SetFloat("Master", volume);
    }
}
