using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class StygianOrbController : WeaponController
{
    public float radius;

    protected override void Start()
    {
        //base.Start();
    }

    protected override void Attack()
    {
        base.Attack();
        float angleStep = 360f / count;
        for (int i = 0; i < count; i++)
        {
            float angle = angleStep * i * Mathf.Deg2Rad;
            float orbX = transform.position.x + Mathf.Cos(angle) * radius;
            float orbY = transform.position.y + Mathf.Sin(angle) * radius;

            GameObject spawnedOrb = Instantiate(prefab, new Vector3(orbX, orbY, 0), Quaternion.identity, gameObject.transform);
            spawnedOrb.transform.localScale *= PlayerController.playerStats.GetStat(Stat.attackAreaModifier);
        }
    }

    public void ResetCooldown()
    {
        currentCooldown = cooldownDuration;
    }
}
