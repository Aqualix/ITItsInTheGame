using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class EndLevel : MonoBehaviour
{
    public GameObject PL;
    public GameObject character;
    public Rigidbody2D RB2;

    private void Start()
    {
        character = GameObject.Find("Character");
        RB2= character.GetComponent<Rigidbody2D>();
      //  PL = character.GetComponent<PlayerController>;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PL.SetActive(false);
            RB2.AddForce(new Vector2(1, 0));
            

        }
    }
}
