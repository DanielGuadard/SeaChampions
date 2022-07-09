using UnityEngine;

public class MouseOver : MonoBehaviour
{
    [SerializeField]
    private AudioClip onMouseOverSound;
    [SerializeField]
    private AudioSource audioSourceOnMouseOverSound;

    public void PlaySound()
    {
        audioSourceOnMouseOverSound.PlayOneShot(onMouseOverSound);
    }
    
}
