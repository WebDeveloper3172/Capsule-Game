using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject finishLevelPopUp;

    private void OnTriggerEnter(Collider other)
    { 
      if(other.gameObject.name == "Player")
      {
       UnlockedNewLevel();
       finishLevelPopUp.SetActive(true);
      }
    }

    void UnlockedNewLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
        {
            PlayerPrefs.SetInt("ReachedIndex" , SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("UnlockedLevel" , PlayerPrefs.GetInt("UnlockedLevel", 1) + 1);
            PlayerPrefs.Save();
        }
    }

    public void PopUpAfterWin()
    {
        finishLevelPopUp.SetActive(true);
    }
}
