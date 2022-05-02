using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteTeam : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ThisTeam, commander, crew1, crew2, crew3, crew4;
    public Image image;
    public AudioClip MySound;
    public AudioSource AudioSour;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void DeletthisTeam()
    {

        ThisTeam.GetComponent<TeamSetItem>().RemoveC();
        ThisTeam.GetComponent<TeamSetItem>().Remove1();
        ThisTeam.GetComponent<TeamSetItem>().Remove2();
        ThisTeam.GetComponent<TeamSetItem>().Remove3();
        ThisTeam.GetComponent<TeamSetItem>().Remove4();

        Destroy(ThisTeam);
        GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().TeamCriado--;
    }

    public void Enter()
    {
        image.GetComponent<Image>().color = new Color(1, 1, 1, .5f);
        AudioSour.PlayOneShot(MySound);
    }
    public void Exit()
    {
        image.GetComponent<Image>().color = new Color(1, 1, 1, 0);
    }


}
