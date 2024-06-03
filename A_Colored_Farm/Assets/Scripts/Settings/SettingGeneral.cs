using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class SettingGeneral : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] public float Volume {  get; set; }

    void Start()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.01f);
        SetVolume(Volume);
    }

    public void SetVolume(float volume)
    {
        _audioMixer.SetFloat("Master", volume);
        Debug.Log($"{volume}");
        Volume = volume;
    }
}
