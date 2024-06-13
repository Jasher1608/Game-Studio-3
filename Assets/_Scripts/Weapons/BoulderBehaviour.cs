using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BoulderBehaviour : ProjectileWeaponBehaviour
{
    BoulderController boulderController;
    public Vector3 targetDirection;

    protected override void Start()
    {
        base.Start();
        boulderController = FindObjectOfType<BoulderController>();
    }

    void Update()
    {
        if (targetDirection != Vector3.zero)
        {
            transform.position += boulderController.speed * Time.deltaTime * targetDirection;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            EnemyController enemyController;
            try
            {
                enemyController = collision.GetComponent<EnemyController>();
            }
            catch
            {
                Debug.LogWarning($"Enemy {collision.gameObject.name} does not have an EnemyController component.");
                return;
            }

            enemyController.enemyStats.ChangeStat(Stat.health, -boulderController.damage);
        }
    }

    private void OnDestroy()
    {
        boulderController.ResetCooldown();
    }
}
