using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StygianOrbBehaviour : ProjectileWeaponBehaviour
{
    StygianOrbController stygianOrbController;

    protected override void Start()
    {
        base.Start();
        stygianOrbController = FindObjectOfType<StygianOrbController>();
    }

    void Update()
    {
        transform.RotateAround(stygianOrbController.transform.position, Vector3.forward, stygianOrbController.speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            EnemyController enemyController = null;
            try
            {
                enemyController = collision.GetComponent<EnemyController>();
            }
            catch
            {
                Debug.LogWarning($"Enemy {collision.gameObject.name} does not have an EnemyController component.");
                return;
            }

            enemyController.enemyStats.ChangeStat(Stat.health, -stygianOrbController.damage);
        }
    }

    private void OnDestroy()
    {
        stygianOrbController.ResetCooldown();
    }
}
