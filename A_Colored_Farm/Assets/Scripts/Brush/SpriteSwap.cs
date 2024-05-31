using UnityEngine;

public class SpriteSwap : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Sprite _sprite1;
    [SerializeField] private Sprite _sprite2;
    [SerializeField] public bool Use { get; set; } = false;

    void Update()
    {
        if (Use)
        {
            _spriteRenderer.sprite = _sprite2;
        }
        else
        {
            _spriteRenderer.sprite = _sprite1;
        }
    }
}
