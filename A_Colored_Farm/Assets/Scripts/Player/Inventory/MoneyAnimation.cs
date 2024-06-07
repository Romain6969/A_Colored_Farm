using UnityEngine;
using System.Collections.Generic;
using TMPro;
using System.Collections;

public class MoneyAnimation : MonoBehaviour
{
    [SerializeField] private List<AnimationClip> _animationList;
    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject _money;
    [SerializeField] private TMP_Text _moneyText;

    private void Start()
    {
        _animator.enabled = false;
    }

    public void OnAnimation(int wichAnimation)
    {
        string animationName = _animationList[wichAnimation].name;
        _animator.Play(animationName);
        _animator.enabled = true;
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        _animator.enabled = false;
        _money.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        _money.transform.localPosition = new Vector3(0f, -6f, 0f);
        _money.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        _moneyText.color = new Color(0.8705883f, 0.7137255f, 0.2784314f, 1);
    }
}
