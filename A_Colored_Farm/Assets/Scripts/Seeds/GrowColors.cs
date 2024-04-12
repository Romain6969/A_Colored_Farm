using UnityEngine;

public class GrowColors : MonoBehaviour
{
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private float _seedsGrowTime;
    [SerializeField] private Dirt _dirt;
    [SerializeField] private WichSeed _wichSeed;
    [SerializeField] private InventoryColor _inventoryColor;

    private void FixedUpdate()
    {
        if (_dirt.SeedPlaced == true)
        {
            _seedsGrowTime += Time.deltaTime;

            if (_wichSeed._redSeed == true)
            {
                if (_seedsGrowTime > _seedMain.RedSeed.GrowTime)
                {
                    _inventoryColor.NumberRed += 1;
                    Destroy(GameObject.Find("RedSeed(Clone)"));
                    _seedsGrowTime = 0;
                    _dirt.SeedPlaced = false;
                }
            }
            if (_wichSeed._blueSeed == true)
            {
                if (_seedsGrowTime > _seedMain.BlueSeed.GrowTime)
                {
                    _inventoryColor.NumberBlue += 1;
                    Destroy(GameObject.Find("BlueSeed(Clone)"));
                    _seedsGrowTime = 0;
                    _dirt.SeedPlaced = false;
                }
            }
            if (_wichSeed._yellowSeed == true)
            {
                if (_seedsGrowTime > _seedMain.YellowSeed.GrowTime)
                {
                    _inventoryColor.NumberYellow += 1;
                    Destroy(GameObject.Find("YellowSeed(Clone)"));
                    _seedsGrowTime = 0;
                    _dirt.SeedPlaced = false;
                }
            }
            if (_wichSeed._greySeed == true)
            {
                if (_seedsGrowTime > _seedMain.GreySeed.GrowTime)
                {
                    _inventoryColor.NumberGrey += 1;
                    Destroy(GameObject.Find("GreySeed(Clone)"));
                    _seedsGrowTime = 0;
                    _dirt.SeedPlaced = false;
                }
            }
            if (_wichSeed._purpleSeed == true)
            {
                if (_seedsGrowTime > _seedMain.GreenSeed.GrowTime)
                {
                    _inventoryColor.NumberGreen += 1;
                    Destroy(GameObject.Find("GreenSeed(Clone)"));
                    _seedsGrowTime = 0;
                    _dirt.SeedPlaced = false;
                }
            }
            if (_wichSeed._orangeSeed == true)
            {
                if (_seedsGrowTime > _seedMain.PurpleSeed.GrowTime)
                {
                    _inventoryColor.NumberPurple += 1;
                    Destroy(GameObject.Find("PurpleSeed(Clone)"));
                    _seedsGrowTime = 0;
                    _dirt.SeedPlaced = false;
                }
            }
            if (_wichSeed._greenSeed == true)
            {
                if (_seedsGrowTime > _seedMain.OrangeSeed.GrowTime)
                {
                    _inventoryColor.NumberOrange += 1;
                    Destroy(GameObject.Find("OrangeSeed(Clone)"));
                    _seedsGrowTime = 0;
                    _dirt.SeedPlaced = false;
                }
            }
        }
    }
}
