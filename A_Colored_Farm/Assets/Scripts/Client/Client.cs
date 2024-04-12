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
                    if (_inventoryMain.InventoryColor.NumberGrey >= 1)
                    {
                        _inventoryMain.Money += (_seedMain.GreySeed.SellValue * 2);
                        _inventoryMain.InventoryColor.NumberGrey -= 1;
                        Received = true;
                        _command = -1;
                    }
                    break;
                case 1:
                    if (_inventoryMain.InventoryColor.NumberBlue >= 1)
                    {
                        _inventoryMain.Money += (_seedMain.BlueSeed.SellValue * 2);
                        _inventoryMain.InventoryColor.NumberBlue -= 1;
                        Received = true;
                        _command = -1;
                    }
                    break;
                case 2:
                    if (_inventoryMain.InventoryColor.NumberYellow >= 1)
                    {
                        _inventoryMain.Money += (_seedMain.YellowSeed.SellValue * 2);
                        _inventoryMain.InventoryColor.NumberYellow -= 1;
                        Received = true;
                        _command = -1;
                    }
                    break;
                case 3:
                    if (_inventoryMain.InventoryColor.NumberRed >= 1)
                    {
                        _inventoryMain.Money += (_seedMain.RedSeed.SellValue * 2);
                        _inventoryMain.InventoryColor.NumberRed -= 1;
                        Received = true;
                        _command = -1;
                    }
                    break;
                case 4:
                    if (_inventoryMain.InventoryColor.NumberPurple >= 1)
                    {
                        _inventoryMain.Money += (_seedMain.PurpleSeed.SellValue * 2);
                        _inventoryMain.InventoryColor.NumberPurple -= 1;
                        Received = true;
                        _command = -1;
                    }
                    break;
                case 5:
                    if (_inventoryMain.InventoryColor.NumberGreen >= 1)
                    {
                        _inventoryMain.Money += (_seedMain.GreenSeed.SellValue * 2);
                        _inventoryMain.InventoryColor.NumberGreen -= 1;
                        Received = true;
                        _command = -1;
                    }
                    break;
                case 6:
                    if (_inventoryMain.InventoryColor.NumberOrange >= 1)
                    {
                        _inventoryMain.Money += (_seedMain.OrangeSeed.SellValue * 2);
                        _inventoryMain.InventoryColor.NumberOrange -= 1;
                        Received = true;
                        _command = -1;
                    }
                    break;
            }
        }
    }
}
