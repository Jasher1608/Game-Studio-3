//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class WhipController : WeaponController
//{

//    public float attackRange;
//    public float attackAngle;
//    public string enemyTag = "Enemy";



//    protected new void Start()
//    {
//        //base.Start();
//    }

//    protected override void Attack()
//    {
//        base.Attack();
//        WhipAttack();
//    }
        
//    private void WhipAttack()
//    {
//        //Direction of attack
//        Vector3 attackDirection = transform.right;

//        //Detect other collders within attack range
//        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(transform.position, attackRange);

//        foreach (Collider2D collider in hitColliders)
//        {
//            if (collider.CompareTag(enemyTag))
//            {
//                Vector3 directionToEnmey = (collider.transform.poistion - transform.position).normalized;
//                float angle = Vector3.Angle(attackDirection, directionToEnmey);

//                if (angle < attackAngle)
//                { 
//                    collider.GetComponent<Enemy>().TakeDamage(playerStatsUtils.GetStat(Stat.attackDamage));
//                }
//            }
//        }
//    }

//    private void OnDrawGizmosSelected()
//    {
//        //To visualise the above
//        Gizmos.color = Color.red;
//        Gizmos.DrawWireSphere(transform.position, attackRange);
//    }

//    //cooldown copoied from Stygianord contoller script
//    public void ResetCooldown()
//    {
//        currentCooldown = cooldownDuration;
//    }



//}
