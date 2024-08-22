using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderController : WeaponController
{

    private AudioSource audioSource;
    public AudioClip boulderSound;

    // Start is called before the first frame update
    protected override void Start()
    {
        //base.Start();

        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>(); 
        }


    }

    protected override void Attack()
    {
        if (nearestEnemyDirection != Vector3.zero)
        {
            base.Attack();
            // TODO: Implement count and area scaling
            GameObject boulder = Instantiate(prefab, transform.position, Quaternion.identity);
            boulder.GetComponent<BoulderBehaviour>().targetDirection = nearestEnemyDirection;

            audioSource.PlayOneShot(boulderSound);

            nearestEnemyDirection = Vector3.zero;
        }
    }
}
