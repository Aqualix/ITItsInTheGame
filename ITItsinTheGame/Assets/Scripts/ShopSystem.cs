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
    Boolean purchased = false;
    public TMP_Text prijsText;
    public TMP_Text scoreText;
    int Coins = Backpack.Coins;

    // Start is called before the first frame update
    void Start()
    {
        Load();
        Showitem1();
       
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
        prijs = 50;
        prijsText.text = "" + prijs; 
    }
    public void buyitem1()
    {
        if (purchased == false)
        {
            if (prijs < Coins)
            {
                Coins = Coins - prijs;
                PlayerPrefs.SetInt("Coins", Coins);
                purchased = true;
                prijsText.text = "Purchased";
                Save();
                scoreText.text = "" + Coins;
            }
        }
    
    }
    public void coinserbij()
    {
        Coins = Coins + 100;
        scoreText.text = "" + Coins;
    }
}
