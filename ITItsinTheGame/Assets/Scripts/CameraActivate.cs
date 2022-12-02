using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraActivate : MonoBehaviour
{
    public CameraFollow script;

    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            script.enabled = true;
        }
    }
}
