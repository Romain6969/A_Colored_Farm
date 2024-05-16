using UnityEngine;

public class GrowColors : MonoBehaviour
{
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private float _seedsGrowTime;
    [SerializeField] private KeepItem _keepItem;
    [SerializeField] private PlaceSeed _placeSeed;
    [SerializeField] private PaintColor _paintColor;
    private bool _collision = false;

    private void Start()
    {
        _seedMain = FindObjectOfType<SeedMain>();
        _keepItem = FindObjectOfType<KeepItem>();
        _placeSeed = FindObjectOfType<PlaceSeed>();
    }

    private void FixedUpdate()
    {
        Debug.Log(_placeSeed.IsPlanting);
        _seedsGrowTime += Time.deltaTime;
        if (_paintColor.Paint == Colors.None)
        {
            if (_collision == true)
            {
                if (_seedsGrowTime > _seedMain.GreySeed.GrowTime)
                {
                    if (_placeSeed.IsPlanting == true)
                    {
                        _keepItem.Id = 1;
                        _keepItem.UpdateSprite();
                        Destroy(gameObject);
                    }
                }

                if (_seedsGrowTime > _seedMain.BlueSeed.GrowTime)
                {
                    if (_placeSeed.IsPlanting == true)
                    {
                        _keepItem.Id = 2;
                        _keepItem.UpdateSprite();
                        Destroy(gameObject);
                    }
                }

                if (_seedsGrowTime > _seedMain.YellowSeed.GrowTime)
                {
                    if (_placeSeed.IsPlanting == true)
                    {
                        _keepItem.Id = 3;
                        _keepItem.UpdateSprite();
                        Destroy(gameObject);
                    }
                }

                if (_seedsGrowTime > _seedMain.RedSeed.GrowTime)
                {
                    if (_placeSeed.IsPlanting == true)
                    {
                        _keepItem.Id = 4;
                        _keepItem.UpdateSprite();
                        Destroy(gameObject);
                    }
                }

                if (_seedsGrowTime > _seedMain.PurpleSeed.GrowTime)
                {
                    if (_placeSeed.IsPlanting == true)
                    {
                        _keepItem.Id = 5;
                        _keepItem.UpdateSprite();
                        Destroy(gameObject);
                    }
                }

                if (_seedsGrowTime > _seedMain.GreenSeed.GrowTime)
                {
                    if (_placeSeed.IsPlanting == true)
                    {
                        _keepItem.Id = 6;
                        _keepItem.UpdateSprite();
                        Destroy(gameObject);
                    }
                }

                if (_seedsGrowTime > _seedMain.OrangeSeed.GrowTime)
                {
                    if (_placeSeed.IsPlanting == true)
                    {
                        _keepItem.Id = 7;
                        _keepItem.UpdateSprite();
                        Destroy(gameObject);
                    }
                }
            }
        }
        else
        {
            if (_collision == true)
            {
                if (_seedsGrowTime > _seedMain.GreySeed.GrowTime)
                {
                    if (_placeSeed.IsPlanting == true)
                    {
                        _keepItem.Id = 1;
                        _keepItem.UpdateSprite();
                        Destroy(gameObject);
                    }
                }

                if (_seedsGrowTime > _seedMain.BlueSeed.GrowTime)
                {
                    if (_placeSeed.IsPlanting == true)
                    {
                        _keepItem.Id = 2;
                        _keepItem.UpdateSprite();
                        Destroy(gameObject);
                    }
                }

                if (_seedsGrowTime > _seedMain.YellowSeed.GrowTime)
                {
                    if (_placeSeed.IsPlanting == true)
                    {
                        _keepItem.Id = 3;
                        _keepItem.UpdateSprite();
                        Destroy(gameObject);
                    }
                }

                if (_seedsGrowTime > _seedMain.RedSeed.GrowTime)
                {
                    if (_placeSeed.IsPlanting == true)
                    {
                        _keepItem.Id = 4;
                        _keepItem.UpdateSprite();
                        Destroy(gameObject);
                    }
                }

                if (_seedsGrowTime > _seedMain.PurpleSeed.GrowTime)
                {
                    if (_placeSeed.IsPlanting == true)
                    {
                        _keepItem.Id = 5;
                        _keepItem.UpdateSprite();
                        Destroy(gameObject);
                    }
                }

                if (_seedsGrowTime > _seedMain.GreenSeed.GrowTime)
                {
                    if (_placeSeed.IsPlanting == true)
                    {
                        _keepItem.Id = 6;
                        _keepItem.UpdateSprite();
                        Destroy(gameObject);
                    }
                }

                if (_seedsGrowTime > _seedMain.OrangeSeed.GrowTime)
                {
                    if (_placeSeed.IsPlanting == true)
                    {
                        _keepItem.Id = 7;
                        _keepItem.UpdateSprite();
                        Destroy(gameObject);
                    }
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            _collision = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            _collision = false;
        }
    }
}
