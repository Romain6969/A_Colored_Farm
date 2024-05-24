using System.Collections.Generic;
using UnityEngine;

public class ListAnimation : MonoBehaviour
{
    [SerializeField] private List<AnimationClip> _animationList;
    [SerializeField] private List<Sprite> _spriteList;
    [SerializeField] private Animator _animator;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _animator.enabled = false;
    }

    public void PlayAnimation(int wichAnimation)
    {
        _animator.enabled = true;
        string animationName = _animationList[wichAnimation].name;
        _animator.Play(animationName);
    }

    public void StopAnimation(int wichSprite)
    {
        _animator.enabled = false;
        _spriteRenderer.sprite = _spriteList[wichSprite];
    }

    public void Restart()
    {
        _spriteRenderer.sprite = _spriteList[0];
    }
}