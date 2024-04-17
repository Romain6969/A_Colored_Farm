using UnityEngine;

public class Client : MonoBehaviour
{
    [field : SerializeField] public bool Received { get; set; }
    [SerializeField] private InventoryMain _inventoryMain;
    [SerializeField] private SeedMain _seedMain;
    private int _command;
    

    void Start()
    {
        OnRandom();
    }

    public void OnRandom()
    {
        _command = Random.Range(0, 7);
        Debug.Log($"La commande numéro {_command}");
    }

    void Update()
    {
        if (Received == false)
        {
            switch (_command)
            {
                case 0:
                    if (_inventoryMain.InventoryColor.GetAmount("GreyColor") > 0)
                    {
                        _inventoryMain.Money += (_seedMain.GreySeed.SellValue * 2);
                        _inventoryMain.InventoryColor.RemoveSeed("GreyColor", 1);
                        Received = true;
                        _command = -1;
                    }
                    break;
                case 1:
                    if (_inventoryMain.InventoryColor.GetAmount("BlueColor") > 0)
                    {
                        _inventoryMain.Money += (_seedMain.BlueSeed.SellValue * 2);
                        _inventoryMain.InventoryColor.RemoveSeed("BlueColor", 1);
                        Received = true;
                        _command = -1;
                    }
                    break;
                case 2:
                    if (_inventoryMain.InventoryColor.GetAmount("YellowColor") > 0)
                    {
                        _inventoryMain.Money += (_seedMain.YellowSeed.SellValue * 2);
                        _inventoryMain.InventoryColor.RemoveSeed("YellowColor", 1);
                        Received = true;
                        _command = -1;
                    }
                    break;
                case 3:
                    if (_inventoryMain.InventoryColor.GetAmount("RedColor") > 0)
                    {
                        _inventoryMain.Money += (_seedMain.RedSeed.SellValue * 2);
                        _inventoryMain.InventoryColor.RemoveSeed("RedColor", 1);
                        Received = true;
                        _command = -1;
                    }
                    break;
                case 4:
                    if (_inventoryMain.InventoryColor.GetAmount("PurpleColor") > 0)
                    {
                        _inventoryMain.Money += (_seedMain.PurpleSeed.SellValue * 2);
                        _inventoryMain.InventoryColor.RemoveSeed("PurpleColor", 1);
                        Received = true;
                        _command = -1;
                    }
                    break;
                case 5:
                    if (_inventoryMain.InventoryColor.GetAmount("GreenColor") > 0)
                    {
                        _inventoryMain.Money += (_seedMain.GreenSeed.SellValue * 2);
                        _inventoryMain.InventoryColor.RemoveSeed("GreenColor", 1);
                        Received = true;
                        _command = -1;
                    }
                    break;
                case 6:
                    if (_inventoryMain.InventoryColor.GetAmount("OrangeColor") > 0)
                    {
                        _inventoryMain.Money += (_seedMain.OrangeSeed.SellValue * 2);
                        _inventoryMain.InventoryColor.RemoveSeed("OrangeColor", 1);
                        Received = true;
                        _command = -1;
                    }
                    break;
            }
        }
    }
}
