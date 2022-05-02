using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeamScript : MonoBehaviour
{
    public GameObject time,teamsContent,vazio,arrow, ImputField;
    public RectTransform TeamHolder;
    public Image imagem,ImputFieldImage;
    public Sprite ArrowClose, ArrowOpen;
    public bool aberto;
    public AudioClip MyteamsSound;
    public AudioSource AudioSourMyteamsSound;
    // Start is called before the first frame update
    void Start()
    {               
        aberto = true;
        imagem = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake()
    {
        
    }

    public void DropDownTeam()
    {
        if (aberto == false)
        {
            arrow.GetComponent<Image>().sprite = ArrowOpen ;
            aberto = true;
         // Debug.Log("abri");
            TeamHolder.sizeDelta = new Vector2(10, 210);
            time.SetActive(true);
            ImputField.GetComponent<InputField>().enabled = true;
         
        }
        else
        {
            arrow.GetComponent<Image>().sprite = ArrowClose;
            aberto = false;
         // Debug.Log("fechei");
            TeamHolder.sizeDelta = new Vector2(10,45);
            time.SetActive(false);
            ImputField.GetComponent<InputField>().enabled = false;
        }
        
        GameObject content = GameObject.Find("Content_01");
        GameObject.Instantiate(vazio).transform.SetParent(content.transform, false);
        Destroy(GameObject.Find("Vazio(Clone)"));

    }
    public void Enter()
    {
        ImputFieldImage.color= new Color(1,1,1,.5f);
        AudioSourMyteamsSound.PlayOneShot(MyteamsSound);
    }
    public void Exit()
    {
        ImputFieldImage.color = new Color(1, 1, 1, 0);
    }
    

}
