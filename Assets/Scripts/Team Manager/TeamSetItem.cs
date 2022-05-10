using UnityEngine;
using UnityEngine.UI;

public class TeamSetItem : MonoBehaviour
{

    public GameObject slot, championObj, commander, crew1, crew2, crew3, crew4,
        addC, add1, add2, add3, add4, removeC, remove1, remove2, remove3, remove4,
        inputField, teamName, nameHolder, incomplete,
        imageC, image1, image2, image3, image4;
    public Texture minusCommander, plus, minus;
    public Sprite plusCommander;
    public bool completed;

    void Start()
    {
        slot = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().slot;
        removeC.SetActive(false);
        remove1.SetActive(false);
        remove2.SetActive(false);
        remove3.SetActive(false);
        remove4.SetActive(false);
    }

    void Update()
    {
        if (commander == null || crew1 == null || crew2 == null || crew3 == null || crew4 == null)
        {
            completed = false;
            incomplete.SetActive(true);
            teamName.GetComponent<RectTransform>().position = incomplete.GetComponent<Transform>().position +
                new Vector3(140, 0, 0);
            nameHolder.GetComponent<RectTransform>().position = incomplete.GetComponent<Transform>().position +
                new Vector3(140, 0, 0);
        }
        if (commander != null & crew1 != null & crew2 != null & crew3 != null & crew4 != null)
        {
            completed = true;
            incomplete.SetActive(false);
            teamName.GetComponent<RectTransform>().position = incomplete.GetComponent<Transform>().position +
                new Vector3(0, 0, 0);
            nameHolder.GetComponent<RectTransform>().position = incomplete.GetComponent<Transform>().position +
                new Vector3(0, 0, 0);

        }
        
    }

    public void SetCommander()
    {
        AddImage(0, removeC, addC, imageC);
    }

    public void SetCrew1()
    {
        crew1 = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().champiomObj;
        AddImage(1, remove1, add1, image1);
    }

    public void SetCrew2()
    {
        crew2 = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().champiomObj;
        AddImage(2, remove2, add2, image2);
    }

    public void SetCrew3()
    {
        crew3 = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().champiomObj;
        AddImage(3, remove3, add3, image3);
    }

    public void SetCrew4()
    {
        crew4 = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().champiomObj;
        AddImage(4, remove4, add4, image4);
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
            RemoveImage(remove3, add3, crew3, image3);
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

    public void AddImage(int crew, GameObject remove, GameObject teamSlot, GameObject teamImage)
    {
        GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().crew = crew;
        GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().remove = remove;
        GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().teamSlot = teamSlot;
        GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().teamImage = teamImage;
        GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().team = this.gameObject;
    }

    public void RemoveImage(GameObject remove, GameObject add, GameObject champ, GameObject image)
    {
        championObj = GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().champiomObj;
        add.GetComponent<RectTransform>().sizeDelta = new Vector2(32, 32);
        remove.SetActive(false);
        add.GetComponent<Image>().sprite = plusCommander;
        add.GetComponent<Image>().sprite = plusCommander;
        image.SetActive(true);
        image.GetComponent<Button>().interactable = true;
        champ.GetComponent<Button>().interactable = true;
        champ.GetComponent<BoxCollider>().enabled = true;
    }

}
