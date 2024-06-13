using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : SerializedMonoBehaviour
{
    // TODO: Move some stats to behaviour script to reduce dependencies
    [Header("Weapon Stats")]
    public GameObject prefab;
    public float damage;
    public float speed;
    public float cooldownDuration;
    [HideInInspector] public float currentCooldown;
    public int pierce;
    public int count;

    public bool fireAtEnemy = false;
    [SerializeField] protected float detectionRadius;
    protected Vector3 nearestEnemyDirection;
    public LayerMask enemyLayer;

    protected virtual void Start()
    {
        currentCooldown = cooldownDuration;
    }

    protected virtual void Update()
    {
        currentCooldown -= Time.deltaTime;
        if (currentCooldown <= 0f)
        {
            if (!fireAtEnemy)
            {
                Attack();
            }
            else
            {
                nearestEnemyDirection = GetDirectionToNearestEnemy(transform.position);
                if (nearestEnemyDirection != null)
                {
                    Attack();
                }
            }
        }
    }

    protected virtual void Attack()
    {
        CalculateStats();
        currentCooldown = cooldownDuration;
    }

    protected void CalculateStats()
    {
        cooldownDuration *= PlayerController.playerStats.GetStat(Stat.abilityCooldownModifier);
        speed *= PlayerController.playerStats.GetStat(Stat.projectileSpeedModifier);
        damage *= PlayerController.playerStats.GetStat(Stat.magicDamageModifier);
        count += Mathf.RoundToInt(PlayerController.playerStats.GetStat(Stat.additionalProjectileCount));
    }

    protected Transform GetNearestEnemyPosition(Vector3 currentPosition)
    {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(currentPosition, detectionRadius, enemyLayer);
        Transform nearestEnemy = null;
        float shortestDistance = Mathf.Infinity;

        foreach (Collider2D hitCollider in hitColliders)
        {
            float distanceToEnemy = Vector3.Distance(currentPosition, hitCollider.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = hitCollider.transform;
            }
        }

        if (nearestEnemy != null)
        {
            return nearestEnemy;
        }
        else
        {
            return null;
        }
    }

    protected Vector3 GetDirectionToNearestEnemy(Vector3 currentPosition)
    {
        Transform nearestEnemy = GetNearestEnemyPosition(currentPosition);
        if (nearestEnemy != null)
        {
            Vector3 directionToEnemy = nearestEnemy.position - currentPosition;
            return directionToEnemy.normalized;
        }
        else
        {
            return Vector3.zero;
        }
    }

    public void ResetCooldown()
    {
        currentCooldown = cooldownDuration;
    }
}