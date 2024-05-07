using UnityEngine;

public class WichColor : MonoBehaviour
{
    [field : SerializeField] public int ColorNumber { get; set; }
    [field: SerializeField] public bool IsNowPaint { get; set; } = false;

    public void OnClickNumberColor(int color)
    {
        ColorNumber = color;

        if (IsNowPaint == false)
        {
            IsNowPaint = true;
        }
        else
        {
            IsNowPaint = false;
        }
    }
}
