using UnityEngine;

public class SeedColorMix : MonoBehaviour
{
    [field :SerializeField] public PaintColor PaintColor { get; set; }
    [field :SerializeField] public SeedColor SeedColor { get; set; }
    [field :SerializeField] public ResultMix ResultMix { get; set; }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dirt")
        {
            PaintColor = collision.gameObject.GetComponent<PaintColor>();
            SeedColor = collision.gameObject.GetComponent<SeedColor>();
            ResultMix = collision.gameObject.GetComponent<ResultMix>();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PaintColor = null;
        SeedColor = null;
        ResultMix = null;
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
        /*
        if ((paintColor == Colors.Grey && seedColor == Colors.Blue) || (paintColor == Colors.Blue && seedColor == Colors.Grey))
        {
            return ResultMix.Result = Colors.Blue
        }
        if ((paintColor == Colors.Grey && seedColor == Colors.Yellow) || (paintColor == Colors.Yellow && seedColor == Colors.Grey))
        {
            return ResultMix.Result = Colors.Yellow
        }
        if ((paintColor == Colors.Grey && seedColor == Colors.Red) || (paintColor == Colors.Red && seedColor == Colors.Grey))
        {
            return ResultMix.Result = Colors.Red
        }
        if ((paintColor == Colors.Grey && seedColor == Colors.Purple) || (paintColor == Colors.Purple && seedColor == Colors.Grey))
        {
            return ResultMix.Result = Colors.Purple
        }
        if ((paintColor == Colors.Grey && seedColor == Colors.Green) || (paintColor == Colors.Green && seedColor == Colors.Grey))
        {
            return ResultMix.Result = Colors.Green
        }
        if ((paintColor == Colors.Grey && seedColor == Colors.Orange) || (paintColor == Colors.Orange && seedColor == Colors.Grey))
        {
            return ResultMix.Result = Colors.Orange
        }
        */
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
