using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhipController : WeaponController
{
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
        GameObject spawnedWhip = Instantiate(prefab, transform.position, transform.rotation);

        // Set the instantiated whip as a child of the player
        spawnedWhip.transform.parent = transform;


        
        // TODO: Ability to increase count of whip
        // TODO: Increase distance / range of whip in realtion to whip count
        // TODO: Depending on the whip count decide which direction to face (e.g. whips in vampire survivor)
    }

    private void OnDrawGizmosSelected()
    {
        //To visualise the above
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }

    //cooldown copied from Stygianord contoller script
    public void ResetCooldown()
    {
        currentCooldown = cooldownDuration;
    }

}
