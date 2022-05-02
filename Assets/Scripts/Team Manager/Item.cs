using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    

    // Start is called before the first frame update
    public GameObject Mainslot, ChampiomObj;
    public GameObject[] Slotlist ;
    public Color Slotcolor;
    
    void Start()
    {
        ChampiomObj = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().ChampiomObj;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseDown()
    {
        if (GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().TeamSlot != null)
        {
            //get the game objects to show the champion
            GameObject Remove = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().Remove;
            GameObject TeamSlot = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().TeamSlot;
            GameObject TeamImage = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().TeamImage;
            GameObject Team = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().Team;
            int Crew = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().Crew;

            //Configure the Gameobjects to show the champion
            Remove.SetActive(true);
            TeamImage.GetComponent<Button>().interactable = false;
            TeamSlot.GetComponent<RectTransform>().sizeDelta = new Vector2(170, 170);
            TeamSlot.GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
            this.GetComponent<BoxCollider>().enabled = false;
            this.GetComponent<Button>().interactable = false;

            switch ( Crew )
            {
                case 0:
                    Team.GetComponent<TeamSetItem>().commander = this.gameObject;
                    break;
                case 1:
                    Team.GetComponent<TeamSetItem>().crew1 = this.gameObject;
                    break;
                case 2:
                    Team.GetComponent<TeamSetItem>().crew2 = this.gameObject;
                    break;
                case 3:
                    Team.GetComponent<TeamSetItem>().crew3 = this.gameObject;
                    break;
                case 4:
                    Team.GetComponent<TeamSetItem>().crew4 = this.gameObject;
                    break;
            }

            // reset
            GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().TeamSlot = null;
            GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().TeamImage = null;

        }


        Slotlist = GameObject.FindGameObjectsWithTag("slot");
        
        foreach(GameObject x in Slotlist)
        {
            
        x.GetComponent<Image>().color = new Color(1, 1, 1,1);
            
        }
        /*
        //transform.parent.parent.parent.parent.parent.parent.GetComponent<TeamSetItem>().Item = this.gameObject;
        GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().item = GetComponent<Image>().sprite;
        GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().ChampiomObj = this.gameObject;
        GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().slot = Mainslot.gameObject;
        Mainslot.GetComponent<Image>().color = new Color (0,0.666f,1,1);
        GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().TeamSlot = null;

       */

       

    }


}
