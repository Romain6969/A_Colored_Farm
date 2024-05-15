using UnityEngine;

public class KeepItem : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _sprite;
    [SerializeField] private SpriteMain _spriteList;
    [field : SerializeField] public int Id { get; set; }
    [field : SerializeField] public bool Here { get; set; }
    private float time;

    private void Update()
    {
        time += Time.deltaTime;

        if (time > 2.5f)
        {
            UpdateSprite();
        }
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
        }
    }
}
