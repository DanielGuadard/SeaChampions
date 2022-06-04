using UnityEngine;

public class DevWallet : MonoBehaviour
{
    public bool walletLogin;
    public string urlAPIFinal;

    void Awake()
    {
        if (walletLogin == true)
        {
            urlAPIFinal = ("https://metadata.seachampions.com/champion/erc1155/unity/" + PlayerPrefs.GetString("Account"));
        }
        else
        {
            // Will wallet
            urlAPIFinal = ("https://metadata.seachampions.com/champion/erc1155/unity/0xD286b7469ECba17A61eaB499D12ad5171B50C11f");
            // Lots ChampsWallet
            // urlAPIFinal = ("https://metadata.seachampions.com/champion/erc1155/unity/0xA95084FF31E7D9AA96E5451FD8438E2AE27CC093");
        }
        GameObject.Find("ScriptHolder").GetComponent<CardConstructor>().urlAPIFinal = urlAPIFinal;
        GameObject.Find("ScriptHolder").GetComponent<ChampionsCheck>().urlAPIFinal = urlAPIFinal;
    }
}
