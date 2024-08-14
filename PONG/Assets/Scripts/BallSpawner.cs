using System;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab; // Prefab of the ball to spawn
    public Transform spawnPoint; // The point where the ball will spawn
    public float spawnForce = 10f; // Force applied to the ball when it spawns


    private void Start()
    {
        SpawnBall();
    }

    private void SpawnBall()
    {
        // Instantiate the ball at the spawn point with no rotation
        GameObject spawnedBall = Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);

        // Get the Rigidbody2D component of the spawned ball
        Rigidbody2D rb = spawnedBall.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            // Apply a force to the ball to make it move forward
            rb.AddForce(new Vector2(1f,1f) * spawnForce, ForceMode2D.Impulse);
        }
    }
}
