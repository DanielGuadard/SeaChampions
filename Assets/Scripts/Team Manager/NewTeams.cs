using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewTeams : MonoBehaviour
{

    public GameObject teamsContent,Team_Pref;    
    public int TeamLimit, TeamCriado;
    public AudioClip MySound;
    public AudioSource AudioSour;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewTeam()
    {
        TeamCriado = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().TeamCriado;
        if (TeamCriado <  TeamLimit)
        {
            GameObject.Instantiate(Team_Pref).transform.SetParent(teamsContent.transform, false);
            GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().TeamCriado++;
        }
        
    }
     public void Enter()
    {
        GetComponent<Image>().color = new Color(1,1,1,.5f);
        AudioSour.PlayOneShot(MySound);
    }
    public void Exit()
    {
        GetComponent<Image>().color = new Color(1, 1, 1, 0);
    }
   
}
