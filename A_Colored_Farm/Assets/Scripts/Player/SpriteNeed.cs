using UnityEngine;

public class SpriteNeed : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _sprite;
    [SerializeField] private SpriteMain _spriteList;
    private int _id = 0;

    void Update()
    {
        _sprite.sprite = _spriteList.SpriteList[_id];
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Shop")
        {
            _id = 1;
        }

        if (collision.tag == "ChestGray" || collision.tag == "ChestBlue" || collision.tag == "ChestYellow" || collision.tag == "ChestRed")
        {
            _id = 2;
        }

        if (collision.tag == "Dirt")
        {
            _id = 3;
        }

        if (collision.tag == "Crusher")
        {
            _id = 4;
        }

        if (collision.tag == "Fridge")
        {
            _id = 5;
        }

        if (collision.tag == "Brush")
        {
            _id = 6;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Shop")
        {
            _id = 0;
        }

        if (collision.tag == "ChestGray" || collision.tag == "ChestBlue" || collision.tag == "ChestYellow" || collision.tag == "ChestRed")
        {
            _id = 0;
        }

        if (collision.tag == "Dirt")
        {
            _id = 0;
        }

        if (collision.tag == "Crusher")
        {
            _id = 0;
        }

        if (collision.tag == "Fridge")
        {
            _id = 0;
        }

        if (collision.tag == "Brush")
        {
            _id = 0;
        }
    }
}
