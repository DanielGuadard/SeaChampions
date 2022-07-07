using UnityEngine;

public class Navigation : MonoBehaviour
{
    // Main windows
    [SerializeField]
    private GameObject menuMiddle, menuSide;

    // Navigation windows
    [SerializeField]
    private GameObject buildYourTeamWindow, compendiumWindow, optionsWindow;

    // Buttons
    [SerializeField]
    private GameObject idlePVEButton, championsButton, compendiumButton,
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
            optionsWindow.SetActive(false);
            buildYourTeamWindow.SetActive(false);
            compendiumWindow.SetActive(true);    
        }
    }
    public void BuildYourTeamClick()
    {
        if (menuSide.activeInHierarchy == true && menuMiddle.activeInHierarchy == false)
        {
            compendiumWindow.SetActive(false);
            optionsWindow.SetActive(false);
            buildYourTeamWindow.SetActive(true);
        }
    }

    public void OptionsClick()
    {
        if (menuMiddle.activeInHierarchy == true)
        {
            menuMiddle.SetActive(false);
            menuSide.SetActive(true);
            optionsButton.SetActive(true);
        }

        compendiumWindow.SetActive(false);
        buildYourTeamWindow.SetActive(false);
        optionsWindow.SetActive(true);
    }


}
