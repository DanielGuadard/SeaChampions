using UnityEngine;

public class MouseOver : MonoBehaviour
{
    public AudioClip onMouseOverSound;
    public AudioSource audioSourceOnMouseOverSound;

    public void PlaySound()
    {
        audioSourceOnMouseOverSound.PlayOneShot(onMouseOverSound);
    }
    
}
