using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainSawAction : MonoBehaviour
{
    public Animator anim;
    public GameObject Player;


    public bool isPressed;
    public float attackCooldown;
    public float cooldownTimer = Mathf.Infinity;

    private void Start()
    {
        anim = Player.GetComponent<Animator>();
        cooldownTimer = 0;
    }

    private void Awake()
    {
        attackCooldown = ChainSawData.Cooldown;
    }

    private void Update()
    {

        if (cooldownTimer < attackCooldown)
        {
            isPressed = false;
        }

        if (isPressed)
        {
            Attack();
        }
        cooldownTimer += Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && cooldownTimer > attackCooldown)
        {
            anim.SetFloat("AttackSpeed", ChainSawData.AttackSpeed);
            isPressed = true;
            anim.SetTrigger("Attack1");
            cooldownTimer = 0;
        }


    }
    public void Attack()
    {
        if (cooldownTimer > attackCooldown)
        {
            anim.SetFloat("AttackSpeed", ChainSawData.AttackSpeed);
            isPressed = true;
            anim.SetTrigger("Attack1");
            cooldownTimer = 0;
        }
    }

    public void OnPointerDown()
    {
        isPressed = true;
    }
    public void OnPointerUp()
    {
        isPressed = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
            collision.GetComponent<EnemyHealth>().TakeDamage(ChainSawData.Damage);

        if (collision.tag == "TorretEnemy")
            collision.GetComponent<TorrretEnemyHealth>().TakeDamage(ChainSawData.Damage);


        if (collision.tag == "Boss")
            collision.GetComponentInParent<BossHealth>().TakeDamage(ChainSawData.Damage);

        if (collision.tag == "SecondStageEnemies")
            collision.GetComponent<Stage2EnemyRangerHealth>().TakeDamage(ChainSawData.Damage);

        if (collision.tag == "Stage2MeleeEnemy")
            collision.GetComponent<Stage2MeleeEnemyHealth>().TakeDamage(ChainSawData.Damage);



    }
}
