using UnityEngine;

public class PaintColor : MonoBehaviour
{
    public enum ColorPaint
    {
        Grey,
        Blue,
        Yellow,
        Red,
        Purple,
        Green,
        Orange,
    }

    [field: SerializeField] public ColorPaint Paint { get; set; }

}
