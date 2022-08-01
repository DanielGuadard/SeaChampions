using UnityEngine;
using UnityEngine.UI;

public class TeamSetItem : MonoBehaviour
{

    [SerializeField]
    private Texture minusCommander, plus, minus;
    [SerializeField]
    private Sprite plusCommander;
    [SerializeField]
    private Text battlePowerText;

    public GameObject slot, championObj, commander, crew1, crew2, crew3, crew4,
        addC, add1, add2, add3, add4, removeC, remove1, remove2, remove3, remove4,
        inputField, teamName, nameHolder, incomplete,
        imageC, image1, image2, image3, image4;

    public bool completed;

    public float battlePowerTeam, battlePowerCommander, battlePowerCrew1, battlePowerCrew2, battlePowerCrew3, battlePowerCrew4;

    void Start()
    {
        slot = GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().slot;
    }

    void Update()
    {
        if (commander == null || crew1 == null || crew2 == null || crew3 == null || crew4 == null)
        {
            completed = false;
            incomplete.SetActive(true);
            teamName.GetComponent<RectTransform>().position = incomplete.GetComponent<Transform>().position + new Vector3(140, 0, 0);
            nameHolder.GetComponent<RectTransform>().position = incomplete.GetComponent<Transform>().position + new Vector3(140, 0, 0);
            GameObject.Find("ScriptHolder").GetComponent<OPENAndEXITGame>().SaveTeams();
        }
        if (commander != null & crew1 != null & crew2 != null & crew3 != null & crew4 != null)
        {
            completed = true;
            incomplete.SetActive(false);
            teamName.GetComponent<RectTransform>().position = incomplete.GetComponent<Transform>().position +
                new Vector3(0, 0, 0);
            nameHolder.GetComponent<RectTransform>().position = incomplete.GetComponent<Transform>().position +
                new Vector3(0, 0, 0);
            GameObject.Find("ScriptHolder").GetComponent<OPENAndEXITGame>().SaveTeams();
        }
        CalculateBattlePower();
    }

    public void SetCommander()
    {
        commander = GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().championObj;
        AddImage(0, removeC, addC, imageC);
        
          
    }

    public void SetCrew1()
    {
        crew1 = GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().championObj;
        AddImage(1, remove1, add1, image1);
        
            
    }

    public void SetCrew2()
    {
        crew2 = GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().championObj;
        AddImage(2, remove2, add2, image2); 
       

    }

    public void SetCrew3()
    {
        crew3 = GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().championObj;
        AddImage(3, remove3, add3, image3);
      

    }

    public void SetCrew4()
    {
        crew4 = GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().championObj;
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
        GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().crew = crew;
        GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().remove = remove;
        GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamSlot = teamSlot;
        GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamImage = teamImage;
        GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().team = this.gameObject;

    }

    public void RemoveImage(GameObject remove, GameObject add, GameObject champ, GameObject image)
    {
        championObj = GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().championObj;
        add.GetComponent<RectTransform>().sizeDelta = new Vector2(32, 32);
        remove.SetActive(false);
        add.GetComponent<Image>().sprite = plusCommander;
        add.GetComponent<Image>().sprite = plusCommander;
        image.SetActive(true);
        image.GetComponent<Button>().interactable = true;
        champ.GetComponent<Button>().interactable = true;
        champ.GetComponent<BoxCollider>().enabled = true;
    }

    public void CalculateBattlePower()
    {
        if (commander != null)
        {
            battlePowerCommander = commander.GetComponent<Item>().battlePower;
        }
        else
        {
            battlePowerCommander = 0;
        }
        if (crew1 != null)
        {
            battlePowerCrew1 = crew1.GetComponent<Item>().battlePower;
        }
        else
        {
            battlePowerCrew1 = 0;
        }
        if (crew2 != null)
        {
            battlePowerCrew2 = crew2.GetComponent<Item>().battlePower;
        }
        else
        {
            battlePowerCrew2 = 0;
        }
        if (crew3 != null)
        {
            battlePowerCrew3 = crew3.GetComponent<Item>().battlePower;
        }
        else
        {
            battlePowerCrew3 = 0;
        }
        if (crew4 != null)
        {
            battlePowerCrew4 = crew4.GetComponent<Item>().battlePower;
        }
        else
        {
            battlePowerCrew4 = 0;
        }

        battlePowerTeam = battlePowerCommander + battlePowerCrew1 + battlePowerCrew2 + battlePowerCrew3 + battlePowerCrew4;
        battlePowerText.text = "BP: " + battlePowerTeam;
    }
}
