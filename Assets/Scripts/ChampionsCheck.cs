using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChampionsCheck : MonoBehaviour
{

    //Objetos de marcaçao se posui o champion 

    


    public GameObject Mark_JOHN_FANGO, Mark_CAPTAIN, Mark_Ted, Mark_NENRUNG, Mark_REZAUL, Mark_GARRINCHA, Mark_LUKE, Mark_RAY, Mark_SIR_WESTLEY, Mark_LIZA, Mark_HANIS, Mark_SARGEANT_HARTMAN, Mark_RIDLEY, Mark_ARSELLA,
        Mark_ROCUS, Mark_AARON, Mark_WANDERLEY, Marck_LOLA, Mark_TODD, Mark_JOHNNY, Mark_SOORYA, Mark_IRFAN, mark_DANILO, Mark_ZEPEREIRA, Mark_BOB_SAW, Mark_TISYA, Mark_SASHA, Mark_MEDHANSH, Mark_SIRILO, Mark_MAHESH,
        Mark_RICHARD, Mark_ED, Mark_ADAM;
   
    public string UrlAPIfinal;

     
    [System.Serializable]
    public class CardList
    {

        public Card[] Deck;

    }
    [System.Serializable]
    public class Card
    {
         //   public int id;
            public string name;
         //   public string image;
         //   public string rarity;
          //  public string tribe;
           // public bool elite;
    }


    public CardList JsonData = new CardList();

    void Start()
    {
        

        //UrlAPIfinal = ("https://metadata.seachampions.com/champion/erc1155/unity/0xD286b7469ECba17A61eaB499D12ad5171B50C11f");
        //UrlAPIfinal = ("https://metadata.seachampions.com/champion/erc1155/unity/"+ PlayerPrefs.GetString("Account"));


        StartCoroutine(GetData());
        

    }
    IEnumerator GetData()
    {
       
        WWW _www = new WWW(UrlAPIfinal);
        yield return _www;
        if (_www.error == null)
        {
            ProcessJsonData(_www.text);
            //Debug.Log("Processando Json, espera ai mano");
        }
        else
        {
            Debug.Log("Deu erro no bagulho ai");
        }
    }
    public void ProcessJsonData(string _url)
    {

        JsonData =  JsonUtility.FromJson<CardList>(_url) ;
        
        // Debug.Log(JsonData.Deck);
        //Debug.Log(x.name);

        foreach (Card x in JsonData.Deck)
        {


           // Debug.Log(x.name);
            //JOHN FANGO THE TACTICAL MEGALODON
            if (x.name == "John Fango the Tactical Megalodon")
            {
                Mark_JOHN_FANGO.SetActive(true);
            }

            //CAPTAIN COSTA THE MAN O’WAR
            if (x.name == "Captain Costa the Man O’War") 
            {
                Mark_CAPTAIN.SetActive(true);
            }

            //TED RIGHTY THE BOXER WHALE
            if (x.name == "Ted Righty the Boxer Whale")
            {
                Mark_Ted.SetActive(true);
            }

            //NENRUNG THE DRAGON
            if (x.name == "Nenrung the Dragon")
            {
                Mark_NENRUNG.SetActive(true);
            }

            //REZAUL THE MASTER OCTOPUS
            if (x.name ==  "Rezaul the master Octopus")//REZAUL THE MASTER OCTOPUS
            {
                Mark_REZAUL.SetActive(true);
            }

            //GARRINCHA THE TOUGH BLUE LOBSTER
            if (x.name == "Garrincha the Tough Blue Lobster")
            {
               Mark_GARRINCHA.SetActive(true);
            }

            //LUKE LEATHERBACK THE TURTLE
            if (x.name == "Luke the Turtle")
            {
                Mark_LUKE.SetActive(true);
            }

            //RAY THE WHIPPING MANTA
            if (x.name == "Ray the Whipping Manta")
            {
                Mark_RAY.SetActive(true);
            }

            //SIR WESTLEY THE FENCING DOLPHIN
            if (x.name == "Sir Westley the Fencing Dolphin")
            {
                Mark_SIR_WESTLEY.SetActive(true);
            }

            //LIZA THE CARRIER CRAB
            if (x.name == "Liza the Carrier Crab")
            {
                Mark_LIZA.SetActive(true);
            }

            //  S THE MANACING FLATFISH
            if (x.name == "Hanis the Menacing Flatfish")
            {
                Mark_HANIS.SetActive(true);
            }

            //SARGEANT HARTMAN THE NAVY SEAL
            if (x.name == "Sargeant Hartman the Navy Seal")
            {
                Mark_SARGEANT_HARTMAN.SetActive(true);
            }

            //RIDLEY THE OLIVE TURTLE
            if (x.name == "Ridley the Olive Turtle")
            {
                Mark_RIDLEY.SetActive(true);
            }

            //ARSELLA THE SEA NETTLE
            if (x.name == "Arsella the Sea Nettle")
            {
                Mark_ARSELLA.SetActive(true);
            }

            //ROCUS “SHADES” THE BLUE SHARK
            if (x.name == "Rocus 'Shades' the Blue Shark")
            {
                Mark_ROCUS.SetActive(true);
            }

            //AARON THE RAMMING CRAB
            if (x.name == "Aaron the Ramming Crab")
            {
                Mark_AARON.SetActive(true);
            }

            //WANDERLEY THE GRAPPLING OCTOPUS
            if (x.name == "Wanderley the Grappling Octopus")
            {
                Mark_WANDERLEY.SetActive(true);
            }

            //LOLA THE BUFF BLOWFISH
            if (x.name == "Lola the Buff Blowfish")
            {
                Marck_LOLA.SetActive(true);
            }

            //TODD THE BARBER EEL
            if (x.name == "Todd the Barber Eel")
            {
                Mark_TODD.SetActive(true);
            }

            //JOHNNY THE SAILOR SQUID
            if (x.name == "Jhonny the Sailor Squid")
            {
                Mark_JOHNNY.SetActive(true);
            }

            //SOORYA THE NEEDLING BOX JELLYFISH
            if (x.name == "Soorya the Needling Box Jellyfish")
            {
                Mark_SOORYA.SetActive(true);
            }

            //IRFAN THE BLADED LOBSTER
            if (x.name == "Irfan the Bladed Lobster")
            {
                Mark_IRFAN.SetActive(true);
            }

            //DANILO THE PIERCING TATUÍ
            if (x.name == "Danilo the Piercing Tatuí")
            {
                mark_DANILO.SetActive(true);
            }

            //ZE PEREIRA THE SANDBAR SHARK
            if (x.name == "Ze Pereira the Sandbar Shark")
            {
                Mark_ZEPEREIRA.SetActive(true);
            }

            //BOB SAW THE ANCHOVY
            if (x.name == "Bob Saw the Anchovy")
            {
                Mark_BOB_SAW.SetActive(true);
            }

            //TISYA THE SPOTTED BLADEMASTER
            if (x.name == "Tisya the Spotted Blademaster")
            {
                Mark_TISYA.SetActive(true);
            }

            //SASHA THE WRESTLING BELUGA
            if (x.name == "Sasha the Wrestling Beluga")
            {
                Mark_SASHA.SetActive(true);
            }

            //MEDHANSH THE SWORDSMAN
            if (x.name == "Medhansh the Swordsman")
            {
                Mark_MEDHANSH.SetActive(true);
            }

            //SIRILO THE MARBLED SWIM CRAB
            if (x.name == "Sirilo the Marbled Swim Crab")
            {
                Mark_SIRILO.SetActive(true);
            }

            //MAHESH THE SLASHING MACKEREL
            if (x.name == "Mahesh the Slashing Mackerel")
            {
                Mark_MAHESH.SetActive(true);
            }

            //RICHARD THE OPPORTUNIST COCKLE
            if (x.name == "Richard the Opportunist Cockle ")
            {
                Mark_RICHARD.SetActive(true);
            }

            //ED THE PUNK SALMON
            if (x.name == "Ed the Punk Salmon")
            {
                Mark_ED.SetActive(true);
            }

            //ADAM RISSO THE DOLPHIN
            if (x.name == "Adam Risso the Dolphin")
            {
                Mark_ADAM.SetActive(true);
            }


        }


    }

}





