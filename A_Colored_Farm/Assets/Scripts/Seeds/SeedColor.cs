using UnityEngine;

public class SeedColor : MonoBehaviour
{
    public enum ColorSeed
    {
        Grey,
        Blue,
        Yellow,
        Red,
        Purple,
        Green,
        Orange,
    }

    [field: SerializeField] public ColorSeed Seed { get; set; }
}
