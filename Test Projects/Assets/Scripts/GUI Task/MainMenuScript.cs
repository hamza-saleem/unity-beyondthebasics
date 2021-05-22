using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace MainMenu
{
    public class MainMenuScript : MonoBehaviour
    {
        public GameObject MainMenuUI;
        public GameObject LevelSelectUI;
        public GameObject loadingLevelUI;
        public GameObject ExitPopUp;
        static bool check = true;
        
        private void Awake()
        {

            if (check)
            {
                PlayerPrefs.SetInt("currentLevel", 0);
                PlayerPrefs.SetInt("unlockedLevel", 0);
                check = false;
            }

            if (PlayerPrefs.GetInt("currentLevel") > 0)
            {
                loadingLevelUI.SetActive(true);
                MainMenuUI.SetActive(false);
                loadingLevelUI.SetActive(false);
                LevelSelectUI.SetActive(true);
            }
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
}

