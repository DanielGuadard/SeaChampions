using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
public class CardCostructor : MonoBehaviour
{

    //Objetos de marcaçao se posui o champion 

    public GameObject MyTeamContent, ChampiomObj, slot, Remove, TeamSlot, TeamImage,Team;
    public Sprite item;
    public int TeamCriado, Crew;
    public string URl,UrlAPIfinal;


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


    IEnumerator GetImage(string _Image)
    {

        UnityWebRequest DataImage = UnityWebRequestTexture.GetTexture(_Image);

        yield return DataImage.SendWebRequest();

        if (DataImage.isNetworkError || DataImage.isHttpError)
        {
            Debug.Log(DataImage.error);
        }
        else
        {
         
            /*  GameObject HeroCard = Instantiate(HeroCardPref);
            HeroCard.GetComponent<Image>().material.mainTexture = Moldura;
            HeroCard.transform.SetParent(MyTeamContent.transform, false);


            GameObject HeroImage = Instantiate(HeroImagePref);
            HeroImage.transform.SetParent(HeroCard.transform, false);
            Texture img= ((DownloadHandlerTexture)DataImage.downloadHandler).texture;



            this.gameObject.GetComponent<Renderer>().material.mainTexture = ((DownloadHandlerTexture)textureRequest.downloadHandler).texture;
             Texture2D WebImage = ((DownloadHandlerTexture)DataImage.downloadHandler).texture;
              conver.sprite = Sprite.Create(WebImage,new Rect(0,0,8,8),Vector2.zero);
            */


        }

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

        JsonData = JsonUtility.FromJson<CardList>(_url);
        //Debug.Log(JsonData.Deck);
        //Debug.Log(x.name);    

        
        foreach (Card x in JsonData.Deck)
        {

            
            // Debug.Log(x.name);
    
            //JOHN FANGO THE TACTICAL MEGALODON
            if (x.name == "John Fango the Tactical Megalodon")
            {
                GameObject.Instantiate(JOHN_FANGOPref).transform.SetParent(MyTeamContent.transform, false);
                
            }

            //CAPTAIN COSTA THE MAN O’WAR
            if (x.name == "Captain Costa the Man O’War")
            {
                GameObject.Instantiate(CAPTAINPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //TED RIGHTY THE BOXER WHALE
            if (x.name == "Ted Righty the Boxer Whale")
            {
                GameObject.Instantiate(TedPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //NENRUNG THE DRAGON
            if (x.name == "Nenrung the Dragon")
            {
                GameObject.Instantiate(NENRUNGPrefg).transform.SetParent(MyTeamContent.transform, false);
            }

            //REZAUL THE MASTER OCTOPUS
            if (x.name == "Rezaul the master Octopus")//REZAUL THE MASTER OCTOPUS
            {
                GameObject.Instantiate(REZAULPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //GARRINCHA THE TOUGH BLUE LOBSTER
            if (x.name == "Garrincha the Tough Blue Lobster")
            {
                GameObject.Instantiate(GARRINCHAPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //LUKE LEATHERBACK THE TURTLE
            if (x.name == "Luke the Turtle")
            {
                GameObject.Instantiate(LUKEPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //RAY THE WHIPPING MANTA
            if (x.name == "Ray the Whipping Manta")
            {
                GameObject.Instantiate(RAYPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //SIR WESTLEY THE FENCING DOLPHIN
            if (x.name == "Sir Westley the Fencing Dolphin")
            {
                GameObject.Instantiate(SIR_WESTLEYPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //LIZA THE CARRIER CRAB
            if (x.name == "Liza the Carrier Crab")
            { 
                GameObject.Instantiate(LIZAPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //  Hanis THE MANACING FLATFISH
            if (x.name == "Hanis the Menacing Flatfish")
            {
            GameObject.Instantiate(HANISPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //SARGEANT HARTMAN THE NAVY SEAL
            if (x.name == "Sargeant Hartman the Navy Seal")
            {
                GameObject.Instantiate(SARGEANT_HARTMANPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //RIDLEY THE OLIVE TURTLE
            if (x.name == "Ridley the Olive Turtle")
            {
                GameObject.Instantiate(RIDLEYPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //ARSELLA THE SEA NETTLE
            if (x.name == "Arsella the Sea Nettle")
            {
                GameObject.Instantiate(ARSELLAPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //ROCUS “SHADES” THE BLUE SHARK
            if (x.name == "Rocus 'Shades' the Blue Shark")
            {
                GameObject.Instantiate(ROCUSPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //AARON THE RAMMING CRAB
            if (x.name == "Aaron the Ramming Crab")
            {
                GameObject.Instantiate(AARONPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //WANDERLEY THE GRAPPLING OCTOPUS
            if (x.name == "Wanderley the Grappling Octopus")
            {
                GameObject.Instantiate(WANDERLEYPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //LOLA THE BUFF BLOWFISH
            if (x.name == "Lola the Buff Blowfish")
            {
                GameObject.Instantiate(LOLAPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //TODD THE BARBER EEL
            if (x.name == "Todd the Barber Eel")
            {
                GameObject.Instantiate(TODDPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //JOHNNY THE SAILOR SQUID
            if (x.name == "Jhonny the Sailor Squid")
            {
                GameObject.Instantiate(JOHNNYPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //SOORYA THE NEEDLING BOX JELLYFISH
            if (x.name == "Soorya the Needling Box Jellyfish")
            {
                GameObject.Instantiate(SOORYAPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //IRFAN THE BLADED LOBSTER
            if (x.name == "Irfan the Bladed Lobster")
            {
                GameObject.Instantiate(IRFANPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //DANILO THE PIERCING TATUÍ
            if (x.name == "Danilo the Piercing Tatuí")
            {
                GameObject.Instantiate(DANILOPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //ZE PEREIRA THE SANDBAR SHARK
            if (x.name == "Ze Pereira the Sandbar Shark")
            {
                GameObject.Instantiate(ZEPEREIRAPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //BOB SAW THE ANCHOVY
            if (x.name == "Bob Saw the Anchovy")
            {
                GameObject.Instantiate(BOB_SAWPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //TISYA THE SPOTTED BLADEMASTER
            if (x.name == "Tisya the Spotted Blademaster")
            {
                GameObject.Instantiate(TISYAPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //SASHA THE WRESTLING BELUGA
            if (x.name == "Sasha the Wrestling Beluga")
            {
                GameObject.Instantiate(SASHAPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //MEDHANSH THE SWORDSMAN
            if (x.name == "Medhansh the Swordsman")
            {
                GameObject.Instantiate(MEDHANSHPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //SIRILO THE MARBLED SWIM CRAB
            if (x.name == "Sirilo the Marbled Swim Crab")
            {
                GameObject.Instantiate(SIRILOPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //MAHESH THE SLASHING MACKEREL
            if (x.name == "Mahesh the Slashing Mackerel")
            {
                GameObject.Instantiate(MAHESHPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //RICHARD THE OPPORTUNIST COCKLE
            if (x.name == "Richard the Opportunist Cockle")
            {
                GameObject.Instantiate(RICHARDPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //ED THE PUNK SALMON
            if (x.name == "Ed the Punk Salmon")
            {
                GameObject.Instantiate(EDPref).transform.SetParent(MyTeamContent.transform, false);
            }

            //ADAM RISSO THE DOLPHIN
            if (x.name == "Adam Risso the Dolphin")
            {
                GameObject.Instantiate(ADAMPref).transform.SetParent(MyTeamContent.transform, false);
            }

           
    
        }
    }

}





