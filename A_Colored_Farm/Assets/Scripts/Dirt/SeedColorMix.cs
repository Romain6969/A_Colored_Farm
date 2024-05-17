using UnityEngine;

public class SeedColorMix : MonoBehaviour
{
    [field :SerializeField] public PaintColor PaintColor { get; set; }
    [field :SerializeField] public SeedColor SeedColor { get; set; }
    [field :SerializeField] public ResultMix ResultMix { get; set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dirt")
        {
            PaintColor = collision.gameObject.GetComponent<PaintColor>();
            SeedColor = collision.gameObject.GetComponent<SeedColor>();
            ResultMix = collision.gameObject.GetComponent<ResultMix>();
        }
    }
    public Colors EveryMix(Colors paintColor, Colors seedColor)
    {
        if (paintColor == Colors.Blue && seedColor == Colors.Blue)
        {
            return ResultMix.Result = Colors.Blue;
        }
        if ((paintColor == Colors.Blue && seedColor == Colors.Yellow) || (paintColor == Colors.Yellow && seedColor == Colors.Blue))
        {
            return ResultMix.Result = Colors.Green;
        }
        if ((paintColor == Colors.Blue && seedColor == Colors.Red) || (paintColor == Colors.Red && seedColor == Colors.Blue))
        {
            return ResultMix.Result = Colors.Purple;
        }
        if (paintColor == Colors.Yellow && seedColor == Colors.Yellow)
        {
            return ResultMix.Result = Colors.Yellow;
        }
        if ((paintColor == Colors.Yellow && seedColor == Colors.Red) || (paintColor == Colors.Red && seedColor == Colors.Yellow))
        {
            return ResultMix.Result = Colors.Orange;
        }
        if (paintColor == Colors.Red && seedColor == Colors.Red)
        {
            return ResultMix.Result = Colors.Red;
        }
        else
        {
            return ResultMix.Result = Colors.Grey;
        }
    }

    public int MixThem()
    {
        return (int)EveryMix(PaintColor.Paint, SeedColor.Seed);
    }
}
