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
    private void Start()
    {
        character = GameObject.Find("Character");
        RB2= character.GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PL.enabled = false;
            while (!einde)
            {
                RB2.AddForce(new Vector2(1.5f, 0));
            }

        }
        
    }
}
