using System.Collections.Generic;
using UnityEngine;

public class GenerateEffect : MonoBehaviour
{
    private float _time = 0;
    private int _chosing = 0;
    [SerializeField] private float _waitTime;
    [SerializeField] private float _number1;
    [SerializeField] private float _number2;
    [SerializeField] private int _choicemax;
    [SerializeField] private List<GameObject> _effects;
    [SerializeField] private Vector2 zone;

    void Update()
    {
        _time += Time.deltaTime;

        if (_time < 0.01f)
        {
            _waitTime =Random.Range(_number1, _number2);
        }

        if (_time >= _waitTime)
        {
            _chosing = Random.Range(0, _choicemax);
            OnSpawn();
            _time = 0;
        }
    }

    private void OnSpawn()
    {
        GameObject instantiated = Instantiate(_effects[_chosing]);

        instantiated.transform.position = new Vector2(
            Random.Range(transform.position.x - zone.x / 2.5f, transform.position.x + zone.x / 2.5f),
            Random.Range(transform.position.y - zone.y / 5, transform.position.y + zone.y / 5));
    }
}
