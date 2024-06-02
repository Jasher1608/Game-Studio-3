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

    protected virtual void Start()
    {
        currentCooldown = cooldownDuration;
    }

    protected virtual void Update()
    {
        currentCooldown -= Time.deltaTime;
        if (currentCooldown <= 0f)
        {
            Attack();
        }
    }

    protected virtual void Attack()
    {
        currentCooldown = cooldownDuration;
    }

    protected void CalculateStats()
    {
        cooldownDuration *= PlayerController.playerStats.GetStat(Stat.abilityCooldownModifier);
        speed *= PlayerController.playerStats.GetStat(Stat.projectileSpeedModifier);
        damage *= PlayerStatUtils.CalculateMagicDamage(PlayerController.playerStats);
        count += Mathf.RoundToInt(PlayerController.playerStats.GetStat(Stat.additionalProjectileCount));
    }
}