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
    public Button button2;
    public Button button3;
    public Image button2Image;
    public Image button3Image;

    // Start is called before the first frame update
    void Start()
    {
        button2 = GameObject.Find("Level2").GetComponent<Button>();
        button3 = GameObject.Find("Level3").GetComponent<Button>();
        button2Image = GameObject.Find("Image").GetComponent<Image>();
        button3Image = GameObject.Find("Image2").GetComponent<Image>();

        if (level1gehaald == true)
        {
            ColorBlock cb = button2.colors;
            cb.normalColor= new Color(0, 0, 0, 0);
            button2.colors = cb;
            button2Image.enabled= false;
        }

        if (level2gehaald == true)
        {
            ColorBlock cb2 = button3.colors;
            cb2.normalColor = new Color(0, 0, 0, 0);
            button3.colors = cb2;
            button3Image.enabled = false;
        }
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
    public void BacktoLevelManager()
    {
       
        SceneManager.LoadScene(1);

    }

}
