using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doodMenu : MonoBehaviour
{
    public void Respawn()
    {
        SceneManager.LoadScene(2);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
