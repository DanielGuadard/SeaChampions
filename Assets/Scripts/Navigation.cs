using UnityEngine;

public class Navigation : MonoBehaviour
{
    // Main windows
    public GameObject menuMiddle, menuSide;

    // Navigation windows
    public GameObject buildYourTeamWindow, compendiumWindow;

    // Buttons
    public GameObject idlePVEButton, championsButton, compendiumButton,
        buildYourTeamButton, optionsButton, optionsButton2;

    public void ChampionsClick()
    {
        if (compendiumButton.activeInHierarchy == false) {
           
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
        
        if (menuMiddle.activeInHierarchy == true)
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
        if (menuSide.activeInHierarchy == true && menuMiddle.activeInHierarchy == false)
        {
            compendiumWindow.SetActive(true);
            buildYourTeamWindow.SetActive(false);
        }
    }
    public void BuildYourTeamClick()
    {
        if (menuSide.activeInHierarchy == true && menuMiddle.activeInHierarchy == false)
        {
            compendiumWindow.SetActive(false);
            buildYourTeamWindow.SetActive(true);
        }
    }

}
