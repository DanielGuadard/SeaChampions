using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class CardConstructor : MonoBehaviour
{
    public GameObject championObj, teamSlot, remove, slot, teamImage, team;
    public int teamsCreated, crew;
    public string URL, urlAPIFinal;

    [SerializeField]
    private GameObject myTeamContent;
    [SerializeField]
    private Sprite item;

    [System.Serializable]
    public class Card
    {
        public int id;
        public string name;
        public string image;
        public string tribe;
        public string rarity;
        public bool elite;
        public int idealPressure;
        public float brawl;
        public float agility;
        public float cunning;
        
    }

    [System.Serializable]
    public class CardList
    {
        public Card[] Deck;
    }

    public CardList JsonData;
    public GameObject ChampionPref;

    void Start()
    {
        StartCoroutine(GetData());
    }

    IEnumerator GetImage(string image)
    {
        UnityWebRequest dataImage = UnityWebRequestTexture.GetTexture(image);

        yield return dataImage.SendWebRequest();

        if (dataImage.isNetworkError || dataImage.isHttpError)
        {
            Debug.Log(dataImage.error);
        }
    }

    IEnumerator GetData()
    {
        WWW www = new WWW(urlAPIFinal);
        yield return www;
        if (www.error == null)
        {
            ProcessJsonData(www.text);
        }
        else
        {
            Debug.Log("Something went wrong! In IEnumerator GetData()");
        }
    }
    public void ProcessJsonData(string content)
    {
        JsonData = JsonUtility.FromJson<CardList>(content); 

        foreach (Card card in JsonData.Deck)
        {
            
            GameObject.Instantiate(ChampionPref).transform.SetParent(myTeamContent.transform, false);
            ChampionPref.GetComponentInChildren<Item>().id = card.id;             
            ChampionPref.GetComponentInChildren<Item>().name = card.name;
            ChampionPref.GetComponentInChildren<Item>().image = card.image;
            ChampionPref.GetComponentInChildren<Item>().tribe = card.tribe;
            ChampionPref.GetComponentInChildren<Item>().rarity = card.rarity;
            ChampionPref.GetComponentInChildren<Item>().elite = card.elite;
            ChampionPref.GetComponentInChildren<Item>().idealPressure = card.idealPressure;
            ChampionPref.GetComponentInChildren<Item>().brawl = card.brawl;
            ChampionPref.GetComponentInChildren<Item>().agility = card.agility;
            ChampionPref.GetComponentInChildren<Item>().cunning = card.cunning;
        }
        
        GameObject.Find("ScriptHolder").GetComponent<OPENAndEXITGame>().LoadTeams();
    }

}
