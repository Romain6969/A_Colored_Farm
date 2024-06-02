using UnityEngine;

public class CollideSwapSprite : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Sprite _sprite1;
    [SerializeField] private Sprite _sprite2;
    [SerializeField] private Vector3 _position1;
    [SerializeField] private Vector3 _position2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Client")
        {
            _spriteRenderer.sprite = _sprite2;
            transform.position = _position2;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Client")
        {
            _spriteRenderer.sprite = _sprite1;
            transform.position = _position1;
        }
    }
}
