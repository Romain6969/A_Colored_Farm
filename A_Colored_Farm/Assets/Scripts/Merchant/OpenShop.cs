using UnityEngine;
public class OpenShop : MonoBehaviour
{
    [SerializeField] private GameObject _shopPanel;
    [SerializeField] private Interactions _interactions;
    private bool _open = false;
    private bool _isTrigger = false;

    public void Update()
    {
        if (_isTrigger == true)
        {
            if (_open == false)
            {
                if (_interactions.IsPerformed == true)
                {
                    _shopPanel.SetActive(true);
                    _open = true;
                    Time.timeScale = 0;
                }
            }
            else
            {
                if (_interactions.IsPerformed == false)
                {
                    _shopPanel.SetActive(false);
                    _open = false;
                    Time.timeScale = 1;
                }
            }
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shop")
        {
            _isTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shop")
        {
            _isTrigger = false;
        }
    }
}
