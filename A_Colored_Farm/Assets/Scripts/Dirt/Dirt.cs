using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dirt : MonoBehaviour
{
    [field :SerializeField] public bool SeedPlaced { get; set; }
    [field: SerializeField] public bool ColorPlaced { get; set; }
    [SerializeField] private List<GameObject> _seedsList;
    [SerializeField] private PlaceSeed _placeSeed;
    [SerializeField] private KeepItem _keepItem;
    [SerializeField] private SeedMain _seedMain;
    [field: SerializeField] public SeedColor SeedColor { get; set; }
    [SerializeField] private PlaceColor _placeColor;
    [SerializeField] private InventoryColor _inventoryColor;
    [field: SerializeField] public PaintColor PaintColor { get; set; }
    [SerializeField] private GameObject _colorPanel;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [field: SerializeField] public List<Sprite> DirtColorSprite { get; set; }
    [SerializeField] private SeedColorMix _seedColorMix;
    [SerializeField] private PlaySounds _playSounds;
    [SerializeField] private Movement _movement;
    [SerializeField] private OpenPause _pause;

    private void FixedUpdate()
    {
        if (PaintColor.PaintUses <= 0)
        {
            PaintColor.Paint = Colors.None;
            _spriteRenderer.sprite = DirtColorSprite[0];
            PaintColor.PaintUses = 2;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //_wichButtonToPress.SetActive(true);

        if (SeedPlaced == false)
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
                                _playSounds.PlayAudio(3);
                                _keepItem.Id = 0;
                                _placeSeed.IsPlanting = false;
                                _keepItem.Here = false;
                                SeedColor.Seed = Colors.Grey;
                                break;
                            case 9:
                                Instantiate(_seedsList[1], transform.position, transform.rotation);
                                _playSounds.PlayAudio(3);
                                _keepItem.Id = 0;
                                _placeSeed.IsPlanting = false;
                                _keepItem.Here = false;
                                SeedColor.Seed = Colors.Blue;
                                break;
                            case 10:
                                Instantiate(_seedsList[2], transform.position, transform.rotation);
                                _playSounds.PlayAudio(3);
                                _keepItem.Id = 0;
                                _placeSeed.IsPlanting = false;
                                _keepItem.Here = false;
                                SeedColor.Seed = Colors.Yellow;
                                break;
                            case 11:
                                Instantiate(_seedsList[3], transform.position, transform.rotation);
                                _playSounds.PlayAudio(3);
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
                                _playSounds.PlayAudio(3);
                                _keepItem.Id = 0;
                                _placeSeed.IsPlanting = false;
                                _keepItem.Here = false;
                                break;
                            case 9:
                                SeedColor.Seed = Colors.Blue;
                                Instantiate(_seedsList[_seedColorMix.MixThem() - 1], transform.position, transform.rotation);
                                _playSounds.PlayAudio(3);
                                _keepItem.Id = 0;
                                _placeSeed.IsPlanting = false;
                                _keepItem.Here = false;
                                break;
                            case 10:
                                SeedColor.Seed = Colors.Yellow;
                                Instantiate(_seedsList[_seedColorMix.MixThem() - 1], transform.position, transform.rotation);
                                _playSounds.PlayAudio(3);
                                _keepItem.Id = 0;
                                _placeSeed.IsPlanting = false;
                                _keepItem.Here = false;
                                break;
                            case 11:
                                SeedColor.Seed = Colors.Red;
                                Instantiate(_seedsList[_seedColorMix.MixThem() - 1], transform.position, transform.rotation);
                                _playSounds.PlayAudio(3);
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
                        if (_placeColor.IsPainting == true)
                        {
                            _colorPanel.SetActive(true);
                            _movement.CanMove = false;
                            _pause.Open = 1;

                        }
                    }
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Seed")
        {
            SeedPlaced = true;
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
