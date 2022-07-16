using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrainingMode : MonoBehaviour
{
    public float Timer;

    [SerializeField]
    private int PollutionLevel, PressureLevel, Round, Match,Action,CleanPlus;
    [SerializeField]
    private GameObject TimerObj,PollutionText, PressureCompass, RoundTextA, RoundTextB, Pointier,Motor;
    [SerializeField]
    private GameObject MatchCount, Match1, Match2, Match3, Match4, Match5;
    [SerializeField]
    private Sprite Motor1, Motor2, Motor3, RoundWin, RoundLose, RoundNone, MatchWin, MatchLose, MatchNone, MatchCount1, MatchCount2, MatchCount3, MatchCount4, MatchCount5;
    [SerializeField]
    private bool Started;

    public string tribe;
    public float speed, smooth,PointearC;
    public int Position;

    public GameObject ACommander,ACrew1,ACrew2,ACrew3,ACrew4;
    public GameObject TeamAActive, TeamACrew1, TeamACrew2, TeamACrew3, TeamACrew4;
    public GameObject teamBActive, BotACrew1, BotCrew2, BotACrew3, BotACrew4;
    public GameObject IdealPressureA1, IdealPressureA2, IdealPressureA3, IdealPressureA4, IdealPressureA5;
    public GameObject IdealPressureB1, IdealPressureB2, IdealPressureB3, IdealPressureB4, IdealPressureB5;
    public GameObject TeamAActiveName, teamBActiveName, RarityA1, RarityA2, RarityA3, RarityA4, RarityA5, RarityB1, RarityB2, RarityB3, RarityB4, RarityB5;
    public GameObject levelA, LevelB, TribeA, TribeB, HabilityA, habilityB, BrawnA, AgilityA, CunnigA, BrawnB, AgilityB, CunningB;
    public Sprite TribecaseManylimbs, TribeSeasinger, TribeClawbeasts, TribeRoughskins, TribeJellies, TribeShellbearers, TribeScalefins;


    //public float AgilityAFloat, AgilityBFloat,BrawAFloat,BrawBFloat,CunnigAFloat,CunningBFloat;



    // Start is called before the first frame update
    private void Awake()
    {

        Timer = 45;
        Started = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer > 0)
        {
            Timer -= Time.deltaTime;
            UpdateDisplay(Timer);
        }
        else Timer = 0; 
        
        if (Started == true)
        {
            switch (PressureLevel)
            {
                /* case 0:
                     PointierCraize();
                     break;*/

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
        if (Started == true)
        {
            MotorFrame();
            UpdateAtributes();
        }
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
        if (seconds > 15 & seconds <30) { TimerObj.GetComponent<Text>().color = Color.yellow; }
        if (seconds <= 15){ TimerObj.GetComponent<Text>().color = Color.red; }

    }
    
    public void ExecuteAction(int Action)
    { switch (Action) 
        {       //tribeskill
            case 1:

                break;

            //Go Donw
            case 2:
                if (PressureLevel > 1) 
                { 
                    PressureLevel -= 1; 
                } 
                break;
            //Go Up
            case 3:
                if (PressureLevel < 5) 
                { 
                    PressureLevel += 1;
                }
                break;
            //Cleaning
            case 4:
                if (PollutionLevel > 1) 
                {
                    PollutionLevel -= 1; 
                }
                break;

            //Cleanig Plus+
            case 5:
                if (PollutionLevel >1) 
                { 
                    PollutionLevel -= 3;
                    if (PollutionLevel <= 0) 
                    { 
                        PollutionLevel = 0; 
                    }
                    CleanPlus = 1;
                }
                break;
            //Switch
            case 6:

                break;

        }
        
    }
    public void Tribeskill() { Action = 1;  }
    public void GoDown() { Action = 2;  }
    public void GoUp() { Action = 3; }
    public void Cleaning() { Action = 4;ExecuteAction(Action); }
    public void CleaningPlus() { Action = 5;ExecuteAction(Action); }    
    public void Switch() { Action = 6; }
    


    public void UpdateActiveChampionChampion()
    {
        
        UpdateAtributes();
        UpdateTribeIcon();
        UpdateChampionPressure();
    }



    public void Starter()
    {
        Started = true;
    }
    public void Ended()
    {
        Started = false;
    }
    public void UpdateAtributes()
    {
        AgilityA.GetComponent<Text>().text = TeamAActive.GetComponent<Item>().agility.ToString();
        BrawnA.GetComponent<Text>().text = TeamAActive.GetComponent<Item>().brawl.ToString();
        CunnigA.GetComponent<Text>().text = TeamAActive.GetComponent<Item>().cunning.ToString();
        
    }
    public void UpdateTribeIcon() {

         tribe = TeamAActive.GetComponent<Item>().tribe;
        switch (tribe){
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
    { int pressure = TeamAActive.GetComponent<Item>().idealPressure;
        switch(pressure)
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

    public void UpdateChampionImage()
    {
        switch(Position){
            case 0:
            TeamAActive.GetComponent<Image>().sprite = ACommander.GetComponent<Sprite>();
                break;
            case 1:
                TeamAActive.GetComponent<Image>().sprite = ACommander.GetComponent<Sprite>();
                break;
            case 2:
                TeamAActive.GetComponent<Image>().sprite = ACommander.GetComponent<Sprite>();
                break;
            case 3:
                TeamAActive.GetComponent<Image>().sprite = ACommander.GetComponent<Sprite>();
                break;
            case 4:
                TeamAActive.GetComponent<Image>().sprite = ACommander.GetComponent<Sprite>();
                break;
            
        }
    }
}

