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
        _command = Random.Range(1, 4);
        Debug.Log($"La commande numéro {_command}");
    }

    void Update()
    {
        if (Received == false)
        {
            switch (_command)
            {
                case 1:
                    if (_inventoryMain.InventoryColor.NumberBlue >= 1)
                    {
                        _inventoryMain.Money += (_seedMain.BlueSeed.SellValue * 2);
                        _inventoryMain.InventoryColor.NumberBlue -= 1;
                        Received = true;
                        _command = 0;
                    }
                    break;
                case 2:
                    if (_inventoryMain.InventoryColor.NumberYellow >= 1)
                    {
                        _inventoryMain.Money += (_seedMain.YellowSeed.SellValue * 2);
                        _inventoryMain.InventoryColor.NumberYellow -= 1;
                        Received = true;
                        _command = 0;
                    }
                    break;
                case 3:
                    if (_inventoryMain.InventoryColor.NumberRed >= 1)
                    {
                        _inventoryMain.Money += (_seedMain.RedSeed.SellValue * 2);
                        _inventoryMain.InventoryColor.NumberRed -= 1;
                        Received = true;
                        _command = 0;
                    }
                    break;
            }
        }
    }
}
