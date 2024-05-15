using UnityEngine;

public class ResultMix : MonoBehaviour
{
    public enum ColorResult
    {
        Grey,
        Blue,
        Yellow,
        Red,
        Purple,
        Green,
        Orange,
    }

    [field: SerializeField] public ColorResult Result { get; set; }
}
