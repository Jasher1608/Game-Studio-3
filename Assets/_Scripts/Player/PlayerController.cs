using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : SerializedMonoBehaviour
{
    public Stats playerStatsOriginal;
    public static Stats playerStats;
    private float movementSpeed;
    private float currentHealth;
    private float maxHealth;
    private float meleeDamage;
    private float meleeRange;
    private float meleeCooldown;
    private float armour;
    private float mana;
    private float magicDamage;
    private float magicRange;
    private float magicCooldown;
    private float luck;
    private float criticalChance;
    private float criticalDamage;
    private float dashPower;
    private float dashCooldown;

    private bool canDash = true;
    [SerializeField]  private bool isDashing = true;
    [SerializeField] private float dashTime;

    public Rigidbody2D rb;
    private Vector3 moveDirection;


    void Start()
    {
        playerStats = Instantiate(playerStatsOriginal);
        CalculateStats();
    }
    
    
    void Update()
    {

        ProcessInputs();
        
        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash)
        {
            StartCoroutine(Dash());
            Debug.Log("Dash button hit");
        }

        if (isDashing)
        {
            return;
        }
    }

    void FixedUpdate()
    {
        Move();

        if (isDashing)
        {
            return;
        }
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector3(moveX, moveY).normalized;
    }

    void Move()
    {
        rb.velocity = new Vector3(moveDirection.x * movementSpeed, moveDirection.y * movementSpeed, 0f);
    }


    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        movementSpeed *= dashPower;
        yield return new WaitForSeconds(dashTime);
        isDashing = false;
        movementSpeed /= dashPower;
        yield return new WaitForSeconds(dashCooldown);
        canDash = true;
    }



    void CalculateStats()
    {
        movementSpeed = PlayerStatUtils.CalculateMovementSpeed(playerStats);
        maxHealth = PlayerStatUtils.CalculateMaxHealth(playerStats);
        meleeDamage = PlayerStatUtils.CalculateMeleeDamage(playerStats);
        meleeRange = PlayerStatUtils.CalculateMeleeRange(playerStats);
        meleeCooldown = PlayerStatUtils.CalculateMeleeCooldown(playerStats);
        armour = PlayerStatUtils.CalculateArmour(playerStats);
        mana = PlayerStatUtils.CalculateMana(playerStats);
        magicDamage = PlayerStatUtils.CalculateMagicDamage(playerStats);
        magicRange = PlayerStatUtils.CalculateMagicRange(playerStats);
        magicCooldown = PlayerStatUtils.CalculateMagicCooldown(playerStats);
        luck = PlayerStatUtils.CalculateLuck(playerStats);
        dashPower = PlayerStatUtils.CalculateDashPower(playerStats);
        dashCooldown = PlayerStatUtils.CalculateDashCooldown(playerStats);
        criticalDamage = PlayerStatUtils.CalculateCritDamage(playerStats);
        criticalChance = PlayerStatUtils.CalculateCritChance(playerStats);
    } 
}