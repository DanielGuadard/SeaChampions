using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    

    // Start is called before the first frame update
    public GameObject mainSlot, championObj;
    public GameObject[] slotList;
    public Color slotColor;
    
    void Start()
    {
        championObj = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().champiomObj;
    }
    
    void OnMouseDown()
    {
        if (GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().teamSlot != null)
        {
            // Get the game objects to show the champion
            GameObject Remove = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().remove;
            GameObject TeamSlot = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().teamSlot;
            GameObject TeamImage = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().teamImage;
            GameObject Team = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().team;
            int Crew = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().crew;

            // Configure the Gameobjects to show the champion
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

            // Reset
            GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().teamSlot = null;
            GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().teamImage = null;

        }

        slotList = GameObject.FindGameObjectsWithTag("slot");
        
        foreach(GameObject gameObject in slotList)
        {
            gameObject.GetComponent<Image>().color = new Color(1, 1, 1,1);   
        }
    }

}
