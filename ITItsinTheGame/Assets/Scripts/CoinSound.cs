using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSound : MonoBehaviour
{
    public AudioSource AS;
    private bool isDestroyed;

    public void Start()
    {
        AS = GetComponent<AudioSource>();
        isDestroyed= false;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !isDestroyed)
        {
            AS.Play();
            isDestroyed= true;
        }
    }
}
