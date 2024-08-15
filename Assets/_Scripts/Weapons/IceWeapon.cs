using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class IceWeapon : MonoBehaviour
{
    public GameObject iceAreaPrefab;
    public float iceDuration = 5.0f;
    public float freezeRadius = 3.0f;
    public float freezeDuration = 3.0f;
    [SerializeField] private float cooldown;
    private float cooldownTimer = 0f;
    public LayerMask enemyLayer;

    private void Update()
    {
        cooldownTimer += Time.deltaTime;
        if (cooldownTimer >= cooldown)
        {
            // Spawn the ice area at the weapon's location
            GameObject iceArea = Instantiate(iceAreaPrefab, transform.position, Quaternion.identity);
            iceArea.GetComponent<IceArea>().Initialize(freezeDuration, enemyLayer);

            cooldownTimer = 0f;
        }
    }
}