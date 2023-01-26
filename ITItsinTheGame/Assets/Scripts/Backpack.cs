using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Backpack : MonoBehaviour
{
    public TMP_Text ScoreText;
    public static int Coins;
    public static int coins;
    
    void Start()
    {
        coins = 0;
        if(!PlayerPrefs.HasKey("Coins"))
        {
            PlayerPrefs.SetInt("Coins", 0);
            Load();
        }

        else
        {
            Load();
        }

        if(coins < 1)
        {
            ScoreText.text = "0"; 
        }

        else
        {
        ScoreText.text = "" + coins;
        }
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
             coins = coins + 1;
            ScoreText.text = "" + coins;
        }

        if (collision.gameObject.tag == "Einde")
        {
            Coins = Coins + coins;
            Save();
        }
    }

    private void Load()
    {
        Coins = PlayerPrefs.GetInt("Coins");
    }
    
    private void Save()
    {
        PlayerPrefs.SetInt("Coins", Coins);
    }
}
    
