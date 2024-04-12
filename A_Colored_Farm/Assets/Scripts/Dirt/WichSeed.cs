using UnityEngine;

public class WichSeed : MonoBehaviour
{
    [field: SerializeField] public int SeedNumber { get; private set; }

    public void OnClickNumberSeed(int Seed)
    {
        SeedNumber = Seed;
    }
}
