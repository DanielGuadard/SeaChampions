using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class CardCostructor : MonoBehaviour
{
    public GameObject myTeamContent, champiomObj, slot, remove, teamSlot, teamImage, team;
    public Sprite item;
    public int teamsCreated, crew;
    public string URL, urlAPIFinal;

    [System.Serializable]
    public class CardList
    {

        public Card[] Deck;

    }

    [System.Serializable]
    public class Card
    {
        public int id;
        public string name;
        public string image;
        public string rarity;
        public string tribe;
        public bool elite;
    }

    public CardList JsonData;
    public GameObject JOHN_FANGOPref, CAPTAINPref,TedPref, NENRUNGPrefg, REZAULPref, GARRINCHAPref, LUKEPref, RAYPref, SIR_WESTLEYPref, LIZAPref, HANISPref, SARGEANT_HARTMANPref, RIDLEYPref, ARSELLAPref,
    ROCUSPref, AARONPref, WANDERLEYPref, LOLAPref, TODDPref, JOHNNYPref, SOORYAPref, IRFANPref, DANILOPref, ZEPEREIRAPref, BOB_SAWPref, TISYAPref, SASHAPref, MEDHANSHPref, SIRILOPref, MAHESHPref,
    RICHARDPref, EDPref, ADAMPref;

    void Start()
    {
       //  UrlAPIfinal = ("https://metadata.seachampions.com/champion/erc1155/unity/0xD286b7469ECba17A61eaB499D12ad5171B50C11f");
       // UrlAPIfinal = ("https://metadata.seachampions.com/champion/erc1155/unity/"+ PlayerPrefs.GetString("Account"));

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
    public void ProcessJsonData(string _url)
    {
        JsonData = JsonUtility.FromJson<CardList>(_url); 

        foreach (Card card in JsonData.Deck)
        {
            switch (card.name)
            {
                case "John Fango the Tactical Megalodon":
                    GameObject.Instantiate(JOHN_FANGOPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Captain Costa the Man O’War":
                    GameObject.Instantiate(CAPTAINPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Ted Righty the Boxer Whale":
                    GameObject.Instantiate(TedPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Nenrung the Dragon":
                    GameObject.Instantiate(NENRUNGPrefg).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Rezaul the master Octopus":
                    GameObject.Instantiate(REZAULPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Garrincha the Tough Blue Lobster":
                    GameObject.Instantiate(GARRINCHAPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Luke the Turtle":
                    GameObject.Instantiate(LUKEPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Ray the Whipping Manta":
                    GameObject.Instantiate(RAYPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Sir Westley the Fencing Dolphin":
                    GameObject.Instantiate(SIR_WESTLEYPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Liza the Carrier Crab":
                    GameObject.Instantiate(LIZAPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Hanis the Menacing Flatfish":
                    GameObject.Instantiate(HANISPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Sargeant Hartman the Navy Seal":
                    GameObject.Instantiate(SARGEANT_HARTMANPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Ridley the Olive Turtle":
                    GameObject.Instantiate(RIDLEYPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Arsella the Sea Nettle":
                    GameObject.Instantiate(ARSELLAPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Rocus 'Shades' the Blue Shark":
                    GameObject.Instantiate(ROCUSPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Aaron the Ramming Crab":
                    GameObject.Instantiate(AARONPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Wanderley the Grappling Octopus":
                    GameObject.Instantiate(WANDERLEYPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Lola the Buff Blowfish":
                    GameObject.Instantiate(LOLAPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Todd the Barber Eel":
                    GameObject.Instantiate(TODDPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Jhonny the Sailor Squid":
                    GameObject.Instantiate(JOHNNYPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Soorya the Needling Box Jellyfish":
                    GameObject.Instantiate(SOORYAPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Irfan the Bladed Lobster":
                    GameObject.Instantiate(IRFANPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Danilo the Piercing Tatui":
                    GameObject.Instantiate(DANILOPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Ze Pereira the Sandbar Shark":
                    GameObject.Instantiate(ZEPEREIRAPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Bob Saw the Anchovy":
                    GameObject.Instantiate(BOB_SAWPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Tisya the Spotted Blademaster":
                    GameObject.Instantiate(TISYAPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Sasha the Wrestling Beluga":
                    GameObject.Instantiate(SASHAPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Medhansh the Swordsman":
                    GameObject.Instantiate(MEDHANSHPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Sirilo the Marbled Swim Crab":
                    GameObject.Instantiate(SIRILOPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Mahesh the Slashing Mackerel":
                    GameObject.Instantiate(MAHESHPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Richard the Opportunist Cockle":
                    GameObject.Instantiate(RICHARDPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Ed the Punk Salmon":
                    GameObject.Instantiate(EDPref).transform.SetParent(myTeamContent.transform, false);
                    break;
                case "Adam Risso the Dolphin":
                    GameObject.Instantiate(ADAMPref).transform.SetParent(myTeamContent.transform, false);
                    break;

                default:
                    break;
            }
        }
    }

}





