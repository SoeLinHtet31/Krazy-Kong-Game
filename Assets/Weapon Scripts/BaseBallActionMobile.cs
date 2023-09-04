using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBallActionMobile : MonoBehaviour
{
    public Animator anim;
    public GameObject Player;

    public AudioSource BatSound;
    public bool canAttack;

    public Animator player;

    public bool isPressed;
    public float attackCooldown;
    public float cooldownTimer = Mathf.Infinity;

    public static int MobileMoode;
    public int CheckMobileMoode;

    private void Start()
    {
        MobileMoode = 0;
        anim = Player.GetComponent<Animator>();
        cooldownTimer = 0;
        canAttack = true;
    }

    private void Update()
    {
        CheckMobileMoode = MobileMoode;
        attackCooldown = BaseBallBatData.Cooldown;

        if (cooldownTimer < attackCooldown)
        {
            isPressed = false;
        }

        if (PrisonerKongData.curentHealth <= 0)
        {
            canAttack = false;
            player.SetBool("canAttack", false);
            player.SetBool("canHurt", false);
        }
        else if (PrisonerKongData.curentHealth > 0)
        {
            canAttack = true;
            player.SetBool("canAttack", true);
            player.SetBool("canHurt", true);
        }
    }



    public void OnPointerDown()
    {
        if (!isPressed && MobileMoode >= 1 && canAttack)
        {
            anim.SetFloat("AttackSpeed", BaseBallBatData.AttackSpeed);
            isPressed = true;
            anim.SetTrigger("Attack1");
            cooldownTimer = 0;
        }
        cooldownTimer += Time.deltaTime;
    }
    public void OnPointerUp()
    {
        isPressed = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            BatSound.Play();
            collision.GetComponent<EnemyHealth>().TakeDamage(BaseBallBatData.Damage);
        }


        if (collision.tag == "TorretEnemy")
        {
            BatSound.Play();
            collision.GetComponent<TorrretEnemyHealth>().TakeDamage(BaseBallBatData.Damage);
        }


        if (collision.tag == "Boss")
        {
            BatSound.Play();
            collision.GetComponent<BossHealth>().TakeDamage(BaseBallBatData.Damage);
        }

        if (collision.tag == "SecondStageEnemies")
        {
            BatSound.Play();
            collision.GetComponent<Stage2EnemyRangerHealth>().TakeDamage(BaseBallBatData.Damage);
        }

        if (collision.name == "Stage2 Boss")
        {
            BatSound.Play();
            collision.GetComponent<SecondStageBossHealth>().TakeDamage(BaseBallBatData.Damage);
        }

        if (collision.tag == "Stage2MeleeEnemy")
        {
            BatSound.Play();
            collision.GetComponent<Stage2MeleeEnemyHealth>().TakeDamage(BaseBallBatData.Damage);
        }



    }
}
