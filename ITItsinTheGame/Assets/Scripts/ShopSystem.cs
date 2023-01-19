using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;
using System;
using UnityEditor.Search;

public class ShopSystem : MonoBehaviour
{
    
    public int prijs;
    public static Boolean SpeedIsPurchased = false;
    public static Boolean JumpIsPurchased = false;
    public TMP_Text prijsText;
    public TMP_Text prijsText2;
    public TMP_Text scoreText;
    int Coins = Backpack.Coins;

    // Start is called before the first frame update
    void Start()
    {
        Load();
        Showitem1();
        Showitem2();
       
    }


    // Update is called once per frame
    void Update()
    {

    }
    private void Save()
    {
        PlayerPrefs.SetInt("Coins", Coins);
    }
    private void Load()
    {
        Coins = PlayerPrefs.GetInt("Coins");
    }

    public void Showitem1()
    {
        prijs = 100;
        prijsText.text = "" + prijs; 
    }
    public void buyitem1()
    {
        if (SpeedIsPurchased == false)
        {
            if (prijs < Coins)
            {
                Coins = Coins - prijs;
                PlayerPrefs.SetInt("Coins", Coins);
                SpeedIsPurchased = true;
                prijsText.text = "Purchased";
                PlayerController.moveSpeed = 2f;
                Save();
                scoreText.text = "" + Coins;
                Load();
               
            }
        }
    
    }
    public void Showitem2()
    {
        prijs = 50;
        prijsText2.text = "" + prijs;
    }
    public void buyitem2()
    {
        if (JumpIsPurchased == false)
        {
            if (prijs < Coins)
            {
                Coins = Coins - prijs;
                PlayerPrefs.SetInt("Coins", Coins);
                JumpIsPurchased = true;
                prijsText2.text = "Purchased";
                PlayerController.jumpForce = 60f;
                Save();
                scoreText.text = "" + Coins;
                Load();

            }
        }

    }
    public void coinserbij()
    {
        Coins = Coins + 100;
        scoreText.text = "" + Coins;
        Save();
        
    }
}
