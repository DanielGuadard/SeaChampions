using UnityEngine;

public class SoundOver : MonoBehaviour
{

    public AudioClip myTeamsSound;

    public void MyTeam()
    {
        GameObject.Find("AudioKey").GetComponent<AudioSource>().PlayOneShot(myTeamsSound);
    }

}
