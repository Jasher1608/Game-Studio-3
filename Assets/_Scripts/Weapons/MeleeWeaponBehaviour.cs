using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeaponBehaviour : MonoBehaviour
{
    public float duration;

    protected virtual void Start()
    {
        Destroy(gameObject, duration * PlayerController.playerStats.GetStat(Stat.durationModifier));
    }
}
