using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dirt : MonoBehaviour
{
    [field :SerializeField] public bool SeedPlaced { get; set; }
    [field: SerializeField] public bool ColorPlaced { get; set; }
    [SerializeField] private GameObject _wichButtonToPress;
    [SerializeField] private TMP_Text _wichButtonToPressText;
    [SerializeField] private List<GameObject> _seedsList;
    [SerializeField] private PlaceSeed _placeSeed;
    [SerializeField] private KeepItem _keepItem;
    [SerializeField] private SeedMain _seedMain;
    private float _currentTime;
    [field: SerializeField] public SeedColor SeedColor { get; set; }
    [SerializeField] private WichColor _wichColor;
    [SerializeField] private PlaceColor _placeColor;
    [SerializeField] private InventoryColor _inventoryColor;
    [field: SerializeField] public PaintColor PaintColor { get; set; }
    [SerializeField] private GameObject _colorPanel;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private List<Sprite> _dirtColorSprite;
    [SerializeField] private SeedColorMix _seedColorMix;

    private void FixedUpdate()
    {
        if (PaintColor.PaintUses <= 0)
        {
            PaintColor.Paint = Colors.None;
            _spriteRenderer.sprite = _dirtColorSprite[0];
            PaintColor.PaintUses = 2;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //_wichButtonToPress.SetActive(true);

        if (SeedPlaced == false)
        {
            _currentTime += Time.deltaTime;

            if (_currentTime > 0.2f)
            {
                if (_placeSeed.IsPlanting == true)
                {
                    if (_keepItem.Id != 12)
                    {
                        if (PaintColor.Paint == Colors.None)
                        {
                            switch (_keepItem.Id)
                            {
                                case 8:
                                    Instantiate(_seedsList[0], transform.position, transform.rotation);
                                    _keepItem.Id = 0;
                                    _placeSeed.IsPlanting = false;
                                    _keepItem.Here = false;
                                    SeedColor.Seed = Colors.Grey;
                                    break;
                                case 9:
                                    Instantiate(_seedsList[1], transform.position, transform.rotation);
                                    _keepItem.Id = 0;
                                    _placeSeed.IsPlanting = false;
                                    _keepItem.Here = false;
                                    SeedColor.Seed = Colors.Blue;
                                    break;
                                case 10:
                                    Instantiate(_seedsList[2], transform.position, transform.rotation);
                                    _keepItem.Id = 0;
                                    _placeSeed.IsPlanting = false;
                                    _keepItem.Here = false;
                                    SeedColor.Seed = Colors.Yellow;
                                    break;
                                case 11:
                                    Instantiate(_seedsList[3], transform.position, transform.rotation);
                                    _keepItem.Id = 0;
                                    _placeSeed.IsPlanting = false;
                                    _keepItem.Here = false;
                                    SeedColor.Seed = Colors.Red;
                                    break;
                            }
                        }
                        else
                        {
                            switch (_keepItem.Id) 
                            {
                                case 8:
                                    SeedColor.Seed = Colors.Grey;
                                    Instantiate(_seedsList[_seedColorMix.MixThem() - 1], transform.position, transform.rotation);
                                    _keepItem.Id = 0;
                                    _placeSeed.IsPlanting = false;
                                    _keepItem.Here = false;
                                    break;
                                case 9:
                                    SeedColor.Seed = Colors.Blue;
                                    Instantiate(_seedsList[_seedColorMix.MixThem() - 1], transform.position, transform.rotation);
                                    _keepItem.Id = 0;
                                    _placeSeed.IsPlanting = false;
                                    _keepItem.Here = false;
                                    break;
                                case 10:
                                    SeedColor.Seed = Colors.Yellow;
                                    Instantiate(_seedsList[_seedColorMix.MixThem() - 1], transform.position, transform.rotation);
                                    _keepItem.Id = 0;
                                    _placeSeed.IsPlanting = false;
                                    _keepItem.Here = false;
                                    break;
                                case 11:
                                    SeedColor.Seed = Colors.Red;
                                    Instantiate(_seedsList[_seedColorMix.MixThem() - 1], transform.position, transform.rotation);
                                    _keepItem.Id = 0;
                                    _placeSeed.IsPlanting = false;
                                    _keepItem.Here = false;
                                    break;
                            }
                        }
                    }
                    else
                    {
                        if (ColorPlaced == false)
                        {
                            if(_placeColor.IsPainting == true)
                            {
                                _colorPanel.SetActive(true);
                            }
                            
                        }
                    }  
                }
            }
        }
    }

    public void OnDate()
    {
        switch (_wichColor.ColorNumber)
        {
            case 0:
                if (_inventoryColor.GetAmount("Grey") > 0)
                {
                    _spriteRenderer.sprite = _dirtColorSprite[1];
                    _inventoryColor.RemoveSeed("Grey", 1);
                    _placeColor.IsPainting = false;
                    PaintColor.Paint = Colors.Grey;
                }
                break;
            case 1:
                if (_inventoryColor.GetAmount("Blue") > 0)
                {
                    _spriteRenderer.sprite = _dirtColorSprite[2];
                    _inventoryColor.RemoveSeed("Blue", 1);
                    _placeColor.IsPainting = false;
                    PaintColor.Paint = Colors.Blue;
                }
                break;
            case 2:
                if (_inventoryColor.GetAmount("Yellow") > 0)
                {
                    _spriteRenderer.sprite = _dirtColorSprite[3];
                    _inventoryColor.RemoveSeed("Yellow", 1);
                    _placeColor.IsPainting = false;
                    PaintColor.Paint = Colors.Yellow;
                }
                break;
            case 3:
                if (_inventoryColor.GetAmount("Red") > 0)
                {
                    _spriteRenderer.sprite = _dirtColorSprite[4];
                    _inventoryColor.RemoveSeed("Red", 1);
                    _placeColor.IsPainting = false;
                    PaintColor.Paint = Colors.Red;
                }
                break;
            case 4:
                if (_inventoryColor.GetAmount("Purple") > 0)
                {
                    _spriteRenderer.sprite = _dirtColorSprite[5];
                    _inventoryColor.RemoveSeed("Purple", 1);
                    _placeColor.IsPainting = false;
                    PaintColor.Paint = Colors.Purple;
                }
                break;
            case 5:
                if (_inventoryColor.GetAmount("Green") > 0)
                {
                    _spriteRenderer.sprite = _dirtColorSprite[6];
                    _inventoryColor.RemoveSeed("Green", 1);
                    _placeColor.IsPainting = false;
                    PaintColor.Paint = Colors.Green;
                }
                break;
            case 6:
                if (_inventoryColor.GetAmount("Orange") > 0)
                {
                    _spriteRenderer.sprite = _dirtColorSprite[7];
                    _inventoryColor.RemoveSeed("Orange", 1);
                    _placeColor.IsPainting = false;
                    PaintColor.Paint = Colors.Orange;
                }
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Seed")
        {
            SeedPlaced = true;
            _currentTime = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Seed")
        {
            SeedPlaced = false;
        }
    }
}
