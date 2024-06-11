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
    [SerializeField] private List<GameObject> _listVfx;

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
                if (_keepItem.Id != 21)
                {
                    if (PaintColor.Paint == Colors.None)
                    {
                        switch (_keepItem.Id)
                        {
                            case 14:
                                Instantiate(_seedsList[0], transform.position, transform.rotation);
                                Instantiate(_listVfx[0], transform.position, transform.rotation);
                                _playSounds.PlayAudio(3);
                                _keepItem.Id = 0;
                                _placeSeed.IsPlanting = false;
                                _keepItem.Here = false;
                                SeedColor.Seed = Colors.Grey;
                                break;
                            case 15:
                                Instantiate(_seedsList[1], transform.position, transform.rotation);
                                Instantiate(_listVfx[0], transform.position, transform.rotation);
                                _playSounds.PlayAudio(3);
                                _keepItem.Id = 0;
                                _placeSeed.IsPlanting = false;
                                _keepItem.Here = false;
                                SeedColor.Seed = Colors.Blue;
                                break;
                            case 16:
                                Instantiate(_seedsList[2], transform.position, transform.rotation);
                                Instantiate(_listVfx[0], transform.position, transform.rotation);
                                _playSounds.PlayAudio(3);
                                _keepItem.Id = 0;
                                _placeSeed.IsPlanting = false;
                                _keepItem.Here = false;
                                SeedColor.Seed = Colors.Yellow;
                                break;
                            case 17:
                                Instantiate(_seedsList[3], transform.position, transform.rotation);
                                Instantiate(_listVfx[0], transform.position, transform.rotation);
                                _playSounds.PlayAudio(3);
                                _keepItem.Id = 0;
                                _placeSeed.IsPlanting = false;
                                _keepItem.Here = false;
                                SeedColor.Seed = Colors.Red;
                                break;
                            case 18:
                                Instantiate(_seedsList[4], transform.position, transform.rotation);
                                Instantiate(_listVfx[0], transform.position, transform.rotation);
                                _playSounds.PlayAudio(3);
                                _keepItem.Id = 0;
                                _placeSeed.IsPlanting = false;
                                _keepItem.Here = false;
                                SeedColor.Seed = Colors.Purple;
                                break;
                            case 19:
                                Instantiate(_seedsList[5], transform.position, transform.rotation);
                                Instantiate(_listVfx[0], transform.position, transform.rotation);
                                _playSounds.PlayAudio(3);
                                _keepItem.Id = 0;
                                _placeSeed.IsPlanting = false;
                                _keepItem.Here = false;
                                SeedColor.Seed = Colors.Green;
                                break;
                            case 20:
                                Instantiate(_seedsList[6], transform.position, transform.rotation);
                                Instantiate(_listVfx[0], transform.position, transform.rotation);
                                _playSounds.PlayAudio(3);
                                _keepItem.Id = 0;
                                _placeSeed.IsPlanting = false;
                                _keepItem.Here = false;
                                SeedColor.Seed = Colors.Orange;
                                break;
                        }
                    }
                    else
                    {
                        switch (_keepItem.Id)
                        {
                            case 14:
                                SeedColor.Seed = Colors.Grey;
                                Instantiate(_seedsList[_seedColorMix.MixThem() - 1], transform.position, transform.rotation);
                                Instantiate(_listVfx[PaintColor.ColorId], transform.position, transform.rotation);
                                _playSounds.PlayAudio(3);
                                _keepItem.Id = 0;
                                _placeSeed.IsPlanting = false;
                                _keepItem.Here = false;
                                break;
                            case 15:
                                SeedColor.Seed = Colors.Blue;
                                Instantiate(_seedsList[_seedColorMix.MixThem() - 1], transform.position, transform.rotation);
                                Instantiate(_listVfx[PaintColor.ColorId], transform.position, transform.rotation);
                                _playSounds.PlayAudio(3);
                                _keepItem.Id = 0;
                                _placeSeed.IsPlanting = false;
                                _keepItem.Here = false;
                                break;
                            case 16:
                                SeedColor.Seed = Colors.Yellow;
                                Instantiate(_seedsList[_seedColorMix.MixThem() - 1], transform.position, transform.rotation);
                                Instantiate(_listVfx[PaintColor.ColorId], transform.position, transform.rotation);
                                _playSounds.PlayAudio(3);
                                _keepItem.Id = 0;
                                _placeSeed.IsPlanting = false;
                                _keepItem.Here = false;
                                break;
                            case 17:
                                SeedColor.Seed = Colors.Red;
                                Instantiate(_seedsList[_seedColorMix.MixThem() - 1], transform.position, transform.rotation);
                                Instantiate(_listVfx[PaintColor.ColorId], transform.position, transform.rotation);
                                _playSounds.PlayAudio(3);
                                _keepItem.Id = 0;
                                _placeSeed.IsPlanting = false;
                                _keepItem.Here = false;
                                break;
                            case 18:
                                SeedColor.Seed = Colors.Purple;
                                Instantiate(_seedsList[_seedColorMix.MixThem() - 1], transform.position, transform.rotation);
                                Instantiate(_listVfx[PaintColor.ColorId], transform.position, transform.rotation);
                                _playSounds.PlayAudio(3);
                                _keepItem.Id = 0;
                                _placeSeed.IsPlanting = false;
                                _keepItem.Here = false;
                                break;
                            case 19:
                                SeedColor.Seed = Colors.Green;
                                Instantiate(_seedsList[_seedColorMix.MixThem() - 1], transform.position, transform.rotation);
                                Instantiate(_listVfx[PaintColor.ColorId], transform.position, transform.rotation);
                                _playSounds.PlayAudio(3);
                                _keepItem.Id = 0;
                                _placeSeed.IsPlanting = false;
                                _keepItem.Here = false;
                                break;
                            case 20:
                                SeedColor.Seed = Colors.Orange;
                                Instantiate(_seedsList[_seedColorMix.MixThem() - 1], transform.position, transform.rotation);
                                Instantiate(_listVfx[PaintColor.ColorId], transform.position, transform.rotation);
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
                            _playSounds.PlayAudio(9);
                            _colorPanel.SetActive(true);
                            _movement.CanMove = false;
                            _pause.Open = 1;
                            _placeColor.IsPainting = false;
                            _placeColor.CanPaint = false;
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
