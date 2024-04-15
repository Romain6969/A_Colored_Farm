using UnityEngine;

public class GrowColors : MonoBehaviour
{
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private float _seedsGrowTime;
    [SerializeField] private WichSeed _wichSeed;
    [SerializeField] private InventoryColor _inventoryColor;

    private void Start()
    {
        _seedMain = FindObjectOfType<SeedMain>();
        _wichSeed = FindObjectOfType<WichSeed>();
        _inventoryColor = FindObjectOfType<InventoryColor>();
    }

    private void FixedUpdate()
    {
        _seedsGrowTime += Time.deltaTime;

        switch (_wichSeed.SeedNumber)
        {
            case 0:
                if (_seedsGrowTime > _seedMain.GreySeed.GrowTime)
                {
                    _inventoryColor.NumberGrey += 1;
                    Destroy(gameObject);
                }
                break;
            case 1:
                if (_seedsGrowTime > _seedMain.BlueSeed.GrowTime)
                {
                    _inventoryColor.NumberBlue += 1;
                    Destroy(gameObject);
                }
                break;
            case 2:
                if (_seedsGrowTime > _seedMain.YellowSeed.GrowTime)
                {
                    _inventoryColor.NumberYellow += 1;
                    Destroy(gameObject);
                }
                break;
            case 3:
                if (_seedsGrowTime > _seedMain.RedSeed.GrowTime)
                {
                    _inventoryColor.NumberRed += 1;
                    Destroy(gameObject);
                }
                break;
            case 4:
                if (_seedsGrowTime > _seedMain.PurpleSeed.GrowTime)
                {
                    _inventoryColor.NumberPurple += 1;
                    Destroy(gameObject);
                }
                break;
            case 5:
                if (_seedsGrowTime > _seedMain.GreenSeed.GrowTime)
                {
                    _inventoryColor.NumberGreen += 1;
                    Destroy(gameObject);
                }
                break;
            case 6:
                if (_seedsGrowTime > _seedMain.OrangeSeed.GrowTime)
                {
                    _inventoryColor.NumberOrange += 1;
                    Destroy(gameObject);
                }
                break;
        }
    }
}
