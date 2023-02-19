using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Web3Unity.Scripts.Library.Web3Wallet;

public class PlayerAccount : MonoBehaviour
{
    // Start is called before the first frame update
    public Text playerAccount;
    void Start()
    {
       playerAccount.text = PlayerPrefs.GetString("Account");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

