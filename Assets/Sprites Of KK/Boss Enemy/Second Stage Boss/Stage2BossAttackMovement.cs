using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2BossAttackMovement : MonoBehaviour
{
    public float speed;
    public float JumpAttackRange;
    public float MeleeAttackRange;

    public Transform player;

    public bool isFlipped = false;

    [SerializeField] private float attackCooldown;
    [SerializeField] private float DashCooldown;
    private float cooldownTimer = Mathf.Infinity;
    private float DashcooldownTimer = Mathf.Infinity;


    public bool canAttack;
    public bool isAttacking;
    public float dashingPower = 25f;

    public float jump;
    public bool canJumpAttack;
    public bool isJumpAttack = false;

    public bool canMove;


    private BoxCollider2D box;
    private CapsuleCollider2D col;
    private Rigidbody2D rb;
    private Animator anim;
    private SecondStageBossHealth Health;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        box = GetComponent<BoxCollider2D>();
        col = GetComponent<CapsuleCollider2D>();
        Health = GetComponent<SecondStageBossHealth>();
        isAttacking = false;
        canAttack = false;
        canMove = true;
    }
    private void Update()
    {
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;

        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        if (distanceFromPlayer < JumpAttackRange && distanceFromPlayer > MeleeAttackRange && Health.currentHealth > 0)
        {
            canAttack = false;
            canMove = true;
            canJumpAttack = true;          
        }

        else if (distanceFromPlayer > JumpAttackRange && Health.currentHealth > 0)
        {
            canJumpAttack = false;
            canAttack = false;
            canMove = true;
        }
        else if (distanceFromPlayer < MeleeAttackRange && Health.currentHealth > 0)
        {
            canJumpAttack = false;
            canAttack = true;
            canMove = false;
        }
        if (Health.currentHealth <= 0)
        {
            canAttack = false;
            canJumpAttack = false;
        }
    }

    public void FixedUpdate()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);

        if (isJumpAttack || isAttacking || Health.currentHealth <= 0)
        {
            Health.canHurt = false;
            anim.SetBool("canHurt", false);
            anim.SetBool("moving", false);
            anim.SetBool("canAttack", false);
        }
        else if (!isJumpAttack && Health.currentHealth > 0 && distanceFromPlayer < JumpAttackRange  || !isAttacking && Health.currentHealth > 0 && distanceFromPlayer < JumpAttackRange)
        {
            Health.canHurt = true;
            anim.SetBool("canHurt", true);
        }

        if (transform.position.x > player.position.x && distanceFromPlayer > JumpAttackRange && Health.currentHealth > 0)
        {
            isFlipped = false;
        }
        else if (transform.position.x < player.position.x && distanceFromPlayer > JumpAttackRange && Health.currentHealth > 0)
        {
            isFlipped = true;
        }

        cooldownTimer += Time.deltaTime;
        DashcooldownTimer += Time.deltaTime;

        if (canJumpAttack)
        {
            if (cooldownTimer >= attackCooldown && !isJumpAttack && Health.currentHealth > 0)
            {
                jump = 1000f;
                rb.gravityScale = 0f;
                isJumpAttack = true;
                cooldownTimer = 0;
                anim.SetTrigger("JumpAttack");
            }
        }
        else if (canAttack && !isAttacking)
        {
            if (DashcooldownTimer >= DashCooldown && Health.currentHealth > 0)
            {
                DashcooldownTimer = 0;
                anim.SetBool("canAttack", true);
            }
        }

        if (canMove)
        {
            anim.SetBool("moving", true);
        }
    }

    public void JumpAttack()
    {
        LookAtThePlayer();
        rb.AddForce(new Vector2(rb.velocity.x, jump));
    }


    public void DashAttack()
    {
        isAttacking = true;
        rb.gravityScale = 0f;
        rb.velocity = new Vector2(transform.localScale.x * dashingPower, 0f);
        Invoke ("ResetAttack1", 1f);
    }

    public void CancelDashAttack()
    {
        anim.SetBool("canAttack", false);
        rb.gravityScale = 10f;
    }

    public void ResetAttack1()
    {
        isAttacking = false;
    }

    public void CancelJump()
    {
        isAttacking = false;
        jump = 0f;
        rb.gravityScale = 100f;
    }

    public void LookAtThePlayer()
    {
        Vector3 flipped = transform.position;
        flipped.z *= -1f;

        if (transform.position.x > player.position.x && !isFlipped)
        {
            transform.position = flipped;
            transform.localScale = new Vector3(-1.275711f, 1f, 1f);
            isFlipped = true;
        }
        else if (transform.position.x < player.position.x && isFlipped)
        {
            transform.position = flipped;
            transform.localScale = new Vector3(1.275711f, 1f, 1f);
            isFlipped = false;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, MeleeAttackRange);
        Gizmos.DrawWireSphere(transform.position, JumpAttackRange);
    }

    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
