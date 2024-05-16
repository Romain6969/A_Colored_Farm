using UnityEngine;

public class Crusher : MonoBehaviour
{
    [SerializeField] private KeepItem _keepItem;
    [field : SerializeField] public int CopyId { get; set; }
    [SerializeField] private bool _activate = false;
    [field : SerializeField] public bool Ready { get; set; } = false;
    [SerializeField] private float _time;


    public void OnActivated()
    {
        CopyId = _keepItem.Id;
        _activate = true;
    }

    void Update()
    {
        if (_activate == true)
        {
            _time += Time.deltaTime;

            if (_time >= 15)
            {
                Ready = true;
                _time = 0;
                _activate = false;
            }
        }
    }
}
