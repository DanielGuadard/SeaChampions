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

        thisTeam.GetComponent<TeamSetItem>().RemoveC();
        thisTeam.GetComponent<TeamSetItem>().Remove1();
        thisTeam.GetComponent<TeamSetItem>().Remove2();
        thisTeam.GetComponent<TeamSetItem>().Remove3();
        thisTeam.GetComponent<TeamSetItem>().Remove4();

        Destroy(thisTeam);
        GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamsCreated--;
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
