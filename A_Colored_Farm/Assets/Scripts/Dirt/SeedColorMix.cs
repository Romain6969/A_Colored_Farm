using UnityEngine;

public class SeedColorMix : MonoBehaviour
{
    [SerializeField] private DetectColors _detectColors;
    [SerializeField] private Dirt _dirt;
    [field: SerializeField] public ColorData TheColor;
    [field: SerializeField] public SeedData TheSeed;
    [SerializeField] private PaintColor _paintColor;
    [SerializeField] private SeedColor _seedColor;
    [SerializeField] private ResultMix _resultMix;

    private ResultMix.ColorResult[,] ColorSomething;

    public void EveryMix(int paintColor, int seedColor)
    {
        if (ColorSomething[paintColor, seedColor] == ColorSomething[1, 1])
        {
            ColorSomething[paintColor, seedColor] = ResultMix.ColorResult.Blue;
        }
        if (ColorSomething[paintColor, seedColor] == ColorSomething[1, 2])
        {
            ColorSomething[paintColor, seedColor] = ResultMix.ColorResult.Green;
        }
        if (ColorSomething[paintColor, seedColor] == ColorSomething[1, 3])
        {
            ColorSomething[paintColor, seedColor] = ResultMix.ColorResult.Purple;
        }
        if (ColorSomething[paintColor, seedColor] == ColorSomething[2, 1])
        {
            ColorSomething[paintColor, seedColor] = ResultMix.ColorResult.Green;
        }
        if (ColorSomething[paintColor, seedColor] == ColorSomething[2, 2])
        {
            ColorSomething[paintColor, seedColor] = ResultMix.ColorResult.Yellow;
        }
        if (ColorSomething[paintColor, seedColor] == ColorSomething[2, 3])
        {
            ColorSomething[paintColor, seedColor] = ResultMix.ColorResult.Orange;
        }
        if (ColorSomething[paintColor, seedColor] == ColorSomething[3, 1])
        {
            ColorSomething[paintColor, seedColor] = ResultMix.ColorResult.Purple;
        }
        if (ColorSomething[paintColor, seedColor] == ColorSomething[3, 2])
        {
            ColorSomething[paintColor, seedColor] = ResultMix.ColorResult.Orange;
        }
        if (ColorSomething[paintColor, seedColor] == ColorSomething[3, 3])
        {
            ColorSomething[paintColor, seedColor] = ResultMix.ColorResult.Red;
        }
        else
        {
            ColorSomething[paintColor, seedColor] = ResultMix.ColorResult.Grey;
        }
    }

    public void MixThem()
    {
        EveryMix((int)_paintColor.Paint, (int)_seedColor.Seed);
    }

    private void FixedUpdate()
    {
        if (_dirt.SeedPlaced == true && _detectColors.ColorPlaced == true)
        {
            MixThem();
        }
    }
}
