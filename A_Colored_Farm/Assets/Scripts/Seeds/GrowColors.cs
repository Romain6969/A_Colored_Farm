using UnityEngine;

public class GrowColors : MonoBehaviour
{
    [SerializeField] private SeedMain _seedMain;
    [SerializeField] private float _seedsGrowTime;
    [SerializeField] private KeepItem _keepItem;
    [SerializeField] private PlaceSeed _placeSeed;
    [field :SerializeField] public PaintColor PaintColor { get; set; }
    [SerializeField] private SeedColorMix _seedColorMix;
    private bool _collision = false;
    [field: SerializeField] public int CopyId { get; set; }

    private void Awake()
    {
        _seedMain = FindObjectOfType<SeedMain>();
        _keepItem = FindObjectOfType<KeepItem>();
        _placeSeed = FindObjectOfType<PlaceSeed>();
        _seedColorMix = FindObjectOfType<SeedColorMix>();
        CopyId = _keepItem.Id;
    }

    private void FixedUpdate()
    {
        Debug.Log(_placeSeed.IsPlanting);
        _seedsGrowTime += Time.deltaTime;

        if (_collision == true)
        {
            if (PaintColor.Paint == Colors.None)
            {
                if (_keepItem.Here == false)
                {
                    switch (CopyId)
                    {
                        case 8:
                            if (_seedsGrowTime > _seedMain.GreySeed.GrowTime)
                            {
                                if (_placeSeed.IsPlanting == true)
                                {
                                    _keepItem.Id = 1;
                                    Destroy(gameObject);
                                    _keepItem.Here = true;
                                    return;
                                }
                            }
                            break;
                        case 9:
                            if (_seedsGrowTime > _seedMain.BlueSeed.GrowTime)
                            {
                                if (_placeSeed.IsPlanting == true)
                                {
                                    _keepItem.Id = 2;
                                    Destroy(gameObject);
                                    _keepItem.Here = true;
                                    return;
                                }
                            }
                            break;
                        case 10:
                            if (_seedsGrowTime > _seedMain.YellowSeed.GrowTime)
                            {
                                if (_placeSeed.IsPlanting == true)
                                {
                                    _keepItem.Id = 3;
                                    Destroy(gameObject);
                                    _keepItem.Here = true;
                                    return;
                                }
                            }
                            break;
                        case 11:
                            if (_seedsGrowTime > _seedMain.RedSeed.GrowTime)
                            {
                                if (_placeSeed.IsPlanting == true)
                                {
                                    _keepItem.Id = 4;
                                    Destroy(gameObject);
                                    _keepItem.Here = true;
                                    return;
                                }
                            }
                            break;
                    }
                }
            }
            else
            {
                if (_keepItem.Here == false)
                {
                    switch (CopyId)
                    {
                        case 8:
                            if (_seedsGrowTime > _seedMain.GreySeed.GrowTime)
                            {
                                if (_placeSeed.IsPlanting == true)
                                {
                                    _keepItem.Id = _seedColorMix.MixThem();
                                    Destroy(gameObject);
                                    PaintColor.PaintUses -= 1;
                                    _keepItem.Here = true;
                                    return;
                                }
                            }
                            break;
                        case 9:
                            if (_seedsGrowTime > _seedMain.BlueSeed.GrowTime)
                            {
                                if (_placeSeed.IsPlanting == true)
                                {
                                    _keepItem.Id = _seedColorMix.MixThem();
                                    Destroy(gameObject);
                                    PaintColor.PaintUses -= 1;
                                    _keepItem.Here = true;
                                    return;
                                }
                            }
                            break;
                        case 10:
                            if (_seedsGrowTime > _seedMain.YellowSeed.GrowTime)
                            {
                                if (_placeSeed.IsPlanting == true)
                                {
                                    _keepItem.Id = _seedColorMix.MixThem();
                                    Destroy(gameObject);
                                    PaintColor.PaintUses -= 1;
                                    _keepItem.Here = true;
                                    return;
                                }
                            }
                            break;
                        case 11:
                            if (_seedsGrowTime > _seedMain.RedSeed.GrowTime)
                            {
                                if (_placeSeed.IsPlanting == true)
                                {
                                    _keepItem.Id = _seedColorMix.MixThem();
                                    Destroy(gameObject);
                                    PaintColor.PaintUses -= 1;
                                    _keepItem.Here = true;
                                    return;
                                }
                            }
                            break;
                    }
                }
                /*if (_seedsGrowTime > _seedMain.PurpleSeed.GrowTime)
                    {
                        if (_placeSeed.IsPlanting == true)
                        {
                            _keepItem.Id = 5;
                            Destroy(gameObject);
                            _keepItem.Here = true;
                        }
                    }

                    if (_seedsGrowTime > _seedMain.GreenSeed.GrowTime)
                    {
                        if (_placeSeed.IsPlanting == true)
                        {
                            _keepItem.Id = 6;
                            Destroy(gameObject);
                            _keepItem.Here = true;
                        }
                    }

                    if (_seedsGrowTime > _seedMain.OrangeSeed.GrowTime)
                    {
                        if (_placeSeed.IsPlanting == true)
                        {
                            _keepItem.Id = 7;
                            Destroy(gameObject);
                            _keepItem.Here = true;
                        }
                    }*/
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            _collision = true;
        }
        if (collision.gameObject.tag == "Dirt")
        {
            PaintColor = collision.gameObject.GetComponent<PaintColor>();
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
