using UnityEngine;
using UnityEngine.UI;

public class LoadAndSaveData : MonoBehaviour
{
    public static LoadAndSaveData instance;

    [SerializeField] private SettingFull _fullScreen;
    [SerializeField] private SettingVolume _volume;
    [SerializeField] private Slider _sliderGeneral;
    [SerializeField] private Slider _sliderMusic;
    [SerializeField] private Slider _sliderSounds;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Il ya plus d'une instance de LoadAndSaveData dans la scène");
        }
        else
        {
            instance = this;
        }
    }

    void Start()
    {
        Time.timeScale = 1;
        _fullScreen._isItFull = PlayerPrefs.GetInt("fullScreen", 0);
        _volume.SettingGeneral.Volume = PlayerPrefs.GetFloat("volumeGeneral", 0);
        _sliderGeneral.value = PlayerPrefs.GetFloat("valueGeneral", 0);
        _volume.SettingMusic.Volume = PlayerPrefs.GetFloat("volumeMusic", 0);
        _sliderMusic.value = PlayerPrefs.GetFloat("valueMusic", 0);
        _volume.SettingSounds.Volume = PlayerPrefs.GetFloat("volumeSounds", 0);
        _sliderSounds.value = PlayerPrefs.GetFloat("valueSounds", 0);
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt("fullScreen", _fullScreen._isItFull);
        PlayerPrefs.SetFloat("volumeGeneral", _volume.SettingGeneral.Volume);
        PlayerPrefs.SetFloat("valueGeneral", _sliderGeneral.value);
        PlayerPrefs.SetFloat("volumeMusic", _volume.SettingMusic.Volume);
        PlayerPrefs.SetFloat("valueMusic", _sliderMusic.value);
        PlayerPrefs.SetFloat("volumeSounds", _volume.SettingSounds.Volume);
        PlayerPrefs.SetFloat("valueSounds", _sliderSounds.value);
    }

    private void OnApplicationQuit()
    {
        SaveData();
    }
}
