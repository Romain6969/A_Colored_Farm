using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dirt : MonoBehaviour
{
    [field :SerializeField] public bool SeedPlaced { get; set; }
    [SerializeField] private GameObject _wichButtonToPress;
    [SerializeField] private TMP_Text _wichButtonToPressText;
    [SerializeField] private List<GameObject> _seedsList;
    [SerializeField] private PlaceSeed _placeSeed;
    [SerializeField] private WichSeed _wichSeed;
    [SerializeField] private InventorySeed _inventorySeed;

    private void Start()
    {
        SeedPlaced = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //_wichButtonToPress.SetActive(true);

            if (SeedPlaced == false)
            {
                if (_placeSeed.IsPlanting == true)
                {
                    if (_wichSeed._redSeed == true)
                    {
                        if (_inventorySeed.NumberRedSeed > 0)
                        {
                            Instantiate(_seedsList[3], transform.parent);
                            _inventorySeed.NumberRedSeed -= 1;
                        }
                    }
                    if (_wichSeed._blueSeed == true)
                    {
                        if (_inventorySeed.NumberBlueSeed > 0)
                        {
                            Instantiate(_seedsList[1], transform.parent);
                            _inventorySeed.NumberBlueSeed -= 1;
                        }
                    }
                    if (_wichSeed._yellowSeed == true)
                    {
                        if (_inventorySeed.NumberYellowSeed > 0)
                        {
                            Instantiate(_seedsList[2], transform.parent);
                            _inventorySeed.NumberYellowSeed -= 1;
                        }
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
                else
                {
                    _placeSeed.IsPlanting = false;
                }
            }
        }
    }
}
