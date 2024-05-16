using UnityEngine;

public class SeedColorMix : MonoBehaviour
{
    [SerializeField] private Dirt _dirt;
    [field: SerializeField] public ColorData TheColor;
    [field: SerializeField] public SeedData TheSeed;
    [SerializeField] private PaintColor _paintColor;
    [SerializeField] private SeedColor _seedColor;
    [SerializeField] private ResultMix _resultMix;

    public Colors EveryMix(Colors paintColor, Colors seedColor)
    {
        if (paintColor == Colors.Blue && seedColor == Colors.Blue)
        {
            return _resultMix.Result = Colors.Blue;
        }
        if ((paintColor == Colors.Blue && seedColor == Colors.Yellow) || (paintColor == Colors.Yellow && seedColor == Colors.Blue))
        {
            return _resultMix.Result = Colors.Green;
        }
        if ((paintColor == Colors.Blue && seedColor == Colors.Red) || (paintColor == Colors.Red && seedColor == Colors.Blue))
        {
            return _resultMix.Result = Colors.Purple;
        }
        if (paintColor == Colors.Yellow && seedColor == Colors.Yellow)
        {
            return _resultMix.Result = Colors.Yellow;
        }
        if ((paintColor == Colors.Yellow && seedColor == Colors.Red) || (paintColor == Colors.Red && seedColor == Colors.Yellow))
        {
            return _resultMix.Result = Colors.Orange;
        }
        if (paintColor == Colors.Red && seedColor == Colors.Red)
        {
            return _resultMix.Result = Colors.Red;
        }
        else
        {
            return _resultMix.Result = Colors.Grey;
        }
    }

    public void MixThem()
    {
        Colors result = EveryMix(_paintColor.Paint, _seedColor.Seed);
    }
}
