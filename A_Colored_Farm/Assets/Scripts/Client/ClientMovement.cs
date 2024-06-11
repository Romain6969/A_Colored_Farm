using UnityEngine;
using UnityEngine.UI;

public class ClientMovement : MonoBehaviour
{
    [SerializeField] private InteractClient _interactClient;
    [field : SerializeField] public bool Back {  get; set; }
    private float _speed = 6;
    private float _time = 0;
    private int _index = 0;
    private bool _nuage = false;
    [SerializeField] private float _wait = 0;
    private bool _position = false;
    [SerializeField] public bool Happy { get; set; } = false;
    [SerializeField] private GameObject _bulle;
    [SerializeField] private GameObject _bullePosition;
    [SerializeField] private GameObject _explosionBulle;
    [SerializeField] private GameObject _emotionHappy;
    [SerializeField] private GameObject _emotionHangry;
    [SerializeField] private AnimationWalk _animationWalk;
    [SerializeField] private Image _image;
    [field : SerializeField] public GameObject ProgressBarGameObject {  get; set; }
    [field : SerializeField] public float Time2 { get; set; }
    [field: SerializeField] public float TimeObjectif { get; set; } = 75;


    void Update()
    {
        _wait += Time.deltaTime;

        if (_wait < 120) return;

        if (_position == false)
        {
            transform.Translate(Vector2.down * _speed * Time.deltaTime);
            _animationWalk.OnAnimation(0);
            _index = 0;
        }
        else
        {
            _animationWalk.StopAnimation();
            ProgressBarGameObject.SetActive(true);
            Time2 += Time.deltaTime;
            _image.fillAmount = Time2 / TimeObjectif;
            _bulle.SetActive(true);

            if (Time2 >= TimeObjectif)
            {
                _interactClient.OnRestart();
            }
        }

        if (transform.position.y <= 4 && transform.position.y >= 2.5)
        {
            _position = true;
        }
        else
        {
            Time2 = 0;
            ProgressBarGameObject.SetActive(false);
            _bulle.SetActive(false);

            if (_nuage == true)
            {
                GameObject instantiated = Instantiate(_explosionBulle);
                instantiated.transform.position = _bullePosition.transform.position;
                _nuage = false;
            }
        }

        if (Back == true)
        {
            transform.Translate(Vector2.up * _speed * Time.deltaTime);
            _time += Time.deltaTime;
            _animationWalk.OnAnimation(1);

            if (Happy == true && _time <= 0.05f && _index == 0)
            {
                GameObject instantiated = Instantiate(_emotionHappy);
                instantiated.transform.position = transform.position;
                _nuage = true;
                _index += 1;
            }
            else if (_time <= 0.05f && _index == 0)
            {
                GameObject instantiated = Instantiate(_emotionHangry);
                instantiated.transform.position = transform.position;
                _nuage = true;
                _index += 1;
            }

            if (_time >= 15)
            {
                _animationWalk.StopAnimation();
                _interactClient.OnRandom();
                _time = 0;
                Back = false;
                _position = false;
                Happy = false;
            }
        }
    }
}
