using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Transform playerTransform;
    private Rigidbody2D rb;

    [SerializeField] private Stats enemyStatsOriginal;
    [SerializeField] private Stats enemyStats;

    private float movementSpeed;
    private float maxHealth;
    private float meleeDamage;
    private float meleeCooldown;

    private Vector2 movement;

    void Awake()
    {
        enemyStats = Instantiate(enemyStatsOriginal);
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        CalculateStats();
    }


    void Update()
    {
        Vector2 direction = (playerTransform.position - transform.position).normalized;
        movement = direction * movementSpeed;
        rb.velocity = movement;
    }

    void CalculateStats()
    {
        movementSpeed = PlayerStatUtils.CalculateMovementSpeed(enemyStats);
        maxHealth = PlayerStatUtils.CalculateMaxHealth(enemyStats);
        meleeDamage = PlayerStatUtils.CalculateMeleeDamage(enemyStats);
        meleeCooldown = PlayerStatUtils.CalculateMeleeCooldown(enemyStats);
    }
}
