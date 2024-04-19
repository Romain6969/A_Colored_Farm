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
    [SerializeField] private SeedMain _seedMain;
    private float _currentTime;

    private void Start()
    {
        SeedPlaced = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //_wichButtonToPress.SetActive(true);

        if (SeedPlaced == false)
        {
            _currentTime += Time.deltaTime;

            if (_currentTime > 0.2f)
            {
                if (_placeSeed.IsPlanting == true)
                {
                    switch (_wichSeed.SeedNumber)
                    {
                        case 0:
                            if (_inventorySeed.GetAmount(_seedMain.GreySeed) > 0)
                            {
                                Instantiate(_seedsList[0], transform.position, transform.rotation);
                                _inventorySeed.RemoveSeed(_seedMain.GreySeed, 1);
                                _placeSeed.IsPlanting = false;
                            }
                            break;
                        case 1:
                            if (_inventorySeed.GetAmount(_seedMain.BlueSeed) > 0)
                            {
                                Instantiate(_seedsList[1], transform.position, transform.rotation);
                                _inventorySeed.RemoveSeed(_seedMain.BlueSeed, 1);
                                _placeSeed.IsPlanting = false;
                            }
                            break;
                        case 2:
                            if (_inventorySeed.GetAmount(_seedMain.YellowSeed) > 0)
                            {
                                Instantiate(_seedsList[2], transform.position, transform.rotation);
                                _inventorySeed.RemoveSeed(_seedMain.YellowSeed, 1);
                                _placeSeed.IsPlanting = false;
                            }
                            break;
                        case 3:
                            if (_inventorySeed.GetAmount(_seedMain.RedSeed) > 0)
                            {
                                Instantiate(_seedsList[3], transform.position, transform.rotation);
                                _inventorySeed.RemoveSeed(_seedMain.RedSeed, 1);
                                _placeSeed.IsPlanting = false;
                            }
                            break;
                        case 4:
                            if (_inventorySeed.GetAmount(_seedMain.PurpleSeed) > 0)
                            {
                                Instantiate(_seedsList[4], transform.position, transform.rotation);
                                _inventorySeed.RemoveSeed(_seedMain.PurpleSeed, 1);
                                _placeSeed.IsPlanting = false;
                            }
                            break;
                        case 5:
                            if (_inventorySeed.GetAmount(_seedMain.GreenSeed) > 0)
                            {
                                Instantiate(_seedsList[5], transform.position, transform.rotation);
                                _inventorySeed.RemoveSeed(_seedMain.GreenSeed, 1);
                                _placeSeed.IsPlanting = false;
                            }
                            break;
                        case 6:
                            if (_inventorySeed.GetAmount(_seedMain.OrangeSeed) > 0)
                            {
                                Instantiate(_seedsList[6], transform.position, transform.rotation);
                                _inventorySeed.RemoveSeed(_seedMain.OrangeSeed, 1);
                                _placeSeed.IsPlanting = false;
                            }
                            break;
                    }
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Seed")
        {
            SeedPlaced = true;
            _currentTime = 0;
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
