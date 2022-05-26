using UnityEngine;

public class SoundOver : MonoBehaviour
{

    [SerializeField]
    private AudioClip myTeamsSound;

    public void MyTeam()
    {
        GameObject.Find("AudioKey").GetComponent<AudioSource>().PlayOneShot(myTeamsSound);
    }

}
