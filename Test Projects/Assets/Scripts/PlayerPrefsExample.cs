using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerPrefsExample : MonoBehaviour
{
    public InputField textBox;

    public void OnButtonClick()
    {
        PlayerPrefs.SetString("Name", textBox.text);
        SceneManager.LoadScene("Scene2");
        Debug.Log("My Name is " + PlayerPrefs.GetString("Name"));
    }
}
