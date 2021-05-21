using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    static bool check;
    public GameObject[] lockedLevels;
    // public GameObject[] unlockedLevels;

    int currentlevel;
    private void Awake()
    {
       // PlayerPrefs.DeleteAll();
        if (check)
        {
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
    public void Start()
    {
      currentlevel =   PlayerPrefs.GetInt("currentLevel");
        CheckLevels();
    }

    void CheckLevels()
    {
        for (int i = 0; i <= currentlevel; i++)
        {
            lockedLevels[i].SetActive(false);
        }
    }

    public void OnClickLevelButton(int level)
    {
        SceneManager.LoadScene(1);

    }

}
