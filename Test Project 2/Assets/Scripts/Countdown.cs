using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    [SerializeField]
    private int countDownTime;

    public Text countDownTimerDisplay;
    
    private void Start()
    {
        StartCoroutine(CountDownStart()); 
    }

    IEnumerator CountDownStart()
    {
        countDownTimerDisplay.gameObject.SetActive(true);
        while (countDownTime > 0)
        {
            countDownTimerDisplay.text = countDownTime.ToString();

            yield return new WaitForSeconds(1f);

            countDownTime--;

        }

        countDownTimerDisplay.text = "GO!";

        yield return new WaitForSeconds(1f);

        countDownTimerDisplay.gameObject.SetActive(false);
        
    }


}
