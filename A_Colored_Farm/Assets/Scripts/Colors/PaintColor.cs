using UnityEngine;

public class PaintColor : MonoBehaviour
{
    [field: SerializeField] public int PaintUses { get; set; }
    [field: SerializeField] public Colors Paint { get; set; }
    [SerializeField] public int ColorId { get; set; }

    private void Start()
    {
        Paint = Colors.None;
        PaintUses = 2;
    }

    private void Update()
    {
        switch (Paint)
        {
            case Colors.None:
                ColorId = 0;
                break;
            case Colors.Grey:
                ColorId = 1;
                break;
            case Colors.Blue:
                ColorId = 2;
                break;
            case Colors.Yellow:
                ColorId = 3;
                break;
            case Colors.Red:
                ColorId = 4;
                break;
            case Colors.Green:
                ColorId = 5;
                break;
            case Colors.Purple:
                ColorId = 6;
                break;
            case Colors.Orange:
                ColorId = 7;
                break;
        }
    }
}
