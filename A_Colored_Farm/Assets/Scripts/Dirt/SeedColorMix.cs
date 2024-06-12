using UnityEngine;
using System.Collections.Generic;

public class SeedColorMix : MonoBehaviour
{
    [field :SerializeField] public PaintColor PaintColor { get; set; }
    [field :SerializeField] public SeedColor SeedColor { get; set; }
    [field :SerializeField] public ResultMix ResultMix { get; set; }

    [SerializeField] private List<GameObject> _listCollision;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Dirt") return;

        _listCollision.Add(collision.gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag != "Dirt") return;

        _listCollision.Remove(collision.gameObject);
    }

    private GameObject GetClosestDirt()
    {
        if (_listCollision.Count == 0) return null;

        if (_listCollision.Count == 1) return _listCollision[0];

        float minDistance = float.MaxValue;
        GameObject closestDirt = null;
        foreach (var dirt in _listCollision)
        {
            float distance = Vector2.Distance(
                new Vector2(transform.position.x, transform.position.y),
                new Vector2(dirt.transform.position.x, dirt.transform.position.y));

            if (distance < minDistance)
            {
                minDistance = distance;
                closestDirt = dirt;
            }
        }

        return closestDirt;
    }

    private void RefreshComponentsReference()
    {
        GameObject closestDirt = GetClosestDirt();

        if (closestDirt == null)
        {
            PaintColor = null;
            SeedColor = null;
            ResultMix = null;
        }
        else
        {
            PaintColor = closestDirt.GetComponent<PaintColor>();
            SeedColor = closestDirt.GetComponent<SeedColor>();
            ResultMix = closestDirt.GetComponent<ResultMix>();
        }
    }

    private Colors EveryMix(Colors paintColor, Colors seedColor)
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
        if ((paintColor == Colors.Blue && seedColor == Colors.Green) || (paintColor == Colors.Green && seedColor == Colors.Blue))
        {
            return ResultMix.Result = Colors.Cyan;
        }
        if ((paintColor == Colors.Blue && seedColor == Colors.Purple) || (paintColor == Colors.Purple && seedColor == Colors.Blue))
        {
            return ResultMix.Result = Colors.Indigo;
        }
        if ((paintColor == Colors.Yellow && seedColor == Colors.Green) || (paintColor == Colors.Green && seedColor == Colors.Yellow))
        {
            return ResultMix.Result = Colors.Lime;
        }
        if ((paintColor == Colors.Red && seedColor == Colors.Orange) || (paintColor == Colors.Orange && seedColor == Colors.Red))
        {
            return ResultMix.Result = Colors.Ocre;
        }
        if ((paintColor == Colors.Purple && seedColor == Colors.Red) || (paintColor == Colors.Red && seedColor == Colors.Purple))
        {
            return ResultMix.Result = Colors.Magenta;
        }
        if ((paintColor == Colors.Orange && seedColor == Colors.Yellow) || (paintColor == Colors.Yellow && seedColor == Colors.Orange))
        {
            return ResultMix.Result = Colors.Or;
        }
        if (paintColor == Colors.Cyan && seedColor == Colors.Cyan)
        {
            return ResultMix.Result = Colors.Cyan;
        }
        if (paintColor == Colors.Indigo && seedColor == Colors.Indigo)
        {
            return ResultMix.Result = Colors.Indigo;
        }
        if (paintColor == Colors.Lime && seedColor == Colors.Lime)
        {
            return ResultMix.Result = Colors.Lime;
        }
        if (paintColor == Colors.Ocre && seedColor == Colors.Ocre)
        {
            return ResultMix.Result = Colors.Ocre;
        }
        if (paintColor == Colors.Magenta && seedColor == Colors.Magenta)
        {
            return ResultMix.Result = Colors.Magenta;
        }
        if (paintColor == Colors.Or && seedColor == Colors.Or)
        {
            return ResultMix.Result = Colors.Or;
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
        RefreshComponentsReference();

        return (int)EveryMix(PaintColor.Paint, SeedColor.Seed);
    }
}
