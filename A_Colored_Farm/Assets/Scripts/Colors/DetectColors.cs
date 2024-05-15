using System.Collections.Generic;
using UnityEngine;

public class DetectColors : MonoBehaviour
{
    [field : SerializeField] public bool ColorPlaced { get; set; }
    [SerializeField] private WichColor _wichColor;
    [SerializeField] private PlaceColor _placeColor;
    [SerializeField] private InventoryColor _inventoryColor;
    [SerializeField] private ColorMain _colorMain;
    [SerializeField] private Dirt _dirt;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (_dirt.SeedPlaced == false)
        {
            if (ColorPlaced == false)
            {
                if (_placeColor.IsPainting == true)
                {
                    switch (_wichColor.ColorNumber)
                    {
                        case 0:
                            if (_inventoryColor.GetAmount("Grey") > 0)
                            {
                                Instantiate(_colorMain.ColorsList[0].PrefabColor, transform.position, transform.rotation);
                                _inventoryColor.RemoveSeed("Grey", 1);
                                _placeColor.IsPainting = false;
                            }
                            break;
                        case 1:
                            if (_inventoryColor.GetAmount("Blue") > 0)
                            {
                                Instantiate(_colorMain.ColorsList[1].PrefabColor, transform.position, transform.rotation);
                                _inventoryColor.RemoveSeed("Blue", 1);
                                _placeColor.IsPainting = false;
                            }
                            break;
                        case 2:
                            if (_inventoryColor.GetAmount("Yellow") > 0)
                            {
                                Instantiate(_colorMain.ColorsList[2].PrefabColor, transform.position, transform.rotation);
                                _inventoryColor.RemoveSeed("Yellow", 1);
                                _placeColor.IsPainting = false;
                            }
                            break;
                        case 3:
                            if (_inventoryColor.GetAmount("Red") > 0)
                            {
                                Instantiate(_colorMain.ColorsList[3].PrefabColor, transform.position, transform.rotation);
                                _inventoryColor.RemoveSeed("Red", 1);
                                _placeColor.IsPainting = false;
                            }
                            break;
                        case 4:
                            if (_inventoryColor.GetAmount("Purple") > 0)
                            {
                                Instantiate(_colorMain.ColorsList[4].PrefabColor, transform.position, transform.rotation);
                                _inventoryColor.RemoveSeed("Purple", 1);
                                _placeColor.IsPainting = false;
                            }
                            break;
                        case 5:
                            if (_inventoryColor.GetAmount("Green") > 0)
                            {
                                Instantiate(_colorMain.ColorsList[5].PrefabColor, transform.position, transform.rotation);
                                _inventoryColor.RemoveSeed("Green", 1);
                                _placeColor.IsPainting = false;
                            }
                            break;
                        case 6:
                            if (_inventoryColor.GetAmount("Orange") > 0)
                            {
                                Instantiate(_colorMain.ColorsList[6].PrefabColor, transform.position, transform.rotation);
                                _inventoryColor.RemoveSeed("Orange", 1);
                                _placeColor.IsPainting = false;
                            }
                            break;
                    }
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Paint")
        {
            ColorPlaced = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Paint")
        {
            ColorPlaced = false;
        }
    }
}
