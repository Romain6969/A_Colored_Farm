using UnityEngine;

public class SetSeed : MonoBehaviour
{
    [SerializeField] private WichColor _wichColor;
    [SerializeField] private InventoryColor _inventoryColor;
    [SerializeField] Dirt _dirt;
    [SerializeField] SpriteRenderer _spriteRenderer;
    [SerializeField] PlaceColor _placeColor;
    [SerializeField] PaintColor _paintColor;
    [SerializeField] PlaySounds _playSounds;

    public void SeedSet()
    {
        switch (_wichColor.ColorNumber)
        {
            case 0:
                if (_inventoryColor.GetAmount("Grey") > 0)
                {
                    _playSounds.PlayAudio(0);
                    _spriteRenderer.sprite = _dirt.DirtColorSprite[1];
                    _inventoryColor.RemoveSeed("Grey", 1);
                    _placeColor.IsPainting = false;
                    _paintColor.Paint = Colors.Grey;
                }
                break;
            case 1:
                if (_inventoryColor.GetAmount("Blue") > 0)
                {
                    _playSounds.PlayAudio(0);
                    _spriteRenderer.sprite = _dirt.DirtColorSprite[2];
                    _inventoryColor.RemoveSeed("Blue", 1);
                    _placeColor.IsPainting = false;
                    _paintColor.Paint = Colors.Blue;
                }
                break;
            case 2:
                if (_inventoryColor.GetAmount("Yellow") > 0)
                {
                    _playSounds.PlayAudio(0);
                    _spriteRenderer.sprite = _dirt.DirtColorSprite[3];
                    _inventoryColor.RemoveSeed("Yellow", 1);
                    _placeColor.IsPainting = false;
                    _paintColor.Paint = Colors.Yellow;
                }
                break;
            case 3:
                if (_inventoryColor.GetAmount("Red") > 0)
                {
                    _playSounds.PlayAudio(0);
                    _spriteRenderer.sprite = _dirt.DirtColorSprite[4];
                    _inventoryColor.RemoveSeed("Red", 1);
                    _placeColor.IsPainting = false;
                    _paintColor.Paint = Colors.Red;
                }
                break;
            case 4:
                if (_inventoryColor.GetAmount("Purple") > 0)
                {
                    _playSounds.PlayAudio(0);
                    _spriteRenderer.sprite = _dirt.DirtColorSprite[5];
                    _inventoryColor.RemoveSeed("Purple", 1);
                    _placeColor.IsPainting = false;
                    _paintColor.Paint = Colors.Purple;
                }
                break;
            case 5:
                if (_inventoryColor.GetAmount("Green") > 0)
                {
                    _playSounds.PlayAudio(0);
                    _spriteRenderer.sprite = _dirt.DirtColorSprite[6];
                    _inventoryColor.RemoveSeed("Green", 1);
                    _placeColor.IsPainting = false;
                    _paintColor.Paint = Colors.Green;
                }
                break;
            case 6:
                if (_inventoryColor.GetAmount("Orange") > 0)
                {
                    _playSounds.PlayAudio(0);
                    _spriteRenderer.sprite = _dirt.DirtColorSprite[7];
                    _inventoryColor.RemoveSeed("Orange", 1);
                    _placeColor.IsPainting = false;
                    _paintColor.Paint = Colors.Orange;
                }
                break;
        }
    }

}
