using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessModifiersExample : MonoBehaviour
{
     private int number = 2;
 

    // Update is called once per frame
    void Start()
    {
        Debug.Log(number);
        number = 23;
        Debug.Log(number);
    }

}
