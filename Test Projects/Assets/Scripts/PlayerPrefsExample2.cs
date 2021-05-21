using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerPrefsExample2 : MonoBehaviour
{
    //public Text Namebox;
    //void Start()
    //{
    //    Namebox.text = PlayerPrefs.GetString("Name");
    //}

    public void ResetName()
    {
        PlayerPrefs.SetInt("currentLevel", PlayerPrefs.GetInt("currentLevel") + 1);
        //PlayerPrefs.DeleteKey("Name");
        SceneManager.LoadScene(0);
    }
}
