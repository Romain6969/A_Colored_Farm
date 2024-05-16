using UnityEngine;

public class SeedColor : MonoBehaviour
{
    [field: SerializeField] public Colors Seed { get; set; }

    private void Start()
    {
        Seed = Colors.None;
    }
}
