using System.Collections.Generic;
using UnityEngine;

public class ClientNeed : MonoBehaviour
{
    [SerializeField] private List<Sprite> _sprite;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private InteractClient _client;

    void Update()
    {
        _spriteRenderer.sprite = _sprite[_client.Command];
    }
}
