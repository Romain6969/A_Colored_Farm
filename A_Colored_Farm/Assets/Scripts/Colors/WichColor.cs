using System.Collections.Generic;
using UnityEngine;

public class WichColor : MonoBehaviour
{
    [field : SerializeField] public int ColorNumber { get; set; }
    [SerializeField] private GameObject _colorPanel;
    [field: SerializeField] public SetSeed SetSeed { get; set; }
    [SerializeField] private Movement _movement;
    [SerializeField] private OpenPause _pause;
    [SerializeField] private Tutorial _tutorial;
    [SerializeField] private PlaySounds _playSounds;
    [SerializeField] private List<GameObject> _effectPaint;
    [SerializeField] private PlaceColor _placeColor;

    public void OnClickNumberColor(int color)
    {
        _playSounds.PlayAudio(9);
        GameObject instantiated = Instantiate(_effectPaint[color]);
        instantiated.transform.position = SetSeed.transform.position + new Vector3(0, 1, 0);
        ColorNumber = color;
        _colorPanel.SetActive(false);
        _movement.CanMove = true;
        _pause.Open = 2;
        SetSeed.SeedSet();
        _placeColor.CanPaint = true;

        if (_tutorial.EndTuto == false && _tutorial.WhenColor == false && _tutorial.ForClosingPanel == true)
        {
            _tutorial.EndTuto = true;
        }
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
