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
        ScoreText.text = "Coins: " + Coins;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Coins = Coins +1;
      }
    }
}
