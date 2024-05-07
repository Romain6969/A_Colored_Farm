using System.Collections.Generic;
using UnityEngine;

public class DetectColors : MonoBehaviour
{
    [SerializeField] private WichColor _wichColor;
    [SerializeField] private PlaceColor _placeColor;
    [SerializeField] private InventoryColor _inventoryColor;
    [SerializeField] private List<GameObject> _colorList;

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (_wichColor.IsNowPaint == true)
        {
            if (_placeColor.IsPainting == true)
            {
                switch (_wichColor.ColorNumber)
                {
                    case 0:
                        if(_inventoryColor.GetAmount("GreyColor") > 0)
                        {
                            Instantiate(_colorList[0], transform.position, transform.rotation);
                            _inventoryColor.RemoveSeed("GreyColor", 1);
                            _placeColor.IsPainting = false;
                        }
                        break;
                    case 1:
                        if (_inventoryColor.GetAmount("BlueColor") > 0)
                        {
                            Instantiate(_colorList[1], transform.position, transform.rotation);
                            _inventoryColor.RemoveSeed("BlueColor", 1);
                            _placeColor.IsPainting = false;
                        }
                        break;
                    case 2:
                        if (_inventoryColor.GetAmount("YellowColor") > 0)
                        {
                            Instantiate(_colorList[2], transform.position, transform.rotation);
                            _inventoryColor.RemoveSeed("YellowColor", 1);
                            _placeColor.IsPainting = false;
                        }
                        break;
                    case 3:
                        if (_inventoryColor.GetAmount("RedColor") > 0)
                        {
                            Instantiate(_colorList[3], transform.position, transform.rotation);
                            _inventoryColor.RemoveSeed("RedColor", 1);
                            _placeColor.IsPainting = false;
                        }
                        break;
                    case 4:
                        if (_inventoryColor.GetAmount("PurpleColor") > 0)
                        {
                            Instantiate(_colorList[4], transform.position, transform.rotation);
                            _inventoryColor.RemoveSeed("PurpleColor", 1);
                            _placeColor.IsPainting = false;
                        }
                        break;
                    case 5:
                        if (_inventoryColor.GetAmount("GreenColor") > 0)
                        {
                            Instantiate(_colorList[5], transform.position, transform.rotation);
                            _inventoryColor.RemoveSeed("GreenColor", 1);
                            _placeColor.IsPainting = false;
                        }
                        break;
                    case 6:
                        if (_inventoryColor.GetAmount("OrangeColor") > 0)
                        {
                            Instantiate(_colorList[6], transform.position, transform.rotation);
                            _inventoryColor.RemoveSeed("OrangeColor", 1);
                            _placeColor.IsPainting = false;
                        }
                        break;
                }
            }
        }
    }
}
