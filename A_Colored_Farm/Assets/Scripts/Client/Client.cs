using UnityEngine;

public class Client : MonoBehaviour
{
    [field : SerializeField] public bool Received { get; set; }
    [SerializeField] private InventoryMain _inventoryMain;
    [SerializeField] private KeepItem _keepItem;
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private ColorMain _colorMain;
    [SerializeField] public int RandomLimit { get; set; } = 8;
    [SerializeField] public int Command { get; set; }

    void Start()
    {
        OnRandom();
    }

    public void OnRandom()
    {
        Command = Random.Range(0,RandomLimit);
        Debug.Log($"La commande numéro {Command}");
    }

    void Update()
    {
        if (Received == false)
        {
            switch (Command)
            {
                case 0:
                    if (_keepItem.Id == 1)
                    {
                        _inventoryMain.Money += (_seedMain.GreySeed.SellValue * 3);
                        OnRestart();
                    }
                    break;
                case 1:
                    if (_keepItem.Id == 2)
                    {
                        _inventoryMain.Money += (_seedMain.BlueSeed.SellValue * 3);
                        OnRestart();
                    }
                    break;
                case 2:
                    if (_keepItem.Id == 3)
                    {
                        _inventoryMain.Money += (_seedMain.YellowSeed.SellValue * 3);
                        OnRestart();
                    }
                    break;
                case 3:
                    if (_keepItem.Id == 4)
                    {
                        _inventoryMain.Money += (_seedMain.RedSeed.SellValue * 3);
                        OnRestart();
                    }
                    break;
                case 4:
                    if (_keepItem.Id == 5)
                    {
                        _inventoryMain.Money += (_colorMain.ColorsList[0].SellValue * 3);
                        OnRestart();
                    }
                    break;
                case 5:
                    if (_keepItem.Id == 6)
                    {
                        _inventoryMain.Money += (_colorMain.ColorsList[1].SellValue * 3);
                        OnRestart();
                    }
                    break;
                case 6:
                    if (_keepItem.Id == 7)
                    {
                        _inventoryMain.Money += (_colorMain.ColorsList[2].SellValue * 3);
                        OnRestart();
                    }
                    break;
                case 7:
                    if (_keepItem.Id == 13)
                    {
                        _inventoryMain.Money += (_colorMain.ColorsList[3].SellValue * 3);
                        OnRestart();
                    }
                    break;
                case 8:
                    if (_keepItem.Id == 14)
                    {
                        _inventoryMain.Money += (_seedMain.PurpleSeed.SellValue * 3);
                        OnRestart();
                    }
                    break;
                case 9:
                    if (_keepItem.Id == 15)
                    {
                        _inventoryMain.Money += (_seedMain.GreenSeed.SellValue * 3);
                        OnRestart();
                    }
                    break;
                case 10:
                    if (_keepItem.Id == 16)
                    {
                        _inventoryMain.Money += (_seedMain.OrangeSeed.SellValue * 3);
                        OnRestart();
                    }
                    break;
                case 11:
                    if (_keepItem.Id == 17)
                    {
                        _inventoryMain.Money += (_colorMain.ColorsList[4].SellValue * 3);
                        OnRestart();
                    }
                    break;
                case 12:
                    if (_keepItem.Id == 18)
                    {
                        _inventoryMain.Money += (_colorMain.ColorsList[5].SellValue * 3);
                        OnRestart();
                    }
                    break;
                case 13:
                    if (_keepItem.Id == 19)
                    {
                        _inventoryMain.Money += (_colorMain.ColorsList[6].SellValue * 3);
                        OnRestart();
                    }
                    break;
            }
        }
    }

    public void OnRestart()
    {
        _keepItem.Id = 0;
        Received = true;
        Command = -1;
    }
}
