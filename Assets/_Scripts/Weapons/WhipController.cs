using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhipController : WeaponController
{
    public GameObject whipPrefab;
    public float attackRange;
    public float attackAngle;
    public string enemyTag = "Enemy";

    protected new void Start()
    {
        //base.Start();
    }

    protected override void Attack()
    {
        base.Attack();
        WhipAttack();
    }

    private void WhipAttack()
    {
        //Instantiate the whip object at the player's position and rotation
        GameObject spawnedWhip = Instantiate(whipPrefab, transform.position, transform.rotation);

        //Detect other collders within attack range
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(transform.position, attackRange);

        foreach (Collider2D collider in hitColliders)
        {
            if (collider.CompareTag(enemyTag))
            {
                Vector3 directionToEnmey = (collider.transform.position - transform.position).normalized;
                float angle = Vector3.Angle(attackDirection, directionToEnmey);

                if (angle < attackAngle)
                {
                    //collider.GetComponent<EnemyController>().TakeDamage(PlayerStatUtils.CalculateMeleeDamage(PlayerController.playerStats));
                    DealDamage(collider.gameObject);

                }
            }
        }
    }

    private void DealDamage(GameObject enemy)
    {
        EnemyController enemyController = enemy.GetComponent<EnemyController>();
        if (enemyController != null)
        {
            float damage = PlayerStatUtils.CalculateMeleeDamage(PlayerController.playerStats);
            enemyController.TakeDamage();
        }
    }

    private void OnDrawGizmosSelected()
    {
        //To visualise the above
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }

    //cooldown copoied from Stygianord contoller script
    public void ResetCooldown()
    {
        currentCooldown = cooldownDuration;
    }

}
