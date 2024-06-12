using UnityEngine;

public class GeneratePowder : MonoBehaviour
{
    [SerializeField] private Movement _movement;
    [SerializeField] private GameObject _powder;
    private float _time;

    void Update()
    {
        if (_movement.GeneratePowder == true)
        {
            _time += Time.deltaTime;

            if (_time >= 0.33f)
            {
                GameObject instantiated = Instantiate(_powder, transform.position, transform.rotation);
                _time = 0;
            }
        }
    }
}
