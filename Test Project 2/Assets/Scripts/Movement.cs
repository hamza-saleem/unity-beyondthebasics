using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Movement : MonoBehaviour
{
    public Camera camera;
    [SerializeField]
    private float speed;

   

    private Vector3 cursorPosition;
    private Vector3 targetPosition;

    [SerializeField]
    private int countDownTime;

    public Text countDownTimerDisplay;
    public GameObject gameOver;

    private void Start()
    {
        StartCoroutine(CountDownStart());
    }

    private void Update()
    {
        if (countDownTime == 0)
        {
            if (Input.GetMouseButton(0))
            {
                SetTargetPosition();
            }

            MoveToTarget();
        }
        
            
    }

    private void SetTargetPosition()
    {
       

        cursorPosition = camera.ScreenToWorldPoint(Input.mousePosition);
        targetPosition = new Vector3(cursorPosition.x, cursorPosition.y, 0);
    }

    private void MoveToTarget()
    {
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed);
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
        if (transform.position == cursorPosition)
        {
                yield return new WaitForSeconds(3);
                gameOver.SetActive(true);
            
        }
           


    }

}
