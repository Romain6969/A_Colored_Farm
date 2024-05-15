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
    [SerializeField] private KeepItem _keepItem;
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
                    switch (_keepItem.Id)
                    {
                        case 8:
                            Instantiate(_seedsList[0], transform.position, transform.rotation);
                            _keepItem.Id = 0;
                            _placeSeed.IsPlanting = false;
                            _keepItem.Here = false;
                            break;
                        case 9:
                            Instantiate(_seedsList[1], transform.position, transform.rotation);
                            _keepItem.Id = 0;
                            _placeSeed.IsPlanting = false;
                            _keepItem.Here = false;
                            break;
                        case 10:
                            Instantiate(_seedsList[2], transform.position, transform.rotation);
                            _keepItem.Id = 0;
                            _placeSeed.IsPlanting = false;
                            _keepItem.Here = false;
                            break;
                        case 11:
                            Instantiate(_seedsList[3], transform.position, transform.rotation);
                            _keepItem.Id = 0;
                            _placeSeed.IsPlanting = false;
                            _keepItem.Here = false;
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
