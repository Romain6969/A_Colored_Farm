using UnityEngine;

public class KeepItem : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _sprite;
    [SerializeField] private SpriteMain _spriteList;
    [field : SerializeField] public int Id { get; set; }
    [field : SerializeField] public bool Here { get; set; }

    private void Update()
    {
        UpdateSprite();

        if (Id != 0) Here = true;
        if (Id == 0) Here = false;
    }

    public void UpdateSprite()
    {
        switch (Id)
        {
            case 0:
                _sprite.sprite = _spriteList.SpriteList[0];
                break;
            case 1:
                _sprite.sprite = _spriteList.SpriteList[1];
                break;
            case 2:
                _sprite.sprite = _spriteList.SpriteList[2];
                break;
            case 3:
                _sprite.sprite = _spriteList.SpriteList[3];
                break;
            case 4:
                _sprite.sprite = _spriteList.SpriteList[4];
                break;
            case 5:
                _sprite.sprite = _spriteList.SpriteList[5];
                break;
            case 6:
                _sprite.sprite = _spriteList.SpriteList[6];
                break;
            case 7:
                _sprite.sprite = _spriteList.SpriteList[7];
                break;
            case 8:
                _sprite.sprite = _spriteList.SpriteList[8];
                break;
            case 9:
                _sprite.sprite = _spriteList.SpriteList[9];
                break;
            case 10:
                _sprite.sprite = _spriteList.SpriteList[10];
                break;
            case 11:
                _sprite.sprite = _spriteList.SpriteList[11];
                break;
            case 12:
                _sprite.sprite = _spriteList.SpriteList[12];
                break;
            case 13:
                _sprite.sprite = _spriteList.SpriteList[13];
                break;
            case 14:
                _sprite.sprite = _spriteList.SpriteList[14];
                break;
            case 15:
                _sprite.sprite = _spriteList.SpriteList[15];
                break;
            case 16:
                _sprite.sprite = _spriteList.SpriteList[16];
                break;
            case 17:
                _sprite.sprite = _spriteList.SpriteList[17];
                break;
            case 18:
                _sprite.sprite = _spriteList.SpriteList[18];
                break;
            case 19:
                _sprite.sprite = _spriteList.SpriteList[19];
                break;
            case 20:
                _sprite.sprite = _spriteList.SpriteList[20];
                break;
            case 21:
                _sprite.sprite = _spriteList.SpriteList[21];
                break;
            case 22:
                _sprite.sprite = _spriteList.SpriteList[22];
                break;
            case 23:
                _sprite.sprite = _spriteList.SpriteList[23];
                break;
            case 24:
                _sprite.sprite = _spriteList.SpriteList[24];
                break;
            case 25:
                _sprite.sprite = _spriteList.SpriteList[25];
                break;
            case 26:
                _sprite.sprite = _spriteList.SpriteList[26];
                break;
            case 27:
                _sprite.sprite = _spriteList.SpriteList[27];
                break;
            case 28:
                _sprite.sprite = _spriteList.SpriteList[28];
                break;

        }
    }
}
