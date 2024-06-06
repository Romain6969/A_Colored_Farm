using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verif : MonoBehaviour
{
    [SerializeField] private KeepItem _keepItem;
    [SerializeField] private InteractClient _interactClient;
    [SerializeField] private NotInteractable _notInteractable;
    [SerializeField] private NotInteractable1 _notInteractable1;
    [SerializeField] private NotInteractable2 _notInteractable2;
    private bool _key1 = false;
    private bool _key2 = false;
    private bool _key3 = false;
    private bool _key4 = false;
    private bool _key5 = false;
    private bool _key6 = false;
    void Awake()
    {
        Time.timeScale = 1;
    }
    void Update()
    {
        switch (_keepItem.Id)
        {
            case 2:
                _key1 = true;
                break;
            case 3:
                _key2 = true;
                break;
            case 4:
                _key3 = true;
                break;
            case 5:
                _key4 = true;
                break;
            case 6:
                _key5 = true;
                break;
            case 7:
                _key6 = true;
                break;
        }

        if (_key1 == true && _key2 == true && _key3 == true)
        {
            _interactClient.RandomLimit = 14;
        }

        if (_key4 == true && _key5 == true && _key6 == true)
        {
            _interactClient.RandomLimit = 26;
        }

        if (_key4 == true)
        {
            _notInteractable.Interactable = true;
        }

        if (_key5 == true)
        {
            _notInteractable1.Interactable = true;
        }

        if (_key6 == true)
        {
            _notInteractable2.Interactable = true;
        }
    }
}
