using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerACC : MonoBehaviour
{
   
    public Text Wallet;
    // Start is called before the first frame update

    void Start()
    {

        Wallet.text = PlayerPrefs.GetString("Account");


    }

    

}
