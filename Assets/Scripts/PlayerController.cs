using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Shape
{
    public ProjectileController projectilePrefab;
    private GameSceneController gameSceneController;
    // Start is called before the first frame update
    void Start()
    {
        gameSceneController = FindObjectOfType<GameSceneController>();
        SetColor(Color.yellow);
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireProjectile();
        }
    }
    
    private void MovePlayer()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");

        if (Mathf.Abs(horizontalMovement) > Mathf.Epsilon)
        {
            horizontalMovement = horizontalMovement + Time.deltaTime * gameSceneController.playerSpeed;
            horizontalMovement += transform.position.x;

            transform.position = new Vector2(horizontalMovement, transform.position.y);
        }
    }
     private void FireProjectile()
    {
        Vector2 spawnPosition = transform.position;

        ProjectileController projectile = Instantiate(projectilePrefab, spawnPosition, Quaternion.identity);

        projectile.projectileSpeed = 2;
        projectile.projectileDirection = Vector2.up;
    }
}
