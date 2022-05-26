using UnityEngine;
using UnityEngine.UI;

public class PlayerACC : MonoBehaviour
{
    [SerializeField]
    private Text wallet;

    void Start()
    {
        wallet.text = PlayerPrefs.GetString("Account");
    }
}
