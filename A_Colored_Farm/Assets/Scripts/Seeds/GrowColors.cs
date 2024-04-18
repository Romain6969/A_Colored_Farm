using UnityEngine;

public class GrowColors : MonoBehaviour
{
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private float _seedsGrowTime;
    [SerializeField] private WichSeed _wichSeed;
    [SerializeField] private InventoryVegetable _plantsInventory;
    [SerializeField] private PlaceSeed _placeSeed;
    private void Start()
    {
        _seedMain = FindObjectOfType<SeedMain>();
        _wichSeed = FindObjectOfType<WichSeed>();
        _plantsInventory = FindObjectOfType<InventoryVegetable>();
        _placeSeed = FindObjectOfType<PlaceSeed>();
    }

    private void FixedUpdate()
    {
        Debug.Log(_placeSeed.IsPlanting);
        _seedsGrowTime += Time.deltaTime;

        switch (_wichSeed.SeedNumber)
        {
            case 0:
                if (_seedsGrowTime > _seedMain.GreySeed.GrowTime)
                {
                    if (_placeSeed.IsPlanting == true)
                    {
                        _plantsInventory.AddSeed("GreyPlant", 1);
                        Destroy(gameObject);
                    }
                }
                break;
            case 1:
                if (_seedsGrowTime > _seedMain.BlueSeed.GrowTime)
                {
                    if (_placeSeed.IsPlanting == true)
                    {
                        _plantsInventory.AddSeed("BluePlant", 1);
                        Destroy(gameObject);
                    }  
                }
                break;
            case 2:
                if (_seedsGrowTime > _seedMain.YellowSeed.GrowTime)
                {
                    if (_placeSeed.IsPlanting == true)
                    {
                        _plantsInventory.AddSeed("YellowPlant", 1);
                        Destroy(gameObject);
                    }
                }
                break;
            case 3:
                if (_seedsGrowTime > _seedMain.RedSeed.GrowTime)
                {
                    if (_placeSeed.IsPlanting == true)
                    {
                        _plantsInventory.AddSeed("RedPlant", 1);
                        Destroy(gameObject);
                    }
                }
                break;
            case 4:
                if (_seedsGrowTime > _seedMain.PurpleSeed.GrowTime)
                {
                    if (_placeSeed.IsPlanting == true)
                    {
                        _plantsInventory.AddSeed("PurplePlant", 1);
                        Destroy(gameObject);
                    }
                }
                break;
            case 5:
                if (_seedsGrowTime > _seedMain.GreenSeed.GrowTime)
                {
                    if (_placeSeed.IsPlanting == true)
                    {
                        _plantsInventory.AddSeed("GreenPlant", 1);
                        Destroy(gameObject);
                    }
                }
                break;
            case 6:
                if (_seedsGrowTime > _seedMain.OrangeSeed.GrowTime)
                {
                    if (_placeSeed.IsPlanting == true)
                    {
                        _plantsInventory.AddSeed("OrangePlant", 1);
                        Destroy(gameObject);
                    }
                }
                break;
        }
    }
}
