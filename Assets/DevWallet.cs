using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevWallet : MonoBehaviour
{

    public bool WalletLogin;
    public string UrlAPIfinal;
    // Start is called before the first frame update

    void Awake()
    {
        if (WalletLogin == true)
        {
            UrlAPIfinal = ("https://metadata.seachampions.com/champion/erc1155/unity/" + PlayerPrefs.GetString("Account"));
        }
        else
        {
            //Will wallet
           // UrlAPIfinal = ("https://metadata.seachampions.com/champion/erc1155/unity/0xD286b7469ECba17A61eaB499D12ad5171B50C11f");
           //Lots ChampsWallet
            UrlAPIfinal = ("https://metadata.seachampions.com/champion/erc1155/unity/0xA95084FF31E7D9AA96E5451FD8438E2AE27CC093"); 
        }
        GameObject.Find("ScriptHolder").GetComponent<CardCostructor>().UrlAPIfinal = UrlAPIfinal;
        GameObject.Find("ScriptHolder").GetComponent<ChampionsCheck>().UrlAPIfinal = UrlAPIfinal;
}
