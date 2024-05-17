using UnityEngine;

public class Crusher : MonoBehaviour
{
    [SerializeField] private KeepItem _keepItem;
    [field : SerializeField] public int CopyId { get; set; }
    [field : SerializeField] public bool Activate { get; set; } = false;
    [field : SerializeField] public bool Ready { get; set; } = false;
    [SerializeField] private float _time;


    public void OnActivated()
    {
        CopyId = _keepItem.Id;
        Activate = true;
    }

    void Update()
    {
        if (Activate == true)
        {
            _time += Time.deltaTime;

            if (_time >= 15)
            {
                Ready = true;
                _time = 0;
                Activate = false;
            }
        }
    }
}
