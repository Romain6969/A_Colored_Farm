using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private bool _right;

    [SerializeField] private float _speedMin;
    [SerializeField] private float _speedMax;

    void Start()
    {
        _speed = Random.Range(_speedMin, _speedMax);
    }

    void Update()
    {
        if (_right)
        {
            transform.Translate(Vector2.right * _speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * _speed * Time.deltaTime);
        }
    }
}
