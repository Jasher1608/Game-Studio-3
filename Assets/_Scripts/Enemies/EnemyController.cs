using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class EnemyController : MonoBehaviour
{
    private Transform playerTransform;
    private Rigidbody2D rb;

    [SerializeField] private Stats enemyStatsOriginal;
    [SerializeField] private Stats enemyStats;

    public float despawnDistance = 20f;

    private float movementSpeed;
    private float maxHealth;
    private float meleeDamage;
    private float meleeCooldown;

    private Vector2 movement;

    public float separationDistance = 0.5f;
    public LayerMask enemyLayerMask;

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
        if (Vector2.Distance(transform.position, playerTransform.position) >= despawnDistance)
        {
            ReturnEnemy();
        }

        Vector2 direction = (playerTransform.position - transform.position).normalized;
        Vector2 separation = CalculateSeparation();

        movement = (direction + separation).normalized * movementSpeed;
        rb.velocity = movement;
    }

    void CalculateStats()
    {
        movementSpeed = PlayerStatUtils.CalculateMovementSpeed(enemyStats);
        maxHealth = PlayerStatUtils.CalculateMaxHealth(enemyStats);
        meleeDamage = PlayerStatUtils.CalculateMeleeDamage(enemyStats);
        meleeCooldown = PlayerStatUtils.CalculateMeleeCooldown(enemyStats);
    }

    private void Death()
    {
        EnemySpawner enemySpawner = FindObjectOfType<EnemySpawner>();
        enemySpawner.OnEnemyKilled();
        Destroy(gameObject);
    }

    void ReturnEnemy()
    {
        Camera mainCamera = Camera.main;
        Vector3 playerPosition = playerTransform.position;

        float cameraHeight = 2f * mainCamera.orthographicSize;
        float cameraWidth = cameraHeight * mainCamera.aspect;

        float minDistance = Mathf.Max(cameraWidth, cameraHeight) / 2f + 1f;
        float maxDistance = minDistance + 5f;

        float angle = Random.Range(0, Mathf.PI * 2);

        float distance = Random.Range(minDistance, maxDistance);

        Vector3 offset = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle)) * distance;

        transform.position = playerPosition + offset;
    }

    Vector2 CalculateSeparation()
    {
        Vector2 separationForce = Vector2.zero;
        Collider2D[] neighbors = Physics2D.OverlapCircleAll(transform.position, separationDistance, enemyLayerMask);

        foreach (Collider2D neighbor in neighbors)
        {
            if (neighbor != null && neighbor.transform != transform)
            {
                Vector2 difference = transform.position - neighbor.transform.position;
                separationForce += difference.normalized / difference.magnitude;
            }
        }

        return separationForce;
    }
}
