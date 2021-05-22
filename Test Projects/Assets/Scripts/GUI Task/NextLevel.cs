using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MainMenu;

public class NextLevel : MonoBehaviour
{


    private void Awake()
    {
       
    }


    public void OnCLickNext()
    {

        PlayerPrefs.SetInt("currentLevel", LevelSelect.instance.currentLevelLoaded+1);
        if (PlayerPrefs.GetInt("currentLevel") > PlayerPrefs.GetInt("unlockedLevel"))
        {
            PlayerPrefs.SetInt("unlockedLevel", PlayerPrefs.GetInt("currentLevel"));
        }

        SceneManager.LoadSceneAsync("TestScene");
    }

}
