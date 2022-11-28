using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSettings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("musicVolume");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
