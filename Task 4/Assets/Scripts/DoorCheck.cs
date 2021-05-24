using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCheck : MonoBehaviour
{
    public GameObject objectiveText;
    private void OnTriggerEnter(Collider other)
    {
        if (!ChangeColor.shotCheck)
        {
            StartCoroutine(ShowText());
        }
    }
    private IEnumerator ShowText()
    {
        objectiveText.SetActive(true);
        yield return new WaitForSeconds(3);
        objectiveText.SetActive(false);
    }
}
