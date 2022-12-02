using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Backpack : MonoBehaviour
{
    public TMP_Text ScoreText;
    public int Coins;
    
    void Start()
    {
        if(!PlayerPrefs.HasKey("Coins"))
        {
            PlayerPrefs.SetInt("Coins", 0);
            Load();
        }

        else
        {
            Load();
        }

        if(Coins < 1)
        {
            ScoreText.text = "0"; 
        }

        else
        {
        ScoreText.text = "" + Coins;
        }
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
             Coins = Coins + 1;
            ScoreText.text = "" + Coins;
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
    
