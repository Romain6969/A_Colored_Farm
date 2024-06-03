using UnityEngine;

public class LoadAndSaveData : MonoBehaviour
{
    public static LoadAndSaveData instance;

    [SerializeField] private SettingFull _fullScreen;

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
        _fullScreen._isItFull = PlayerPrefs.GetInt("fullScreen", 0);
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt("fullScreen", _fullScreen._isItFull);
    }
}
