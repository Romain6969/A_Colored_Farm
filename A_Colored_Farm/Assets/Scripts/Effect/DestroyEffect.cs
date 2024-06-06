using UnityEngine;

public class DestroyEffect : MonoBehaviour
{
    [SerializeField] private int _timeDestruct;

    void Update()
    {
        Destroy(gameObject, _timeDestruct);
    }
}
