using UnityEngine;
using UnityEngine.UI;

public class NotInteractable : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Sprite _sprite;
    [SerializeField] private Button _button;
    [SerializeField] public bool Interactable { get; set; } = false;

    void Update()
    {
        if (Interactable == true)
        {
            _image.sprite = _sprite;
            _button.interactable = true;
        }
    }
}
