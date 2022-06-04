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
    public GameObject JOHN_FANGOPref, CAPTAINPref,TedPref, NENRUNGPref, REZAULPref, GARRINCHAPref, LUKEPref, RAYPref, SIR_WESTLEYPref, LIZAPref, HANISPref, SARGEANT_HARTMANPref, RIDLEYPref, ARSELLAPref,
    ROCUSPref, AARONPref, WANDERLEYPref, LOLAPref, TODDPref, JOHNNYPref, SOORYAPref, IRFANPref, DANILOPref, ZEPEREIRAPref, BOB_SAWPref, TISYAPref, SASHAPref, MEDHANSHPref, SIRILOPref, MAHESHPref,
    RICHARDPref, EDPref, ADAMPref;

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
            switch (card.name)
            {
                case "John Fango the Tactical Megalodon":
                    GameObject.Instantiate(JOHN_FANGOPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 222;
					card.brawl = 333;
					card.cunning = 111;
					card.idealPressure = 4;
                    break;
                case "Captain Costa the Man O'War":
                    GameObject.Instantiate(CAPTAINPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 222;
					card.brawl = 111;
					card.cunning = 222;
					card.idealPressure = 1;
                    break;
                case "Ted Righty the Boxer Whale":
                    GameObject.Instantiate(TedPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 240;
					card.brawl = 260;
					card.cunning = 100;
					card.idealPressure = 2;
                    break;
                case "Nenrung the Dragon":
                    GameObject.Instantiate(NENRUNGPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 247;
					card.brawl = 120;
					card.cunning = 100;
					card.idealPressure = 3;
                    break;
                case "Rezaul the master Octopus":
                    GameObject.Instantiate(REZAULPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 75;
					card.brawl = 150;
					card.cunning = 233;
					card.idealPressure = 1;
                    break;
                case "Garrincha the Tough Blue Lobster":
                    GameObject.Instantiate(GARRINCHAPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 220;
					card.brawl = 220;
					card.cunning = 51;
					card.idealPressure = 2;
                    break;
                case "Luke the Turtle":
                    GameObject.Instantiate(LUKEPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 150;
					card.brawl = 261;
					card.cunning = 85;
					card.idealPressure = 2;
                    break;
                case "Ray the Whipping Manta":
                    GameObject.Instantiate(RAYPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 181;
					card.brawl = 264;
					card.cunning = 55;
					card.idealPressure = 3;
                    break;
                case "Sir Westley the Fencing Dolphin":
                    GameObject.Instantiate(SIR_WESTLEYPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 183;
					card.brawl = 75;
					card.cunning = 110;
					card.idealPressure = 1;
                    break;
                case "Liza the Carrier Crab":
                    GameObject.Instantiate(LIZAPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 120;
					card.brawl = 193;
					card.cunning = 78;
					card.idealPressure = 3;
                    break;
                case "Hanis the Menacing Flatfish":
                    GameObject.Instantiate(HANISPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 185;
					card.brawl = 96;
					card.cunning = 90;
					card.idealPressure = 2;
                    break;
                case "Sargeant Hartman the Navy Seal":
                    GameObject.Instantiate(SARGEANT_HARTMANPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 180;
					card.brawl = 116;
					card.cunning = 80;
					card.idealPressure = 1;
                    break;
                case "Ridley the Olive Turtle":
                    GameObject.Instantiate(RIDLEYPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 160;
					card.brawl = 145;
					card.cunning = 80;
					card.idealPressure = 1;
                    break;
                case "Arsella the Sea Nettle":
                    GameObject.Instantiate(ARSELLAPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 85;
					card.brawl = 115;
					card.cunning = 169;
					card.idealPressure = 4;
                    break;
                case "Rocus 'Shades' the Blue Shark":
                    GameObject.Instantiate(ROCUSPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 100;
					card.brawl = 203;
					card.cunning = 90;
					card.idealPressure = 2;
                    break;
                case "Aaron the Ramming Crab":
                    GameObject.Instantiate(AARONPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 102;
					card.brawl = 199;
					card.cunning = 93;
					card.idealPressure = 3;
                    break;
                case "Wanderley the Grappling Octopus":
                    GameObject.Instantiate(WANDERLEYPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 93;
					card.brawl = 100;
					card.cunning = 171;
					card.idealPressure = 1;
                    break;
                case "Lola the Buff Blowfish":
                    GameObject.Instantiate(LOLAPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 182;
					card.brawl = 102;
					card.cunning = 90;
					card.idealPressure = 3;
                    break;
                case "Todd the Barber Eel":
                    GameObject.Instantiate(TODDPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 150;
					card.brawl = 79;
					card.cunning = 93;
					card.idealPressure = 4;
                    break;
                case "Jhonny the Sailor Squid":
                    GameObject.Instantiate(JOHNNYPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 110;
					card.brawl = 60;
					card.cunning = 143;
					card.idealPressure = 2;
                    break;
                case "Soorya the Needling Box Jellyfish":
                    GameObject.Instantiate(SOORYAPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 115;
					card.brawl = 73;
					card.cunning = 132;
					card.idealPressure = 4;
                    break;
                case "Irfan the Bladed Lobster":
                    GameObject.Instantiate(IRFANPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 89;
					card.brawl = 168;
					card.cunning = 82;
					card.idealPressure = 3;
                    break;
                case "Danilo the Piercing Tatui":
                    GameObject.Instantiate(DANILOPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 111;
					card.brawl = 151;
					card.cunning = 75;
					card.idealPressure = 3;
                    break;
                case "Ze Pereira the Sandbar Shark":
                    GameObject.Instantiate(ZEPEREIRAPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 85;
					card.brawl = 170;
					card.cunning = 85;
					card.idealPressure = 1;
                    break;
                case "Bob Saw the Anchovy":
                    GameObject.Instantiate(BOB_SAWPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 154;
					card.brawl = 90;
					card.cunning = 80;
					card.idealPressure = 2;
                    break;
                case "Tisya the Spotted Blademaster":
                    GameObject.Instantiate(TISYAPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 100;
					card.brawl = 90;
					card.cunning = 130;
					card.idealPressure = 2;
                    break;
                case "Sasha the Wrestling Beluga":
                    GameObject.Instantiate(SASHAPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 99;
					card.brawl = 165;
					card.cunning = 75;
					card.idealPressure = 1;
                    break;
                case "Medhansh the Swordsman":
                    GameObject.Instantiate(MEDHANSHPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 65;
					card.brawl = 135;
					card.cunning = 130;
					card.idealPressure = 2;
                    break;
                case "Sirilo the Marbled Swim Crab":
                    GameObject.Instantiate(SIRILOPref).transform.SetParent(myTeamContent.transform, false);
                    card.agility = 93;
                    card.brawl = 140;
                    card.cunning = 100;
                    card.idealPressure = 3;
                    break;
                case "Mahesh the Slashing Mackerel":
                    GameObject.Instantiate(MAHESHPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 160;
					card.brawl = 97;
					card.cunning = 70;
					card.idealPressure = 3;
                    break;
                case "Richard the Opportunist Cockle":
                    GameObject.Instantiate(RICHARDPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 98;
					card.brawl = 163;
					card.cunning = 80;
					card.idealPressure = 2;
                    break;
                case "Ed the Punk Salmon":
                    GameObject.Instantiate(EDPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 160;
					card.brawl = 85;
					card.cunning = 80;
					card.idealPressure = 4;
                    break;
                case "Adam Risso the Dolphin":
                    GameObject.Instantiate(ADAMPref).transform.SetParent(myTeamContent.transform, false);
					card.agility = 140;
					card.brawl = 75;
					card.cunning = 105;
					card.idealPressure = 2;
                    break;

                default:
                    break;
            }
        }
        try
        {
            GameObject.Find("ScriptHolder").GetComponent<OPENAndEXITGame>().LoadTeams();
        }
        catch(System.NullReferenceException) {
            Debug.Log("NullReferenceException in CardConstructor.cs at GameObject.Find(\"ScriptHolder\").GetComponent<OPENAndEXITGame>().LoadTeams();");
        }
    }

}
