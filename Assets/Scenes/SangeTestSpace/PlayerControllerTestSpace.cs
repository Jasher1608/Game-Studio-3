using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTestSpace : MonoBehaviour
{
    public GameObject playerTest;

    public float movementSpeed;
    public Rigidbody2D rb;

    private Vector3 moveDirection;

    [SerializeField] private float dashCooldown;

    [SerializeField] private bool canDash = true;
    [SerializeField] private bool isDashing = false;
    [SerializeField] private float dashPower;
    [SerializeField] private float dashTime;


    void Start()
    {

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
}

