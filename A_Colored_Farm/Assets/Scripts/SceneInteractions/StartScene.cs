using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private GameObject _sign;
    [SerializeField] private Movement _movement;

    void Start()
    {
        _panel.SetActive(true);
        _sign.SetActive(false);
        StartCoroutine(Wait());
        _movement.CanMove = false;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2f);
        _panel.SetActive(false);
        _sign.SetActive(true);
        _movement.CanMove = true;
    }
}
