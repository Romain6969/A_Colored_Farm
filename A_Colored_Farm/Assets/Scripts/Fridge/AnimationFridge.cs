using System.Collections;
using UnityEngine;

public class AnimationFridge : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    void Start()
    {
        _animator.enabled = false;
    }

    public void OnAnimation()
    {
        _animator.enabled = true;
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.28f);
        _animator.enabled = false;
    }
}
