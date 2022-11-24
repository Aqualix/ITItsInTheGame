using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    public AudioSource AS;
 void OnTriggerEnter2D(Collider2D collision)
 {
    if (collision.gameObject.tag == "Player")
    {
        AS = GetComponent<AudioSource>();
        AS.Play();
        Destroy(gameObject);
    }
 }
}
