using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrainingMode : MonoBehaviour
{ 
    public float Timer;
    [SerializeField]
    private float  TotalBpTeamA,TotalBpTeamB;
    [SerializeField]
    private int PollutionLevel, PressureLevel, Round, Match, Action, CleanPlus;
    [SerializeField]
    private GameObject TimerObj, PollutionText, PressureCompass, RoundTextA, RoundTextB, Pointier, Motor, CardChampion, Pollution1, Pollution2, Pollution3, Pollution4, Pollution5, Pollution6, Pollution7;
    [SerializeField]
    private GameObject MatchCount, Match1, Match2, Match3, Match4, Match5;
    [SerializeField]
    private Sprite Motor1, Motor2, Motor3, RoundWin, RoundLose, RoundNone, MatchWin, MatchLose, MatchNone, MatchCount1, MatchCount2, MatchCount3, MatchCount4, MatchCount5;
    [SerializeField]
    private bool CrewImage;

    private float BPlow,BPhigh;

    public bool Started, ConfirmationButton;
    public string tribe, ChampionName, Name;
    public float speed, smooth, PointearC;
    public int Position, Dificult;

    public GameObject ACommander, ACrew1, ACrew2, ACrew3, ACrew4;
    public GameObject TeamAActive, TeamACrew1, TeamACrew2, TeamACrew3, TeamACrew4;
    //public GameObject BCommander, BCrew1,BCrew2, BCrew3, BCrew4;
    public GameObject TeamBActive, TeamBCrew1,TeamBCrew2, TeamBCrew3, TeamBCrew4;
    public GameObject IdealPressureA1, IdealPressureA2, IdealPressureA3, IdealPressureA4, IdealPressureA5;
    public GameObject IdealPressureB1, IdealPressureB2, IdealPressureB3, IdealPressureB4, IdealPressureB5;
    public GameObject TeamAActiveName, teamBActiveName, RarityA1, RarityA2, RarityA3, RarityA4, RarityA5, RarityB1, RarityB2, RarityB3, RarityB4, RarityB5;
    public GameObject levelA, LevelB, TribeA, TribeB, HabilityA, habilityB, BrawnA, AgilityA, CunnigA, BrawnB, AgilityB, CunningB;
    public Sprite TribecaseManylimbs, TribeSeasinger, TribeClawbeasts, TribeRoughskins, TribeJellies, TribeShellbearers, TribeScalefins;
    public Sprite JOHN_FANGO, CAPTAIN, TED, NENRUNG, REZAUL, GARRINCHA, LUKE, RAY, SIR_WESTLEY, LIZA, HANIS, SARGEANT_HARTMAN, RIDLEY, ARSELLA,
   ROCUS, AARON, WANDERLEY, LOLA, TODD, JOHNNY, SOORYA, IRFAN, DANILO, ZEPEREIRA, BOB_SAW, TISYA, SASHA, MEDHANSH, SIRILO, MAHESH,
   RICHARD, ED, ADAM;

    // Start is called before the first frame update
    private void Awake()
    {
        Timer = 45;
        CrewImage = false;
        Pollution1.SetActive(false);
        Pollution2.SetActive(false);
        Pollution3.SetActive(false);
        Pollution4.SetActive(false);
        Pollution5.SetActive(false);
        Pollution6.SetActive(false);
        Pollution7.SetActive(false); 
    }
    
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
           
            if (CrewImage == false)
            {
                CrewUpdateImage();               
               
                CrewImage = true;
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
    }
    public void CrewUpdateImage()
    {
        UpdateActiveChampion();
        UpdateChampionImage(TeamACrew1, 1);
        UpdateChampionImage(TeamACrew2, 2);
        UpdateChampionImage(TeamACrew3, 3);
        UpdateChampionImage(TeamACrew4, 4);
    }

    public void PointierRotation(int Target)
    {
        var TargetF = Quaternion.Euler(Pointier.transform.eulerAngles.y, Pointier.transform.eulerAngles.x, Target);
        Pointier.transform.rotation = Quaternion.Lerp(Pointier.transform.rotation, TargetF, Time.deltaTime * smooth);
    }
    private void MotorFrame()
    {
        if (Motor.GetComponent<Image>().sprite == Motor1)
        {
            Motor.GetComponent<Image>().sprite = Motor2;
            new WaitForSeconds(3);
        }
        if (Motor.GetComponent<Image>().sprite == Motor2)
        {
            Motor.GetComponent<Image>().sprite = Motor3;
            new WaitForSeconds(3);
        }
        if (Motor.GetComponent<Image>().sprite == Motor3)
        {
            Motor.GetComponent<Image>().sprite = Motor1;
            new WaitForSeconds(3);
        }


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

    //Action confirmation and action Buttons 
    public void ExecuteAction()
    {

        switch (Action)
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
                    if (PollutionLevel <= 0)
                    {
                        PollutionLevel = 0;
                    }
                    CleanPlus = 1;
                }
                break;

            case 6://Switch
                Debug.Log("Action Switch Card");

                break;

        }
        BotAction();

    }
    public void Tribeskill() { Action = 1; }
    public void GoDown() { Action = 2; }
    public void GoUp() { Action = 3; }
    public void Cleaning() { Action = 4; }
    public void CleaningPlus() { Action = 5; }
    public void Switch() { Action = 6; }

    //Starte and and funciontio
    public void Starter()
    {
        Started = true;
    }
    public void Ended()
    {
        Started = false;
    }

    //Main function to Update The visual of the card on Fight, iniciated as the commander of the team 
    public void UpdateActiveChampion()
    {

        UpdateAtributes();
        UpdateTribeIcon();
        UpdateChampionPressure();
        UpdateChampionImage(TeamAActive,0);
        UpdateName(TeamAActive);
    }    
    public void UpdateAtributes()
    {
        switch (Position)
        {
            case 0:
                AgilityA.GetComponent<Text>().text = ACommander.GetComponent<Item>().agility.ToString();
                BrawnA.GetComponent<Text>().text = ACommander.GetComponent<Item>().brawl.ToString();
                CunnigA.GetComponent<Text>().text = ACommander.GetComponent<Item>().cunning.ToString();
                break;
            case 1:
                AgilityA.GetComponent<Text>().text = ACrew1.GetComponent<Item>().agility.ToString();
                BrawnA.GetComponent<Text>().text = ACrew1.GetComponent<Item>().brawl.ToString();
                CunnigA.GetComponent<Text>().text = ACrew1.GetComponent<Item>().cunning.ToString();
                break;
            case 2:
                AgilityA.GetComponent<Text>().text = ACrew2.GetComponent<Item>().agility.ToString();
                BrawnA.GetComponent<Text>().text = ACrew2.GetComponent<Item>().brawl.ToString();
                CunnigA.GetComponent<Text>().text = ACrew2.GetComponent<Item>().cunning.ToString();
                break;
            case 3:
                AgilityA.GetComponent<Text>().text = ACrew3.GetComponent<Item>().agility.ToString();
                BrawnA.GetComponent<Text>().text = ACrew3.GetComponent<Item>().brawl.ToString();
                CunnigA.GetComponent<Text>().text = ACrew3.GetComponent<Item>().cunning.ToString();
                break;
            case 4:
                AgilityA.GetComponent<Text>().text = ACrew4.GetComponent<Item>().agility.ToString();
                BrawnA.GetComponent<Text>().text = ACrew4.GetComponent<Item>().brawl.ToString();
                CunnigA.GetComponent<Text>().text = ACrew4.GetComponent<Item>().cunning.ToString();
                break;
        }


    }
    public void UpdateTribeIcon()
    {

        switch (Position)
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
        switch (Position)
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
    public void UpdateChampionImage(GameObject Champion,int position)
    {

        switch (position)
        {

            case 0:
                Name = ACommander.GetComponent<Item>().name;
                break;
            case 1:
                Name = ACrew1.GetComponent<Item>().name;
                break;
            case 2:
                Name = ACrew2.GetComponent<Item>().name;
                break;
            case 3:
                Name = ACrew3.GetComponent<Item>().name;
                break;
            case 4:
                Name = ACrew4.GetComponent<Item>().name;
                break;
            case 5:
                
                break;

        }
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
    public void UpdateName(GameObject Champion)
    {
        switch (Position)
        {

            case 0:
                TeamAActiveName.GetComponent<Text>().text = ACommander.GetComponent<Item>().name.ToString();
                break;
            case 1:
                TeamAActiveName.GetComponent<Text>().text = ACrew1.GetComponent<Item>().name.ToString();
                break;
            case 2:
                TeamAActiveName.GetComponent<Text>().text = ACrew2.GetComponent<Item>().name.ToString();
                break;
            case 3:
                TeamAActiveName.GetComponent<Text>().text = ACrew3.GetComponent<Item>().name.ToString();
                break;
            case 4:
                TeamAActiveName.GetComponent<Text>().text = ACrew4.GetComponent<Item>().name.ToString();
                break;

        }
    }

    //INtantiate and Destroy Card Overlay os the crew
    public void ShowCardOver()
    {
        var CardOverlay = Instantiate(CardChampion);
        CardOverlay.transform.SetParent(GameObject.Find("Canvas_TrainingMode").transform, false);
        CardOverlay.transform.localScale = new Vector3(0.5f, 0.5f, 1);
        switch (Position)
        {
            
            case 1:
                CardOverlay.transform.position = TeamACrew1.transform.position;
                CardOverlay.GetComponent<CardChapion>().id = ACrew1.GetComponent<Item>().id;
                CardOverlay.GetComponent<CardChapion>().name = ACrew1.GetComponent<Item>().name;
                CardOverlay.GetComponent<CardChapion>().image = ACrew1.GetComponent<Item>().image;
                CardOverlay.GetComponent<CardChapion>().tribe = ACrew1.GetComponent<Item>().tribe;
                CardOverlay.GetComponent<CardChapion>().rarity = ACrew1.GetComponent<Item>().rarity;
                CardOverlay.GetComponent<CardChapion>().elite = ACrew1.GetComponent<Item>().elite;
                CardOverlay.GetComponent<CardChapion>().idealPressure = ACrew1.GetComponent<Item>().idealPressure;
                CardOverlay.GetComponent<CardChapion>().brawl = ACrew1.GetComponent<Item>().brawl;
                CardOverlay.GetComponent<CardChapion>().agility = ACrew1.GetComponent<Item>().agility;
                CardOverlay.GetComponent<CardChapion>().cunning = ACrew1.GetComponent<Item>().cunning;
                CardOverlay.GetComponent<CardChapion>().battlePower = ACrew1.GetComponent<Item>().battlePower;
                break;

            case 2:
                CardOverlay.transform.position = TeamACrew2.transform.position;
                CardOverlay.GetComponent<CardChapion>().id = ACrew2.GetComponent<Item>().id;
                CardOverlay.GetComponent<CardChapion>().name = ACrew2.GetComponent<Item>().name;
                CardOverlay.GetComponent<CardChapion>().image = ACrew2.GetComponent<Item>().image;
                CardOverlay.GetComponent<CardChapion>().tribe = ACrew2.GetComponent<Item>().tribe;
                CardOverlay.GetComponent<CardChapion>().rarity = ACrew2.GetComponent<Item>().rarity;
                CardOverlay.GetComponent<CardChapion>().elite = ACrew2.GetComponent<Item>().elite;
                CardOverlay.GetComponent<CardChapion>().idealPressure = ACrew2.GetComponent<Item>().idealPressure;
                CardOverlay.GetComponent<CardChapion>().brawl = ACrew2.GetComponent<Item>().brawl;
                CardOverlay.GetComponent<CardChapion>().agility = ACrew2.GetComponent<Item>().agility;
                CardOverlay.GetComponent<CardChapion>().cunning = ACrew2.GetComponent<Item>().cunning;
                CardOverlay.GetComponent<CardChapion>().battlePower = ACrew2.GetComponent<Item>().battlePower;
                break;

            case 3:
                CardOverlay.transform.position = TeamACrew3.transform.position;
                CardOverlay.GetComponent<CardChapion>().id = ACrew3.GetComponent<Item>().id;
                CardOverlay.GetComponent<CardChapion>().name = ACrew3.GetComponent<Item>().name;
                CardOverlay.GetComponent<CardChapion>().image = ACrew3.GetComponent<Item>().image;
                CardOverlay.GetComponent<CardChapion>().tribe = ACrew3.GetComponent<Item>().tribe;
                CardOverlay.GetComponent<CardChapion>().rarity = ACrew3.GetComponent<Item>().rarity;
                CardOverlay.GetComponent<CardChapion>().elite = ACrew3.GetComponent<Item>().elite;
                CardOverlay.GetComponent<CardChapion>().idealPressure = ACrew3.GetComponent<Item>().idealPressure;
                CardOverlay.GetComponent<CardChapion>().brawl = ACrew3.GetComponent<Item>().brawl;
                CardOverlay.GetComponent<CardChapion>().agility = ACrew3.GetComponent<Item>().agility;
                CardOverlay.GetComponent<CardChapion>().cunning = ACrew3.GetComponent<Item>().cunning;
                CardOverlay.GetComponent<CardChapion>().battlePower = ACrew3.GetComponent<Item>().battlePower;
                break;

            case 4:
                CardOverlay.transform.position = TeamACrew4.transform.position;
                
                CardOverlay.GetComponent<CardChapion>().id = ACrew4.GetComponent<Item>().id;
                CardOverlay.GetComponent<CardChapion>().name = ACrew4.GetComponent<Item>().name;
                CardOverlay.GetComponent<CardChapion>().image = ACrew4.GetComponent<Item>().image;
                CardOverlay.GetComponent<CardChapion>().tribe = ACrew4.GetComponent<Item>().tribe;
                CardOverlay.GetComponent<CardChapion>().rarity = ACrew4.GetComponent<Item>().rarity;
                CardOverlay.GetComponent<CardChapion>().elite = ACrew4.GetComponent<Item>().elite;
                CardOverlay.GetComponent<CardChapion>().idealPressure = ACrew4.GetComponent<Item>().idealPressure;
                CardOverlay.GetComponent<CardChapion>().brawl = ACrew4.GetComponent<Item>().brawl;
                CardOverlay.GetComponent<CardChapion>().agility = ACrew4.GetComponent<Item>().agility;
                CardOverlay.GetComponent<CardChapion>().cunning = ACrew4.GetComponent<Item>().cunning;
                CardOverlay.GetComponent<CardChapion>().battlePower = ACrew4.GetComponent<Item>().battlePower;
                break;
        }
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
    public void GetCommander() { Position = 0; }
    public void GetCrew1() { Position = 1; }
    public void GetCrew2() { Position = 2; }
    public void GetCrew3() { Position = 3; }
    public void GetCrew4() { Position = 4; }



    //Bot Instructions and settings
    public void BotAction()
    {

    }
    public void GetBotCards()
    {
        TotalBpTeamA = ACommander.GetComponent<Item>().battlePower + ACrew1.GetComponent<Item>().battlePower + ACrew2.GetComponent<Item>().battlePower + ACrew3.GetComponent<Item>().battlePower + ACrew4.GetComponent<Item>().battlePower;

        switch (Dificult)
        {
            case 1:  BPlow = TotalBpTeamA * 0.5f;  BPhigh = TotalBpTeamA;break;
            case 2:  BPlow = TotalBpTeamA * 0.85f; BPhigh = TotalBpTeamA *1.15f;break;
            case 3:  BPlow = TotalBpTeamA * 1.25f; BPhigh = TotalBpTeamA *1.50f;break;
        }
        {
            GetRandonCard(TeamBActive);
            GetRandonCard(TeamBCrew1);
            GetRandonCard(TeamBCrew2);
            GetRandonCard(TeamBCrew3);
            GetRandonCard(TeamBCrew4);
            TotalBpTeamB = TeamBActive.GetComponent<SimpleCard>().battlePower + TeamBCrew1.GetComponent<SimpleCard>().battlePower + TeamBCrew2.GetComponent<SimpleCard>().battlePower + TeamBCrew3.GetComponent<SimpleCard>().battlePower + TeamBCrew4.GetComponent<SimpleCard>().battlePower;

            if ((BPlow < TotalBpTeamB) & (TotalBpTeamB < BPhigh))
            {
                Debug.Log("funcionou");
            }
            else { Debug.Log("falhou"); GetBotCards(); }
            
        }

    }

    private void GetRandonCard(GameObject card)
    {  
        int number = Random.Range(1, 34);
        switch (number)
            {
                case 1:
                    card.GetComponent<SimpleCard>().agility = 222;
                    card.GetComponent<SimpleCard>().brawl = 333;
                    card.GetComponent<SimpleCard>().cunning = 111;
                    card.GetComponent<SimpleCard>().idealPressure = 4;
                    break;
                case 2:
                    card.GetComponent<SimpleCard>().agility = 222;
                    card.GetComponent<SimpleCard>().brawl = 111;
                    card.GetComponent<SimpleCard>().cunning = 222;
                    card.GetComponent<SimpleCard>().idealPressure = 1;

                    break;
                case 3:
                    card.GetComponent<SimpleCard>().agility = 240;
                    card.GetComponent<SimpleCard>().brawl = 260;
                    card.GetComponent<SimpleCard>().cunning = 100;
                    card.GetComponent<SimpleCard>().idealPressure = 2;

                    break;
                case 4:
                    card.GetComponent<SimpleCard>().agility = 247;
                    card.GetComponent<SimpleCard>().brawl = 120;
                    card.GetComponent<SimpleCard>().cunning = 100;
                    card.GetComponent<SimpleCard>().idealPressure = 3;

                    break;
                case 5:
                    card.GetComponent<SimpleCard>().agility = 75;
                    card.GetComponent<SimpleCard>().brawl = 150;
                    card.GetComponent<SimpleCard>().cunning = 233;
                    card.GetComponent<SimpleCard>().idealPressure = 1;

                    break;
                case 6:
                    card.GetComponent<SimpleCard>().agility = 220;
                    card.GetComponent<SimpleCard>().brawl = 220;
                    card.GetComponent<SimpleCard>().cunning = 51;
                    card.GetComponent<SimpleCard>().idealPressure = 2;
                    break;
                case 7:
                    card.GetComponent<SimpleCard>().agility = 150;
                    card.GetComponent<SimpleCard>().brawl = 261;
                    card.GetComponent<SimpleCard>().cunning = 85;
                    card.GetComponent<SimpleCard>().idealPressure = 2;

                    break;
                case 8:
                    card.GetComponent<SimpleCard>().agility = 181;
                    card.GetComponent<SimpleCard>().brawl = 264;
                    card.GetComponent<SimpleCard>().cunning = 55;
                    card.GetComponent<SimpleCard>().idealPressure = 4;

                    break;
                case 9:
                    card.GetComponent<SimpleCard>().agility = 183;
                    card.GetComponent<SimpleCard>().brawl = 75;
                    card.GetComponent<SimpleCard>().cunning = 110;
                    card.GetComponent<SimpleCard>().idealPressure = 1;
                    break;
                case 10:
                    card.GetComponent<SimpleCard>().agility = 120;
                    card.GetComponent<SimpleCard>().brawl = 193;
                    card.GetComponent<SimpleCard>().cunning = 78;
                    card.GetComponent<SimpleCard>().idealPressure = 3;
                    break;
                case 11:

                    card.GetComponent<SimpleCard>().agility = 185;
                    card.GetComponent<SimpleCard>().brawl = 96;
                    card.GetComponent<SimpleCard>().cunning = 90;
                    card.GetComponent<SimpleCard>().idealPressure = 2;
                    break;

                case 12:
                    card.GetComponent<SimpleCard>().agility = 180;
                    card.GetComponent<SimpleCard>().brawl = 116;
                    card.GetComponent<SimpleCard>().cunning = 80;
                    card.GetComponent<SimpleCard>().idealPressure = 1;
                    break;

                 case 13:
                    card.GetComponent<SimpleCard>().agility = 160;
                    card.GetComponent<SimpleCard>().brawl = 1745;
                    card.GetComponent<SimpleCard>().cunning = 80;
                    card.GetComponent<SimpleCard>().idealPressure = 1;
                    break;

                case 14:
                    card.GetComponent<SimpleCard>().agility = 85;
                    card.GetComponent<SimpleCard>().brawl = 115;
                    card.GetComponent<SimpleCard>().cunning = 169;
                    card.GetComponent<SimpleCard>().idealPressure = 4;
                    break;

                case 15:
                card.GetComponent<SimpleCard>().agility = 100;
                card.GetComponent<SimpleCard>().brawl = 203;
                card.GetComponent<SimpleCard>().cunning = 90;
                card.GetComponent<SimpleCard>().idealPressure = 4;
                break;

                 case 16:
                card.GetComponent<SimpleCard>().agility = 102;
                card.GetComponent<SimpleCard>().brawl = 199;
                card.GetComponent<SimpleCard>().cunning = 93;
                card.GetComponent<SimpleCard>().idealPressure = 4;
                break;

                 case 17:
                card.GetComponent<SimpleCard>().agility = 93;
                card.GetComponent<SimpleCard>().brawl = 100;
                card.GetComponent<SimpleCard>().cunning = 111;
                card.GetComponent<SimpleCard>().idealPressure = 1;
                break;

                 case 18:
                card.GetComponent<SimpleCard>().name = "Loa the Blowfish";
                card.GetComponent<SimpleCard>().agility = 182;
                card.GetComponent<SimpleCard>().brawl = 102;
                card.GetComponent<SimpleCard>().cunning = 90;
                card.GetComponent<SimpleCard>().idealPressure = 3;
                break;

                 case 19:                
               card.GetComponent<SimpleCard>().agility = 150;
                card.GetComponent<SimpleCard>().brawl = 79;
                card.GetComponent<SimpleCard>().cunning = 93;
                card.GetComponent<SimpleCard>().idealPressure = 4;
                break;

                 case 20:
                card.GetComponent<SimpleCard>().agility = 110;
                card.GetComponent<SimpleCard>().brawl = 60;
                card.GetComponent<SimpleCard>().cunning = 143;
                card.GetComponent<SimpleCard>().idealPressure = 2;
                break;

                 case 21:
                card.GetComponent<SimpleCard>().agility = 115;
                card.GetComponent<SimpleCard>().brawl = 73;
                card.GetComponent<SimpleCard>().cunning = 132;
                card.GetComponent<SimpleCard>().idealPressure = 4;
                break;

                 case 22:
                card.GetComponent<SimpleCard>().agility = 89;
                card.GetComponent<SimpleCard>().brawl = 168;
                card.GetComponent<SimpleCard>().cunning = 82;
                card.GetComponent<SimpleCard>().idealPressure = 3;
                break;

                 case 23:
                card.GetComponent<SimpleCard>().agility = 111;
                card.GetComponent<SimpleCard>().brawl = 151;
                card.GetComponent<SimpleCard>().cunning = 75;
                card.GetComponent<SimpleCard>().idealPressure = 3;
                break;

                case 24:
                card.GetComponent<SimpleCard>().agility = 85;
                card.GetComponent<SimpleCard>().brawl = 170;
                card.GetComponent<SimpleCard>().cunning = 85;
                card.GetComponent<SimpleCard>().idealPressure = 1;
                break;

                 case 25:
                card.GetComponent<SimpleCard>().agility = 145;
                card.GetComponent<SimpleCard>().brawl = 90;
                card.GetComponent<SimpleCard>().cunning = 80;
                card.GetComponent<SimpleCard>().idealPressure = 2;
                break;

                case 26:
                card.GetComponent<SimpleCard>().agility = 100;
                card.GetComponent<SimpleCard>().brawl = 90;
                card.GetComponent<SimpleCard>().cunning = 130;
                card.GetComponent<SimpleCard>().idealPressure = 2;
                break;

            case 27:
                card.GetComponent<SimpleCard>().agility = 99;
                card.GetComponent<SimpleCard>().brawl = 165;
                card.GetComponent<SimpleCard>().cunning = 75;
                card.GetComponent<SimpleCard>().idealPressure = 2;
                break;

                 case 28:
                card.GetComponent<SimpleCard>().agility = 65;
                card.GetComponent<SimpleCard>().brawl = 135;
                card.GetComponent<SimpleCard>().cunning = 130;
                card.GetComponent<SimpleCard>().idealPressure = 2;
                break;

                 case 29:
                card.GetComponent<SimpleCard>().agility = 93;
                card.GetComponent<SimpleCard>().brawl = 160;
                card.GetComponent<SimpleCard>().cunning = 100;
                card.GetComponent<SimpleCard>().idealPressure = 3;
                break;

                 case 30:
                card.GetComponent<SimpleCard>().agility = 160;
                card.GetComponent<SimpleCard>().brawl = 97;
                card.GetComponent<SimpleCard>().cunning = 70;
                card.GetComponent<SimpleCard>().idealPressure = 3;
                break;

                     case 31:
                card.GetComponent<SimpleCard>().agility = 98;
                card.GetComponent<SimpleCard>().brawl = 163;
                card.GetComponent<SimpleCard>().cunning = 80;
                card.GetComponent<SimpleCard>().idealPressure = 2;
                break;

                 case 32:
                card.GetComponent<SimpleCard>().agility = 160;
                card.GetComponent<SimpleCard>().brawl = 85;
                card.GetComponent<SimpleCard>().cunning = 80;
                card.GetComponent<SimpleCard>().idealPressure = 4;
                break;

                 case 33:
                card.GetComponent<SimpleCard>().agility = 140;
                card.GetComponent<SimpleCard>().brawl = 75;
                card.GetComponent<SimpleCard>().cunning = 105;
                card.GetComponent<SimpleCard>().idealPressure = 2;
                break;
                    

                default:
                    Debug.Log("Something go wrong");
                    break;
            }
        card.GetComponent<SimpleCard>().battlePower = card.GetComponent<SimpleCard>().agility + (card.GetComponent<SimpleCard>().brawl * 0.8f) + (card.GetComponent<SimpleCard>().cunning * 1.2f);

        
    }
    
}
