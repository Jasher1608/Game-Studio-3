using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeBoss : MonoBehaviour
{
    [SerializeField] GameObject player; // Reference to the player GameObject
    [SerializeField] GameObject boss_Slime_Idle; 
    [SerializeField] float slimeBossSpeed = 5.0f; // Speed of horizontal movement
    [SerializeField] float slimeBossRange = 5.0f; // Range of horizontal movement
    [SerializeField] float chargeSpeed = 10.0f; // Speed of charging towards the player
    [SerializeField] float chargeInterval = 5.0f; // Interval between charges

    private Vector3 startPosition;
    private SpriteRenderer spriteRenderer;
    private bool isCharging = false; // Indicates whether the enemy is charging
    private float chargeEndTime; // Time when the charge should end

    void Start()
    {
        // Store the starting position of the enemy
        startPosition = transform.position;

        // Get the SpriteRenderer component
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Set the initial charge end time
        chargeEndTime = Time.time;
    }

    void Update()
    {
        MoveTowardsPlayer();
    }


    void MoveTowardsPlayer()
    {
        if (player == null) return;

        // Calculate the direction towards the player
        Vector3 direction = (player.transform.position - transform.position).normalized;

        // Move towards the player
        transform.position += direction * chargeSpeed * Time.deltaTime;

        // Flip the sprite based on the direction towards the player
        if (direction.x < 0)
        {
            spriteRenderer.flipX = false; // Face right
        }
        else
        {
            spriteRenderer.flipX = true; // Face left
        }
    }

    void StartCharge()
    {
        isCharging = true; // Start charging
        // Set the end time for the current charge
        chargeEndTime = Time.time + chargeInterval;
    }
}
