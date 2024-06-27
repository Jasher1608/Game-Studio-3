using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Slider = UnityEngine.UI.Slider;

public class PlayerController : SerializedMonoBehaviour
{
    public CharacterDatabase characterDB;
    public SpriteRenderer artworkSprite;
    private int selectedOption = 0;

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
    private float pickupRange;

    public float ambrosiaXP;

    private bool canDash = true;
    [SerializeField] private bool isDashing = true;
    [SerializeField] private float dashTime;

    public Rigidbody2D rb;
    private Vector3 moveDirection;

    public LayerMask ambrosiaLayerMask;
    [SerializeField] private float ambrosiaSpeed;

    public ExperienceManager experienceManager;
    public Slider xpBarSlider;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI godText;

    [SerializeField] private GameObject skillTreeUI;
    [SerializeField] private UIDocument skillTreeDocument;

    private Coroutine updateUICoroutine;

    void Start()
    {
        playerStats = Instantiate(playerStatsOriginal);
        CalculateStats();

        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }

        UpdateCharacter(selectedOption);
        ToggleSkillTree(true);
    }

    void Update()
    {
        ProcessInputs();

        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash)
        {
            StartCoroutine(Dash());
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ToggleSkillTree(!skillTreeUI.activeSelf);
        }

        AttractAmbrosia();
        Debug.Log(playerStats.GetStat(Stat.meleeDamageModifier));
    }

    void FixedUpdate()
    {
        Move();
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
        pickupRange = PlayerStatUtils.CalculatePickupRange(playerStats);
    }

    private void UpdateCharacter(int selectedOption)
    {
        Character character = characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;
    }

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }

    private void AttractAmbrosia()
    {
        Collider2D[] ambrosias = Physics2D.OverlapCircleAll(transform.position, pickupRange, ambrosiaLayerMask);

        foreach (Collider2D ambrosia in ambrosias)
        {
            if (ambrosia != null)
            {
                Vector2 direction = (transform.position - ambrosia.transform.position).normalized;
                float step = ambrosiaSpeed * Time.deltaTime;

                ambrosia.transform.position = Vector2.MoveTowards(ambrosia.transform.position, transform.position, step);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ambrosia"))
        {
            Destroy(collision.gameObject);
            experienceManager.GainExperience(ambrosiaXP);
            UpdateUI();
        }
    }

    private void UpdateUI()
    {
        if (experienceManager.currentGodInstance != null)
        {
            xpBarSlider.maxValue = experienceManager.currentGodInstance.xpToNextLevel;

            if (updateUICoroutine != null)
            {
                StopCoroutine(updateUICoroutine);
            }

            updateUICoroutine = StartCoroutine(SmoothlyUpdateXPBar(experienceManager.currentGodInstance.currentXP));
            levelText.text = "LVL " + experienceManager.currentGodInstance.level;
            godText.text = experienceManager.currentGodInstance.god.godName;
        }
    }

    private IEnumerator SmoothlyUpdateXPBar(float targetValue)
    {
        float currentValue = xpBarSlider.value;
        float duration = 0.35f;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            xpBarSlider.value = Mathf.Lerp(currentValue, targetValue, elapsed / duration);
            yield return null;
        }

        xpBarSlider.value = targetValue;
    }

    public void ChangeGod(God newGod)
    {
        experienceManager.SetCurrentGod(newGod);
        UpdateUI();
    }

    public void ToggleSkillTree(bool isActive)
    {
        skillTreeUI.SetActive(isActive);
        if (isActive)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
            UpdateUI();
        }
    }
}