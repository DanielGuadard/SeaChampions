using UnityEngine;
using UnityEngine.UI;

public class DeleteTeam : MonoBehaviour
{
    public GameObject thisTeam, commander, crew1, crew2, crew3, crew4;
    public Image image;
    public AudioClip mySound;
    public AudioSource audioSource;

   public void DeleteThisTeam()
    {

        thisTeam.GetComponent<TeamSetItem>().RemoveC();
        thisTeam.GetComponent<TeamSetItem>().Remove1();
        thisTeam.GetComponent<TeamSetItem>().Remove2();
        thisTeam.GetComponent<TeamSetItem>().Remove3();
        thisTeam.GetComponent<TeamSetItem>().Remove4();

        Destroy(thisTeam);
        GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().teamsCreated--;
    }

    public void Enter()
    {
        image.GetComponent<Image>().color = new Color(1, 1, 1, .5f);
        audioSource.PlayOneShot(mySound);
    }

    public void Exit()
    {
        image.GetComponent<Image>().color = new Color(1, 1, 1, 0);
    }

}
