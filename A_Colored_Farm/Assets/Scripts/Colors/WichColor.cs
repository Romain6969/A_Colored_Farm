using UnityEngine;

public class WichColor : MonoBehaviour
{
    [field : SerializeField] public int ColorNumber { get; set; }
    [SerializeField] private GameObject _colorPanel;
    [field: SerializeField] public Dirt _dirt { get; set; }

    public void OnClickNumberColor(int color)
    {
        ColorNumber = color;
        _colorPanel.SetActive(false);
        _dirt.OnDate();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dirt")
        {
            _dirt = collision.gameObject.GetComponent<Dirt>();
        }
    }
}
