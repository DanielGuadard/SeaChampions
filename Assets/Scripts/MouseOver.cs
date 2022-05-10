using UnityEngine;

public class MouseOver : MonoBehaviour
{
    public AudioClip menuSound;
    public AudioSource audioSourceMenuSound;

    public void Menu()
    {
        audioSourceMenuSound.PlayOneShot(menuSound);
    }
    
}
