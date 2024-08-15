using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceArea : MonoBehaviour
{
    private float duration;
    private float timer = 0f;
    private LayerMask enemyLayer;

    private Material enemyMaterial;

    public void Initialize(float duration, LayerMask enemyLayer)
    {
        this.duration = duration;
        this.enemyLayer = enemyLayer;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= duration)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            EnemyController enemyController = collision.GetComponent<EnemyController>();
            Stats enemyStats = enemyController.enemyStats;
            enemyMaterial = collision.GetComponent<SpriteRenderer>().material;

            if (enemyStats != null)
            {
                float originalSpeedModifier = enemyStats.GetStat(Stat.movementSpeedModifier);

                // Halves enemy speed
                var temp = originalSpeedModifier / 2;
                enemyStats.ChangeStat(Stat.movementSpeedModifier, -temp);
                enemyController.CalculateStats();

                enemyMaterial.SetFloat("_FrozenFade", 1);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            EnemyController enemyController = collision.GetComponent<EnemyController>();
            Stats enemyStats = enemyController.enemyStats;
            enemyMaterial = collision.GetComponent<SpriteRenderer>().material;

            if (enemyStats != null)
            {
                // Restore the original speed
                var temp = enemyStats.GetStat(Stat.movementSpeedModifier);
                enemyStats.ChangeStat(Stat.movementSpeedModifier, temp);
                enemyController.CalculateStats();
                
                enemyMaterial.SetFloat("_FrozenFade", 0);
            }

        }
    }
}