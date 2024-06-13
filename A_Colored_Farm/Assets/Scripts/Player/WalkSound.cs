using UnityEngine;

public class WalkSound : MonoBehaviour
{
    [SerializeField] private PlaySounds _playSounds;

    public void OnActivate()
    {
        _playSounds.PlayAudio(7);
    }
}
