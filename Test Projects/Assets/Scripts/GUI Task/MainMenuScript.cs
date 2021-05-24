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
       // public GameObject MainMenuUIButtons;
        public GameObject LevelSelectUI;
        public GameObject loadingLevelUI;
        public GameObject ExitPopUp;
        private Animation transitionToLevelSelectUI;
        private Animation exitAnimation;
        static bool check = true;
        
        private void Awake()
        {
            exitAnimation = ExitPopUp.GetComponent<Animation>();
            transitionToLevelSelectUI = GetComponentInChildren<Animation>();
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
            transitionToLevelSelectUI.Play("MainMenuTransition");
            MainMenuUI.SetActive(false);
            LevelSelectUI.SetActive(true);
        }
        public void OnClickExit()
        {
            ExitPopUp.SetActive(true);
            StartCoroutine(ExitPopUpCoroutine());

        }

        private IEnumerator ExitPopUpCoroutine()
        {
            
            yield return new WaitForSeconds(0.5f);
            exitAnimation.Play("ExitPopupAnim");

        }

        public void NoExit()
        {
            ExitPopUp.SetActive(false);
        }

    }
}

