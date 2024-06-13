using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderController : WeaponController
{
    // Start is called before the first frame update
    protected override void Start()
    {
        //base.Start();
    }

    protected override void Attack()
    {
        if (nearestEnemyDirection != Vector3.zero)
        {
            base.Attack();
            // TODO: Implement count and area scaling
            GameObject boulder = Instantiate(prefab, transform.position, Quaternion.identity);
            boulder.GetComponent<BoulderBehaviour>().targetDirection = nearestEnemyDirection;
            nearestEnemyDirection = Vector3.zero;
        }
    }
}
