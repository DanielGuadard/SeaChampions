using UnityEngine;
using UnityEngine.UI;

public class TeamScript : MonoBehaviour
{
    [SerializeField]
    private GameObject time, teamsContent, empty, arrow, inputField;
    [SerializeField]
    private RectTransform teamHolder;
    [SerializeField]
    private Image image, inputFieldImage;
    [SerializeField]
    private Sprite arrowClose, arrowOpen;
    [SerializeField]
    private AudioClip myTeamsSound;

    public bool open;

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
        inputFieldImage.color = new Color(1, 1, 1, .5f);
        GameObject.Find("AudioKey").GetComponent<AudioSource>().PlayOneShot(myTeamsSound);
    }

    public void Exit()
    {
        inputFieldImage.color = new Color(1, 1, 1, 0);
    }

}
