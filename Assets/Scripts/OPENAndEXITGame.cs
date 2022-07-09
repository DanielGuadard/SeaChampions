using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OPENAndEXITGame : MonoBehaviour
{
    [SerializeField]
    private string filenameTeams, filenameConfig;
    [SerializeField]
    private GameObject teamsContent, teamsContentPlayNow, teamPref, teamPrefPlayNow;
    [SerializeField]
    private GameObject[] slotList;

    private CardListJSONFile[] teams = new CardListJSONFile[3];

    public void LoadTeams()
    {
        teams = JSONHandler.ReadTeamsFromJSON(filenameTeams);

        int teamsCount = 0;
        foreach (CardListJSONFile team in teams)
        {
            if (team.name != "")
            {
                // Creating Team Prefab Clone
                GameObject.Instantiate(teamPref).transform.SetParent(teamsContent.transform, false);

                for (int i = 0; i < 5; i++)
                {
                    GameObject cardObject = FindAvailableCard(team.deck[i].cardID);


                    // Filling team with cards

                    GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().team = FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team")[teamsCount];
                    GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().championObj = cardObject.transform.GetChild(0).gameObject;

                    if (cardObject == null)
                    {
                        FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team")[teamsCount].GetComponent<TeamSetItem>().completed = false;
                        continue;
                    }

                    switch (i)
                    {
                        case 0:
                            // Setting team's commander
                            FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team")[teamsCount].GetComponent<TeamSetItem>().SetCommander();
                            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().crew = 0;
                            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().remove = 
                                FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "Remove_Commander")[teamsCount];
                            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamSlot =
                                FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "Add_commander")[teamsCount];
                            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamImage =
                                FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "ImageC")[teamsCount];
                            cardObject.GetComponentInChildren<Item>().OnMouseDown();
                            cardObject.GetComponentInChildren<Item>().SetCardImage();
                            FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "Add_commander")[teamsCount].GetComponent<Image>().sprite =
                                cardObject.GetComponentInChildren<Item>().GetSprite();
                            break;
                        case 1:
                            // Setting team's crew1
                            FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team")[teamsCount].GetComponent<TeamSetItem>().SetCrew1();
                            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().crew = 1;
                            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().remove =
                                FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "Remove_crew (1)")[teamsCount];
                            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamSlot =
                                FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "Add_crew (1)")[teamsCount];
                            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamImage =
                                FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "Image1")[teamsCount];
                            cardObject.GetComponentInChildren<Item>().OnMouseDown();
                            cardObject.GetComponentInChildren<Item>().SetCardImage();
                            FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "Add_crew (1)")[teamsCount].GetComponent<Image>().sprite =
                                cardObject.GetComponentInChildren<Item>().GetSprite();
                            break;
                        case 2:
                            // Setting team's crew2
                            FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team")[teamsCount].GetComponent<TeamSetItem>().SetCrew2();
                            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().crew = 2;
                            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().remove =
                                FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "Remove_crew (2)")[teamsCount];
                            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamSlot =
                                FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "Add_crew (2)")[teamsCount];
                            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamImage =
                                FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "Image2")[teamsCount];
                            cardObject.GetComponentInChildren<Item>().OnMouseDown();
                            cardObject.GetComponentInChildren<Item>().SetCardImage();
                            FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "Add_crew (2)")[teamsCount].GetComponent<Image>().sprite =
                                cardObject.GetComponentInChildren<Item>().GetSprite();
                            break;
                        case 3:
                            // Setting team's crew3
                            FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team")[teamsCount].GetComponent<TeamSetItem>().SetCrew3();
                            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().crew = 3;
                            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().remove =
                                FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "Remove_crew (3)")[teamsCount];
                            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamSlot =
                                FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "Add_crew (3)")[teamsCount];
                            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamImage =
                                FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "Image3")[teamsCount];
                            cardObject.GetComponentInChildren<Item>().OnMouseDown();
                            cardObject.GetComponentInChildren<Item>().SetCardImage();
                            FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "Add_crew (3)")[teamsCount].GetComponent<Image>().sprite =
                                cardObject.GetComponentInChildren<Item>().GetSprite();
                            break;
                        case 4:
                            // Setting team's crew4
                            FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team")[teamsCount].GetComponent<TeamSetItem>().SetCrew4();
                            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().crew = 4;
                            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().remove =
                                FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "Remove_crew (4)")[teamsCount];
                            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamSlot =
                                FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "Add_crew (4)")[teamsCount];
                            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamImage =
                                FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "Image4")[teamsCount];
                            cardObject.GetComponentInChildren<Item>().OnMouseDown();
                            cardObject.GetComponentInChildren<Item>().SetCardImage();
                            FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "Add_crew (4)")[teamsCount].GetComponent<Image>().sprite =
                                cardObject.GetComponentInChildren<Item>().GetSprite();
                            break;
                    }
                }
                
                // Filling team's name
                FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "Placeholder_Team")[teamsCount].GetComponent<Text>().text = "Enter new name...";
                FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "TeamName")[teamsCount].GetComponent<Text>().text = team.name;
                FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "InputField_Team")[teamsCount].GetComponent<InputField>().text = team.name;

                FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team")[teamsCount].GetComponent<TeamSetItem>().completed = true;

                // Instantiating Play Now menu team
                GameObject.Instantiate(teamPrefPlayNow).transform.SetParent(teamsContentPlayNow.transform, false);
                teamsCount++;
            }
        }

        // Associating teams in two menus
        int teamCount = 0;
        foreach (GameObject team in FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team"))
        {
            FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "playnowteam")[teamCount].GetComponent<PlayNowTeamSetItem>().team = team;
            FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team")[teamCount].GetComponent<TeamSetItem>().CalculateBattlePower();
            teamCount++;
        }

        // Updating teamsCreated counter in scripts
        GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamsCreated = teamsCount;
        teamsContent.GetComponentInChildren<NewTeams>().teamCreated = teamsCount;
    }

    public void NewTeamPlayNow()
    {
        GameObject.Instantiate(teamPrefPlayNow).transform.SetParent(teamsContentPlayNow.transform, false);
        int teamCount = 0;
        foreach (GameObject team in FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team"))
        {
            FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "playnowteam")[teamCount].GetComponent<PlayNowTeamSetItem>().team = team;
            FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team")[teamCount].GetComponent<TeamSetItem>().CalculateBattlePower();
            teamCount++;
        }
    }

    public GameObject FindAvailableCard(int id)
    {
        // Looking for a card in available cards loaded from wallet
        foreach (GameObject foundObject in FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "slot"))
        {
            if (foundObject.GetComponentInChildren<Item>() && foundObject.GetComponentInChildren<Button>().interactable && foundObject.GetComponentInChildren<Item>().id == id)
            {
                return foundObject;
            }
        }
        return null;
    }

    public void ExitGame()
    {
        // Saving teams and settings to JSON
        JSONHandler.SaveTeamsToJSON(GetTeams(), filenameTeams);
        JSONHandler.SaveConfigToJSON(GetConfig(), filenameConfig);

        // Closing the game
        Application.Quit();
    }

    public void SaveTeams()
    {
        JSONHandler.SaveTeamsToJSON(GetTeams(), filenameTeams);
    }

    public void SaveConfig()
    {
        JSONHandler.SaveConfigToJSON(GetConfig(), filenameConfig);
    }

    public ConfigJSON GetConfig()
    {
        ConfigJSON config = new ConfigJSON((int)FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "Music_Slider").GetComponent<Slider>().value,
            (int)FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "Sound_Slider").GetComponent<Slider>().value,
            FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "Dropdown_Resolution").GetComponent<TMP_Dropdown>().value,
            GameObject.Find("ScriptHolder").GetComponent<PlayNow>().gamemode,
            FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "Full_Screen_Toggle").GetComponent<Toggle>().isOn);

        return config;
    }

    public CardListJSONFile[] GetTeams()
    {
        if (FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team") == null)
        {
            return new CardListJSONFile[3];
        }

        int i = 0;

        // Looking for completed teams
        foreach (GameObject team in FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team"))
        {
            if (team.GetComponent<TeamSetItem>().completed)
            {
                GameObject nameObj = team.GetComponent<TeamSetItem>().teamName;
                teams[i].name = nameObj.GetComponent<Text>().text;
                teams[i].deck = GetCards(i);
                i++;
            }
            else
            {
                teams[i].name = "";
                teams[i].deck = new CardJSONFile[5];
            }
        }
        if (i == 0)
        {
            return new CardListJSONFile[3];
        }

        return teams;
    }

    public CardJSONFile[] GetCards(int teamID)
    {
        CardJSONFile[] team = new CardJSONFile[5];
        int id = 0;
        for (int i = 0; i < 5; i++)
        {
            // Getting card's id
            try
            {
                switch (i)
                {
                    case 0:
                        id = FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team")[teamID].GetComponent<TeamSetItem>().commander.GetComponent<Item>().id;
                        break;
                    case 1:
                        id = FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team")[teamID].GetComponent<TeamSetItem>().crew1.GetComponent<Item>().id;
                        break;
                    case 2:
                        id = FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team")[teamID].GetComponent<TeamSetItem>().crew2.GetComponent<Item>().id;
                        break;
                    case 3:
                        id = FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team")[teamID].GetComponent<TeamSetItem>().crew3.GetComponent<Item>().id;
                        break;
                    case 4:
                        id = FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team")[teamID].GetComponent<TeamSetItem>().crew4.GetComponent<Item>().id;
                        break;
                }
            }
            catch (System.NullReferenceException)
            {
                Debug.Log("NullReferenceException in OPENAndEXITGame.cs, try&cath block in public CardJSONFile[] GetCards(int teamID)");
                return new CardJSONFile[0];
            }

            team[i] = new CardJSONFile(id);
        }

        return team;
    }



}
