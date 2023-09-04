using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeDamage : MonoBehaviour
{
    public float Damage;
    private Animator anim;
    public GameObject Player;

    public bool isPressed;
    [SerializeField] private float attackCooldown;
    public float cooldownTimer = Mathf.Infinity;

    private void Start()
    {
        cooldownTimer = 0;
        anim = Player.GetComponent<Animator>();
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
    }
    public void Attack()
    {
        anim.SetTrigger("Attack1");
        cooldownTimer = 0;
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
            collision.GetComponent<EnemyHealth>().TakeDamage(Damage);

        if (collision.tag == "TorretEnemy")
            collision.GetComponent<TorrretEnemyHealth>().TakeDamage(Damage);


        if (collision.tag == "Boss")
            collision.GetComponentInParent<BossHealth>().TakeDamage(Damage);

        if (collision.tag == "SecondStageEnemies")
            collision.GetComponent<Stage2EnemyRangerHealth>().TakeDamage(Damage);

        if (collision.tag == "Stage2MeleeEnemy")
            collision.GetComponent<Stage2MeleeEnemyHealth>().TakeDamage(Damage);



    }
}
