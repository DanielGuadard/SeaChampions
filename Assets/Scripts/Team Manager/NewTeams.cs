using UnityEngine;
using UnityEngine.UI;

public class NewTeams : MonoBehaviour
{
    public GameObject teamsContent,teamPref;    
    public int teamLimit, teamCreated;
    public AudioClip mySound;
    public AudioSource audioSource;

    public void NewTeam()
    {
        teamCreated = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().teamsCreated;
        if (teamCreated <  teamLimit)
        {
            GameObject.Instantiate(teamPref).transform.SetParent(teamsContent.transform, false);
            GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().teamsCreated++;
        }
    }

     public void Enter()
    {
        GetComponent<Image>().color = new Color(1, 1, 1, .5f);
        audioSource.PlayOneShot(mySound);
    }

    public void Exit()
    {
        GetComponent<Image>().color = new Color(1, 1, 1, 0);
    }
   
}
