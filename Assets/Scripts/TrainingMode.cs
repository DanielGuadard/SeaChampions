using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TrainingMode : MonoBehaviour
{
    public float Timer;
    [SerializeField]
    private float TotalBpTeamA, TotalBpTeamB;
    [SerializeField]
    private int PollutionLevel, PressureLevel, Match, MatchA, MatchB, Round, RoundA,RoundB, ActionA, ActionB, CleanPlus;

    public bool Started, ConfirmationButton, SwitchActionA, SwitchActionB, OnSwitch,A1, ValidCrewA1, ValidCrewA2, ValidCrewA3, ValidCrewA4, ValidCrewB1, ValidCrewB2, ValidCrewB3, ValidCrewB4;
    public string tribe, ChampionName, Name;
    public float speed, smooth, PointearC;
    public int PositionA, PositionB, Dificult, Current, Fail;

    [SerializeField]
    private float AidealPressure, Aagility, Abrawl, Acunning, BIdealPressure, BAgility, BBrawl, BCunning, Abig, Bbig;
    [SerializeField]
    private int LastActionA,LastActionB;

    [SerializeField]
    private GameObject TimerObj, PollutionText, PressureCompass, RoundTextA, RoundTextB,RoundA1, RoundA2, RoundA3, RoundB1, RoundB2, RoundB3, Pointier, Motor, CardChampion, Pollution1, Pollution2, Pollution3, Pollution4, Pollution5, Pollution6, Pollution7;
    [SerializeField]
    private GameObject MatchCount, Match1, Match2, Match3, Match4, Match5,Alert;
    [SerializeField]
    private Sprite RoundWin, RoundLose, RoundNone, MatchWin, MatchLose, MatchNone, MatchCount1, MatchCount2, MatchCount3, MatchCount4, MatchCount5;
    [SerializeField]
    private bool StartPreparation;
    [SerializeField]
    private string Ocean;

    private float BPlow, BPhigh;

    [SerializeField]
    private GameObject BigAtributeA, BigAtributeB, AagilityPlate, AbrawlPlate, AcunningPlate, BagilityPlate, BbrawlPlate, BcunningPlate;
    [SerializeField]
    private GameObject FlagA, FlagB;
    [SerializeField]
    private Sprite FlagBrazil, FlagIndian, FlagIndonesia, FlagUk, FlagUsa;


    public GameObject ACommander, ACrew1, ACrew2, ACrew3, ACrew4;
    public GameObject TeamAActive, TeamACrew1, TeamACrew2, TeamACrew3, TeamACrew4;
    //public GameObject BCommander, BCrew1,BCrew2, BCrew3, BCrew4;
    public GameObject TeamBActive, TeamBCrew1, TeamBCrew2, TeamBCrew3, TeamBCrew4;
    public GameObject IdealPressureA1, IdealPressureA2, IdealPressureA3, IdealPressureA4, IdealPressureA5;
    public GameObject IdealPressureB1, IdealPressureB2, IdealPressureB3, IdealPressureB4, IdealPressureB5;
    public GameObject TeamAActiveName, teamBActiveName, OceanName, CurrentText, ChampionSelection,MatchOverlay,MatchText;
    public GameObject levelA, MedalIconA, LevelB, MedalIconB, TribeA, TribeB, HabilityA, habilityB, BrawnA, AgilityA, CunningA, BrawnB, AgilityB, CunningB;
    public Sprite TribecaseManylimbs, TribeSeasinger, TribeClawbeasts, TribeRoughskins, TribeJellies, TribeShellbearers, TribeScalefins, Common, Uncommon, Rare, RareVery, Legendary;
    public Sprite JOHN_FANGO, CAPTAIN, TED, NENRUNG, REZAUL, GARRINCHA, LUKE, RAY, SIR_WESTLEY, LIZA, HANIS, SARGEANT_HARTMAN, RIDLEY, ARSELLA,
   ROCUS, AARON, WANDERLEY, LOLA, TODD, JOHNNY, SOORYA, IRFAN, DANILO, ZEPEREIRA, BOB_SAW, TISYA, SASHA, MEDHANSH, SIRILO, MAHESH,
   RICHARD, ED, ADAM;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Started == true)
        {
            if (Timer > 0)

            {
                Timer -= Time.deltaTime;
                UpdateDisplay(Timer);
            }

            else
            {
                Timer = 0;
            }


            switch (PressureLevel)
            {
                case 1:
                    PointierRotation(105);
                    break;

                case 2:
                    PointierRotation(55);
                    break;

                case 3:
                    PointierRotation(0);
                    break;

                case 4:

                    PointierRotation(-55);
                    break;

                case 5:
                    PointierRotation(-110);
                    break;
            }
        }



    }
    public void SetPreparation()
    {
        Match = 1;
        MatchCount.GetComponent<Image>().sprite = MatchCount1;
        Round =1;
        Timer = 45;
        PollutionLevel = 0;
        SetupPlayerCards(TeamAActive, TeamACrew1, TeamACrew2, TeamACrew3, TeamACrew4);
        GetBotCards();
        UpdateImage();
        SetOceanPressure();
        SetCurrent();
        Pollution();

    }


    public void SetupPlayerCards(GameObject commander, GameObject crew1, GameObject crew2, GameObject crew3, GameObject crew4)
    {
        commander.GetComponent<SimpleCard>().name = ACommander.GetComponent<Item>().name;
        commander.GetComponent<SimpleCard>().agility = ACommander.GetComponent<Item>().agility;
        commander.GetComponent<SimpleCard>().brawl = ACommander.GetComponent<Item>().brawl;
        commander.GetComponent<SimpleCard>().cunning = ACommander.GetComponent<Item>().cunning;
        commander.GetComponent<SimpleCard>().idealPressure = ACommander.GetComponent<Item>().idealPressure;
        commander.GetComponent<SimpleCard>().tribe = ACommander.GetComponent<Item>().tribe;
        commander.GetComponent<SimpleCard>().rarity = ACommander.GetComponent<Item>().rarity;

        crew1.GetComponent<SimpleCard>().name = ACrew1.GetComponent<Item>().name;
        crew1.GetComponent<SimpleCard>().agility = ACrew1.GetComponent<Item>().agility;
        crew1.GetComponent<SimpleCard>().brawl = ACrew1.GetComponent<Item>().brawl;
        crew1.GetComponent<SimpleCard>().cunning = ACrew1.GetComponent<Item>().cunning;
        crew1.GetComponent<SimpleCard>().idealPressure = ACrew1.GetComponent<Item>().idealPressure;
        crew1.GetComponent<SimpleCard>().tribe = ACrew1.GetComponent<Item>().tribe;
        crew1.GetComponent<SimpleCard>().rarity = ACrew1.GetComponent<Item>().rarity;

        crew2.GetComponent<SimpleCard>().name = ACrew2.GetComponent<Item>().name;
        crew2.GetComponent<SimpleCard>().agility = ACrew2.GetComponent<Item>().agility;
        crew2.GetComponent<SimpleCard>().brawl = ACrew2.GetComponent<Item>().brawl;
        crew2.GetComponent<SimpleCard>().cunning = ACrew2.GetComponent<Item>().cunning;
        crew2.GetComponent<SimpleCard>().idealPressure = ACrew2.GetComponent<Item>().idealPressure;
        crew2.GetComponent<SimpleCard>().tribe = ACrew2.GetComponent<Item>().tribe;
        crew2.GetComponent<SimpleCard>().rarity = ACrew2.GetComponent<Item>().rarity;

        crew3.GetComponent<SimpleCard>().name = ACrew3.GetComponent<Item>().name;
        crew3.GetComponent<SimpleCard>().agility = ACrew3.GetComponent<Item>().agility;
        crew3.GetComponent<SimpleCard>().brawl = ACrew3.GetComponent<Item>().brawl;
        crew3.GetComponent<SimpleCard>().cunning = ACrew3.GetComponent<Item>().cunning;
        crew3.GetComponent<SimpleCard>().idealPressure = ACrew3.GetComponent<Item>().idealPressure;
        crew3.GetComponent<SimpleCard>().tribe = ACrew3.GetComponent<Item>().tribe;
        crew3.GetComponent<SimpleCard>().rarity = ACrew3.GetComponent<Item>().rarity;

        crew4.GetComponent<SimpleCard>().name = ACrew4.GetComponent<Item>().name;
        crew4.GetComponent<SimpleCard>().agility = ACrew4.GetComponent<Item>().agility;
        crew4.GetComponent<SimpleCard>().brawl = ACrew4.GetComponent<Item>().brawl;
        crew4.GetComponent<SimpleCard>().cunning = ACrew4.GetComponent<Item>().cunning;
        crew4.GetComponent<SimpleCard>().idealPressure = ACrew4.GetComponent<Item>().idealPressure;
        crew4.GetComponent<SimpleCard>().tribe = ACrew4.GetComponent<Item>().tribe;
        crew4.GetComponent<SimpleCard>().rarity = ACrew4.GetComponent<Item>().rarity;
    }
    public void Pollution()
    {
        if (PollutionLevel == 0)
        {
            Pollution1.SetActive(false);
            Pollution2.SetActive(false);
            Pollution3.SetActive(false);
            Pollution4.SetActive(false);
            Pollution5.SetActive(false);
            Pollution6.SetActive(false);
            Pollution7.SetActive(false);
        }
        if (PollutionLevel == 1)
        {
            Pollution1.SetActive(true);
            Pollution2.SetActive(false);
            Pollution3.SetActive(false);
            Pollution4.SetActive(false);
            Pollution5.SetActive(false);
            Pollution6.SetActive(false);
            Pollution7.SetActive(false);
        }
        if (PollutionLevel == 2)
        {
            Pollution1.SetActive(true);
            Pollution2.SetActive(true);
            Pollution3.SetActive(false);
            Pollution4.SetActive(false);
            Pollution5.SetActive(false);
            Pollution6.SetActive(false);
            Pollution7.SetActive(false);
        }
        if (PollutionLevel == 3)
        {
            Pollution1.SetActive(true);
            Pollution2.SetActive(true);
            Pollution3.SetActive(true);
            Pollution4.SetActive(false);
            Pollution5.SetActive(false);
            Pollution6.SetActive(false);
            Pollution7.SetActive(false);
        }
        if (PollutionLevel == 4)
        {
            Pollution1.SetActive(true);
            Pollution2.SetActive(true);
            Pollution3.SetActive(true);
            Pollution4.SetActive(true);
            Pollution5.SetActive(false);
            Pollution6.SetActive(false);
            Pollution7.SetActive(false);
        }
        if (PollutionLevel == 5)
        {
            Pollution1.SetActive(true);
            Pollution2.SetActive(true);
            Pollution3.SetActive(true);
            Pollution4.SetActive(true);
            Pollution5.SetActive(true);
            Pollution6.SetActive(false);
            Pollution7.SetActive(false);
        }
        if (PollutionLevel == 6)
        {
            Pollution1.SetActive(true);
            Pollution2.SetActive(true);
            Pollution3.SetActive(true);
            Pollution4.SetActive(true);
            Pollution5.SetActive(true);
            Pollution6.SetActive(true);
            Pollution7.SetActive(false);
        }
        if (PollutionLevel == 7)
        {
            Pollution1.SetActive(true);
            Pollution2.SetActive(true);
            Pollution3.SetActive(true);
            Pollution4.SetActive(true);
            Pollution5.SetActive(true);
            Pollution6.SetActive(true);
            Pollution7.SetActive(true);
        }
        PollutionText.GetComponent<Text>().text = (-1 * (PollutionLevel * 5)).ToString();
    }
    public void UpdateImage()
    {

        UpdateActiveChampionB();
        UpdateActiveChampion();
        UpdateChampionImage(TeamACrew1);
        UpdateChampionImage(TeamACrew2);
        UpdateChampionImage(TeamACrew3);
        UpdateChampionImage(TeamACrew4);
        UpdateChampionImage(TeamBCrew1);
        UpdateChampionImage(TeamBCrew2);
        UpdateChampionImage(TeamBCrew3);
        UpdateChampionImage(TeamBCrew4);
    }

    public void PointierRotation(int Target)
    {
        var TargetF = Quaternion.Euler(Pointier.transform.eulerAngles.y, Pointier.transform.eulerAngles.x, Target);
        Pointier.transform.rotation = Quaternion.Lerp(Pointier.transform.rotation, TargetF, Time.deltaTime * smooth);
    }

    //Timer relateted funcitions
    void ResetTimer()
    {
        Timer = 45;
    }
    private void UpdateDisplay(float Timer)
    {
        float seconds = Mathf.FloorToInt(Timer % 60);

        string secondsText = seconds.ToString();
        if (seconds < 0) secondsText = ("0");
        TimerObj.GetComponent<Text>().text = secondsText;
        if (seconds > 30) { TimerObj.GetComponent<Text>().color = Color.green; }
        if (seconds > 15 & seconds < 30) { TimerObj.GetComponent<Text>().color = Color.yellow; }
        if (seconds <= 15) { TimerObj.GetComponent<Text>().color = Color.red; }

    }


    //Action Button
    public void Tribeskill() { ActionA = 1; }
    public void GoDown() { ActionA = 2; }
    public void GoUp() { ActionA = 3; }
    public void Cleaning() { ActionA = 4; }
    public void CleaningPlus() { ActionA = 5; }
    public void Switch()
    {
        ActionA = 6;
        ChampionSelection.SetActive(true);
        OnSwitch = true;
    }

    //--------------
    public void SwitchCardsA()
    {
        if (PositionA == 1 & ValidCrewA1 == false) { PositionA = 0; }
        if (PositionA == 2 & ValidCrewA2 == false) { PositionA = 0; }
        if (PositionA == 3 & ValidCrewA3 == false) { PositionA = 0; }
        if (PositionA == 4 & ValidCrewA4 == false) { PositionA = 0; }

        Button crew1;
        //Store information on local variable
        string Activename = TeamAActive.GetComponent<SimpleCard>().name;
        float Activeagility = TeamAActive.GetComponent<SimpleCard>().agility;
        float Activebrawl = TeamAActive.GetComponent<SimpleCard>().brawl;
        float Activecunning = TeamAActive.GetComponent<SimpleCard>().cunning;
        int ActiveidealPressure = TeamAActive.GetComponent<SimpleCard>().idealPressure;
        string ActiveTribe = TeamAActive.GetComponent<SimpleCard>().tribe;
        string ActiveRarity = TeamAActive.GetComponent<SimpleCard>().rarity;
        switch (PositionA)
        {
            case 0:
                ActionA = 0;
                break;
            case 1:
                //Get the choosen champion to active combate position
                TeamAActive.GetComponent<SimpleCard>().name = TeamACrew1.GetComponent<SimpleCard>().name;
                TeamAActive.GetComponent<SimpleCard>().agility = TeamACrew1.GetComponent<SimpleCard>().agility;
                TeamAActive.GetComponent<SimpleCard>().brawl = TeamACrew1.GetComponent<SimpleCard>().brawl;
                TeamAActive.GetComponent<SimpleCard>().cunning = TeamACrew1.GetComponent<SimpleCard>().cunning;
                TeamAActive.GetComponent<SimpleCard>().idealPressure = TeamACrew1.GetComponent<SimpleCard>().idealPressure;
                TeamAActive.GetComponent<SimpleCard>().tribe = TeamACrew1.GetComponent<SimpleCard>().tribe;
                TeamAActive.GetComponent<SimpleCard>().rarity = TeamACrew1.GetComponent<SimpleCard>().rarity;
                //Get the local saved Champion to the reserve bench
                TeamACrew1.GetComponent<SimpleCard>().name = Activename;
                TeamACrew1.GetComponent<SimpleCard>().agility = Activeagility;
                TeamACrew1.GetComponent<SimpleCard>().brawl = Activebrawl;
                TeamACrew1.GetComponent<SimpleCard>().cunning = Activecunning;
                TeamACrew1.GetComponent<SimpleCard>().idealPressure = ActiveidealPressure;
                TeamACrew1.GetComponent<SimpleCard>().tribe = ActiveTribe;
                TeamACrew1.GetComponent<SimpleCard>().rarity = ActiveRarity;
                ValidCrewA1 = false;
                break;
            case 2:
                TeamAActive.GetComponent<SimpleCard>().name = TeamACrew2.GetComponent<SimpleCard>().name;
                TeamAActive.GetComponent<SimpleCard>().agility = TeamACrew2.GetComponent<SimpleCard>().agility;
                TeamAActive.GetComponent<SimpleCard>().brawl = TeamACrew2.GetComponent<SimpleCard>().brawl;
                TeamAActive.GetComponent<SimpleCard>().cunning = TeamACrew2.GetComponent<SimpleCard>().cunning;
                TeamAActive.GetComponent<SimpleCard>().idealPressure = TeamACrew2.GetComponent<SimpleCard>().idealPressure;
                TeamAActive.GetComponent<SimpleCard>().tribe = TeamACrew2.GetComponent<SimpleCard>().tribe;
                TeamAActive.GetComponent<SimpleCard>().rarity = TeamACrew2.GetComponent<SimpleCard>().rarity;

                TeamACrew2.GetComponent<SimpleCard>().name = Activename;
                TeamACrew2.GetComponent<SimpleCard>().agility = Activeagility;
                TeamACrew2.GetComponent<SimpleCard>().brawl = Activebrawl;
                TeamACrew2.GetComponent<SimpleCard>().cunning = Activecunning;
                TeamACrew2.GetComponent<SimpleCard>().idealPressure = ActiveidealPressure;
                TeamACrew2.GetComponent<SimpleCard>().tribe = ActiveTribe;
                TeamACrew2.GetComponent<SimpleCard>().rarity = ActiveRarity;
                ValidCrewA2 = false;
                break;
            case 3:
                TeamAActive.GetComponent<SimpleCard>().name = TeamACrew3.GetComponent<SimpleCard>().name;
                TeamAActive.GetComponent<SimpleCard>().agility = TeamACrew3.GetComponent<SimpleCard>().agility;
                TeamAActive.GetComponent<SimpleCard>().brawl = TeamACrew3.GetComponent<SimpleCard>().brawl;
                TeamAActive.GetComponent<SimpleCard>().cunning = TeamACrew3.GetComponent<SimpleCard>().cunning;
                TeamAActive.GetComponent<SimpleCard>().idealPressure = TeamACrew3.GetComponent<SimpleCard>().idealPressure;
                TeamAActive.GetComponent<SimpleCard>().tribe = TeamACrew3.GetComponent<SimpleCard>().tribe;
                TeamAActive.GetComponent<SimpleCard>().rarity = TeamACrew3.GetComponent<SimpleCard>().rarity;

                TeamACrew3.GetComponent<SimpleCard>().name = Activename;
                TeamACrew3.GetComponent<SimpleCard>().agility = Activeagility;
                TeamACrew3.GetComponent<SimpleCard>().brawl = Activebrawl;
                TeamACrew3.GetComponent<SimpleCard>().cunning = Activecunning;
                TeamACrew3.GetComponent<SimpleCard>().idealPressure = ActiveidealPressure;
                TeamACrew3.GetComponent<SimpleCard>().tribe = ActiveTribe;
                TeamACrew3.GetComponent<SimpleCard>().rarity = ActiveRarity;
                ValidCrewA3 = false;
                break;
            case 4:
                TeamAActive.GetComponent<SimpleCard>().name = TeamACrew4.GetComponent<SimpleCard>().name;
                TeamAActive.GetComponent<SimpleCard>().agility = TeamACrew4.GetComponent<SimpleCard>().agility;
                TeamAActive.GetComponent<SimpleCard>().brawl = TeamACrew4.GetComponent<SimpleCard>().brawl;
                TeamAActive.GetComponent<SimpleCard>().cunning = TeamACrew4.GetComponent<SimpleCard>().cunning;
                TeamAActive.GetComponent<SimpleCard>().idealPressure = TeamACrew4.GetComponent<SimpleCard>().idealPressure;
                TeamAActive.GetComponent<SimpleCard>().tribe = TeamACrew4.GetComponent<SimpleCard>().tribe;
                TeamAActive.GetComponent<SimpleCard>().rarity = TeamACrew4.GetComponent<SimpleCard>().rarity;

                TeamACrew4.GetComponent<SimpleCard>().name = Activename;
                TeamACrew4.GetComponent<SimpleCard>().agility = Activeagility;
                TeamACrew4.GetComponent<SimpleCard>().brawl = Activebrawl;
                TeamACrew4.GetComponent<SimpleCard>().cunning = Activecunning;
                TeamACrew4.GetComponent<SimpleCard>().idealPressure = ActiveidealPressure;
                TeamACrew4.GetComponent<SimpleCard>().tribe = ActiveTribe;
                TeamACrew4.GetComponent<SimpleCard>().rarity = ActiveRarity;
                ValidCrewA4 = false;
                break;
        }

    }
    public void SwitchCardsB()
    {
        //Store information on local variable
        string Activename = TeamBActive.GetComponent<SimpleCard>().name;
        float Activeagility = TeamBActive.GetComponent<SimpleCard>().agility;
        float Activebrawl = TeamBActive.GetComponent<SimpleCard>().brawl;
        float Activecunning = TeamBActive.GetComponent<SimpleCard>().cunning;
        int ActiveidealPressure = TeamBActive.GetComponent<SimpleCard>().idealPressure;
        string ActiveTribe = TeamBActive.GetComponent<SimpleCard>().tribe;
        string ActiveRarity = TeamBActive.GetComponent<SimpleCard>().rarity;

        switch (PositionB)
        {
            case 1:
                //Get the choosen champion to active combate position
                TeamBActive.GetComponent<SimpleCard>().name = TeamACrew1.GetComponent<Item>().name;
                TeamBActive.GetComponent<SimpleCard>().agility = TeamACrew1.GetComponent<Item>().agility;
                TeamBActive.GetComponent<SimpleCard>().brawl = TeamACrew1.GetComponent<Item>().brawl;
                TeamBActive.GetComponent<SimpleCard>().cunning = TeamACrew1.GetComponent<Item>().cunning;
                TeamBActive.GetComponent<SimpleCard>().idealPressure = TeamACrew1.GetComponent<Item>().idealPressure;
                TeamBActive.GetComponent<SimpleCard>().tribe = TeamACrew1.GetComponent<Item>().tribe;
                TeamBActive.GetComponent<SimpleCard>().rarity = TeamACrew1.GetComponent<Item>().rarity;
                //Get the local saved Champion to the reserve bench
                TeamBCrew1.GetComponent<SimpleCard>().name = Activename;
                TeamBCrew1.GetComponent<SimpleCard>().agility = Activeagility;
                TeamBCrew1.GetComponent<SimpleCard>().brawl = Activebrawl;
                TeamBCrew1.GetComponent<SimpleCard>().cunning = Activecunning;
                TeamBCrew1.GetComponent<SimpleCard>().idealPressure = ActiveidealPressure;
                TeamBCrew1.GetComponent<SimpleCard>().tribe = ActiveTribe;
                TeamBCrew1.GetComponent<SimpleCard>().rarity = ActiveRarity;
                ValidCrewB1 = false;
                break;
            case 2:
                TeamBActive.GetComponent<SimpleCard>().name = TeamACrew2.GetComponent<Item>().name;
                TeamBActive.GetComponent<SimpleCard>().agility = TeamACrew2.GetComponent<Item>().agility;
                TeamBActive.GetComponent<SimpleCard>().brawl = TeamACrew2.GetComponent<Item>().brawl;
                TeamBActive.GetComponent<SimpleCard>().cunning = TeamACrew2.GetComponent<Item>().cunning;
                TeamBActive.GetComponent<SimpleCard>().idealPressure = TeamACrew2.GetComponent<Item>().idealPressure;
                TeamBActive.GetComponent<SimpleCard>().tribe = TeamACrew2.GetComponent<Item>().tribe;
                TeamBActive.GetComponent<SimpleCard>().rarity = TeamACrew2.GetComponent<Item>().rarity;

                TeamBCrew2.GetComponent<SimpleCard>().name = Activename;
                TeamBCrew2.GetComponent<SimpleCard>().agility = Activeagility;
                TeamBCrew2.GetComponent<SimpleCard>().brawl = Activebrawl;
                TeamBCrew2.GetComponent<SimpleCard>().cunning = Activecunning;
                TeamBCrew2.GetComponent<SimpleCard>().idealPressure = ActiveidealPressure;
                TeamBCrew2.GetComponent<SimpleCard>().tribe = ActiveTribe;
                TeamBCrew2.GetComponent<SimpleCard>().rarity = ActiveRarity;
                ValidCrewB2 = false;
                break;
            case 3:
                TeamBActive.GetComponent<SimpleCard>().name = TeamACrew3.GetComponent<Item>().name;
                TeamBActive.GetComponent<SimpleCard>().agility = TeamACrew3.GetComponent<Item>().agility;
                TeamBActive.GetComponent<SimpleCard>().brawl = TeamACrew3.GetComponent<Item>().brawl;
                TeamBActive.GetComponent<SimpleCard>().cunning = TeamACrew3.GetComponent<Item>().cunning;
                TeamBActive.GetComponent<SimpleCard>().idealPressure = TeamACrew3.GetComponent<Item>().idealPressure;
                TeamBActive.GetComponent<SimpleCard>().tribe = TeamACrew3.GetComponent<Item>().tribe;
                TeamBActive.GetComponent<SimpleCard>().rarity = TeamACrew3.GetComponent<Item>().rarity;

                TeamBCrew3.GetComponent<SimpleCard>().name = Activename;
                TeamBCrew3.GetComponent<SimpleCard>().agility = Activeagility;
                TeamBCrew3.GetComponent<SimpleCard>().brawl = Activebrawl;
                TeamBCrew3.GetComponent<SimpleCard>().cunning = Activecunning;
                TeamBCrew3.GetComponent<SimpleCard>().idealPressure = ActiveidealPressure;
                TeamBCrew3.GetComponent<SimpleCard>().tribe = ActiveTribe;
                TeamBCrew3.GetComponent<SimpleCard>().rarity = ActiveRarity;
                ValidCrewB3 = false;
                break;
            case 4:
                TeamBActive.GetComponent<SimpleCard>().name = TeamACrew4.GetComponent<Item>().name;
                TeamBActive.GetComponent<SimpleCard>().agility = TeamACrew4.GetComponent<Item>().agility;
                TeamBActive.GetComponent<SimpleCard>().brawl = TeamACrew4.GetComponent<Item>().brawl;
                TeamBActive.GetComponent<SimpleCard>().cunning = TeamACrew4.GetComponent<Item>().cunning;
                TeamBActive.GetComponent<SimpleCard>().idealPressure = TeamACrew4.GetComponent<Item>().idealPressure;
                TeamBActive.GetComponent<SimpleCard>().tribe = TeamACrew4.GetComponent<Item>().tribe;
                TeamBActive.GetComponent<SimpleCard>().rarity = TeamACrew4.GetComponent<Item>().rarity;

                TeamBCrew4.GetComponent<SimpleCard>().name = Activename;
                TeamBCrew4.GetComponent<SimpleCard>().agility = Activeagility;
                TeamBCrew4.GetComponent<SimpleCard>().brawl = Activebrawl;
                TeamBCrew4.GetComponent<SimpleCard>().cunning = Activecunning;
                TeamBCrew4.GetComponent<SimpleCard>().idealPressure = ActiveidealPressure;
                TeamBCrew4.GetComponent<SimpleCard>().tribe = ActiveTribe;
                TeamBCrew4.GetComponent<SimpleCard>().rarity = ActiveRarity;
                ValidCrewB4 = false;
                break;
        }
    }
    //---------------

    //Starte and end funciontio
    public void Starter()
    {
        Started = true;

    }
    public void Ended()
    {
        Started = false;
    }



    //Main function to Update The visual of the card on Fight
    public void UpdateActiveChampion()
    {
        UpdateAtributes();
        UpdateTribeIcon();
        UpdateChampionPressure();
        UpdateChampionImage(TeamAActive);
        UpdateName();
        UpdateRaityA(ACommander);
        UpdateFlag(TeamAActive, FlagA);
        UpdateFlag(TeamBActive, FlagB);
    }
    public void UpdateActiveChampionB()
    {
        AgilityB.GetComponent<Text>().text = TeamBActive.GetComponent<SimpleCard>().agility.ToString();
        BrawnB.GetComponent<Text>().text = TeamBActive.GetComponent<SimpleCard>().brawl.ToString();
        CunningB.GetComponent<Text>().text = TeamBActive.GetComponent<SimpleCard>().cunning.ToString();
        switch (TeamBActive.GetComponent<SimpleCard>().tribe)
        {
            case "Scalefins":
                TribeB.GetComponent<Image>().sprite = TribeScalefins;
                break;

            case "Seasingers":
                TribeB.GetComponent<Image>().sprite = TribeSeasinger;
                break;

            case "Jellies":
                TribeB.GetComponent<Image>().sprite = TribeJellies;
                break;

            case "Clawbeasts":
                TribeB.GetComponent<Image>().sprite = TribeClawbeasts;
                break;

            case "Shellbearers":
                TribeB.GetComponent<Image>().sprite = TribeShellbearers;
                break;

            case "Manylimbs":
                TribeB.GetComponent<Image>().sprite = TribecaseManylimbs;
                break;

            case "Roughskins":
                TribeB.GetComponent<Image>().sprite = TribeRoughskins;
                break;
        }
        switch (TeamBActive.GetComponent<SimpleCard>().idealPressure)
        {
            case 1:
                IdealPressureB1.SetActive(true);
                IdealPressureB2.SetActive(false);
                IdealPressureB3.SetActive(false);
                IdealPressureB4.SetActive(false);
                IdealPressureB5.SetActive(false);

                break;
            case 2:
                IdealPressureB1.SetActive(true);
                IdealPressureB2.SetActive(true);
                IdealPressureB3.SetActive(false);
                IdealPressureB4.SetActive(false);
                IdealPressureB5.SetActive(false);
                break;
            case 3:
                IdealPressureB1.SetActive(true);
                IdealPressureB2.SetActive(true);
                IdealPressureB3.SetActive(true);
                IdealPressureB4.SetActive(false);
                IdealPressureB5.SetActive(false);
                break;
            case 4:
                IdealPressureB1.SetActive(true);
                IdealPressureB2.SetActive(true);
                IdealPressureB3.SetActive(true);
                IdealPressureB4.SetActive(true);
                IdealPressureB5.SetActive(false);
                break;
            case 5:
                IdealPressureB1.SetActive(true);
                IdealPressureB2.SetActive(true);
                IdealPressureB3.SetActive(true);
                IdealPressureB4.SetActive(true);
                IdealPressureB5.SetActive(true);
                break;

        }
        teamBActiveName.GetComponent<Text>().text = TeamBActive.GetComponent<SimpleCard>().name.ToString();
        UpdateRaityB(TeamBActive);
    }
    public void UpdateAtributes()
    {

        AidealPressure = TeamAActive.GetComponent<SimpleCard>().idealPressure;
        Aagility = TeamAActive.GetComponent<SimpleCard>().agility * (1 - (PollutionLevel * 0.05f)) * (1 + (Current * 0.01f));
        Abrawl = TeamAActive.GetComponent<SimpleCard>().brawl * (1 - (PollutionLevel * 0.05f)) * (1 - (0.1f * Mathf.Abs(AidealPressure - PressureLevel)));
        Acunning = TeamAActive.GetComponent<SimpleCard>().cunning;


        BIdealPressure = TeamBActive.GetComponent<SimpleCard>().idealPressure;
        BAgility = TeamBActive.GetComponent<SimpleCard>().agility * (1 - (PollutionLevel * 0.05f)) * (1 + (Current * 0.01f));
        BBrawl = TeamBActive.GetComponent<SimpleCard>().brawl * (1 - (PollutionLevel * 0.05f)) * (1 - (0.1f * Mathf.Abs(BIdealPressure - PressureLevel)));
        BCunning = TeamBActive.GetComponent<SimpleCard>().cunning;


        if (Aagility > Abrawl & Aagility > Acunning) { BigAtributeA = AagilityPlate; Abig = Aagility; }
        if (Abrawl > Aagility & Abrawl > Acunning) { BigAtributeA = AbrawlPlate; Abig = Abrawl; }
        if (Acunning > Abrawl & Acunning > Aagility) { BigAtributeA = AcunningPlate; Abig = Acunning; }

        if (BAgility > BBrawl & BAgility > BCunning) { BigAtributeB = BagilityPlate; Bbig = BAgility; }
        else if (BBrawl > BAgility & BBrawl > BCunning) { BigAtributeB = BbrawlPlate; Bbig = BBrawl; }
        else if (BCunning > BBrawl & BCunning > BAgility) { BigAtributeB = BcunningPlate; Bbig = BCunning; }
        else { BigAtributeB = BcunningPlate; Bbig = BCunning; }

        AagilityPlate.transform.localScale = new Vector3(1, 1, 1);
        AbrawlPlate.transform.localScale = new Vector3(1, 1, 1);
        AcunningPlate.transform.localScale = new Vector3(1, 1, 1);
        BagilityPlate.transform.localScale = new Vector3(1, 1, 1);
        BbrawlPlate.transform.localScale = new Vector3(1, 1, 1);
        BcunningPlate.transform.localScale = new Vector3(1, 1, 1);



        BigAtributeA.transform.localScale = new Vector3(1.4f, 1.4f, 1);
        BigAtributeB.transform.localScale = new Vector3(1.4f, 1.4f, 1);

        AgilityA.GetComponent<Text>().text = Aagility.ToString();
        BrawnA.GetComponent<Text>().text = Abrawl.ToString();
        CunningA.GetComponent<Text>().text = Acunning.ToString();

        AgilityB.GetComponent<Text>().text = BAgility.ToString();
        BrawnB.GetComponent<Text>().text = BBrawl.ToString();
        CunningB.GetComponent<Text>().text = BCunning.ToString();





    }
    public void UpdateTribeIcon()
    {

        switch (PositionA)
        {
            case 0:
                tribe = ACommander.GetComponent<Item>().tribe;
                break;
            case 1:
                tribe = ACrew1.GetComponent<Item>().tribe;
                break;
            case 2:
                tribe = ACrew2.GetComponent<Item>().tribe;
                break;
            case 3:
                tribe = ACrew3.GetComponent<Item>().tribe;
                break;
            case 4:
                tribe = ACrew4.GetComponent<Item>().tribe;
                break;

        }

        switch (tribe)
        {
            case ("Manylimbs"):
                TribeA.GetComponent<Image>().sprite = TribecaseManylimbs;
                break;
            case ("Seasingers"):
                TribeA.GetComponent<Image>().sprite = TribeSeasinger;
                break;

            case ("Clawbeasts"):
                TribeA.GetComponent<Image>().sprite = TribeClawbeasts;

                break;
            case ("Roughskins"):
                TribeA.GetComponent<Image>().sprite = TribeRoughskins;

                break;
            case ("Jellies"):
                TribeA.GetComponent<Image>().sprite = TribeJellies;
                break;
            case ("Shellbearers"):
                TribeA.GetComponent<Image>().sprite = TribeShellbearers;
                break;
            case ("Scalefins"):
                TribeA.GetComponent<Image>().sprite = TribeScalefins;
                break;
        }
    }
    public void UpdateChampionPressure()
    {
        int pressure = 6;
        switch (PositionA)
        {
            case 0:
                pressure = ACommander.GetComponent<Item>().idealPressure;
                break;
            case 1:
                pressure = ACrew1.GetComponent<Item>().idealPressure;
                break;
            case 2:
                pressure = ACrew2.GetComponent<Item>().idealPressure;
                break;
            case 3:
                pressure = ACrew3.GetComponent<Item>().idealPressure;
                break;
            case 4:
                pressure = ACrew4.GetComponent<Item>().idealPressure;
                break;

        }

        switch (pressure)
        {
            case 1:
                IdealPressureA1.SetActive(true);
                IdealPressureA2.SetActive(false);
                IdealPressureA3.SetActive(false);
                IdealPressureA4.SetActive(false);
                IdealPressureA5.SetActive(false);

                break;
            case 2:
                IdealPressureA1.SetActive(true);
                IdealPressureA2.SetActive(true);
                IdealPressureA3.SetActive(false);
                IdealPressureA4.SetActive(false);
                IdealPressureA5.SetActive(false);
                break;
            case 3:
                IdealPressureA1.SetActive(true);
                IdealPressureA2.SetActive(true);
                IdealPressureA3.SetActive(true);
                IdealPressureA4.SetActive(false);
                IdealPressureA5.SetActive(false);
                break;
            case 4:
                IdealPressureA1.SetActive(true);
                IdealPressureA2.SetActive(true);
                IdealPressureA3.SetActive(true);
                IdealPressureA4.SetActive(true);
                IdealPressureA5.SetActive(false);
                break;
            case 5:
                IdealPressureA1.SetActive(true);
                IdealPressureA2.SetActive(true);
                IdealPressureA3.SetActive(true);
                IdealPressureA4.SetActive(true);
                IdealPressureA5.SetActive(true);
                break;

        }
    }
    public void UpdateChampionImage(GameObject Champion)
    {
        Name = Champion.GetComponent<SimpleCard>().name;
        switch (Name)
        {
            case "John Fango the Tactical Megalodon":
                Champion.GetComponent<Image>().sprite = JOHN_FANGO;
                break;
            case "Captain Costa the Man O�War":
                Champion.GetComponent<Image>().sprite = CAPTAIN;
                break;
            case "Ted Righty the Boxer Whale":
                Champion.GetComponent<Image>().sprite = TED;
                break;
            case "Nenrung the Dragon":
                Champion.GetComponent<Image>().sprite = NENRUNG;
                break;
            case "Rezaul the Master Octopus":
                Champion.GetComponent<Image>().sprite = REZAUL;
                break;
            case "Garrincha the Tough Blue Lobster":
                Champion.GetComponent<Image>().sprite = GARRINCHA;
                break;
            case "Luke Leatherback the Turtle":
                Champion.GetComponent<Image>().sprite = LUKE;
                break;
            case "Ray the Whipping Manta":
                Champion.GetComponent<Image>().sprite = RAY;
                break;
            case "Sir Westley the Fencing Dolphin":
                Champion.GetComponent<Image>().sprite = SIR_WESTLEY;
                break;
            case "Liza the Carrier Crab":
                Champion.GetComponent<Image>().sprite = LIZA;
                break;
            case "Hanis the Menacing Flatfish":
                Champion.GetComponent<Image>().sprite = HANIS;
                break;
            case "Sargeant Hartman the Navy Seal":
                Champion.GetComponent<Image>().sprite = SARGEANT_HARTMAN;
                break;
            case "Ridley the Olive Turtle":
                Champion.GetComponent<Image>().sprite = RIDLEY;
                break;
            case "Arsella the Sea Nettle":
                Champion.GetComponent<Image>().sprite = ARSELLA;
                break;
            case "Rocus Shades the�Blue Shark":
                Champion.GetComponent<Image>().sprite = ROCUS;
                break;
            case "Aaron the Ramming Crab":
                Champion.GetComponent<Image>().sprite = AARON;
                break;
            case "Wanderley the Grappling Octopus":
                Champion.GetComponent<Image>().sprite = WANDERLEY;
                break;
            case "Lola the Buff Blowfish":
                Champion.GetComponent<Image>().sprite = LOLA;
                break;
            case "Todd the Barber Eel":
                Champion.GetComponent<Image>().sprite = TODD;
                break;
            case "Johnny the Sailor Squid":
                Champion.GetComponent<Image>().sprite = JOHNNY;
                break;
            case "Soorya the Needling Box Jellyfish":
                Champion.GetComponent<Image>().sprite = SOORYA;
                break;
            case "Irfan the Bladed Lobster":
                Champion.GetComponent<Image>().sprite = IRFAN;
                break;
            case "Danilo the Piercing Tatui":
                Champion.GetComponent<Image>().sprite = DANILO;
                break;
            case "Ze Pereira the Sandbar Shark":
                Champion.GetComponent<Image>().sprite = ZEPEREIRA;
                break;
            case "Bob Saw the Anchovy":
                Champion.GetComponent<Image>().sprite = BOB_SAW;
                break;
            case "Tisya the Spotted Blademaster":
                Champion.GetComponent<Image>().sprite = TISYA;
                break;
            case "Sasha the Wrestling Beluga":
                Champion.GetComponent<Image>().sprite = SASHA;
                break;
            case "Medhansh the Swordsman Octopus":
                Champion.GetComponent<Image>().sprite = MEDHANSH;
                break;
            case "Sirilo the Marbled Swim Crab":
                Champion.GetComponent<Image>().sprite = SIRILO;
                break;
            case "Mahesh the Slashing Mackerel":
                Champion.GetComponent<Image>().sprite = MAHESH;
                break;
            case "Richard the Opportunist Cockle":
                Champion.GetComponent<Image>().sprite = RICHARD;
                break;
            case "Ed the Punk Salmon":
                Champion.GetComponent<Image>().sprite = ED;
                break;
            case "Adam Risso the Dolphin":
                Champion.GetComponent<Image>().sprite = ADAM;
                break;
        }
    }
    public void UpdateName()
    {
        TeamAActiveName.GetComponent<Text>().text = TeamAActive.GetComponent<SimpleCard>().name.ToString();
        teamBActiveName.GetComponent<Text>().text = TeamBActive.GetComponent<SimpleCard>().name.ToString();
    }
    public void UpdateRaityA(GameObject Champion)
    {
        switch (Champion.GetComponent<Item>().rarity.ToString())
        {
            case "Common":
                MedalIconA.GetComponent<Image>().sprite = Common;
                break;

            case "Uncommon":
                MedalIconA.GetComponent<Image>().sprite = Uncommon;
                break;

            case "Rare":
                MedalIconA.GetComponent<Image>().sprite = Rare;
                break;

            case "Very Rare":
                MedalIconA.GetComponent<Image>().sprite = RareVery;
                break;

            case "Legendary":
                MedalIconA.GetComponent<Image>().sprite = Legendary;
                break;
        }

    }
    public void UpdateRaityB(GameObject Champion)
    {
        switch (Champion.GetComponent<SimpleCard>().rarity.ToString())
        {
            case "Common":
                MedalIconB.GetComponent<Image>().sprite = Common;
                break;

            case "Uncommon":
                MedalIconB.GetComponent<Image>().sprite = Uncommon;
                break;

            case "Rare":
                MedalIconB.GetComponent<Image>().sprite = Rare;
                break;

            case "Very Rare":
                MedalIconB.GetComponent<Image>().sprite = RareVery;
                break;

            case "Legendary":
                MedalIconB.GetComponent<Image>().sprite = Legendary;
                break;
        }

    }
    private void UpdateFlag(GameObject Champion, GameObject Flag)
    {
        switch (Champion.GetComponent<SimpleCard>().name)
        {
            case "John Fango the Tactical Megalodon":
                Flag.GetComponent<Image>().sprite = FlagUsa;
                break;
            case "Captain Costa the Man O�War":
                Flag.GetComponent<Image>().sprite = FlagBrazil;
                break;
            case "Ted Righty the Boxer Whale":
                Flag.GetComponent<Image>().sprite = FlagUk;
                break;
            case "Nenrung the Dragon":
                Flag.GetComponent<Image>().sprite = FlagUk;
                break;
            case "Rezaul the Master Octopus":
                Flag.GetComponent<Image>().sprite = FlagIndian;
                break;
            case "Garrincha the Tough Blue Lobster":
                Flag.GetComponent<Image>().sprite = FlagBrazil;
                break;
            case "Luke Leatherback the Turtle":
                Flag.GetComponent<Image>().sprite = FlagUsa;
                break;
            case "Ray the Whipping Manta":
                Flag.GetComponent<Image>().sprite = FlagIndonesia;
                break;
            case "Sir Westley the Fencing Dolphin":
                Flag.GetComponent<Image>().sprite = FlagUk;
                break;
            case "Liza the Carrier Crab":
                Flag.GetComponent<Image>().sprite = FlagUk;
                break;
            case "Hanis the Menacing Flatfish":
                Flag.GetComponent<Image>().sprite = FlagIndonesia;
                break;
            case "Sargeant Hartman the Navy Seal":
                Flag.GetComponent<Image>().sprite = FlagUsa;
                break;
            case "Ridley the Olive Turtle":
                Flag.GetComponent<Image>().sprite = FlagIndian;
                break;
            case "Arsella the Sea Nettle":
                Flag.GetComponent<Image>().sprite = FlagIndonesia;
                break;
            case "Rocus Shades the�Blue Shark":
                Flag.GetComponent<Image>().sprite = FlagIndian;
                break;
            case "Aaron the Ramming Crab":
                Flag.GetComponent<Image>().sprite = FlagUsa;
                break;
            case "Wanderley the Grappling Octopus":
                Flag.GetComponent<Image>().sprite = FlagBrazil;
                break;
            case "Lola the Buff Blowfish":
                Flag.GetComponent<Image>().sprite = FlagBrazil;
                break;
            case "Todd the Barber Eel":
                Flag.GetComponent<Image>().sprite = FlagUk;
                break;
            case "Johnny the Sailor Squid":
                Flag.GetComponent<Image>().sprite = FlagUsa;
                break;
            case "Soorya the Needling Box Jellyfish":
                Flag.GetComponent<Image>().sprite = FlagIndian;
                break;
            case "Irfan the Bladed Lobster":
                Flag.GetComponent<Image>().sprite = FlagIndonesia;
                break;
            case "Danilo the Piercing Tatui":
                Flag.GetComponent<Image>().sprite = FlagBrazil;
                break;
            case "Ze Pereira the Sandbar Shark":
                Flag.GetComponent<Image>().sprite = FlagBrazil;
                break;
            case "Bob Saw the Anchovy":
                Flag.GetComponent<Image>().sprite = FlagUsa;
                break;
            case "Tisya the Spotted Blademaster":
                Flag.GetComponent<Image>().sprite = FlagIndonesia;
                break;
            case "Sasha the Wrestling Beluga":
                Flag.GetComponent<Image>().sprite = FlagUsa;
                break;
            case "Medhansh the Swordsman Octopus":
                Flag.GetComponent<Image>().sprite = FlagIndian;
                break;
            case "Sirilo the Marbled Swim Crab":
                Flag.GetComponent<Image>().sprite = FlagUsa;
                break;
            case "Mahesh the Slashing Mackerel":
                Flag.GetComponent<Image>().sprite = FlagIndonesia;
                break;
            case "Richard the Opportunist Cockle":
                Flag.GetComponent<Image>().sprite = FlagUk;
                break;
            case "Ed the Punk Salmon":
                Flag.GetComponent<Image>().sprite = FlagUk;
                break;
            case "Adam Risso the Dolphin":
                Flag.GetComponent<Image>().sprite = FlagIndonesia;
                break;
            default:
                break;
        }
    }


    //Instantiate and Destroy Card Overlay os the crew
    public void ShowCardOver(GameObject card)
    {
        var CardOverlay = Instantiate(CardChampion);
        CardOverlay.transform.SetParent(GameObject.Find("Canvas_TrainingMode").transform, false);
        CardOverlay.transform.localScale = new Vector3(0.5f, 0.5f, 1);

        CardOverlay.transform.position = card.transform.position;
        CardOverlay.GetComponent<CardChapion>().name = card.GetComponent<SimpleCard>().name;
        CardOverlay.GetComponent<CardChapion>().tribe = card.GetComponent<SimpleCard>().tribe;
        CardOverlay.GetComponent<CardChapion>().rarity = card.GetComponent<SimpleCard>().rarity;
        CardOverlay.GetComponent<CardChapion>().elite = card.GetComponent<SimpleCard>().elite;
        CardOverlay.GetComponent<CardChapion>().idealPressure = card.GetComponent<SimpleCard>().idealPressure;
        int localpressure = card.GetComponent<SimpleCard>().idealPressure;
        CardOverlay.GetComponent<CardChapion>().brawl = card.GetComponent<SimpleCard>().brawl * (1 - (PollutionLevel * 0.05f)) * (1 - (0.1f * Mathf.Abs(localpressure - PressureLevel)));
        CardOverlay.GetComponent<CardChapion>().agility = card.GetComponent<SimpleCard>().agility * (1 - (PollutionLevel * 0.05f)) * (1 + (Current * 0.01f)); ;
        CardOverlay.GetComponent<CardChapion>().cunning = card.GetComponent<SimpleCard>().cunning;
        CardOverlay.GetComponent<CardChapion>().battlePower = card.GetComponent<SimpleCard>().battlePower;



    }
    public void DestroyCardOver()
    {
        GameObject[] Overlay = GameObject.FindGameObjectsWithTag("Overlay");
        foreach (GameObject x in Overlay)
        {
            Destroy(x);
        }
    }



    //Get the cards by position on team
    public void GetCommander() { if (OnSwitch == true) { PositionA = 0; } }
    public void GetCrew1() { if (OnSwitch == true) { PositionA = 1; } }
    public void GetCrew2() { if (OnSwitch == true) { PositionA = 2; } }
    public void GetCrew3() { if (OnSwitch == true) { PositionA = 3; } }
    public void GetCrew4() { if (OnSwitch == true) { PositionA = 4; } }


    //Itial Pressure and Ocean with Current
    public void SetOceanPressure()
    {
        int team = Random.RandomRange(0, 1);

        switch (team)
        {
            case 0:
                switch (TeamAActive.GetComponent<SimpleCard>().name)
                {
                    case "John Fango the Tactical Megalodon":
                        Ocean = "Usa";
                        break;
                    case "Captain Costa the Man O�War":
                        Ocean = "Brazil";
                        break;
                    case "Ted Righty the Boxer Whale":
                        Ocean = "Brazil";
                        break;
                    case "Nenrung the Dragon":
                        Ocean = "UK";
                        break;
                    case "Rezaul the Master Octopus":
                        Ocean = "Indian";
                        break;
                    case "Garrincha the Tough Blue Lobster":
                        Ocean = "Brazil";
                        break;
                    case "Luke Leatherback the Turtle":
                        Ocean = "Usa";
                        break;
                    case "Ray the Whipping Manta":
                        Ocean = "Indonesia";
                        break;
                    case "Sir Westley the Fencing Dolphin":
                        Ocean = "UK";
                        break;
                    case "Liza the Carrier Crab":
                        Ocean = "UK";
                        break;
                    case "Hanis the Menacing Flatfish":
                        Ocean = "Indonesia";
                        break;
                    case "Sargeant Hartman the Navy Seal":
                        Ocean = "Usa";
                        break;
                    case "Ridley the Olive Turtle":
                        Ocean = "Indian";
                        break;
                    case "Arsella the Sea Nettle":
                        Ocean = "Indonesia";
                        break;
                    case "Rocus Shades the�Blue Shark":
                        Ocean = "Indian";
                        break;
                    case "Aaron the Ramming Crab":
                        Ocean = "Usa";
                        break;
                    case "Wanderley the Grappling Octopus":
                        Ocean = "Brazil";
                        break;
                    case "Lola the Buff Blowfish":
                        Ocean = "Brazil";
                        break;
                    case "Todd the Barber Eel":
                        Ocean = "UK";
                        break;
                    case "Johnny the Sailor Squid":
                        Ocean = "Usa";
                        break;
                    case "Soorya the Needling Box Jellyfish":
                        Ocean = "Indian";
                        break;
                    case "Irfan the Bladed Lobster":
                        Ocean = "Indonesia";
                        break;
                    case "Danilo the Piercing Tatui":
                        Ocean = "Brazil";
                        break;
                    case "Ze Pereira the Sandbar Shark":
                        Ocean = "Brazil";
                        break;
                    case "Bob Saw the Anchovy":
                        Ocean = "Usa";
                        break;
                    case "Tisya the Spotted Blademaster":
                        Ocean = "Indonesia";
                        break;
                    case "Sasha the Wrestling Beluga":
                        Ocean = "Usa";
                        break;
                    case "Medhansh the Swordsman Octopus":
                        Ocean = "Indian";
                        break;
                    case "Sirilo the Marbled Swim Crab":
                        Ocean = "Usa";
                        break;
                    case "Mahesh the Slashing Mackerel":
                        Ocean = "Indonesia";
                        break;
                    case "Richard the Opportunist Cockle":
                        Ocean = "UK";
                        break;
                    case "Ed the Punk Salmon":
                        Ocean = "UK";
                        break;
                    case "Adam Risso the Dolphin":
                        Ocean = "Indonesia";
                        break;
                    default:
                        break;
                }
                PressureLevel = TeamBActive.GetComponent<SimpleCard>().idealPressure;
                break;
            case 1:
                switch (TeamBActive.GetComponent<SimpleCard>().name)
                {
                    case "John Fango the Tactical Megalodon":
                        Ocean = "Usa";
                        break;
                    case "Captain Costa the Man O�War":
                        Ocean = "Brazil";
                        break;
                    case "Ted Righty the Boxer Whale":
                        Ocean = "Brazil";
                        break;
                    case "Nenrung the Dragon":
                        Ocean = "UK";
                        break;
                    case "Rezaul the Master Octopus":
                        Ocean = "Indian";
                        break;
                    case "Garrincha the Tough Blue Lobster":
                        Ocean = "Brazil";
                        break;
                    case "Luke Leatherback the Turtle":
                        Ocean = "Usa";
                        break;
                    case "Ray the Whipping Manta":
                        Ocean = "Indonesia";
                        break;
                    case "Sir Westley the Fencing Dolphin":
                        Ocean = "UK";
                        break;
                    case "Liza the Carrier Crab":
                        Ocean = "UK";
                        break;
                    case "Hanis the Menacing Flatfish":
                        Ocean = "Indonesia";
                        break;
                    case "Sargeant Hartman the Navy Seal":
                        Ocean = "Usa";
                        break;
                    case "Ridley the Olive Turtle":
                        Ocean = "Indian";
                        break;
                    case "Arsella the Sea Nettle":
                        Ocean = "Indonesia";
                        break;
                    case "Rocus Shades the�Blue Shark":
                        Ocean = "Indian";
                        break;
                    case "Aaron the Ramming Crab":
                        Ocean = "Usa";
                        break;
                    case "Wanderley the Grappling Octopus":
                        Ocean = "Brazil";
                        break;
                    case "Lola the Buff Blowfish":
                        Ocean = "Brazil";
                        break;
                    case "Todd the Barber Eel":
                        Ocean = "UK";
                        break;
                    case "Johnny the Sailor Squid":
                        Ocean = "Usa";
                        break;
                    case "Soorya the Needling Box Jellyfish":
                        Ocean = "Indian";
                        break;
                    case "Irfan the Bladed Lobster":
                        Ocean = "Indonesia";
                        break;
                    case "Danilo the Piercing Tatui":
                        Ocean = "Brazil";
                        break;
                    case "Ze Pereira the Sandbar Shark":
                        Ocean = "Brazil";
                        break;
                    case "Bob Saw the Anchovy":
                        Ocean = "Usa";
                        break;
                    case "Tisya the Spotted Blademaster":
                        Ocean = "Indonesia";
                        break;
                    case "Sasha the Wrestling Beluga":
                        Ocean = "Usa";
                        break;
                    case "Medhansh the Swordsman Octopus":
                        Ocean = "Indian";
                        break;
                    case "Sirilo the Marbled Swim Crab":
                        Ocean = "Usa";
                        break;
                    case "Mahesh the Slashing Mackerel":
                        Ocean = "Indonesia";
                        break;
                    case "Richard the Opportunist Cockle":
                        Ocean = "UK";
                        break;
                    case "Ed the Punk Salmon":
                        Ocean = "UK";
                        break;
                    case "Adam Risso the Dolphin":
                        Ocean = "Indonesia";
                        break;
                    default:
                        break;
                }
                PressureLevel = TeamAActive.GetComponent<SimpleCard>().idealPressure;
                break;
        }        
        OceanName.GetComponent<Text>().text = Ocean;
    }
    public void SetCurrent()
    {
        switch (Ocean, PressureLevel)
        {
            case ("Brazil", 1):
                Current = -15;
                break;
            case ("Brazil", 2)
            :Current = -10;
                break;
            case ("Brazil", 3):
                Current = 0;
                break;
            case ("Brazil", 4):
                Current = 15;
                break;
            case ("Brazil", 5):
                Current = 20;
                break;
            case ("Usa", 1):
                Current = 20;
                break;
            case ("Usa", 2):
                Current = 15;
                break;
            case ("Usa", 3):
                Current = 0;
                break;
            case ("Usa", 4):
                Current = -10;
                break;
            case ("Usa", -15):
                Current = -15;
                break;
            case ("Indian", 1):
                Current = 5;
                break;
            case ("Indian", 2):
                Current = 5;
                break;
            case ("Indian", 3):
                Current = 10;
                break;
            case ("Indian", 4):
                Current = 10;
                break;
            case ("Indian", 5):
                Current = 15;
                break;
            case ("Indonesia", 1):
                Current = 10;
                break;
            case ("Indonesia", 2):
                Current = -15;
                break;
            case ("Indonesia", 3):
                Current = 15;
                break;
            case ("Indonesia", 4):
                Current = -10;
                break;
            case ("Indonesia", 5):
                Current = 20;
                break;
            case ("UK", 1):
                Current = -10;
                break;
            case ("UK", 2):
                Current = 20;
                break;
            case ("UK", 3):
                Current = -10;
                break;
            case ("UK", 4):
                Current = 20;
                break;
            case ("UK", 5):
                Current = -10;
                break;

        }
        if (Current < 0) { CurrentText.GetComponent<Text>().text = Current.ToString(); }
        if (Current >= 0) { CurrentText.GetComponent<Text>().text = "+" + Current.ToString(); }
    }


    //Bot Instructions and settings    
    public void GetBotCards()
    {
        TotalBpTeamA = ACommander.GetComponent<Item>().battlePower + ACrew1.GetComponent<Item>().battlePower + ACrew2.GetComponent<Item>().battlePower + ACrew3.GetComponent<Item>().battlePower + ACrew4.GetComponent<Item>().battlePower;

        switch (Dificult)
        {
            case 1:  BPlow = TotalBpTeamA * 0.1f;  BPhigh = TotalBpTeamA;break;
            case 2:  BPlow = TotalBpTeamA * 0.85f; BPhigh = TotalBpTeamA *1.15f;break;
            case 3:  BPlow = TotalBpTeamA * 0.9f; BPhigh = TotalBpTeamA *2;break;
        }
        {
            GetRandonCard(TeamBActive);
            GetRandonCard(TeamBCrew1);
            GetRandonCard(TeamBCrew2);
            GetRandonCard(TeamBCrew3);
            GetRandonCard(TeamBCrew4);
            TotalBpTeamB =
                TeamBActive.GetComponent<SimpleCard>().battlePower +
                TeamBCrew1.GetComponent<SimpleCard>().battlePower +
                TeamBCrew2.GetComponent<SimpleCard>().battlePower +
                TeamBCrew3.GetComponent<SimpleCard>().battlePower +
                TeamBCrew4.GetComponent<SimpleCard>().battlePower;

            if ((BPlow < TotalBpTeamB) & (TotalBpTeamB < BPhigh))
            {
                Debug.Log("Success");
                StartPreparation = true;
            }
            else 
            {   Fail++;
                Debug.Log("Fail: "+Fail.ToString());
                GetBotCards();

            }
            
        }

    }
    private void GetRandonCard(GameObject card)
    {  
        int number = Random.Range(1, 34);
        switch (number)
        {
            case 1:
                card.GetComponent<SimpleCard>().name = "John Fango the Tactical Megalodon";
                card.GetComponent<SimpleCard>().agility = 222;
                card.GetComponent<SimpleCard>().brawl = 333;
                card.GetComponent<SimpleCard>().cunning = 111;
                card.GetComponent<SimpleCard>().idealPressure = 4;
                card.GetComponent<SimpleCard>().tribe = "Roughskins";
                card.GetComponent<SimpleCard>().rarity = "Legendary";
                break;
            
            case 2:
                card.GetComponent<SimpleCard>().name = "Captain Costa the Man O�War";
                card.GetComponent<SimpleCard>().agility = 222;
                card.GetComponent<SimpleCard>().brawl = 111;
                card.GetComponent<SimpleCard>().cunning = 222;
                card.GetComponent<SimpleCard>().idealPressure = 1;
                card.GetComponent<SimpleCard>().tribe = "Jellies";
                card.GetComponent<SimpleCard>().rarity = "Very Rare";
                break;
       
            case 3:
                card.GetComponent<SimpleCard>().name = "Ted Righty the Boxer Whale";
                card.GetComponent<SimpleCard>().agility = 240;
                card.GetComponent<SimpleCard>().brawl = 260;
                card.GetComponent<SimpleCard>().cunning = 100;
                card.GetComponent<SimpleCard>().idealPressure = 2;
                card.GetComponent<SimpleCard>().tribe = "Seasingers";
                card.GetComponent<SimpleCard>().rarity = "Very Rare";

                break;
            case 4:
                card.GetComponent<SimpleCard>().name = "Nenrung the Dragon";
                card.GetComponent<SimpleCard>().agility = 247;
                card.GetComponent<SimpleCard>().brawl = 120;
                card.GetComponent<SimpleCard>().cunning = 100;
                card.GetComponent<SimpleCard>().idealPressure = 3;
                card.GetComponent<SimpleCard>().tribe = "Scalefins";
                card.GetComponent<SimpleCard>().rarity = "Rare";
                break;
            case 5:
                card.GetComponent<SimpleCard>().name = "Rezaul the master Octopus";
                card.GetComponent<SimpleCard>().agility = 75;
                card.GetComponent<SimpleCard>().brawl = 150;
                card.GetComponent<SimpleCard>().cunning = 233;
                card.GetComponent<SimpleCard>().idealPressure = 1;
                card.GetComponent<SimpleCard>().tribe = "Manylimbs";
                card.GetComponent<SimpleCard>().rarity = "Rare";
                break;

            case 6:
                card.GetComponent<SimpleCard>().name = "Garrincha the Tough Blue Lobster";
                card.GetComponent<SimpleCard>().agility = 220;
                card.GetComponent<SimpleCard>().brawl = 220;
                card.GetComponent<SimpleCard>().cunning = 51;
                card.GetComponent<SimpleCard>().idealPressure = 2;
                card.GetComponent<SimpleCard>().tribe = "Clawbeasts";
                card.GetComponent<SimpleCard>().rarity = "Rare";
                break;
            case 7:
                card.GetComponent<SimpleCard>().name = "Luke Leatherback the Turtle";
                card.GetComponent<SimpleCard>().agility = 150;
                card.GetComponent<SimpleCard>().brawl = 261;
                card.GetComponent<SimpleCard>().cunning = 85;
                card.GetComponent<SimpleCard>().idealPressure = 2;
                card.GetComponent<SimpleCard>().tribe = "Shellbearers";
                card.GetComponent<SimpleCard>().rarity = "Rare";

                break;
                case 8:
                card.GetComponent<SimpleCard>().name = "Ray the Whipping Manta";
                card.GetComponent<SimpleCard>().agility = 181;
                    card.GetComponent<SimpleCard>().brawl = 264;
                    card.GetComponent<SimpleCard>().cunning = 55;
                    card.GetComponent<SimpleCard>().idealPressure = 4;
                    card.GetComponent<SimpleCard>().tribe = "Roughskins";
                card.GetComponent<SimpleCard>().rarity = "Rare";
                break;

                case 9:
                card.GetComponent<SimpleCard>().name = "Sir Westley the Fencing Dolphin";
                card.GetComponent<SimpleCard>().agility = 183;
                    card.GetComponent<SimpleCard>().brawl = 75;
                    card.GetComponent<SimpleCard>().cunning = 110;
                    card.GetComponent<SimpleCard>().idealPressure = 1;
                    card.GetComponent<SimpleCard>().tribe = "Seasingers";
                card.GetComponent<SimpleCard>().rarity = "Uncommon";
                break;

                case 10:
                card.GetComponent<SimpleCard>().name = "Liza the Carrier Crab";
                card.GetComponent<SimpleCard>().agility = 120;
                    card.GetComponent<SimpleCard>().brawl = 193;
                    card.GetComponent<SimpleCard>().cunning = 78;
                    card.GetComponent<SimpleCard>().idealPressure = 3;
                    card.GetComponent<SimpleCard>().tribe = "Clawbeasts";
                card.GetComponent<SimpleCard>().rarity = "Uncommon";
                break;

                case 11:
                card.GetComponent<SimpleCard>().name = "Hanis the Menacing Flatfish";
                card.GetComponent<SimpleCard>().agility = 185;
                    card.GetComponent<SimpleCard>().brawl = 96;
                    card.GetComponent<SimpleCard>().cunning = 90;
                    card.GetComponent<SimpleCard>().idealPressure = 2;
                    card.GetComponent<SimpleCard>().tribe = "Scalefins";
                card.GetComponent<SimpleCard>().rarity = "Uncommon";
                break;

                case 12:
                card.GetComponent<SimpleCard>().name = "Sargeant Hartman the Navy Seal";
                card.GetComponent<SimpleCard>().agility = 180;
                    card.GetComponent<SimpleCard>().brawl = 116;
                    card.GetComponent<SimpleCard>().cunning = 80;
                    card.GetComponent<SimpleCard>().idealPressure = 1;
                    card.GetComponent<SimpleCard>().tribe = "Seasingers";
                card.GetComponent<SimpleCard>().rarity = "Uncommon";
                break;

                 case 13:
                card.GetComponent<SimpleCard>().name = "Ridley the Olive Turtle";
                card.GetComponent<SimpleCard>().agility = 160;
                    card.GetComponent<SimpleCard>().brawl = 145;
                    card.GetComponent<SimpleCard>().cunning = 80;
                    card.GetComponent<SimpleCard>().idealPressure = 1;
                    card.GetComponent<SimpleCard>().tribe = "Shellbearers";
                card.GetComponent<SimpleCard>().rarity = "Uncommon";
                break;

                case 14:
                    card.GetComponent<SimpleCard>().name = "Arsella the Sea Nettle";
                    card.GetComponent<SimpleCard>().agility = 85;
                    card.GetComponent<SimpleCard>().brawl = 115;
                    card.GetComponent<SimpleCard>().cunning = 169;
                    card.GetComponent<SimpleCard>().idealPressure = 4;
                    card.GetComponent<SimpleCard>().tribe = "Jellies";
                card.GetComponent<SimpleCard>().rarity = "Uncommon";
                break;

                case 15:
                    card.GetComponent<SimpleCard>().name = "Rocus Shades the�Blue Shark";
                    card.GetComponent<SimpleCard>().agility = 100;
                    card.GetComponent<SimpleCard>().brawl = 203;
                    card.GetComponent<SimpleCard>().cunning = 90;
                    card.GetComponent<SimpleCard>().idealPressure = 4;
                    card.GetComponent<SimpleCard>().tribe = "Roughskins";
                card.GetComponent<SimpleCard>().rarity = "Uncommon";
                break;

                case 16:
                    card.GetComponent<SimpleCard>().name = "Aaron the Ramming Crab";
                    card.GetComponent<SimpleCard>().agility = 102;
                    card.GetComponent<SimpleCard>().brawl = 199;
                    card.GetComponent<SimpleCard>().cunning = 93;
                    card.GetComponent<SimpleCard>().idealPressure = 4;
                    card.GetComponent<SimpleCard>().tribe = "Shellbearers";
                card.GetComponent<SimpleCard>().rarity = "Uncommon";
                break;

                case 17:
                card.GetComponent<SimpleCard>().name = "Wanderley the Grappling Octopus";
                card.GetComponent<SimpleCard>().agility = 93;
                card.GetComponent<SimpleCard>().brawl = 100;
                card.GetComponent<SimpleCard>().cunning = 111;
                card.GetComponent<SimpleCard>().idealPressure = 1;
                card.GetComponent<SimpleCard>().tribe = "Manylimbs";
                card.GetComponent<SimpleCard>().rarity = "Uncommon";
                break;

                case 18:                
                card.GetComponent<SimpleCard>().name = "Lola the Buff Blowfish";
                card.GetComponent<SimpleCard>().agility = 182;
                card.GetComponent<SimpleCard>().brawl = 102;
                card.GetComponent<SimpleCard>().cunning = 90;
                card.GetComponent<SimpleCard>().idealPressure = 3;
                card.GetComponent<SimpleCard>().tribe = "Scalefins";
                card.GetComponent<SimpleCard>().rarity = "Uncommon";
                break;

                case 19:
                card.GetComponent<SimpleCard>().name = "Todd the Barber Eel";
                card.GetComponent<SimpleCard>().agility = 150;
                card.GetComponent<SimpleCard>().brawl = 79;
                card.GetComponent<SimpleCard>().cunning = 93;
                card.GetComponent<SimpleCard>().idealPressure = 4;
                card.GetComponent<SimpleCard>().tribe = "Scalefins";
                card.GetComponent<SimpleCard>().rarity = "Common";
                break;

                case 20:
                card.GetComponent<SimpleCard>().name = "Johnny the Sailor Squid";
                card.GetComponent<SimpleCard>().agility = 110;
                card.GetComponent<SimpleCard>().brawl = 60;
                card.GetComponent<SimpleCard>().cunning = 143;
                card.GetComponent<SimpleCard>().idealPressure = 2;
                card.GetComponent<SimpleCard>().tribe = "Manylimbs";
                card.GetComponent<SimpleCard>().rarity = "Common";
                break;

                case 21:
                card.GetComponent<SimpleCard>().name = "Soorya the Needling Box Jellyfish";
                card.GetComponent<SimpleCard>().agility = 115;
                card.GetComponent<SimpleCard>().brawl = 73;
                card.GetComponent<SimpleCard>().cunning = 132;
                card.GetComponent<SimpleCard>().idealPressure = 4;
                card.GetComponent<SimpleCard>().tribe = "Jellies";
                card.GetComponent<SimpleCard>().rarity = "Common";
                break;

                case 22:
                card.GetComponent<SimpleCard>().name = "Irfan the Bladed Lobster";
                card.GetComponent<SimpleCard>().agility = 89;
                card.GetComponent<SimpleCard>().brawl = 168;
                card.GetComponent<SimpleCard>().cunning = 82;
                card.GetComponent<SimpleCard>().idealPressure = 3;
                card.GetComponent<SimpleCard>().rarity = "Common";
                break;

                case 23:
                card.GetComponent<SimpleCard>().name = "Danilo the Piercing Tatui";
                card.GetComponent<SimpleCard>().agility = 111;
                card.GetComponent<SimpleCard>().brawl = 151;
                card.GetComponent<SimpleCard>().cunning = 75;
                card.GetComponent<SimpleCard>().idealPressure = 3;
                card.GetComponent<SimpleCard>().tribe = "Shellbearers";
                card.GetComponent<SimpleCard>().rarity = "Common";
                break;

                case 24:
                card.GetComponent<SimpleCard>().name = "Ze Pereira the Sandbar Shark";
                card.GetComponent<SimpleCard>().agility = 85;
                card.GetComponent<SimpleCard>().brawl = 170;
                card.GetComponent<SimpleCard>().cunning = 85;
                card.GetComponent<SimpleCard>().idealPressure = 1;
                card.GetComponent<SimpleCard>().tribe = "Roughskins";
                card.GetComponent<SimpleCard>().rarity = "Common";
                break;

                case 25:
                card.GetComponent<SimpleCard>().name = "Bob Saw the Anchovy";
                card.GetComponent<SimpleCard>().agility = 154;
                card.GetComponent<SimpleCard>().brawl = 90;
                card.GetComponent<SimpleCard>().cunning = 80;
                card.GetComponent<SimpleCard>().idealPressure = 2;
                card.GetComponent<SimpleCard>().tribe = "Scalefins";
                card.GetComponent<SimpleCard>().rarity = "Common";
                break;

                case 26:
                card.GetComponent<SimpleCard>().name = "Tisya the Spotted Blademaster";
                card.GetComponent<SimpleCard>().agility = 100;
                card.GetComponent<SimpleCard>().brawl = 90;
                card.GetComponent<SimpleCard>().cunning = 130;
                card.GetComponent<SimpleCard>().idealPressure = 2;
                card.GetComponent<SimpleCard>().tribe = "Jellies";
                card.GetComponent<SimpleCard>().rarity = "Common";
                break;

                case 27:
                card.GetComponent<SimpleCard>().name = "Sasha the Wrestling Beluga";
                card.GetComponent<SimpleCard>().agility = 99;
                card.GetComponent<SimpleCard>().brawl = 165;
                card.GetComponent<SimpleCard>().cunning = 75;
                card.GetComponent<SimpleCard>().idealPressure = 2;
                card.GetComponent<SimpleCard>().tribe = "Seasingers";
                card.GetComponent<SimpleCard>().rarity = "Common";
                break;

                case 28:
                card.GetComponent<SimpleCard>().name = "Medhansh the Swordsman Octopus";
                card.GetComponent<SimpleCard>().agility = 65;
                card.GetComponent<SimpleCard>().brawl = 135;
                card.GetComponent<SimpleCard>().cunning = 130;
                card.GetComponent<SimpleCard>().idealPressure = 2;
                card.GetComponent<SimpleCard>().tribe = "Manylimbs";
                card.GetComponent<SimpleCard>().rarity = "Common";
                break;

                case 29:
                card.GetComponent<SimpleCard>().name = "Sirilo the Marbled Swim Crab";
                card.GetComponent<SimpleCard>().agility = 93;
                card.GetComponent<SimpleCard>().brawl = 160;
                card.GetComponent<SimpleCard>().cunning = 100;
                card.GetComponent<SimpleCard>().idealPressure = 3;
                card.GetComponent<SimpleCard>().tribe = "Clawbeasts";
                card.GetComponent<SimpleCard>().rarity = "Common";
                break;

                case 30:
                card.GetComponent<SimpleCard>().name = "Mahesh the Slashing Mackerel";
                card.GetComponent<SimpleCard>().agility = 160;
                card.GetComponent<SimpleCard>().brawl = 97;
                card.GetComponent<SimpleCard>().cunning = 70;
                card.GetComponent<SimpleCard>().idealPressure = 3;
                card.GetComponent<SimpleCard>().tribe = "Scalefins";
                card.GetComponent<SimpleCard>().rarity = "Common";
                break;

                case 31:
                card.GetComponent<SimpleCard>().name = "Richard the Opportunist Cockle";
                card.GetComponent<SimpleCard>().agility = 98;
                card.GetComponent<SimpleCard>().brawl = 163;
                card.GetComponent<SimpleCard>().cunning = 80;
                card.GetComponent<SimpleCard>().idealPressure = 2;
                card.GetComponent<SimpleCard>().tribe = "Shellbearers";
                card.GetComponent<SimpleCard>().rarity = "Common";
                break;

                case 32:
                card.GetComponent<SimpleCard>().name = "Ed the Punk Salmon";
                card.GetComponent<SimpleCard>().agility = 160;
                card.GetComponent<SimpleCard>().brawl = 85;
                card.GetComponent<SimpleCard>().cunning = 80;
                card.GetComponent<SimpleCard>().idealPressure = 4;
                card.GetComponent<SimpleCard>().tribe = "Scalefins";
                card.GetComponent<SimpleCard>().rarity = "Common";
                break;

                case 33:
                card.GetComponent<SimpleCard>().name = "Adam Risso the Dolphin";
                card.GetComponent<SimpleCard>().agility = 140;
                card.GetComponent<SimpleCard>().brawl = 75;
                card.GetComponent<SimpleCard>().cunning = 105;
                card.GetComponent<SimpleCard>().idealPressure = 2;
                card.GetComponent<SimpleCard>().tribe = "Seasingers";
                card.GetComponent<SimpleCard>().rarity = "Common";
                break;
                    

                default:
                    Debug.Log("Something go wrong");
                    break;
            }
        card.GetComponent<SimpleCard>().battlePower = card.GetComponent<SimpleCard>().agility + (card.GetComponent<SimpleCard>().brawl * 0.8f) + (card.GetComponent<SimpleCard>().cunning * 1.2f);
        UpdateChampionImage(card);


    }

    //Action confirmation and action Buttons 
    public void ExecuteAction()
    { 
        if(OnSwitch == true) 
        {
            ChampionSelection.SetActive(false);
            OnSwitch = false;
        }
        if (OnSwitch == false)
        {
            if (LastActionA == ActionA) { ActionA = 0; }
            else 
            {
                //Player action
                switch (ActionA)
                {
                    case 1://tribeskill
                        Debug.Log("Action TribeSkill");
                        break;


                    case 2://Go Donw
                        Debug.Log("Action Go Down");
                        if (PressureLevel > 1)
                        {
                            PressureLevel -= 1;
                        }
                        break;

                    case 3://Go Up
                        Debug.Log("Action Go Up");
                        if (PressureLevel < 5)
                        {
                            PressureLevel += 1;
                        }
                        break;

                    case 4://Cleaning
                        Debug.Log("Action Clean");
                        if (PollutionLevel > 1)
                        {
                            PollutionLevel -= 1;
                        }
                        break;


                    case 5://Cleanig Plus+
                        Debug.Log("Action CleanPlus");
                        if (PollutionLevel > 1)
                        {
                            PollutionLevel -= 3;
                            if (PollutionLevel < 0)
                            {
                                PollutionLevel = 0;
                            }
                            CleanPlus = 1;
                        }
                        break;

                    case 6://Switch
                        Debug.Log("Action Switch Card");
                        SwitchCardsA();
                        break;

                }

                // BotAction 
                {
                    if (Abig > Bbig)
                    {
                        if (Abig == Aagility) 
                        {
                            if (Ocean == "Usa") { ActionB = 2; if (LastActionB == ActionB) { ActionB = 4; } }
                            else if (Ocean == "Brazil") { ActionB = 3; if (LastActionB == ActionB) { ActionB = 4; } }
                            else if (Ocean == "Indonesia") 
                            {
                                if (PressureLevel == 4) { ActionB = 4; if (LastActionB == ActionB) { ActionB = 2; } } 
                                else if(PressureLevel == 5) { ActionB = 2; if (LastActionB == ActionB) { ActionB = 4; } }
                                else if(PressureLevel==3) { ActionB = 2; if (LastActionB == ActionB) { ActionB = 4; } }
                                else if (PressureLevel == 2) { ActionB = 2; if (LastActionB == ActionB) { ActionB = 4; } }
                                else if (PressureLevel == 1) { ActionB = 3; if (LastActionB == ActionB) { ActionB = 4; } }
                            }
                        }
                        if (Abig == Abrawl)
                        {
                            switch (AidealPressure)
                            {
                                case 1:
                                    if (PressureLevel <= 1) {  ActionB = 3; if (LastActionB == ActionB) { ActionB = 4; } }
                                    break;

                                case 2:
                                    if (PressureLevel <= 1) { ActionB = 3; if (LastActionB == ActionB) { ActionB = 4; } }
                                    break;

                                case 3:
                                    if (PressureLevel <= 1) { ActionB = Random.Range(2, 4); if (LastActionB == ActionB) { ActionB = 4; } }
                                    break;

                                case 4:
                                    if (PressureLevel <= 1) { ActionB = 3; if (LastActionB == ActionB) { ActionB = 4; } }
                                    break;

                                case 5:
                                    if (PressureLevel <= 1) { ActionB = 3; if (LastActionB == ActionB) { ActionB = 4; } }
                                    break;
                            }
                        }
                        if (Abig == Acunning)
                        {
                            if (SwitchActionB == true)
                            {
                                if (TeamBCrew1.GetComponent<SimpleCard>().agility > Abig || TeamBCrew1.GetComponent<SimpleCard>().brawl > Abig || TeamBCrew1.GetComponent<SimpleCard>().cunning > Abig)
                                { PositionB = 1;ActionB = 6; if (LastActionB == ActionB) { ActionB = 4; } }
                                else if (TeamBCrew2.GetComponent<SimpleCard>().agility > Abig || TeamBCrew2.GetComponent<SimpleCard>().brawl > Abig || TeamBCrew2.GetComponent<SimpleCard>().cunning > Abig)
                                { PositionB = 2; ActionB = 6; if (LastActionB == ActionB) { ActionB = 4; } }
                                else if (TeamBCrew3.GetComponent<SimpleCard>().agility > Abig || TeamBCrew3.GetComponent<SimpleCard>().brawl > Abig || TeamBCrew3.GetComponent<SimpleCard>().cunning > Abig)
                                { PositionB = 3; ActionB = 6; if (LastActionB == ActionB) { ActionB = 4; } }
                                else if (TeamBCrew4.GetComponent<SimpleCard>().agility > Abig || TeamBCrew4.GetComponent<SimpleCard>().brawl > Abig || TeamBCrew4.GetComponent<SimpleCard>().cunning > Abig)
                                { PositionB = 4; ActionB = 6; if (LastActionB == ActionB) { ActionB = 4; } }

                            }
                        }

                    }
                    else if(LastActionB == ActionB) { ActionB = 4; }

                }
                switch (ActionB)
                {
                    case 1://tribeskill
                        Debug.Log("Action TribeSkill");
                        break;


                    case 2://Go Donw
                        Debug.Log("Action Go Down");
                        if (PressureLevel > 1)
                        {
                            PressureLevel -= 1;
                        }
                        break;

                    case 3://Go Up
                        Debug.Log("Action Go Up");
                        if (PressureLevel < 5)
                        {
                            PressureLevel += 1;
                        }
                        break;

                    case 4://Cleaning
                        Debug.Log("Action Clean");
                        if (PollutionLevel > 1)
                        {
                            PollutionLevel -= 1;
                        }
                        break;


                    case 5://Cleanig Plus+
                        Debug.Log("Action CleanPlus");
                        if (PollutionLevel > 1)
                        {
                            PollutionLevel -= 3;
                            if (PollutionLevel < 0)
                            {
                                PollutionLevel = 0;
                            }
                            CleanPlus = 1;
                        }
                        break;

                    case 6://Switch
                        Debug.Log("Action Switch Card");
                         SwitchCardsB(); SwitchActionB = true;
                        break;

                }

                UpdateAtributes();
                Pollution();
                SetCurrent();
                UpdateImage();
                UpdateName();
                Turno();
                LastActionA = ActionA;
                LastActionB = ActionB;
                ActionA = 0;
                ActionB = 0;
            }
        }
        

    }

    private void Turno()
    {
        Timer = 45.5f;
        switch (Match)
        {
            case 1:
                switch (Round)
                {
                    case 1:
                        if (Abig > Bbig) { RoundA++; RoundA1.GetComponent<Image>().sprite = RoundWin; RoundB1.GetComponent<Image>().sprite = RoundLose; }
                        if (Bbig > Abig) { RoundB++; RoundA1.GetComponent<Image>().sprite = RoundLose; RoundB1.GetComponent<Image>().sprite = RoundWin; }
                        Round++;
                        break;
                    case 2:
                        if (Abig > Bbig) { RoundA++; RoundA2.GetComponent<Image>().sprite = RoundWin; RoundB2.GetComponent<Image>().sprite = RoundLose; }
                        if (Bbig > Abig) { RoundB++; RoundA2.GetComponent<Image>().sprite = RoundLose; RoundB2.GetComponent<Image>().sprite = RoundWin; }
                        Round++;
                        break;
                    case 3:
                        if (Abig > Bbig) { RoundA++; RoundA3.GetComponent<Image>().sprite = RoundWin; RoundB3.GetComponent<Image>().sprite = RoundLose; }
                        if (Bbig > Abig) { RoundB++; RoundA3.GetComponent<Image>().sprite = RoundLose; RoundB3.GetComponent<Image>().sprite = RoundWin; }
                        Round = 1;

                        MatchRefresh();


                        if (RoundA > RoundB) { MatchText.GetComponent<Text>().text = "You Won this match"; MatchA++; Match1.GetComponent<Image>().sprite = MatchWin; }
                        if (RoundA < RoundB) { MatchText.GetComponent<Text>().text = "You Lost this match"; MatchB++; Match1.GetComponent<Image>().sprite = MatchLose; }
                        break;
                }
                break;
            case 2:
                switch (Round)
                {
                    case 1:
                        if (Abig > Bbig) { RoundA++; RoundA1.GetComponent<Image>().sprite = RoundWin; RoundB1.GetComponent<Image>().sprite = RoundLose; }
                        if (Bbig > Abig) { RoundB++; RoundA1.GetComponent<Image>().sprite = RoundLose; RoundB1.GetComponent<Image>().sprite = RoundWin; }
                        Round++;
                        break;
                    case 2:
                        if (Abig > Bbig) { RoundA++; RoundA2.GetComponent<Image>().sprite = RoundWin; RoundB2.GetComponent<Image>().sprite = RoundLose; }
                        if (Bbig > Abig) { RoundB++; RoundA2.GetComponent<Image>().sprite = RoundLose; RoundB2.GetComponent<Image>().sprite = RoundWin; }
                        Round++;
                        break;
                    case 3:
                        if (Abig > Bbig) { RoundA++; RoundA3.GetComponent<Image>().sprite = RoundWin; RoundB3.GetComponent<Image>().sprite = RoundLose; }
                        if (Bbig > Abig) { RoundB++; RoundA3.GetComponent<Image>().sprite = RoundLose; RoundB3.GetComponent<Image>().sprite = RoundWin; }
                        Round = 1;

                        MatchRefresh();


                        if (RoundA > RoundB) { MatchText.GetComponent<Text>().text = "You Won this match"; MatchA++; Match2.GetComponent<Image>().sprite = MatchWin; }
                        if (RoundA < RoundB) { MatchText.GetComponent<Text>().text = "You Lost this match"; MatchB++; Match2.GetComponent<Image>().sprite = MatchLose; }
                        break;
                }
                break;
            case 3:
                switch (Round)
                {
                    case 1:
                        if (Abig > Bbig) { RoundA++; RoundA1.GetComponent<Image>().sprite = RoundWin; RoundB1.GetComponent<Image>().sprite = RoundLose; }
                        if (Bbig > Abig) { RoundB++; RoundA1.GetComponent<Image>().sprite = RoundLose; RoundB1.GetComponent<Image>().sprite = RoundWin; }
                        Round++;
                        break;
                    case 2:
                        if (Abig > Bbig) { RoundA++; RoundA2.GetComponent<Image>().sprite = RoundWin; RoundB2.GetComponent<Image>().sprite = RoundLose; }
                        if (Bbig > Abig) { RoundB++; RoundA2.GetComponent<Image>().sprite = RoundLose; RoundB2.GetComponent<Image>().sprite = RoundWin; }
                        Round++;
                        break;
                    case 3:
                        if (Abig > Bbig) { RoundA++; RoundA3.GetComponent<Image>().sprite = RoundWin; RoundB3.GetComponent<Image>().sprite = RoundLose; }
                        if (Bbig > Abig) { RoundB++; RoundA3.GetComponent<Image>().sprite = RoundLose; RoundB3.GetComponent<Image>().sprite = RoundWin; }
                        Round = 1;

                        MatchRefresh();


                        if (RoundA > RoundB) { MatchText.GetComponent<Text>().text = "You Won this match"; MatchA++; Match3.GetComponent<Image>().sprite = MatchWin; }
                        if (RoundA < RoundB) { MatchText.GetComponent<Text>().text = "You Lost this match"; MatchB++; Match3.GetComponent<Image>().sprite = MatchLose; }
                        break;
                }
                break;
            case 4:
                switch (Round)
                {
                    case 1:
                        if (Abig > Bbig) { RoundA++; RoundA1.GetComponent<Image>().sprite = RoundWin; RoundB1.GetComponent<Image>().sprite = RoundLose; }
                        if (Bbig > Abig) { RoundB++; RoundA1.GetComponent<Image>().sprite = RoundLose; RoundB1.GetComponent<Image>().sprite = RoundWin; }
                        Round++;
                        break;
                    case 2:
                        if (Abig > Bbig) { RoundA++; RoundA2.GetComponent<Image>().sprite = RoundWin; RoundB2.GetComponent<Image>().sprite = RoundLose; }
                        if (Bbig > Abig) { RoundB++; RoundA2.GetComponent<Image>().sprite = RoundLose; RoundB2.GetComponent<Image>().sprite = RoundWin; }
                        Round++;
                        break;
                    case 3:
                        if (Abig > Bbig) { RoundA++; RoundA3.GetComponent<Image>().sprite = RoundWin; RoundB3.GetComponent<Image>().sprite = RoundLose; }
                        if (Bbig > Abig) { RoundB++; RoundA3.GetComponent<Image>().sprite = RoundLose; RoundB3.GetComponent<Image>().sprite = RoundWin; }
                        Round = 1;

                        MatchRefresh();


                        if (RoundA > RoundB) { MatchText.GetComponent<Text>().text = "You Won this match"; MatchA++; Match4.GetComponent<Image>().sprite = MatchWin; }
                        if (RoundA < RoundB) { MatchText.GetComponent<Text>().text = "You Lost this match"; MatchB++; Match4.GetComponent<Image>().sprite = MatchLose; }
                        break;
                }
                break;
            case 5:
                switch (Round)
                {
                    case 1:
                        if (Abig > Bbig) { RoundA++; RoundA1.GetComponent<Image>().sprite = RoundWin; RoundB1.GetComponent<Image>().sprite = RoundLose; }
                        if (Bbig > Abig) { RoundB++; RoundA1.GetComponent<Image>().sprite = RoundLose; RoundB1.GetComponent<Image>().sprite = RoundWin; }
                        Round++;
                        break;
                    case 2:
                        if (Abig > Bbig) { RoundA++; RoundA2.GetComponent<Image>().sprite = RoundWin; RoundB2.GetComponent<Image>().sprite = RoundLose; }
                        if (Bbig > Abig) { RoundB++; RoundA2.GetComponent<Image>().sprite = RoundLose; RoundB2.GetComponent<Image>().sprite = RoundWin; }
                        Round++;
                        break;
                    case 3:
                        if (Abig > Bbig) { RoundA++; RoundA3.GetComponent<Image>().sprite = RoundWin; RoundB3.GetComponent<Image>().sprite = RoundLose; }
                        if (Bbig > Abig) { RoundB++; RoundA3.GetComponent<Image>().sprite = RoundLose; RoundB3.GetComponent<Image>().sprite = RoundWin; }
                        Round = 1;

                        MatchOverlay.SetActive(true);


                        if (RoundA > RoundB) { MatchText.GetComponent<Text>().text = "You Won this match"; MatchA++; Match5.GetComponent<Image>().sprite = MatchWin; }
                        if (RoundA < RoundB) { MatchText.GetComponent<Text>().text = "You Lost this match"; MatchB++; Match5.GetComponent<Image>().sprite = MatchLose; }
                        break;
                }
                break;

        }

        PollutionLevel++;
        if (PollutionLevel >= 7) { PollutionLevel = 7; }
    }
    public void MatchRefresh()
    {
        Match++;
        MatchOverlay.SetActive(true);
        if (Match == 2) { MatchCount.GetComponent<Image>().sprite = MatchCount2; }
        if (Match == 3) { MatchCount.GetComponent<Image>().sprite = MatchCount3; }
        if (Match == 4) { MatchCount.GetComponent<Image>().sprite = MatchCount4; }
        if (Match == 5) { MatchCount.GetComponent<Image>().sprite = MatchCount5; }
        if (MatchA > MatchB) { MatchText.GetComponent < Text>().text = "You Won this Game!!";}
        if (MatchA < MatchB) { MatchText.GetComponent<Text>().text = "You Lost this Game!!"; }
        RoundA = 0;
        RoundB = 0;
        RoundA1.GetComponent<Image>().sprite = RoundNone;
        RoundA2.GetComponent<Image>().sprite = RoundNone;
        RoundA3.GetComponent<Image>().sprite = RoundNone;
        RoundB1.GetComponent<Image>().sprite = RoundNone;
        RoundB2.GetComponent<Image>().sprite = RoundNone;
        RoundB3.GetComponent<Image>().sprite = RoundNone;
        Timer = 50;
        ActionA = 6;
        OnSwitch = true;        
        ExecuteAction();
    }

    
}