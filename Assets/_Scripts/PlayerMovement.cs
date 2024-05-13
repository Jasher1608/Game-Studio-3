using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Stats playerStats;
    private float movementSpeed;
    public Rigidbody2D rb;
    private Vector3 moveDirection;

    
    void Start()
    {
        playerStats = Instantiate(playerStats);
        movementSpeed = playerStats.GetStat(Stat.movementSpeed) * playerStats.GetStat(Stat.movementSpeedModifier);
        
    }
    
    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector3(moveX, moveY).normalized;
    }

    void Move()
    {
        rb.velocity = new Vector3(moveDirection.x * movementSpeed, moveDirection.y * movementSpeed, 0f);

    }

}