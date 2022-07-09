using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FilterAndSort : MonoBehaviour
{

    [SerializeField]
    private TMP_Dropdown filterDropdown;

    private bool isDescendingAlphabeticalOrder = true;
    private bool isDescendingBattlePower = true;
    private bool isDescendingRarity = true;

    public string tribe;
    public string nationality;
    public int level;

    public void sortInAlphabeticalOrder()
    {
        int size = 0;
        foreach (GameObject card in FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "slot"))
        {
            size++;
        }
        string[] cardsNames = new string[size];
        int i = 0;
        foreach (GameObject card in FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "slot"))
        {
            cardsNames[i] = card.GetComponentInChildren<Item>().name;
            i++;
        }

        if (isDescendingAlphabeticalOrder)
        {
            Array.Sort(cardsNames, (x, y) => String.Compare(x, y));
            isDescendingAlphabeticalOrder = false;
            FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "OrderAscending")[0].SetActive(false);
            FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "OrderDescending")[0].SetActive(true);
        }
        else
        {   
            Array.Sort(cardsNames, (x, y) => String.Compare(y, x));
            isDescendingAlphabeticalOrder = true;
            FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "OrderAscending")[0].SetActive(true);
            FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "OrderDescending")[0].SetActive(false);
        }

        i = 0;
        foreach (string cardName in cardsNames)
        {
            foreach (GameObject card in GameObject.FindGameObjectsWithTag("slot"))
            {
                if (card.GetComponentInChildren<Item>().name == cardName && card.transform.GetSiblingIndex() != i)
                {
                    card.transform.SetSiblingIndex(i);
                    i++;
                }
            }
        }

    }

    public void sortByBattlePower()
    {
        int size = 0;
        foreach (GameObject card in FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "slot"))
        {
            size++;
        }
        float[] cardsBattlePowers = new float[size];
        int i = 0;
        foreach (GameObject card in FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "slot"))
        {
            cardsBattlePowers[i] = card.GetComponentInChildren<Item>().battlePower;
            i++;
        }

        if (isDescendingBattlePower)
        {
            Array.Sort(cardsBattlePowers, (x, y) => x.CompareTo(y));
            isDescendingBattlePower = false;
            FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "OrderAscending")[1].SetActive(false);
            FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "OrderDescending")[1].SetActive(true);
        }
        else
        {
            Array.Sort(cardsBattlePowers, (x, y) => y.CompareTo(x));
            isDescendingBattlePower = true;
            FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "OrderAscending")[1].SetActive(true);
            FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "OrderDescending")[1].SetActive(false);
        }

        i = 0;
        foreach (float cardBattlePower in cardsBattlePowers)
        {
            foreach (GameObject card in GameObject.FindGameObjectsWithTag("slot"))
            {
                if (card.GetComponentInChildren<Item>().battlePower == cardBattlePower && card.transform.GetSiblingIndex() != i)
                {
                    card.transform.SetSiblingIndex(i);
                    i++;
                }
            }
        }

    }

    public void sortByRarity()
    {
        int size = 0;
        foreach (GameObject card in FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "slot"))
        {
            size++;
        }
        int[] cardsRarities = new int[size];
        int i = 0;
        foreach (GameObject card in FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "slot"))
        {
            switch (card.GetComponentInChildren<Item>().rarity)
            {
                case "Common":
                    cardsRarities[i] = 0;
                    break;
                case "Uncommon":
                    cardsRarities[i] = 1;
                    break;
                case "Rare":
                    cardsRarities[i] = 2;
                    break;
                case "Very Rare":
                    cardsRarities[i] = 3;
                    break;
                case "Legendary":
                    cardsRarities[i] = 4;
                    break;
                default:
                    break;
            }
            i++;
        }

        if (isDescendingRarity)
        {
            Array.Sort(cardsRarities, (x, y) => x.CompareTo(y));
            isDescendingRarity = false;
            FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "OrderAscending")[2].SetActive(false);
            FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "OrderDescending")[2].SetActive(true);
        }
        else
        {
            Array.Sort(cardsRarities, (x, y) => y.CompareTo(x));
            isDescendingRarity = true;
            FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "OrderAscending")[2].SetActive(true);
            FindInactiveHelper.FindObjectsByName(GameObject.Find("Canvas_Holder"), "OrderDescending")[2].SetActive(false);
        }

        i = 0;
        foreach (int cardRarity in cardsRarities)
        {
            foreach (GameObject card in GameObject.FindGameObjectsWithTag("slot"))
            {
                String rarity = "";
                switch (cardRarity)
                {
                    case 0:
                        rarity = "Common";
                        break;
                    case 1:
                        rarity = "Uncommon";
                        break;
                    case 2:
                        rarity = "Rare";
                        break;
                    case 3:
                        rarity = "Very Rare";
                        break;
                    case 4:
                        rarity = "Legendary";
                        break;
                    default:
                        break;
                }
                if (card.GetComponentInChildren<Item>().rarity == rarity && card.transform.GetSiblingIndex() != i)
                {
                    card.transform.SetSiblingIndex(i);
                    i++;
                }
            }
        }
    }

    private void Start()
    {
        filterDropdown.ClearOptions();

        List<string> options = new List<string>();
        options.Add("None");
        options.Add("Tribe");
        options.Add("<i>  Clawbeasts</i>");
        options.Add("<i>  Jellies</i>");
        options.Add("<i>  Manylimbs</i>");
        options.Add("<i>  Roughskins</i>");
        options.Add("<i>  Scalefins</i>");
        options.Add("<i>  Seasingers</i>");
        options.Add("<i>  Shellbearers</i>");
        options.Add("Nationality");
        options.Add("<i>  Nationality1</i>");
        options.Add("<i>  Nationality2</i>");
        options.Add("<i>  Nationality3</i>");
        options.Add("Level");
        options.Add("<i>  Level 1</i>");
        options.Add("<i>  Level 2</i>");
        options.Add("<i>  Level 3</i>");
        filterDropdown.AddOptions(options);
        filterDropdown.value = 0;
        filterDropdown.RefreshShownValue();
       

    }

    public void filter()
    {
        if (filterDropdown.value > 1 && filterDropdown.value < 9)
        {
            filterByTribe();
        }
        else if (filterDropdown.value > 9 && filterDropdown.value < 13)
        {
            filterByNationality();
        }
        else if (filterDropdown.value > 13 && filterDropdown.value < 17)
        {
            filterByChampionLevel();
        }
        if (filterDropdown.value < 1)
        {
            foreach (GameObject card in FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "slot"))
            {
                card.SetActive(true);
            }
        }
    }

    public void filterByTribe()
    {
        foreach (GameObject card in FindInactiveHelper.FindObjectsByTag(GameObject.Find("Canvas_Holder"), "slot"))
        {
            String tribe = "";
            switch (filterDropdown.options[filterDropdown.value].text)
            {
                case "<i>  Clawbeasts</i>":
                    tribe = "Clawbeasts";
                    break;
                case "<i>  Jellies</i>":
                    tribe = "Jellies";
                    break;
                case "<i>  Manylimbs</i>":
                    tribe = "Manylimbs";
                    break;
                case "<i>  Roughskins</i>":
                    tribe = "Roughskins";
                    break;
                case "<i>  Scalefins</i>":
                    tribe = "Scalefins";
                    break;
                case "<i>  Seasingers</i>":
                    tribe = "Seasingers";
                    break;
                case "<i>  Shellbearers</i>":
                    tribe = "Shellbearers";
                    break;
                default:
                    break;
            }
            if (card.GetComponentInChildren<Item>().tribe == tribe)
            {
                card.SetActive(true);
            }
            else
            {
                card.SetActive(false);
            }
        }
    }

    public void filterByNationality()
    {
        // Implementation here
    }

    public void filterByChampionLevel()
    {
        // Implementation here
    }

}
