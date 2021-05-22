using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    //private void Awake()
    //{
    //    Debug.Log("Awake Method Called.");
    //}

    private void Start()
    {
        Invoke("Update", 5);
    }

    private void Update()
    {
        Debug.Log("Update Method Called");
    }

    //private void FixedUpdate()
    //{
    //    Debug.Log("Fixed Update Method Called");
    //}

    //private void LateUpdate()
    //{
    //    Debug.Log("Late Update Method Called");
    //}

    //void OnGUI()
    //{
    //    if (GUI.Button(new Rect(10, 10, 150, 100), "I am a button"))
    //    {
    //        print("You clicked the button!");
    //    }
    //}

    //private void OnEnable()
    //{
    //    Debug.Log("Script Enabled");
    //}

    //private void OnDisable()
    //{
    //    Debug.Log("Script Disabled");
    //}
}
