using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public GameObject MainMenuUI;
    public GameObject LevelSelectUI;
    public GameObject loadingLevelUI;
    static bool check =true;
    public GameObject[] lockedLevels;
    // public GameObject[] unlockedLevels;
   
     int currentlevel;
    public static LevelSelect instance;
    [HideInInspector] public int currentLevelLoaded;

    private void Awake()
    {
        instance = GetComponent<LevelSelect>();
        
       //PlayerPrefs.DeleteAll();
        if (check)
        {
           // Debug.Log("Here");
            PlayerPrefs.SetInt("currentLevel", 0);
            PlayerPrefs.SetInt("unlockedLevel", 0);
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

    public void Start()
    {
      currentlevel =   PlayerPrefs.GetInt("unlockedLevel");
        CheckLevels();
    }

    void CheckLevels()
    {
        
        for (int i = 0; i <= currentlevel; i++)
        {
            if(i<lockedLevels.Length)
            lockedLevels[i].SetActive(false);


            if (currentlevel > lockedLevels.Length)
                PlayerPrefs.SetInt("currentlevel", 0);

        }

    }

    public void OnClickNext()
    {
        //SceneManager.LoadScene("TestScene");
        MainMenuUI.SetActive(false);
        LevelSelectUI.SetActive(true);
    }

    public void OnClickLevelButton(int level)
    {
        currentLevelLoaded = level;


        LevelSelectUI.SetActive(false);
        loadingLevelUI.SetActive(true);
        SceneManager.LoadScene("Level " +(level+1));
       

    }

}
