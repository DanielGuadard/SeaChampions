using UnityEngine;
using UnityEngine.UI;

public class PlayerACC : MonoBehaviour
{
    public Text wallet;

    void Start()
    {
        wallet.text = PlayerPrefs.GetString("Account");
    }
}
