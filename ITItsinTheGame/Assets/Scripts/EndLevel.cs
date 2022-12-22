using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class EndLevel : MonoBehaviour
{
    public PlayerController PL;
    public GameObject character;
    public Rigidbody2D RB2;
    bool einde = PlayerController.einde;
    float moveHorizontal = PlayerController.moveHorizontal;
    int i = 0;
    private void Start()
    {
        character = GameObject.Find("Character");
        RB2= character.GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            moveHorizontal = 0;
            while (i < 5)
            {
                RB2.AddForce(new Vector2(1.5f, 0), ForceMode2D.Impulse);
                i++;
            }

        }
        
    }
}
