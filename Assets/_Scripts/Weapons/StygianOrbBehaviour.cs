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

    private void OnDestroy()
    {
        stygianOrbController.ResetCooldown();
    }
}
