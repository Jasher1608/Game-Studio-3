using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Rendering;

public class EnemyController : MonoBehaviour
{
    private Transform playerTransform;
    private Rigidbody2D rb;

    [SerializeField] private Stats enemyStatsOriginal;
    [HideInInspector] public Stats enemyStats;

    public float despawnDistance = 20f;

    private float movementSpeed;
    private float maxHealth;
    private float meleeDamage;
    private float meleeCooldown;

    private Vector2 movement;

    public float separationDistance = 0.5f;
    public LayerMask enemyLayerMask;

    [SerializeField] private GameObject ambrosia;


    // Added variables for enemy attacks 
    public float damage;
    public float hitWaitTime = 1f;
    private float hitCounter; // to keep track of wait time



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
        if (enemyStats.GetStat(Stat.health) <= 0)
        {
            Death();
        }
        
        if (Vector2.Distance(transform.position, playerTransform.position) >= despawnDistance)
        {
            ReturnEnemy();
        }

        Vector2 direction = (playerTransform.position - transform.position).normalized;
        Vector2 separation = CalculateSeparation();

        movement = (direction + separation).normalized * movementSpeed;
        rb.velocity = movement;

        // added to incorporate hit Counter on enemy attack

        if(hitCounter > 0f)
        {
            hitCounter -= Time.deltaTime;
        }

    }



    // Added to engage with Player Health Controller script when enemy attacks player

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" && hitCounter <= 0f)
        {
            PlayerHealthController.instance.TakeDamage(damage);

            hitCounter = hitWaitTime;
        }
    }



    public void CalculateStats()
    {
        movementSpeed = PlayerStatUtils.CalculateMovementSpeed(enemyStats);
        maxHealth = PlayerStatUtils.CalculateMaxHealth(enemyStats);
        meleeDamage = PlayerStatUtils.CalculateMeleeDamage(enemyStats);
        meleeCooldown = PlayerStatUtils.CalculateMeleeCooldown(enemyStats);
    }

    // TODO: Implement an OnTakeDamage() method

    private void Death()
    {
        EnemySpawner enemySpawner = FindObjectOfType<EnemySpawner>();
        enemySpawner.OnEnemyKilled();
        Instantiate(ambrosia, transform.position, Quaternion.identity);
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

    // TODO: Rework flocking to reduce jitter
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
    
    public void TakeDamage()
    {
        Death();
    }
}
