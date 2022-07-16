using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Item : MonoBehaviour
{
    [SerializeField]
    private GameObject mainSlot, championObj, BattlePowerText;
    [SerializeField]
    private GameObject[] slotList;
    [SerializeField]
    private Color slotColor;
    public GameObject CardChampion;

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
    public float battlePower;

    public Sprite JOHN_FANGO, CAPTAIN, TED, NENRUNG, REZAUL, GARRINCHA, LUKE, RAY, SIR_WESTLEY, LIZA, HANIS, SARGEANT_HARTMAN, RIDLEY, ARSELLA,
    ROCUS, AARON, WANDERLEY, LOLA, TODD, JOHNNY, SOORYA, IRFAN, DANILO, ZEPEREIRA, BOB_SAW, TISYA, SASHA, MEDHANSH, SIRILO, MAHESH,
    RICHARD, ED, ADAM;
    

    void Awake()
    {
        championObj = GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().championObj;
        SetCardImage();

        battlePower = agility + (0.8f * brawl) + (1.2f * cunning);
        BattlePowerText.GetComponent<Text>().text = "BP: " + battlePower.ToString();
    }

    public void SelectChampion()
    {
        if (GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamSlot != null)
        {
            // Get the game objects to show the champion
            GameObject Remove = GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().remove;
            GameObject TeamSlot = GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamSlot;
            GameObject TeamImage = GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamImage;
            GameObject Team = GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().team;
            int Crew = GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().crew;

            // Configure the Gameobjects to show the champion
            Remove.SetActive(true);
            TeamImage.GetComponent<Button>().interactable = false;
            TeamSlot.GetComponent<RectTransform>().sizeDelta = new Vector2(170, 170);
            TeamSlot.GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
            this.GetComponent<BoxCollider>().enabled = false;
            this.GetComponent<Button>().interactable = false;

            switch (Crew)
            {
                case 0:
                    Team.GetComponent<TeamSetItem>().commander = this.gameObject;
                    break;
                case 1:
                    Team.GetComponent<TeamSetItem>().crew1 = this.gameObject;
                    break;
                case 2:
                    Team.GetComponent<TeamSetItem>().crew2 = this.gameObject;
                    break;
                case 3:
                    Team.GetComponent<TeamSetItem>().crew3 = this.gameObject;
                    break;
                case 4:
                    Team.GetComponent<TeamSetItem>().crew4 = this.gameObject;
                    break;
            }

            // Reset
            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamSlot = null;
            GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().teamImage = null;

        }

        slotList = GameObject.FindGameObjectsWithTag("slot");

        foreach (GameObject gameObject in slotList)
        {
            gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        }
    }

    public void SetCardImage()
    {
        switch (name)
        {
            case "John Fango the Tactical Megalodon":
                this.GetComponent<Image>().sprite = JOHN_FANGO;
                idealPressure = 4;
                break;
            case "Captain Costa the Man O’War":
                this.GetComponent<Image>().sprite = CAPTAIN;
                idealPressure = 1;
                break;
            case "Ted Righty the Boxer Whale":
                this.GetComponent<Image>().sprite = TED;
                idealPressure = 2;
                break;
            case "Nenrung the Dragon":
                this.GetComponent<Image>().sprite = NENRUNG;
                idealPressure = 3;
                break;
            case "Rezaul the Master Octopus":
                this.GetComponent<Image>().sprite = REZAUL;
                idealPressure = 1;
                break;
            case "Garrincha the Tough Blue Lobster":
                this.GetComponent<Image>().sprite = GARRINCHA;
                idealPressure = 2;
                break;
            case "Luke Leatherback the Turtle":
                this.GetComponent<Image>().sprite = LUKE;
                idealPressure = 2;
                break;
            case "Ray the Whipping Manta":
                this.GetComponent<Image>().sprite = RAY;
                idealPressure = 3;
                break;
            case "Sir Westley the Fencing Dolphin":
                this.GetComponent<Image>().sprite = SIR_WESTLEY;
                idealPressure = 1;
                break;
            case "Liza the Carrier Crab":
                this.GetComponent<Image>().sprite = LIZA;
                idealPressure = 3;
                break;
            case "Hanis the Menacing Flatfish":
                this.GetComponent<Image>().sprite = HANIS;
                idealPressure = 2;
                break;
            case "Sargeant Hartman the Navy Seal":
                this.GetComponent<Image>().sprite = SARGEANT_HARTMAN;
                idealPressure = 1;
                break;
            case "Ridley the Olive Turtle":
                this.GetComponent<Image>().sprite = RIDLEY;
                idealPressure = 1;
                break;
            case "Arsella the Sea Nettle":
                this.GetComponent<Image>().sprite = ARSELLA;
                idealPressure = 4;
                break;
            case "Rocus Shades the Blue Shark":
                this.GetComponent<Image>().sprite = ROCUS;
                idealPressure = 2;
                break;
            case "Aaron the Ramming Crab":
                this.GetComponent<Image>().sprite = AARON;
                idealPressure = 3;
                break;
            case "Wanderley the Grappling Octopus":
                this.GetComponent<Image>().sprite = WANDERLEY;
                idealPressure = 1;
                break;
            case "Lola the Buff Blowfish":
                this.GetComponent<Image>().sprite = LOLA;
                idealPressure = 3;
                break;
            case "Todd the Barber Eel":
                this.GetComponent<Image>().sprite = TODD;
                idealPressure = 4;
                break;
            case "Johnny the Sailor Squid":
                this.GetComponent<Image>().sprite = JOHNNY;
                idealPressure = 2;
                break;
            case "Soorya the Needling Box Jellyfish":
                this.GetComponent<Image>().sprite = SOORYA;
                idealPressure = 4;
                break;
            case "Irfan the Bladed Lobster":
                this.GetComponent<Image>().sprite = IRFAN;
                idealPressure = 3;
                break;
            case "Danilo the Piercing Tatui":
                this.GetComponent<Image>().sprite = DANILO;
                idealPressure = 3;
                break;
            case "Ze Pereira the Sandbar Shark":
                this.GetComponent<Image>().sprite = ZEPEREIRA;
                idealPressure = 1;
                break;
            case "Bob Saw the Anchovy":
                this.GetComponent<Image>().sprite = BOB_SAW;
                idealPressure = 2;
                break;
            case "Tisya the Spotted Blademaster":
                this.GetComponent<Image>().sprite = TISYA;
                idealPressure = 2;
                break;
            case "Sasha the Wrestling Beluga":
                this.GetComponent<Image>().sprite = SASHA;
                idealPressure = 1;
                break;
            case "Medhansh the Swordsman Octopus":
                this.GetComponent<Image>().sprite = MEDHANSH;
                idealPressure = 2;
                break;
            case "Sirilo the Marbled Swim Crab":
                this.GetComponent<Image>().sprite = SIRILO;
                idealPressure = 3;
                break;
            case "Mahesh the Slashing Mackerel":
                this.GetComponent<Image>().sprite = MAHESH;
                idealPressure = 3;
                break;
            case "Richard the Opportunist Cockle":
                this.GetComponent<Image>().sprite = RICHARD;
                idealPressure = 2;
                break;
            case "Ed the Punk Salmon":
                this.GetComponent<Image>().sprite = ED;
                idealPressure = 4;
                break;
            case "Adam Risso the Dolphin":
                this.GetComponent<Image>().sprite = ADAM;
                idealPressure = 2;
                break;

        }
    }

    public Sprite GetSprite()
    {
        return this.GetComponent<Image>().sprite;
    }


    public void GetCard()
    {
        GameObject CardOverlayHolder = GameObject.Find("CardOverlayHolder");
        var CardChampionClone = Instantiate(CardChampion);
        CardChampionClone.transform.SetParent(CardOverlayHolder.transform, false);
        CardChampionClone.transform.position = Input.mousePosition;
        CardChampionClone.GetComponent<CardChapion>().id = this.id;
        CardChampionClone.GetComponent<CardChapion>().name = this.name;
        CardChampionClone.GetComponent<CardChapion>().image = this.image;
        CardChampionClone.GetComponent<CardChapion>().tribe = this.tribe;
        CardChampionClone.GetComponent<CardChapion>().rarity = this.rarity;
        CardChampionClone.GetComponent<CardChapion>().elite = this.elite;
        CardChampionClone.GetComponent<CardChapion>().idealPressure = this.idealPressure;
        CardChampionClone.GetComponent<CardChapion>().brawl = this.brawl;
        CardChampionClone.GetComponent<CardChapion>().agility = this.agility;
        CardChampionClone.GetComponent<CardChapion>().cunning = this.cunning;
        CardChampionClone.GetComponent<CardChapion>().battlePower = this.battlePower;
    }
    public void DestroyCard()
    {
        GameObject CardChampionClone = GameObject.Find("CardChampion(Clone)");
        Destroy(CardChampionClone);
    }



}


