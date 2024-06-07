using UnityEngine;

public class CollideSwapSprite : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private SpriteRenderer _spriteRenderer2;
    [SerializeField] private Sprite _sprite1;
    [SerializeField] private Sprite _sprite2;
    [SerializeField] private Sprite _sprite3;
    [SerializeField] private Sprite _sprite4;
    [SerializeField] private Vector3 _position1;
    [SerializeField] private Vector3 _position2;
    [SerializeField] private Vector3 _position3;
    [SerializeField] private Vector3 _position4;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Client")
        {
            _spriteRenderer.sprite = _sprite2;
            transform.position = _position2;
            _spriteRenderer2.sprite = _sprite4;
            _spriteRenderer2.transform.position = _position4;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Client")
        {
            _spriteRenderer.sprite = _sprite1;
            transform.position = _position1;
            _spriteRenderer2.sprite = _sprite3;
            _spriteRenderer2.transform.position = _position3;
        }
    }
}
