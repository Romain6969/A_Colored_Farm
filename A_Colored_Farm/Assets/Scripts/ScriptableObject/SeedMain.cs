using UnityEngine;

public class SeedMain : MonoBehaviour
{
    [field: SerializeField] public SeedData GreySeed { get; private set; }
    [field : SerializeField] public SeedData BlueSeed { get; private set; }
    [field : SerializeField] public SeedData YellowSeed { get; private set; }
    [field : SerializeField] public SeedData RedSeed { get; private set; }
    [field: SerializeField] public SeedData PurpleSeed { get; private set; }
    [field: SerializeField] public SeedData GreenSeed { get; private set; }
    [field: SerializeField] public SeedData OrangeSeed { get; private set; }
}
