using UnityEngine;

public class SettingVolume : MonoBehaviour
{
    [field : SerializeField] public SettingGeneral SettingGeneral {  get; set; }
    [field : SerializeField] public SettingMusic SettingMusic { get; set; }
    [field : SerializeField] public SettingSounds SettingSounds { get; set; }
}
