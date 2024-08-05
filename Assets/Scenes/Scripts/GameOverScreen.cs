using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class GameOverScreen : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 0;
    }

    public void ReloadLevelButton()
     {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void MainMenuButton()
     {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
    }

}
