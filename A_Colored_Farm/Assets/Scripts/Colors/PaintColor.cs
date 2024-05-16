using UnityEngine;

public class PaintColor : MonoBehaviour
{
    [field: SerializeField] public Colors Paint { get; set; }

    private void Start()
    {
        Paint = Colors.None;
    }
}
