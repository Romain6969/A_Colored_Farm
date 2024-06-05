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
                        case 14:
                            if (_seedsGrowTime > _seedMain.GreySeed.GrowTime)
                            {
                                if (_placeSeed.IsPlanting == true)
                                {
                                    _keepItem.Id = 1;
                                    Destroy(gameObject);
                                    _keepItem.Here = true;
                                    _keepItem.NumberGreySeedPlanted += 1;
                                    return;
                                }
                            }
                            break;
                        case 15:
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
                        case 16:
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
                        case 17:
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
                        case 18:
                            if (_seedsGrowTime > _seedMain.PurpleSeed.GrowTime)
                            {
                                if (_placeSeed.IsPlanting == true)
                                {
                                    _keepItem.Id = 5;
                                    Destroy(gameObject);
                                    _keepItem.Here = true;
                                    return;
                                }
                            }
                            break;
                        case 19:
                            if (_seedsGrowTime > _seedMain.GreenSeed.GrowTime)
                            {
                                if (_placeSeed.IsPlanting == true)
                                {
                                    _keepItem.Id = 6;
                                    Destroy(gameObject);
                                    _keepItem.Here = true;
                                    return;
                                }
                            }
                            break;
                        case 20:
                            if (_seedsGrowTime > _seedMain.OrangeSeed.GrowTime)
                            {
                                if (_placeSeed.IsPlanting == true)
                                {
                                    _keepItem.Id = 7;
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
                    switch (_seedColorMix.MixThem())
                    {
                        case 1:
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
                        case 2:
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
                        case 3:
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
                        case 4:
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
                        case 5:
                            if (_seedsGrowTime > _seedMain.PurpleSeed.GrowTime)
                            {
                                if (_placeSeed.IsPlanting == true)
                                {
                                    _keepItem.Id = _seedColorMix.MixThem();
                                    Destroy(gameObject);
                                    PaintColor.PaintUses -= 1;
                                    _keepItem.Here = true;
                                }
                            }
                            break;
                        case 6:
                            if (_seedsGrowTime > _seedMain.GreenSeed.GrowTime)
                            {
                                if (_placeSeed.IsPlanting == true)
                                {
                                    _keepItem.Id = _seedColorMix.MixThem();
                                    Destroy(gameObject);
                                    PaintColor.PaintUses -= 1;
                                    _keepItem.Here = true;
                                }
                            }
                            break;
                        case 7:
                            if (_seedsGrowTime > _seedMain.OrangeSeed.GrowTime)
                            {
                                if (_placeSeed.IsPlanting == true)
                                {
                                    _keepItem.Id = _seedColorMix.MixThem();
                                    Destroy(gameObject);
                                    PaintColor.PaintUses -= 1;
                                    _keepItem.Here = true;
                                }
                            }
                            break;
                        case 8:
                            if (_seedsGrowTime > _seedMain.CyanSeed.GrowTime)
                            {
                                if (_placeSeed.IsPlanting == true)
                                {
                                    _keepItem.Id = _seedColorMix.MixThem();
                                    Destroy(gameObject);
                                    PaintColor.PaintUses -= 1;
                                    _keepItem.Here = true;
                                }
                            }
                            break;
                        case 9:
                            if (_seedsGrowTime > _seedMain.IndigoSeed.GrowTime)
                            {
                                if (_placeSeed.IsPlanting == true)
                                {
                                    _keepItem.Id = _seedColorMix.MixThem();
                                    Destroy(gameObject);
                                    PaintColor.PaintUses -= 1;
                                    _keepItem.Here = true;
                                }
                            }
                            break;
                        case 10:
                            if (_seedsGrowTime > _seedMain.LimeSeed.GrowTime)
                            {
                                if (_placeSeed.IsPlanting == true)
                                {
                                    _keepItem.Id = _seedColorMix.MixThem();
                                    Destroy(gameObject);
                                    PaintColor.PaintUses -= 1;
                                    _keepItem.Here = true;
                                }
                            }
                            break;
                        case 11:
                            if (_seedsGrowTime > _seedMain.OcreSeed.GrowTime)
                            {
                                if (_placeSeed.IsPlanting == true)
                                {
                                    _keepItem.Id = _seedColorMix.MixThem();
                                    Destroy(gameObject);
                                    PaintColor.PaintUses -= 1;
                                    _keepItem.Here = true;
                                }
                            }
                            break;
                        case 12:
                            if (_seedsGrowTime > _seedMain.MagentaSeed.GrowTime)
                            {
                                if (_placeSeed.IsPlanting == true)
                                {
                                    _keepItem.Id = _seedColorMix.MixThem();
                                    Destroy(gameObject);
                                    PaintColor.PaintUses -= 1;
                                    _keepItem.Here = true;
                                }
                            }
                            break;
                        case 13:
                            if (_seedsGrowTime > _seedMain.OrSeed.GrowTime)
                            {
                                if (_placeSeed.IsPlanting == true)
                                {
                                    _keepItem.Id = _seedColorMix.MixThem();
                                    Destroy(gameObject);
                                    PaintColor.PaintUses -= 1;
                                    _keepItem.Here = true;
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
