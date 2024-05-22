using UnityEngine;

public class ClientMovement : MonoBehaviour
{
    [SerializeField] private InteractClient _interactClient;
    [field : SerializeField] public bool Back {  get; set; }
    private float _speed = 6;
    private float _time = 0;
    private bool _position = false;
    

    void Update()
    {
        if (_position == false)
        {
            transform.Translate(Vector2.down * _speed * Time.deltaTime);
        }

        if (transform.position.y <= 3.5 && transform.position.y >= 3)
        {
            _position = true;
        }

        if (Back == true)
        {
            transform.Translate(Vector2.up * _speed * Time.deltaTime);
            _time += Time.deltaTime;

            if (_time >= 10)
            {
                _interactClient.OnRandom();
                _time = 0;
                Back = false;
                _position = false;
            }
        }
    }
}
