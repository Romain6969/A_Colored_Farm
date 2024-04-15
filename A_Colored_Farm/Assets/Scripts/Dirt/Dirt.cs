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
        //_wichButtonToPress.SetActive(true);

        if (SeedPlaced == false)
        {
            if (_placeSeed.IsPlanting == true)
            {
                switch (_wichSeed.SeedNumber)
                {
                    case 0:
                        if (_inventorySeed.NumberGreySeed > 0)
                        {
                            Instantiate(_seedsList[0], transform.position, transform.rotation);
                            _inventorySeed.NumberGreySeed -= 1;
                            _placeSeed.IsPlanting = false;
                        }
                        break;
                    case 1:
                        if (_inventorySeed.NumberBlueSeed > 0)
                        {
                            Instantiate(_seedsList[1], transform.position, transform.rotation);
                            _inventorySeed.NumberBlueSeed -= 1;
                            _placeSeed.IsPlanting = false;
                        }
                        break;
                    case 2:
                        if (_inventorySeed.NumberYellowSeed > 0)
                        {
                            Instantiate(_seedsList[2], transform.position, transform.rotation);
                            _inventorySeed.NumberYellowSeed -= 1;
                            _placeSeed.IsPlanting = false;
                        }
                        break;
                    case 3:
                        if (_inventorySeed.NumberRedSeed > 0)
                        {
                            Instantiate(_seedsList[3], transform.position, transform.rotation);
                            _inventorySeed.NumberRedSeed -= 1;
                            _placeSeed.IsPlanting = false;
                        }
                        break;
                    case 4:
                        if (_inventorySeed.NumberPurpleSeed > 0)
                        {
                            Instantiate(_seedsList[4], transform.position, transform.rotation);
                            _inventorySeed.NumberPurpleSeed -= 1;
                            _placeSeed.IsPlanting = false;
                        }
                        break;
                    case 5:
                        if (_inventorySeed.NumberGreenSeed > 0)
                        {
                            Instantiate(_seedsList[5], transform.position, transform.rotation);
                            _inventorySeed.NumberGreenSeed -= 1;
                            _placeSeed.IsPlanting = false;
                        }
                        break;
                    case 6:
                        if (_inventorySeed.NumberOrangeSeed > 0)
                        {
                            Instantiate(_seedsList[6], transform.position, transform.rotation);
                            _inventorySeed.NumberOrangeSeed -= 1;
                            _placeSeed.IsPlanting = false;
                        }
                        break;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Seed")
        {
            SeedPlaced = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Seed")
        {
            SeedPlaced = false;
        }
    }
}
