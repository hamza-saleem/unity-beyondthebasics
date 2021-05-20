﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneController : MonoBehaviour
{
    #region Variable declarations
    public float playerSpeed;
    public Vector3 screenBounds;
    public EnemyController enemyPrefab;
    #endregion
    void Start()
    {
        playerSpeed = 10f;
        screenBounds = GetScreenBounds();
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnEnemies()
    {
        WaitForSeconds wait = new WaitForSeconds(2);

        while (true)
        {
            float horizontalPosition = Random.Range(-screenBounds.x, screenBounds.x);
            Vector2 spawnPosition = new Vector2(horizontalPosition, screenBounds.y);

            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

            yield return wait;
        }
    }

    private Vector3 GetScreenBounds()
    {
        Camera mainCamera = Camera.main;
        Vector3 screenVector = new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z);

        return mainCamera.ScreenToWorldPoint(screenVector);
    }
}
