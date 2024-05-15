using UnityEngine;

[CreateAssetMenu(fileName = "Color", menuName = "NewColor")]
public class ColorData : ScriptableObject
{
    [field : SerializeField] public int ColorID { get; private set; }
    [field : SerializeField] public int SellValue { get; private set; }
    [field: SerializeField] public GameObject PrefabColor { get; private set; }
}
