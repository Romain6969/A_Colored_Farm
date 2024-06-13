using UnityEngine;

public class JustCloseShop : MonoBehaviour
{
    [SerializeField] private OpenShop _openShop;

    public void OnShop()
    {
        _openShop.Open = false;
    }
}
