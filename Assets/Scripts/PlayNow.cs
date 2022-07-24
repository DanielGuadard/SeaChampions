using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayNow : MonoBehaviour
{

    public int gamemode,Dificult;
    private bool started;

    [SerializeField]
    private GameObject chooseCompleteText;

    private IEnumerator FadeIn()
    {// 255 0 0 255 -> 255 255 255 106
        Color begin = chooseCompleteText.GetComponent<Text>().color;
        for (float i = 0f; i < 1f; i += 0.02f)
        {
            chooseCompleteText.GetComponent<Text>().color = new Color(1f, begin.g - i, begin.b - i, begin.a + i * 149 / 255);
        }
        yield return new WaitForSeconds (0.6f);
        StartCoroutine(FadeOut());
    }

    private IEnumerator FadeOut()
    {
        for (float i = 0f; i < 1f; i += 0.02f)
        {
            chooseCompleteText.GetComponent<Text>().color = new Color(1f, i, i, 1f - i * 149 / 255);
        }
        yield return new WaitForSeconds(0.8f);
    }

    private void Start()
    {
        if (!System.IO.File.Exists(Application.persistentDataPath + "/config.json"))
        {
            gamemode = 0;
        }
        else
        {
            // Loading gamemode from config
            ConfigJSON config = JSONHandler.ReadConfigFromJSON("config.json");
            gamemode = config.gamemode;
        }

        switch (gamemode)
        {
            case 0:
                QuickPlayClick();
                break;
            case 1:
                TrainingModeClick();
                break;
            case 2:
                TutorialClick();
                break;
            default:
                QuickPlayClick();
                break;
        }
    }

    public void QuickPlayClick()
    {
        gamemode = 0;
        FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "QuickPlay_Button").GetComponent<Image>().color = new Color32(255, 170, 0,255);
        FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "QuickPlay_Button").transform.GetComponentInChildren<Text>().color = new Color32(255, 170, 0,255);
        FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "TrainingMode_Button").GetComponent<Image>().color = new Color32(255, 255, 255,255);
        FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "TrainingMode_Button").transform.GetComponentInChildren<Text>().color = new Color32(255, 255, 255, 255);
        FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "Tutorial_Button").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "Tutorial_Button").transform.GetComponentInChildren<Text>().color = new Color32(255, 255, 255, 255);
        FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "Dificults").SetActive(false);
    }

    public void TrainingModeClick()
    {
        gamemode = 1;
        FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "TrainingMode_Button").GetComponent<Image>().color = new Color32(255, 170, 0,255);
        FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "TrainingMode_Button").transform.GetComponentInChildren<Text>().color = new Color32(255, 170, 0,255);
        FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "QuickPlay_Button").GetComponent<Image>().color = new Color(255, 255, 255);
        FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "QuickPlay_Button").transform.GetComponentInChildren<Text>().color = new Color(255, 255, 255);
        FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "Tutorial_Button").GetComponent<Image>().color = new Color(255, 255, 255);
        FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "Tutorial_Button").transform.GetComponentInChildren<Text>().color = new Color(255, 255, 255);
        FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "Dificults").SetActive(true);
        DificultBegginer();
    }

    public void TutorialClick()
    {
        gamemode = 2;
        FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "Tutorial_Button").GetComponent<Image>().color = new Color32(255, 170, 0,255);
        FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "Tutorial_Button").transform.GetComponentInChildren<Text>().color = new Color32(255, 170, 0,255);
        FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "TrainingMode_Button").GetComponent<Image>().color = new Color(255, 255, 255);
        FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "TrainingMode_Button").transform.GetComponentInChildren<Text>().color = new Color(255, 255, 255);
        FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "QuickPlay_Button").GetComponent<Image>().color = new Color(255, 255, 255);
        FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "QuickPlay_Button").transform.GetComponentInChildren<Text>().color = new Color(255, 255, 255);
        FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "Dificults").SetActive(false);
    }

    public void StartGameClick()
    {
        started = false;
        foreach (GameObject playnowteam in FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "playnowteam"))
        {
            if (playnowteam.GetComponent<PlayNowTeamSetItem>().isSelected && playnowteam.GetComponent<PlayNowTeamSetItem>().isCompleted && !started)
            {
                started = true;
                switch (gamemode)
                {
                    case 0:
                        FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "Canvas_Queu").SetActive(true);
                        // Other implementation when Quick Play is selected
                        GameObject.Find("ScriptHolder").GetComponent<Navigation>().BattleMode = 0;
                        break;
                    case 1:
                        // Implementation when Training Mode is selected
                        GameObject.Find("ScriptHolder").GetComponent<Navigation>().BattleMode = 1;

                        break;
                    case 2:
                        // Implementation when Tutorial is selected
                        GameObject.Find("ScriptHolder").GetComponent<Navigation>().BattleMode = 2;
                        break;
                    default:
                        break;
                }
            GameObject.Find("ScriptHolder").GetComponent<Navigation>().Invoke("ToBattle", 1);           
            }
            else if (playnowteam.GetComponent<PlayNowTeamSetItem>().isSelected)
            {
                StartCoroutine(FadeIn());
            }
        }
        
    }

    public void Cancel()
    {
        started = false;
    }

    public void DificultBegginer() 
    {
        GameObject.Find("ScriptHolder").GetComponent<TrainingMode>().Dificult = 1;
        GameObject.Find("Begginner_Button").GetComponent<Image>().color= new Color32(255, 170, 0, 255);
        GameObject.Find("Begginner_Button").transform.GetComponentInChildren<Text>().color = new Color32(255, 170, 0, 255);
        GameObject.Find("Challenging_Button").GetComponent<Image>().color = new Color(255, 255, 255);
        GameObject.Find("Challenging_Button").transform.GetComponentInChildren<Text>().color = new Color(255, 255, 255);
        GameObject.Find("Expert_Button").GetComponent<Image>().color = new Color(255, 255, 255);
        GameObject.Find("Expert_Button").transform.GetComponentInChildren<Text>().color = new Color(255, 255, 255);
    }
    public void DificultChallenging() 
    {
        GameObject.Find("ScriptHolder").GetComponent<TrainingMode>().Dificult = 2;
        GameObject.Find("Begginner_Button").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        GameObject.Find("Begginner_Button").transform.GetComponentInChildren<Text>().color = new Color32(255, 255, 255, 255);
        GameObject.Find("Challenging_Button").GetComponent<Image>().color = new Color32(255, 170, 0,255);
        GameObject.Find("Challenging_Button").transform.GetComponentInChildren<Text>().color = new Color32(255, 170, 0,255);
        GameObject.Find("Expert_Button").GetComponent<Image>().color = new Color(255, 255, 255);
        GameObject.Find("Expert_Button").transform.GetComponentInChildren<Text>().color = new Color(255, 255, 255);
    }
    public void DificultExpert() 
    {
        GameObject.Find("ScriptHolder").GetComponent<TrainingMode>().Dificult = 3;
        GameObject.Find("Begginner_Button").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        GameObject.Find("Begginner_Button").transform.GetComponentInChildren<Text>().color = new Color32(255, 255, 255, 255);
        GameObject.Find("Challenging_Button").GetComponent<Image>().color = new Color(255, 255, 255);
        GameObject.Find("Challenging_Button").transform.GetComponentInChildren<Text>().color = new Color(255, 255,255);
        GameObject.Find("Expert_Button").GetComponent<Image>().color = new Color32(255, 170, 0,255);
        GameObject.Find("Expert_Button").transform.GetComponentInChildren<Text>().color = new Color32(255, 170, 0,255);
    }


}
