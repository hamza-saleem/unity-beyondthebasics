using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider loadingSlider;
    public Text loadingText;
    public void OnClickNext()
    {
        
        StartCoroutine(LoadAsynchronously(PlayerPrefs.GetInt("currentLevel") + 1));
        //SceneManager.LoadScene("TestScene");

    }
    private void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));

    }


    private IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        loadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            loadingSlider.value = progress;
            loadingText.text = progress * 100f + "%";
            yield return null;
        }
    }
}
