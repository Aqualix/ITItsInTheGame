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
        PlayerController.finishGehaald = false;
        SceneManager.LoadScene(2);
        
    }

    public void Level2()
    {
        if (level1gehaald == true)
        {

            level = 2;
            PlayerController.finishGehaald = false;
            SceneManager.LoadScene(3);
        }
    }
    public void Level3() 
    {

        if (level2gehaald == true)
        {

            level = 3;
            PlayerController.finishGehaald = false;
            SceneManager.LoadScene(4);
        }
        
    }

}
