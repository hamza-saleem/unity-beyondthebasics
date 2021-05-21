using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameObject MainMenuUI;
    public GameObject LevelSelectUI;
    public GameObject ExitPopUp;
    static bool check=true;

    private void Awake()
    {
        if (check) { 
            PlayerPrefs.SetInt("currentLevel", 0);
        check = false;
        }
        //if (PlayerPrefs.HasKey("level")) {
        //    // 
        //    Debug.Log("YEs");
        //}
        //else
        //{
        //    Debug.Log("No");
        //}
    }

    public void OnClickPlay()
    {
        MainMenuUI.SetActive(false);
        LevelSelectUI.SetActive(true);
    }
    public void OnClickExit()
    {
        ExitPopUp.SetActive(true);
        
    }

    public void NoExit()
    {
        ExitPopUp.SetActive(false);
    }

}
