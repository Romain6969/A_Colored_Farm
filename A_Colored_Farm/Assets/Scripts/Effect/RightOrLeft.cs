using UnityEngine;

public class RightOrLeft : MonoBehaviour
{
    private float _time;
    private int _choice;
    [SerializeField] private GameObject _generate1;
    [SerializeField] private GameObject _generate2;

    void Update()
    {
        _time += Time.deltaTime;

        if (_time > 35)
        {
            _choice = Random.Range(0, 2);
            _time = 0;
        }

        if (_choice == 0)
        {
            _generate1.SetActive(true);
            _generate2.SetActive(false);
        }
        else
        {
            _generate1.SetActive(false);
            _generate2.SetActive(true);
        }
    }
}
