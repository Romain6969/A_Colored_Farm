using System.Collections.Generic;
using UnityEngine;

public class AnimationWalk : MonoBehaviour
{
    [SerializeField] private List<AnimationClip> _animationList;
    [SerializeField] private Animator _animator;
    [SerializeField] private Sprite _sprite;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _animator.enabled = false;
    }

    public void OnAnimation(int wichAnimation)
    {
        string animationName = _animationList[wichAnimation].name;
        _animator.Play(animationName);
        _animator.enabled = true;
    }

    public void StopAnimation()
    {
        _animator.enabled = false;
        _spriteRenderer.sprite = _sprite;
    }
}
