using UnityEngine;
using UnityEngine.InputSystem;

public class OpenCrusher : MonoBehaviour
{
    [field: SerializeField] public bool Open { get; set; }
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private KeepItem _keepItem;
    [SerializeField] private Crusher _crusher;
    [SerializeField] private ListAnimation _listAnimation;
    [SerializeField] private GameObject _progressBarGameObject;
    [SerializeField] private Tutorial _tutorial;
    private bool _isTrigger = false;

    public PlayerInput PlayerInput => _playerInput;

    public void OnCrusher(InputAction.CallbackContext context)
    {
        if (_isTrigger == true)
        {
            if (context.performed)
            {
                if (_keepItem.Id == 1 || _keepItem.Id == 2 || _keepItem.Id == 3 || _keepItem.Id == 4 || _keepItem.Id == 5 || _keepItem.Id == 6 || _keepItem.Id == 7 || _keepItem.Id == 8 || _keepItem.Id == 9 || _keepItem.Id == 10 || _keepItem.Id == 11 || _keepItem.Id == 12 || _keepItem.Id == 13)
                {
                    if (_crusher.Activate == false)
                    {
                        if (_crusher.Ready == false)
                        {
                            _tutorial.IndicatorsList[4].SetActive(false);
                            _crusher.OnActivated();
                            _keepItem.Id = 0;
                            _keepItem.Here = false;
                        }
                    }
                }

                if (_keepItem.Here == false)
                {
                    if (_crusher.Ready == true)
                    {
                        switch (_crusher.CopyId)
                        {
                            case 1:
                                _keepItem.Id = 22;
                                break;
                            case 2:
                                _keepItem.Id = 23;
                                break;
                            case 3:
                                _keepItem.Id = 24;
                                break;
                            case 4:
                                _keepItem.Id = 25;
                                break;
                            case 5:
                                _keepItem.Id = 26;
                                break;
                            case 6:
                                _keepItem.Id = 27;
                                break;
                            case 7:
                                _keepItem.Id = 28;
                                break;
                            case 8:
                                _keepItem.Id = 29;
                                break;
                            case 9:
                                _keepItem.Id = 30;
                                break;
                            case 10:
                                _keepItem.Id = 31;
                                break;
                            case 11:
                                _keepItem.Id = 32;
                                break;
                            case 12:
                                _keepItem.Id = 33;
                                break;
                            case 13:
                                _keepItem.Id = 34;
                                break;
                        }
                        _tutorial.IndicatorsList[4].SetActive(false);
                        _tutorial.WhenMix = true;
                        _tutorial.WhenMix2 = true;
                        if (_tutorial.ForClosingPanel == true)
                        {
                            _tutorial.WhenColor = true;
                        }
                        _progressBarGameObject.SetActive(false);
                        _crusher.Ready = false;
                        _listAnimation.Restart();
                    }
                }
            }
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Crusher")
        {
            _isTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Crusher")
        {
            _isTrigger = false;
        }
    }
}
