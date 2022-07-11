using UnityEngine;
using UnityEngine.UI;

public class DeleteTeam : MonoBehaviour
{
    [SerializeField]
    private GameObject thisTeam, commander, crew1, crew2, crew3, crew4;
    [SerializeField]
    private Image image;
    [SerializeField]
    private AudioClip mySound;

    public void DeleteThisTeam()
    {

        foreach (GameObject playnowteam in FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "playnowteam"))
        {
            if (playnowteam.GetComponent<PlayNowTeamSetItem>().team == thisTeam)
            {
                playnowteam.GetComponent<PlayNowTeamSetItem>().DeleteTeam();
            }
        }
    }

    public void Enter()
    {
        image.GetComponent<Image>().color = new Color(1, 1, 1, .5f);
        GameObject.Find("AudioKey").GetComponent<AudioSource>().PlayOneShot(mySound);
    }

    public void Exit()
    {
        image.GetComponent<Image>().color = new Color(1, 1, 1, 0);
    }

}
