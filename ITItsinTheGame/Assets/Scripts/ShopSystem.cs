using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;
using System;


public class ShopSystem : MonoBehaviour
{
    
    public int prijs;
    public static Boolean SpeedIsPurchased = false;
    public static Boolean JumpIsPurchased = false;
    public TMP_Text prijsText;
    public TMP_Text prijsText2;
    public TMP_Text scoreText;
    int Coins = Backpack.Coins;
    public Button turnonitem1;
    public Button turnoffitem1;
    public Button turnonitem2;
    public Button turnoffitem2;


    // Start is called before the first frame update
    void Start()
    {
        Load();
        Showitem1();
        Showitem2();
        showbuttonsitem1();
        showbuttonsitem2();
        scoreText.text = "" + Coins;

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
                showbuttonsitem1();
               
            }
        }
    
    }
    public void showbuttonsitem1()
    {
        if(SpeedIsPurchased == true)
        {
            turnonitem1.gameObject.SetActive(true);
            turnoffitem1.gameObject.SetActive(true);
        }
    }
    public void showbuttonsitem2()
    {
        if (JumpIsPurchased == true)
        {
            turnonitem2.gameObject.SetActive(true);
            turnoffitem2.gameObject.SetActive(true);
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
                showbuttonsitem2();

            }
        }

    }
    public void turnitem1off() {
        
            PlayerController.moveSpeed = 1.5f;
        

    }
    public void turnitem1on()
    {
        
            PlayerController.moveSpeed = 2f;
        

    }
    public void turnitem2off()
    {
        
            PlayerController.jumpForce = 45f;
        

    }
    public void turnitem2on()
    {
       
            PlayerController.jumpForce = 60f;
        

    }
    public void coinserbij()
    {
        Coins = Coins + 100;
        scoreText.text = "" + Coins;
        Save();
        
    }
}
