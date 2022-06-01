using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OPENAndEXITGame : MonoBehaviour
{
    [SerializeField]
    private string filenameTeams, filenameConfig;
    [SerializeField]
    private GameObject teamsContent, teamPref;
    [SerializeField]
    private GameObject[] slotList;

    private CardListJSONFile[] teams = new CardListJSONFile[3];

    private bool loaded;

    private void Start()
    {
        loaded = false;
    }

    public void LoadTeams()
    {
        if (!loaded)
        {
            teams = JSONHandler.ReadTeamsFromJSON(filenameTeams);

            int teamsCount = 0;
            int id = 0;

            foreach (CardListJSONFile team in teams)
            {
                if (team.name != "")
                {
                    GameObject.Instantiate(teamPref).transform.SetParent(teamsContent.transform, false);

                    for (int i = 0; i < 5; i++)
                    {
                        GameObject cardObject = new GameObject();
                        id = team.deck[i].cardID;
                        switch (id)
                        {
                            case 1:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "AARON THE RAMMING CRAB");
                                break;
                            case 2:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "ADAM RISSO THE DOLPHIN");
                                break;
                            case 3:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "ARSELLA THE SEA NETTLE");
                                break;
                            case 4:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "BOB SAW THE ANCHOVY");
                                break;
                            case 5:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "CAPTAIN COSTA THE MAN O’WAR");
                                break;
                            case 6:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "DANILO THE PIERCING TATUI");
                                break;
                            case 7:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "ED THE PUNK SALMON");
                                break;
                            case 8:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "GARRINCHA THE TOUGH BLUE LOBSTER");
                                break;
                            case 9:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "HANIS THE MANACING FLATFISH");
                                break;
                            case 10:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "IRFAN THE BLADED LOBSTER");
                                break;
                            case 11:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "JOHN FANGO THE TACTICAL");
                                break;
                            case 12:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "JOHNNY THE SAILOR SQUID");
                                break;
                            case 13:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "LIZA THE CARRIER CRAB");
                                break;
                            case 14:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "LOLA THE BUFF BLOWFISH");
                                break;
                            case 15:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "LUKE LEATHERBACK THE TURTLE");
                                break;
                            case 16:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "MAHESH THE SLASHING MACKEREL");
                                break;
                            case 17:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "MEDHANSH THE SWORDSMAN OCTOPUS");
                                break;
                            case 18:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "NENRUNG THE DRAGON");
                                break;
                            case 19:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "RAY THE WHIPPING MANTA");
                                break;
                            case 20:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "REZAUL THE MASTER OCTOPUS");
                                break;
                            case 21:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "RICHARD THE OPPORTUNIST COCKLE");
                                break;
                            case 22:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "RIDLEY THE OLIVE TURTLE");
                                break;
                            case 23:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "ROCUS “SHADES” THE BLUE SHARK");
                                break;
                            case 24:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "SARGEANT HARTMAN THE NAVY SEAL");
                                break;
                            case 25:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "SASHA THE WRESTLING BELUGA");
                                break;
                            case 26:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "SIR WESTLEY THE FENCING DOLPHIN");
                                break;
                            case 27:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "SIRILO THE MARBLED SWIM CRAB");
                                break;
                            case 28:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "SOORYA THE NEEDLING BOX JELLYFISH");
                                break;
                            case 29:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "TED RIGHTY THE BOXER WHALE");
                                break;
                            case 30:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "TISYA THE SPOTTED BLADEMASTER");
                                break;
                            case 31:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "TODD THE BARBER EEL");
                                break;
                            case 32:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "WANDERLEY THE GRAPPLING OCTOPUS");
                                break;
                            case 33:
                                cardObject = FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "ZE PEREIRA THE SANDBAR SHARK");
                                break;
                        }

                        switch (i)
                        {
                            case 0:
                                // Setting team's commander
                                
                                break;
                            case 1:
                                // Setting team's crew1
                                
                                break;
                            case 2:
                                // Setting team's crew2
                                
                                break;
                            case 3:
                                // Setting team's crew3
                                
                                break;
                            case 4:
                                // Setting team's crew4
                                
                                break;
                        }

                        FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "TeamName")[teamsCount].GetComponent<Text>().text = team.name;
                        FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "Placeholder_Team")[teamsCount].GetComponent<Text>().text = team.name;
                        teamsCount++;
                    }
                }
            }

            // Updating teamsCreated counter in scripts
            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamsCreated = teamsCount;
            teamsContent.GetComponentInChildren<NewTeams>().teamCreated = teamsCount;
            loaded = true;
        }
    }

    public void ExitGame()
    {
        // Saving teams and settings to JSON
        JSONHandler.SaveTeamsToJSON(GetTeams(), filenameTeams);
        JSONHandler.SaveConfigToJSON(GetConfig(), filenameConfig);

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
        int i = 0;
        foreach (GameObject team in FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team"))
        {
            if (team.GetComponent<TeamSetItem>().completed)
            {
                GameObject nameObj = team.GetComponent<TeamSetItem>().teamName;
                teams[i].name = nameObj.GetComponent<Text>().text;
                teams[i].deck = GetCards(i);
            }
            i++;
        }
        if (FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "team").Length == 0)
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
