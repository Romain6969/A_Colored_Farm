using System.Collections.Generic;
using UnityEngine;

public class ListAnimation : MonoBehaviour
{
    [SerializeField] private List<AnimationClip> _animationList;
    [SerializeField] private List<Sprite> _spriteList;
    [SerializeField] private Animator _animator;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private GameObject _vfx;

    void Start()
    {
        _animator.enabled = false;
    }

    public void PlayAnimation(int wichAnimation)
    {
        _animator.enabled = true;
        string animationName = _animationList[wichAnimation].name;
        _animator.Play(animationName);
        _vfx.SetActive(false);
    }

    public void StopAnimation(int wichSprite)
    {
        _animator.enabled = false;
        _spriteRenderer.sprite = _spriteList[wichSprite];
        _vfx.SetActive(true);
    }

    public void Restart()
    {
        _spriteRenderer.sprite = _spriteList[0];
    }
}