using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{
    bool einde = PlayerController.einde;
    bool level1gehaald = LevelManager.level1gehaald;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Einde")
        {
            einde= true;
            level1gehaald = true;
            // ruimte voor animatie

            SceneManager.LoadScene(1);
        }
    }
}
