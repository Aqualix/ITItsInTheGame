using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    public AudioSource AS;

    public void Start()
    {
        AS = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D collision)
 {
    if (collision.gameObject.tag == "Player")
    {
        AS.Play();
        Destroy(gameObject);
    }
 }
}
