using UnityEngine;
using UnityEngine.UI;

public class NewTeams : MonoBehaviour
{
    [SerializeField]
    private GameObject teamsContent, teamPref;    
    [SerializeField]
    private AudioClip mySound;
    [SerializeField]
    private AudioSource audioSource;

    public int teamLimit, teamCreated;

    public void NewTeam()
    {
        teamCreated = GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamsCreated;
        if (teamCreated < teamLimit)
        {
            GameObject.Instantiate(teamPref).transform.SetParent(teamsContent.transform, false);
            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamsCreated++;
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
