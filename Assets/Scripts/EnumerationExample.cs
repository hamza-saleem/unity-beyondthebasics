using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumerationExample : MonoBehaviour
{
    private PlayerState playerState;
    void Start()
    {
        playerState = PlayerState.Prone;
    }

    void Update()
    {
        switch (playerState)
        {
            case PlayerState.Prone:
                Debug.Log("Prone");
                break;
            case PlayerState.Walking:
                Debug.Log("Walk");
                break;
        }
    }
}


public enum PlayerState
{
    Walking, 
    Running, 
    Prone
}
