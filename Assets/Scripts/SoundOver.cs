using UnityEngine;

public class SoundOver : MonoBehaviour
{

    public AudioClip myTeamsSound;
    public AudioSource audioSourceMyTeamsSound;

    public void MyTeam()
    {
        audioSourceMyTeamsSound.PlayOneShot(myTeamsSound);
    }
}
