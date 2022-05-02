using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeamSetItem : MonoBehaviour
{

    public GameObject slot, ChampiomObj, commander, crew1, crew2, crew3, crew4, addC, add1, add2, add3, add4, removeC, remove1, remove2, remove3, remove4, InputField, TeamName, NameHolder, Incomplete,
    imageC,image1, image2, image3, image4;
    public Texture MinusCommander, Plus, Minus;
    public Sprite PlusCommander;
    public bool Completo;
    // Start is called before the first frame update
    void Start()
    {
      //  ChampiomObj = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().ChampiomObj;
        slot = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().slot;
        removeC.SetActive(false);
        remove1.SetActive(false);
        remove2.SetActive(false);
        remove3.SetActive(false);
        remove4.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (commander == null || crew1 == null || crew2 == null || crew3 == null || crew4 == null)
        {
            Completo = false;
            Incomplete.SetActive(true);
            TeamName.GetComponent<RectTransform>().position = Incomplete.GetComponent<Transform>().position + new Vector3(140, 0, 0);
            NameHolder.GetComponent<RectTransform>().position = Incomplete.GetComponent<Transform>().position + new Vector3(140, 0, 0);
        }
        if (commander != null & crew1 != null & crew2 != null & crew3 != null & crew4 != null)
        {
            Completo = true;
            Incomplete.SetActive(false);
            TeamName.GetComponent<RectTransform>().position = Incomplete.GetComponent<Transform>().position+ new Vector3(0,0,0);
            NameHolder.GetComponent<RectTransform>().position = Incomplete.GetComponent<Transform>().position + new Vector3(0, 0, 0);

        }
        
    }


    public void SetCommander()
    {
         
        AddImage(0,removeC, addC, imageC);


    }
    public void Setcrew1()
    {
        crew1 = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().ChampiomObj;
        AddImage(1,remove1, add1, image1);
    }
    public void Setcrew2()
    {
        crew2 = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().ChampiomObj;
        AddImage(2,remove2, add2, image2);
    }
    public void Setcrew3()
    {
        crew3 = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().ChampiomObj;
        AddImage(3,remove3, add3, image3);
    }
    public void Setcrew4()
    {
        crew4 = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().ChampiomObj;
        AddImage(4,remove4, add4, image4);
    }


    public void RemoveC()
    {
        if (commander != null)
        { 
            RemoveImage(removeC, addC, commander, imageC);
        commander = null;
        }
    }

    public void Remove1()
    {
        if (crew1 != null)
        {
            RemoveImage(remove1, add1, crew1, image1);
            crew1 = null;
        }
           
    }
    public void Remove2()
    {
        if (crew2 != null)
        {
            RemoveImage(remove2, add2, crew2, image2);
            crew2 = null;
        }
            
    }
    public void Remove3()
    {
        if (crew3 != null)
        {
            RemoveImage(remove3, add3, crew3,image3);
            crew3 = null;
        }
            
    }
    public void Remove4()
    {
        if (crew4 != null)
        {
            RemoveImage(remove4, add4, crew4, image4);
            crew4 = null;
        }
            
    }


    public void AddImage(int Crew,GameObject Remove, GameObject TeamSlot, GameObject TeamImage )
    {   GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().Crew = Crew;
        GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().Remove = Remove;
        GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().TeamSlot = TeamSlot;
        GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().TeamImage = TeamImage;
        GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().Team = this.gameObject;

        /*ChampiomObj = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().ChampiomObj;
        slot = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().slot;
        */
        /* if (GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().TeamSlot != null && ChampiomObj != null)
        {

            add.GetComponent<RectTransform>().sizeDelta = new Vector2(170, 170);
            add.GetComponent<Image>().sprite = ChampiomObj.GetComponent<Image>().sprite;
            remove.SetActive(true);
            ChampiomObj.GetComponent<Button>().interactable = false;
            slot.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            ChampiomObj.GetComponent<BoxCollider>().enabled = false;
            GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().ChampiomObj = null;
            image.GetComponent<Button>().interactable = false;

        }*/

    }

    public void RemoveImage(GameObject remove, GameObject add, GameObject champ, GameObject image)
    {

        ChampiomObj = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().ChampiomObj;
        add.GetComponent<RectTransform>().sizeDelta = new Vector2(32, 32);
        remove.SetActive(false);
        add.GetComponent<Image>().sprite = PlusCommander;

        // Debug.Log("removed");
        add.GetComponent<Image>().sprite = PlusCommander;
        image.SetActive(true);
        image.GetComponent<Button>().interactable = true;
        champ.GetComponent<Button>().interactable = true;
        champ.GetComponent<BoxCollider>().enabled = true;

    }
}
