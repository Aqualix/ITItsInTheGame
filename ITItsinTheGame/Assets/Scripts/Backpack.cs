using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Backpack : MonoBehaviour
{
    public Text ScoreText;
    public int Coins;
    
    void Start()
    {
        Coins = 0;
        ScoreText.text = "Coins: " + Coins;
    }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
             Coins +=1;
            ScoreText.text = "Coins: " + Coins;
      }
    }
    
