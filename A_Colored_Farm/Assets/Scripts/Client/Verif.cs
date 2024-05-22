using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verif : MonoBehaviour
{
    [SerializeField] private KeepItem _keepItem;
    [SerializeField] private InteractClient _interactClient;
    private bool _key1 = false;
    private bool _key2 = false;
    private bool _key3 = false;

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
        }

        if (_key1 == true && _key2 == true && _key3 == true)
        {
            _interactClient.RandomLimit = 14;
        }
    }
}
