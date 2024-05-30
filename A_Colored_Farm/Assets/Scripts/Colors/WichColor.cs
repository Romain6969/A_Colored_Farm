using UnityEngine;

public class WichColor : MonoBehaviour
{
    [field : SerializeField] public int ColorNumber { get; set; }
    [SerializeField] private GameObject _colorPanel;
    [field: SerializeField] public SetSeed SetSeed { get; set; }
    [SerializeField] private Movement _movement;

    public void OnClickNumberColor(int color)
    {
        ColorNumber = color;
        _colorPanel.SetActive(false);
        _movement.CanMove = true;
        SetSeed.SeedSet();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dirt")
        {
            SetSeed = collision.gameObject.GetComponent<SetSeed>();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        SetSeed = null;
    }
}
