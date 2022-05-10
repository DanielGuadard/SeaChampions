using System.Collections;
using UnityEngine;
public class ChampionsCheck : MonoBehaviour
{

    public GameObject Mark_JOHN_FANGO, Mark_CAPTAIN, Mark_Ted, Mark_NENRUNG, Mark_REZAUL, Mark_GARRINCHA, Mark_LUKE, Mark_RAY, Mark_SIR_WESTLEY, Mark_LIZA, Mark_HANIS, Mark_SARGEANT_HARTMAN, Mark_RIDLEY, Mark_ARSELLA,
        Mark_ROCUS, Mark_AARON, Mark_WANDERLEY, Marck_LOLA, Mark_TODD, Mark_JOHNNY, Mark_SOORYA, Mark_IRFAN, mark_DANILO, Mark_ZEPEREIRA, Mark_BOB_SAW, Mark_TISYA, Mark_SASHA, Mark_MEDHANSH, Mark_SIRILO, Mark_MAHESH,
        Mark_RICHARD, Mark_ED, Mark_ADAM;
   
    public string urlAPIFinal;

     
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

    public CardList jsonData = new CardList();

    void Start()
    {
        //UrlAPIfinal = ("https://metadata.seachampions.com/champion/erc1155/unity/0xD286b7469ECba17A61eaB499D12ad5171B50C11f");
        //UrlAPIfinal = ("https://metadata.seachampions.com/champion/erc1155/unity/"+ PlayerPrefs.GetString("Account"));

        StartCoroutine(GetData());
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
        jsonData =  JsonUtility.FromJson<CardList>(_url);

        foreach (Card card in jsonData.Deck)
        {
            switch (card.name)
            {
                case "John Fango the Tactical Megalodon":
                    Mark_JOHN_FANGO.SetActive(true);
                    break;
                case "Captain Costa the Man O’War":
                    Mark_CAPTAIN.SetActive(true);
                    break;
                case "Ted Righty the Boxer Whale":
                    Mark_Ted.SetActive(true);
                    break;
                case "Nenrung the Dragon":
                    Mark_NENRUNG.SetActive(true);
                    break;
                case "Rezaul the master Octopus":
                    Mark_REZAUL.SetActive(true);
                    break;
                case "Garrincha the Tough Blue Lobster":
                    Mark_GARRINCHA.SetActive(true);
                    break;
                case "Luke the Turtle":
                    Mark_LUKE.SetActive(true);
                    break;
                case "Ray the Whipping Manta":
                    Mark_RAY.SetActive(true);
                    break;
                case "Sir Westley the Fencing Dolphin":
                    Mark_SIR_WESTLEY.SetActive(true);
                    break;
                case "Liza the Carrier Crab":
                    Mark_LIZA.SetActive(true);
                    break;
                case "Hanis the Menacing Flatfish":
                    Mark_HANIS.SetActive(true);
                    break;
                case "Sargeant Hartman the Navy Seal":
                    Mark_SARGEANT_HARTMAN.SetActive(true);
                    break;
                case "Ridley the Olive Turtle":
                    Mark_RIDLEY.SetActive(true);
                    break;
                case "Arsella the Sea Nettle":
                    Mark_ARSELLA.SetActive(true);
                    break;
                case "Rocus 'Shades' the Blue Shark":
                    Mark_ROCUS.SetActive(true);
                    break;
                case "Aaron the Ramming Crab":
                    Mark_AARON.SetActive(true);
                    break;
                case "Wanderley the Grappling Octopus":
                    Mark_WANDERLEY.SetActive(true);
                    break;
                case "Lola the Buff Blowfish":
                    Marck_LOLA.SetActive(true);
                    break;
                case "Todd the Barber Eel":
                    Mark_TODD.SetActive(true);
                    break;
                case "Jhonny the Sailor Squid":
                    Mark_JOHNNY.SetActive(true);
                    break;
                case "Soorya the Needling Box Jellyfish":
                    Mark_SOORYA.SetActive(true);
                    break;
                case "Irfan the Bladed Lobster":
                    Mark_IRFAN.SetActive(true);
                    break;
                case "Danilo the Piercing Tatui":
                    mark_DANILO.SetActive(true);
                    break;
                case "Ze Pereira the Sandbar Shark":
                    Mark_ZEPEREIRA.SetActive(true);
                    break;
                case "Bob Saw the Anchovy":
                    Mark_BOB_SAW.SetActive(true);
                    break;
                case "Tisya the Spotted Blademaster":
                    Mark_TISYA.SetActive(true);
                    break;
                case "Sasha the Wrestling Beluga":
                    Mark_SASHA.SetActive(true);
                    break;
                case "Medhansh the Swordsman":
                    Mark_MEDHANSH.SetActive(true);
                    break;
                case "Sirilo the Marbled Swim Crab":
                    Mark_SIRILO.SetActive(true);
                    break;
                case "Mahesh the Slashing Mackerel":
                    Mark_MAHESH.SetActive(true);
                    break;
                case "Richard the Opportunist Cockle":
                    Mark_RICHARD.SetActive(true);
                    break;
                case "Ed the Punk Salmon":
                    Mark_ED.SetActive(true);
                    break;
                case "Adam Risso the Dolphin":
                    Mark_ADAM.SetActive(true);
                    break;

                default:
                    break;
            }
        }
    }

}





