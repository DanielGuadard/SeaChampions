using UnityEngine;

public class Navigation : MonoBehaviour
{
    // Main windows
    [SerializeField]
    private GameObject menuMiddle, menuSide;

    // Navigation windows
    [SerializeField]
    private GameObject buildYourTeamWindow, compendiumWindow, optionsWindow, playNowWindow;

    // Buttons
    [SerializeField]
    private GameObject playNowButton, idlePVEButton, championsButton, compendiumButton,
        buildYourTeamButton, optionsButton, optionsButton2;

    //Scenes
    [SerializeField]
    private GameObject MainWindow, TrainingMode;


    public int BattleMode;

    public void ChampionsClick()
    {
        if (!compendiumButton.activeInHierarchy) {
           
            compendiumButton.SetActive(true);
            buildYourTeamButton.SetActive(true);
            optionsButton2.SetActive(true);
            optionsButton.SetActive(false);
        }
        else 
        {

            compendiumButton.SetActive(false);
            buildYourTeamButton.SetActive(false);
            optionsButton2.SetActive(false);
            optionsButton.SetActive(true);
        }
        
        if (menuMiddle.activeInHierarchy)
        {
            menuMiddle.SetActive(false);
            menuSide.SetActive(true);
            compendiumButton.SetActive(true);
            buildYourTeamButton.SetActive(true);
            optionsButton2.SetActive(true);
            optionsButton.SetActive(false);
        }
    }
    public void CompemdiumClick()
    {
        if (menuSide.activeInHierarchy)
        {
            optionsWindow.SetActive(false);
            buildYourTeamWindow.SetActive(false);
            playNowWindow.SetActive(false);
            compendiumWindow.SetActive(true);    
        }
    }
    public void BuildYourTeamClick()
    {
        if (menuSide.activeInHierarchy)
        {
            compendiumWindow.SetActive(false);
            optionsWindow.SetActive(false);
            playNowWindow.SetActive(false);
            buildYourTeamWindow.SetActive(true);
        }
    }

    public void OptionsClick()
    {
        if (menuMiddle.activeInHierarchy)
        {
            menuMiddle.SetActive(false);
            menuSide.SetActive(true);
            optionsButton.SetActive(true);
        }

        compendiumWindow.SetActive(false);
        buildYourTeamWindow.SetActive(false);
        playNowWindow.SetActive(false);
        optionsWindow.SetActive(true);
    }

    public void PlayNowClick()
    {
        if (menuMiddle.activeInHierarchy)
        {
            menuMiddle.SetActive(false);
            menuSide.SetActive(true);
            playNowButton.SetActive(true);
        }

        compendiumWindow.SetActive(false);
        buildYourTeamWindow.SetActive(false);
        optionsWindow.SetActive(false);
        playNowWindow.SetActive(true);
    }

    public void ToBattle()
    {
        switch (BattleMode)
        {
            case 0://QuickPlay

            break;

            case 1://TrainigMode
                MainWindow.SetActive(false);
                TrainingMode.SetActive(true);
                GameObject.Find("ScriptHolder").GetComponent<TrainingMode>().Timer = 50;

                break;

            case 2: //Tutorial

            break;

        }
    }
}
