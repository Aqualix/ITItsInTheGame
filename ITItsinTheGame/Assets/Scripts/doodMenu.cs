using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doodMenu : MonoBehaviour
{
    public int level;
    public int sceneId;
    public void Respawn()
    {
        level = PlayerController.level;
        sceneId = level + 1;
        SceneManager.LoadScene(sceneId);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
