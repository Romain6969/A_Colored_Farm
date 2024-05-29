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
        yield return new WaitForSeconds(0.267f);
        _animator.enabled = false;
        transform.localScale = new Vector3(1, 1, 1);
    }
}
