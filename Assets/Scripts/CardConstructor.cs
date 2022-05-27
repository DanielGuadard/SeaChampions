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
        public float Agility;
        public float Brawn;
        public float Cunning;
        public float BattlePower;
        public int IdealPressure;
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
					card.Agility = 222;
					card.Brawn = 333;
					card.Cunning = 111;
					card.IdealPressure = 4;
                    break;
                case "Captain Costa the Man O'War":
                    GameObject.Instantiate(CAPTAINPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 222;
					card.Brawn = 111;
					card.Cunning = 222;
					card.IdealPressure = 1;
                    break;
                case "Ted Righty the Boxer Whale":
                    GameObject.Instantiate(TedPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 240;
					card.Brawn = 260;
					card.Cunning = 100;
					card.IdealPressure = 2;
                    break;
                case "Nenrung the Dragon":
                    GameObject.Instantiate(NENRUNGPrefg).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 247;
					card.Brawn = 120;
					card.Cunning = 100;
					card.IdealPressure = 3;
                    break;
                case "Rezaul the master Octopus":
                    GameObject.Instantiate(REZAULPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 75;
					card.Brawn = 150;
					card.Cunning = 233;
					card.IdealPressure = 1;
                    break;
                case "Garrincha the Tough Blue Lobster":
                    GameObject.Instantiate(GARRINCHAPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 220;
					card.Brawn = 220;
					card.Cunning = 51;
					card.IdealPressure = 2;
                    break;
                case "Luke the Turtle":
                    GameObject.Instantiate(LUKEPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 150;
					card.Brawn = 261;
					card.Cunning = 85;
					card.IdealPressure = 2;
                    break;
                case "Ray the Whipping Manta":
                    GameObject.Instantiate(RAYPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 181;
					card.Brawn = 264;
					card.Cunning = 55;
					card.IdealPressure = 3;
                    break;
                case "Sir Westley the Fencing Dolphin":
                    GameObject.Instantiate(SIR_WESTLEYPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 183;
					card.Brawn = 75;
					card.Cunning = 110;
					card.IdealPressure = 1;
                    break;
                case "Liza the Carrier Crab":
                    GameObject.Instantiate(LIZAPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 120;
					card.Brawn = 193;
					card.Cunning = 78;
					card.IdealPressure = 3;
                    break;
                case "Hanis the Menacing Flatfish":
                    GameObject.Instantiate(HANISPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 185;
					card.Brawn = 96;
					card.Cunning = 90;
					card.IdealPressure = 2;
                    break;
                case "Sargeant Hartman the Navy Seal":
                    GameObject.Instantiate(SARGEANT_HARTMANPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 180;
					card.Brawn = 116;
					card.Cunning = 80;
					card.IdealPressure = 1;
                    break;
                case "Ridley the Olive Turtle":
                    GameObject.Instantiate(RIDLEYPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 160;
					card.Brawn = 145;
					card.Cunning = 80;
					card.IdealPressure = 1;
                    break;
                case "Arsella the Sea Nettle":
                    GameObject.Instantiate(ARSELLAPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 85;
					card.Brawn = 115;
					card.Cunning = 169;
					card.IdealPressure = 4;
                    break;
                case "Rocus 'Shades' the Blue Shark":
                    GameObject.Instantiate(ROCUSPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 100;
					card.Brawn = 203;
					card.Cunning = 90;
					card.IdealPressure = 2;
                    break;
                case "Aaron the Ramming Crab":
                    GameObject.Instantiate(AARONPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 102;
					card.Brawn = 199;
					card.Cunning = 93;
					card.IdealPressure = 3;
                    break;
                case "Wanderley the Grappling Octopus":
                    GameObject.Instantiate(WANDERLEYPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 93;
					card.Brawn = 100;
					card.Cunning = 171;
					card.IdealPressure = 1;
                    break;
                case "Lola the Buff Blowfish":
                    GameObject.Instantiate(LOLAPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 182;
					card.Brawn = 102;
					card.Cunning = 90;
					card.IdealPressure = 3;
                    break;
                case "Todd the Barber Eel":
                    GameObject.Instantiate(TODDPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 150;
					card.Brawn = 79;
					card.Cunning = 93;
					card.IdealPressure = 4;
                    break;
                case "Jhonny the Sailor Squid":
                    GameObject.Instantiate(JOHNNYPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 110;
					card.Brawn = 60;
					card.Cunning = 143;
					card.IdealPressure = 2;
                    break;
                case "Soorya the Needling Box Jellyfish":
                    GameObject.Instantiate(SOORYAPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 115;
					card.Brawn = 73;
					card.Cunning = 132;
					card.IdealPressure = 4;
                    break;
                case "Irfan the Bladed Lobster":
                    GameObject.Instantiate(IRFANPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 89;
					card.Brawn = 168;
					card.Cunning = 82;
					card.IdealPressure = 3;
                    break;
                case "Danilo the Piercing Tatui":
                    GameObject.Instantiate(DANILOPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 111;
					card.Brawn = 151;
					card.Cunning = 75;
					card.IdealPressure = 3;
                    break;
                case "Ze Pereira the Sandbar Shark":
                    GameObject.Instantiate(ZEPEREIRAPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 85;
					card.Brawn = 170;
					card.Cunning = 85;
					card.IdealPressure = 1;
                    break;
                case "Bob Saw the Anchovy":
                    GameObject.Instantiate(BOB_SAWPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 154;
					card.Brawn = 90;
					card.Cunning = 80;
					card.IdealPressure = 2;
                    break;
                case "Tisya the Spotted Blademaster":
                    GameObject.Instantiate(TISYAPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 100;
					card.Brawn = 90;
					card.Cunning = 130;
					card.IdealPressure = 2;
                    break;
                case "Sasha the Wrestling Beluga":
                    GameObject.Instantiate(SASHAPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 99;
					card.Brawn = 165;
					card.Cunning = 75;
					card.IdealPressure = 1;
                    break;
                case "Medhansh the Swordsman":
                    GameObject.Instantiate(MEDHANSHPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 65;
					card.Brawn = 135;
					card.Cunning = 130;
					card.IdealPressure = 2;
                    break;
                case "Sirilo the Marbled Swim Crab":
                    GameObject.Instantiate(SIRILOPref).transform.SetParent(myTeamContent.transform, false);
                    card.Agility = 93;
                    card.Brawn = 140;
                    card.Cunning = 100;
                    card.IdealPressure = 3;
                    break;
                case "Mahesh the Slashing Mackerel":
                    GameObject.Instantiate(MAHESHPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 160;
					card.Brawn = 97;
					card.Cunning = 70;
					card.IdealPressure = 3;
                    break;
                case "Richard the Opportunist Cockle":
                    GameObject.Instantiate(RICHARDPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 98;
					card.Brawn = 163;
					card.Cunning = 80;
					card.IdealPressure = 2;
                    break;
                case "Ed the Punk Salmon":
                    GameObject.Instantiate(EDPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 160;
					card.Brawn = 85;
					card.Cunning = 80;
					card.IdealPressure = 4;
                    break;
                case "Adam Risso the Dolphin":
                    GameObject.Instantiate(ADAMPref).transform.SetParent(myTeamContent.transform, false);
					card.Agility = 140;
					card.Brawn = 75;
					card.Cunning = 105;
					card.IdealPressure = 2;
                    break;

                default:
                    break;
            }
        }
    }

}





