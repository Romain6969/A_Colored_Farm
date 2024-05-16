using UnityEngine;

public class WichColor : MonoBehaviour
{
    [field : SerializeField] public int ColorNumber { get; set; }
    [SerializeField] private GameObject _colorPanel;
    [SerializeField] private Dirt _dirt;

    public void OnClickNumberColor(int color)
    {
        ColorNumber = color;
        _colorPanel.SetActive(false);
        _dirt.OnDate();
    }
}
