using UnityEngine;
using UnityEngine.UI;

public class TeamScript : MonoBehaviour
{
    public GameObject time, teamsContent, empty, arrow, inputField;
    public RectTransform teamHolder;
    public Image image, inputFieldImage;
    public Sprite arrowClose, arrowOpen;
    public bool open;
    public AudioClip myTeamsSound;

    void Start()
    {               
        open = true;
        image = GetComponent<Image>();
    }

    public void DropDownTeam()
    {
        if (open == false)
        {
            arrow.GetComponent<Image>().sprite = arrowOpen ;
            open = true;
            teamHolder.sizeDelta = new Vector2(10, 210);
            time.SetActive(true);
            inputField.GetComponent<InputField>().enabled = true;
         
        }
        else
        {
            arrow.GetComponent<Image>().sprite = arrowClose;
            open = false;
            teamHolder.sizeDelta = new Vector2(10, 45);
            time.SetActive(false);
            inputField.GetComponent<InputField>().enabled = false;
        }
        
        GameObject content = GameObject.Find("Content_01");
        GameObject.Instantiate(empty).transform.SetParent(content.transform, false);
        Destroy(GameObject.Find("Vazio(Clone)"));

    }

    public void Enter()
    {
        inputFieldImage.color= new Color(1, 1, 1, .5f);
        GameObject.Find("AudioKey").GetComponent<AudioSource>().PlayOneShot(myTeamsSound);
    }

    public void Exit()
    {
        inputFieldImage.color = new Color(1, 1, 1, 0);
    }

}
