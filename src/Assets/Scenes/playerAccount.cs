using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class playerAccount : MonoBehaviour
{
    [SerializeField] 
    public Text WalletText;
    
    
    void Awake()
    {
        string acc = PlayerPrefs.GetString("Account", "no player account found!");
        if (string.IsNullOrEmpty(acc)) {
	    WalletText.text = "Account not found!";
        } else {
            WalletText.text = acc;
        }
    }


    void Start()
    {
    }

    void Update()
    {
        
    }
}
