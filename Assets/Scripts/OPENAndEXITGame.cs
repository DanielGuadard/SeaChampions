using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class OPENAndEXITGame : MonoBehaviour
{
    [SerializeField]
    private string filenameTeams, filenameConfig;
    [SerializeField]
    private GameObject teamsContent, teamPref;
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
                    GameObject cardObject = new GameObject();
                    int id = team.deck[i].cardID;
                    switch (id)
                    {
                        case 1:
                            cardObject = FindAvailableCard("AARON THE RAMMING CRAB");
                            break;
                        case 2:
                            cardObject = FindAvailableCard("ADAM RISSO THE DOLPHIN");
                            break;
                        case 3:
                            cardObject = FindAvailableCard("ARSELLA THE SEA NETTLE");
                            break;
                        case 4:
                            cardObject = FindAvailableCard("BOB SAW THE ANCHOVY");
                            break;
                        case 5:
                            cardObject = FindAvailableCard("CAPTAIN COSTA THE MAN O’WAR");
                            break;
                        case 6:
                            cardObject = FindAvailableCard("DANILO THE PIERCING TATUI");
                            break;
                        case 7:
                            cardObject = FindAvailableCard("ED THE PUNK SALMON");
                            break;
                        case 8:
                            cardObject = FindAvailableCard("GARRINCHA THE TOUGH BLUE LOBSTER");
                            break;
                        case 9:
                            cardObject = FindAvailableCard("HANIS THE MANACING FLATFISH");
                            break;
                        case 10:
                            cardObject = FindAvailableCard("IRFAN THE BLADED LOBSTER");
                            break;
                        case 11:
                            cardObject = FindAvailableCard("JOHN FANGO THE TACTICAL");
                            break;
                        case 12:
                            cardObject = FindAvailableCard("JOHNNY THE SAILOR SQUID");
                            break;
                        case 13:
                            cardObject = FindAvailableCard("LIZA THE CARRIER CRAB");
                            break;
                        case 14:
                            cardObject = FindAvailableCard("LOLA THE BUFF BLOWFISH");
                            break;
                        case 15:
                            cardObject = FindAvailableCard("LUKE LEATHERBACK THE TURTLE");
                            break;
                        case 16:
                            cardObject = FindAvailableCard("MAHESH THE SLASHING MACKEREL");
                            break;
                        case 17:
                            cardObject = FindAvailableCard("MEDHANSH THE SWORDSMAN OCTOPUS");
                            break;
                        case 18:
                            cardObject = FindAvailableCard("NENRUNG THE DRAGON");
                            break;
                        case 19:
                            cardObject = FindAvailableCard("RAY THE WHIPPING MANTA");
                            break;
                        case 20:
                            cardObject = FindAvailableCard("REZAUL THE MASTER OCTOPUS");
                            break;
                        case 21:
                            cardObject = FindAvailableCard("RICHARD THE OPPORTUNIST COCKLE");
                            break;
                        case 22:
                            cardObject = FindAvailableCard("RIDLEY THE OLIVE TURTLE");
                            break;
                        case 23:
                            cardObject = FindAvailableCard("ROCUS “SHADES” THE BLUE SHARK");
                            break;
                        case 24:
                            cardObject = FindAvailableCard("SARGEANT HARTMAN THE NAVY SEAL");
                            break;
                        case 25:
                            cardObject = FindAvailableCard("SASHA THE WRESTLING BELUGA");
                            break;
                        case 26:
                            cardObject = FindAvailableCard("SIR WESTLEY THE FENCING DOLPHIN");
                            break;
                        case 27:
                            cardObject = FindAvailableCard("SIRILO THE MARBLED SWIM CRAB");
                            break;
                        case 28:
                            cardObject = FindAvailableCard("SOORYA THE NEEDLING BOX JELLYFISH");
                            break;
                        case 29:
                            cardObject = FindAvailableCard("TED RIGHTY THE BOXER WHALE");
                            break;
                        case 30:
                            cardObject = FindAvailableCard("TISYA THE SPOTTED BLADEMASTER");
                            break;
                        case 31:
                            cardObject = FindAvailableCard("TODD THE BARBER EEL");
                            break;
                        case 32:
                            cardObject = FindAvailableCard("WANDERLEY THE GRAPPLING OCTOPUS");
                            break;
                        case 33:
                            cardObject = FindAvailableCard("ZE PEREIRA THE SANDBAR SHARK");
                            break;
                    }

                    // Filling team with cards

                    GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().team = FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team")[teamsCount];
                    GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().championObj = cardObject;

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
                            cardObject.GetComponent<Item>().OnMouseDown();
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
                            cardObject.GetComponent<Item>().OnMouseDown();
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
                            cardObject.GetComponent<Item>().OnMouseDown();
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
                            cardObject.GetComponent<Item>().OnMouseDown();
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
                            cardObject.GetComponent<Item>().OnMouseDown();
                            break;
                    }
                }
                
                // Filling team's name

                FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "Placeholder_Team")[teamsCount].GetComponent<Text>().text = "Enter new name...";
                FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "TeamName")[teamsCount].GetComponent<Text>().text = team.name;
                FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "InputField_Team")[teamsCount].GetComponent<InputField>().text = team.name;
                teamsCount++;
            }
        }

        // Updating teamsCreated counter in scripts
        GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamsCreated = teamsCount;
        teamsContent.GetComponentInChildren<NewTeams>().teamCreated = teamsCount;

        // Cleaning up the Editor
        for (int i = 0; i < 15; i++)
        {
            Destroy(GameObject.Find("New Game Object"));
        }
    }

    public GameObject FindAvailableCard(string cardName)
    {
        // Looking for a card in available cards loaded from wallet
        foreach (GameObject foundObject in FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), cardName))
        {
            if (foundObject.GetComponent<Item>() && foundObject.GetComponent<Button>().interactable)
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

    public ConfigJSON GetConfig()
    {
        ConfigJSON config = new ConfigJSON((int)FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "Music_Slider").GetComponent<Slider>().value,
            (int)FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "Sound_Slider").GetComponent<Slider>().value,
            FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "Dropdown_Resolution").GetComponent<TMP_Dropdown>().value,
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
        string cardName = "";
        for (int i = 0; i < 5; i++)
        {
            // Getting card's name
            switch (i)
            {
                case 0:
                    cardName = FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team")[teamID].GetComponent<TeamSetItem>().commander.name;
                    break;
                case 1:
                    cardName = FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team")[teamID].GetComponent<TeamSetItem>().crew1.name;
                    break;
                case 2:
                    cardName = FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team")[teamID].GetComponent<TeamSetItem>().crew2.name;
                    break;
                case 3:
                    cardName = FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team")[teamID].GetComponent<TeamSetItem>().crew3.name;
                    break;
                case 4:
                    cardName = FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team")[teamID].GetComponent<TeamSetItem>().crew4.name;
                    break;
            }

            // Assigning card ID according to it's name
            switch (cardName)
            {
                case "AARON THE RAMMING CRAB":
                    id = 1;
                    break;
                case "ADAM RISSO THE DOLPHIN":
                    id = 2;
                    break;
                case "ARSELLA THE SEA NETTLE":
                    id = 3;
                    break;
                case "BOB SAW THE ANCHOVY":
                    id = 4;
                    break;
                case "CAPTAIN COSTA THE MAN O’WAR":
                    id = 5;
                    break;
                case "DANILO THE PIERCING TATUI":
                    id = 6;
                    break;
                case "ED THE PUNK SALMON":
                    id = 7;
                    break;
                case "GARRINCHA THE TOUGH BLUE LOBSTER":
                    id = 8;
                    break;
                case "HANIS THE MANACING FLATFISH":
                    id = 9;
                    break;
                case "IRFAN THE BLADED LOBSTER":
                    id = 10;
                    break;
                case "JOHN FANGO THE TACTICAL":
                    id = 11;
                    break;
                case "JOHNNY THE SAILOR SQUID":
                    id = 12;
                    break;
                case "LIZA THE CARRIER CRAB":
                    id = 13;
                    break;
                case "LOLA THE BUFF BLOWFISH":
                    id = 14;
                    break;
                case "LUKE LEATHERBACK THE TURTLE":
                    id = 15;
                    break;
                case "MAHESH THE SLASHING MACKEREL":
                    id = 16;
                    break;
                case "MEDHANSH THE SWORDSMAN OCTOPUS":
                    id = 17;
                    break;
                case "NENRUNG THE DRAGON":
                    id = 18;
                    break;
                case "RAY THE WHIPPING MANTA":
                    id = 19;
                    break;
                case "REZAUL THE MASTER OCTOPUS":
                    id = 20;
                    break;
                case "RICHARD THE OPPORTUNIST COCKLE":
                    id = 21;
                    break;
                case "RIDLEY THE OLIVE TURTLE":
                    id = 22;
                    break;
                case "ROCUS “SHADES” THE BLUE SHARK":
                    id = 23;
                    break;
                case "SARGEANT HARTMAN THE NAVY SEAL":
                    id = 24;
                    break;
                case "SASHA THE WRESTLING BELUGA":
                    id = 25;
                    break;
                case "SIR WESTLEY THE FENCING DOLPHIN":
                    id = 26;
                    break;
                case "SIRILO THE MARBLED SWIM CRAB":
                    id = 27;
                    break;
                case "SOORYA THE NEEDLING BOX JELLYFISH":
                    id = 28;
                    break;
                case "TED RIGHTY THE BOXER WHALE":
                    id = 29;
                    break;
                case "TISYA THE SPOTTED BLADEMASTER":
                    id = 30;
                    break;
                case "TODD THE BARBER EEL":
                    id = 31;
                    break;
                case "WANDERLEY THE GRAPPLING OCTOPUS":
                    id = 32;
                    break;
                case "ZE PEREIRA THE SANDBAR SHARK":
                    id = 33;
                    break;
            }
            team[i] = new CardJSONFile(id);
        }

        return team;
    }



}
