using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Dirt : MonoBehaviour
{
    [SerializeField] private bool _seedPlaced = false;
    [SerializeField] private GameObject _wichButtonToPress;
    [SerializeField] private List<GameObject> _seedsList;
    [SerializeField] private PlaceSeed _placeSeed;
    [SerializeField] private WichSeed _wichSeed;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            _wichButtonToPress.SetActive(true);

            if (_seedPlaced == false)
            {
                if (_placeSeed.IsPlanting == true)
                {
                    if (_wichSeed._redSeed == true)
                    {
                        Instantiate(_seedsList[3], transform.parent);
                    }
                    if (_wichSeed._blueSeed == true)
                    {
                        Instantiate(_seedsList[1], transform.parent);
                    }
                    if (_wichSeed._yellowSeed == true)
                    {
                        Instantiate(_seedsList[2], transform.parent);
                    }
                    if (_wichSeed._greySeed == true)
                    {
                        Instantiate(_seedsList[0], transform.parent);
                    }
                    if (_wichSeed._purpleSeed == true)
                    {
                        Instantiate(_seedsList[4], transform.parent);
                    }
                    if (_wichSeed._orangeSeed == true)
                    {
                        Instantiate(_seedsList[6], transform.parent);
                    }
                    if (_wichSeed._greenSeed == true)
                    {
                        Instantiate(_seedsList[5], transform.parent);
                    }
                }
            }
        }
    }
}
