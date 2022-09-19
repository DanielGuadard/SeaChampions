using UnityEngine;
using UnityEngine.UI;

public class PlayNowTeamSetItem : MonoBehaviour
{

    [SerializeField]
    private GameObject thisTeam, commander, crew1, crew2, crew3, crew4, teamName, inactiveName, incomplete, battlePower, selected, selectButton, SelectedBackGround;

    public GameObject team;

    public bool isSelected, isCompleted;

    void Update()
    {
        SetCommanderImage();
        SetCrew1Image();
        SetCrew2Image();
        SetCrew3Image();
        SetCrew4Image();
        SetTeamName();
        SetIncomplete();
        SetBattlePower();
    }

    public void SetCommanderImage()
    {
        
        {
            commander.GetComponent<Image>().sprite = team.GetComponent<TeamSetItem>().commander.GetComponent<Image>().sprite;
            commander.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        }
    }

    public void SetCrew1Image()
    {
        
            crew1.GetComponent<Image>().sprite = team.GetComponent<TeamSetItem>().crew1.GetComponent<Image>().sprite;
            crew1.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        
    }

    public void SetCrew2Image()
    {
       
            crew2.GetComponent<Image>().sprite = team.GetComponent<TeamSetItem>().crew2.GetComponent<Image>().sprite;
            crew2.GetComponent<Image>().color = new Color(255, 255, 255, 255);
       
    }

    public void SetCrew3Image()
    {
        
        
            crew3.GetComponent<Image>().sprite = team.GetComponent<TeamSetItem>().crew3.GetComponent<Image>().sprite;
            crew3.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        
    }

    public void SetCrew4Image()
    {
       
            crew4.GetComponent<Image>().sprite = team.GetComponent<TeamSetItem>().crew4.GetComponent<Image>().sprite;
            crew4.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        
    }

    public void SetTeamName()
    {
        teamName.GetComponent<Text>().text = team.GetComponent<TeamSetItem>().teamName.GetComponent<Text>().text;
        inactiveName.GetComponent<Text>().text = team.GetComponent<TeamSetItem>().teamName.GetComponent<Text>().text;
    }

    public void SetIncomplete()
    {
        incomplete.SetActive(!team.GetComponent<TeamSetItem>().completed);
        if (team.GetComponent<TeamSetItem>().completed)
        {
            teamName.SetActive(true);
            inactiveName.SetActive(false);
            isCompleted = true;
        }
        else
        {
            teamName.SetActive(false);
            inactiveName.SetActive(true);
            isCompleted = false;
        }
    }

    public void SetBattlePower()
    {
        team.GetComponent<TeamSetItem>().CalculateBattlePower();
        battlePower.GetComponent<Text>().text = "BP: " + team.GetComponent<TeamSetItem>().battlePowerTeam;
    }

    public void OnClick()
    {
        int teamCount = 0;
        int selectedTeams = 0;
        foreach (GameObject playnowteam in FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "playnowteam"))
        {
            if (playnowteam.GetComponent<PlayNowTeamSetItem>().isSelected)
            {
                selectedTeams++;

            }
            teamCount++;
        }
        if (selectedTeams == 0)
        {
            isSelected = true;
            selected.SetActive(true);
            selectButton.GetComponentInChildren<Text>().text = "Unselect";
<<<<<<< HEAD
            GameObject.Find("ScriptHolder").GetComponent<TrainingMode>().ACommander = team.GetComponent<TeamSetItem>().commander;
            GameObject.Find("ScriptHolder").GetComponent<TrainingMode>().TeamAActive = team.GetComponent<TeamSetItem>().commander;
            GameObject.Find("ScriptHolder").GetComponent<TrainingMode>().ACrew1 = team.GetComponent<TeamSetItem>().crew1;
            GameObject.Find("ScriptHolder").GetComponent<TrainingMode>().ACrew2 = team.GetComponent<TeamSetItem>().crew2;
            GameObject.Find("ScriptHolder").GetComponent<TrainingMode>().ACrew3 = team.GetComponent<TeamSetItem>().crew3; 
            GameObject.Find("ScriptHolder").GetComponent<TrainingMode>().ACrew4 = team.GetComponent<TeamSetItem>().crew4; 
=======
           
            GameObject.Find("ScriptHolder").GetComponent<TrainingMode>().ACommander = team.GetComponent<TeamSetItem>().commander;           
            GameObject.Find("ScriptHolder").GetComponent<TrainingMode>().ACrew1 = team.GetComponent<TeamSetItem>().crew1;
            GameObject.Find("ScriptHolder").GetComponent<TrainingMode>().ACrew2 = team.GetComponent<TeamSetItem>().crew2;
            GameObject.Find("ScriptHolder").GetComponent<TrainingMode>().ACrew3 = team.GetComponent<TeamSetItem>().crew3; 
            GameObject.Find("ScriptHolder").GetComponent<TrainingMode>().ACrew4 = team.GetComponent<TeamSetItem>().crew4;
            SelectedBackGround.SetActive(true);
            //GameObject.Find("ScriptHolder").GetComponent<TrainingMode>().Invoke("",1);


>>>>>>> ec07000c922841ccd5b3d99020a37826fa097aaf
        }
        else if (selectedTeams == 1)
        {
            if (isSelected)
            {
                isSelected = false;
                selected.SetActive(false);
                selectButton.GetComponentInChildren<Text>().text = "Select";
                SelectedBackGround.SetActive(false);
            }
        }
    }

    public void DeleteTeam()
    {
        team.GetComponent<TeamSetItem>().RemoveC();
        team.GetComponent<TeamSetItem>().Remove1();
        team.GetComponent<TeamSetItem>().Remove2();
        team.GetComponent<TeamSetItem>().Remove3();
        team.GetComponent<TeamSetItem>().Remove4();
        team.GetComponent<TeamSetItem>().completed = false;
        teamName.GetComponent<Text>().text = "";
        team.GetComponent<TeamSetItem>().teamName.GetComponent<Text>().text = "";

        Destroy(thisTeam);
        Destroy(team);
        GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamsCreated--;
    }

}
