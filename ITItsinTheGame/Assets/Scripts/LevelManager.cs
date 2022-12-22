using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    bool unlockedlvl = false;
    int level = PlayerController.level;
    public static bool level1gehaald = false;
    public static bool level2gehaald = false;
    public static bool level3gehaald = false;
    public static bool level4gehaald = false;
    public static bool level5gehaald = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Level1() 
    {
        level = 1;
        SceneManager.LoadScene(2);
        
    }

    public void Level2() 
    {
        level= 2;
        SceneManager.LoadScene(3);
    }
    public void Level3() 
    {
        level= 3;
        SceneManager.LoadScene(4);
    }
    public void Level4() 
    {
        level= 4;
        SceneManager.LoadScene(5);
    }
    public void Level5() 
    { 
        level= 5;
        SceneManager.LoadScene(6);
    }

}
