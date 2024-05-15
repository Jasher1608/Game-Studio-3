using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileWeaponBehaviour : MonoBehaviour
{
    protected Vector3 direction;
    public float duration;
    
    protected virtual void Start()
    {
        duration *= PlayerController.playerStats.GetStat(Stat.durationModifier);
        Destroy(gameObject, duration);
    }

    public void DirectionChecker(Vector3 dir)
    {
        direction = dir;
    }
}