using UnityEngine;

public class SoundOver : MonoBehaviour
{

    public AudioClip myTeamsSound;
    public AudioSource audioSourMyTeamsSound;

    public void MyTeam()
    {
        audioSourMyTeamsSound.PlayOneShot(myTeamsSound);
    }
}
