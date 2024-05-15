using UnityEngine;

[CreateAssetMenu(fileName = "Seed", menuName = "NewSeed")]
public class SeedData : ScriptableObject
{
    [field : SerializeField] public int SeedID { get; private set; }
    [field : SerializeField] public int PurchaseValue { get; private set; }
    [field : SerializeField] public int SellValue { get; private set; }
    [field: SerializeField] public float GrowTime { get; private set; }
}
