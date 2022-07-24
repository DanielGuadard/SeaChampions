using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class CardConstructor : MonoBehaviour
{
    public GameObject championObj, teamSlot, remove, slot, teamImage, team, PlayNowContent;
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

    public CardList jsonData;
    public GameObject championPref;

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
        jsonData = JsonUtility.FromJson<CardList>(content);

        foreach (Card card in jsonData.Deck)
        {
            GameObject.Instantiate(championPref).transform.SetParent(myTeamContent.transform, false);
            championPref.GetComponentInChildren<Item>().id = card.id;
            championPref.GetComponentInChildren<Item>().name = card.name;
            championPref.GetComponentInChildren<Item>().image = card.image;
            championPref.GetComponentInChildren<Item>().tribe = card.tribe;
            championPref.GetComponentInChildren<Item>().rarity = card.rarity;
            championPref.GetComponentInChildren<Item>().elite = card.elite;
            championPref.GetComponentInChildren<Item>().idealPressure = card.idealPressure;
            championPref.GetComponentInChildren<Item>().brawl = card.brawl;
            championPref.GetComponentInChildren<Item>().agility = card.agility;
            championPref.GetComponentInChildren<Item>().cunning = card.cunning;
        }

        GameObject.Find("ScriptHolder").GetComponent<OPENAndEXITGame>().LoadTeams();
    }

}
