using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private bool _right;

    void Start()
    {
        _speed = Random.Range(6, 8);
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
